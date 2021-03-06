﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AlquileresDEC.Datos;
using AlquileresDEC.Entidades;
using Interfaces;

namespace AlquileresDEC.Interfaces
{
    public partial class Consulta_Propiedades : Form
    {
        private MapeoPropiedad mp;
        
        public Consulta_Propiedades()
        {
            InitializeComponent();
            mp = new MapeoPropiedad();  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consulta_Propiedades_Load(object sender, EventArgs e)
        {
            //Oculta un txt y muestra el txt auxiliar
            txtPrecioDesde.Visible = false;
            txtAuxDesde.Visible = true;

            txtPrecioHasta.Visible = false;
            txtAuxHasta.Visible = true;

            //Cargar combo TipoPropiedad
            cmbFiltroTipoPropiedad.DisplayMember = "Nombre";
            cmbFiltroTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbFiltroTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

            //Cargar combo Localidad
            cmbFiltroLocalidad.DisplayMember = "Nombre";
            cmbFiltroLocalidad.ValueMember = "Id_localidad";
            cmbFiltroLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            cmbFiltroBarrio.Enabled = false;
            
            cmbFiltroNroHab.SelectedIndex = 0;
            
            //Mostrar todas las propiedades en grilla
            dgvPropiedades.DataSource = mp.consultarPropiedades();
            dgvPropiedades.DataMember = "Propiedades";
            
            //Ocultar id_propiedad
            dgvPropiedades.Columns[2].Visible = false;
        }

        //Listas con ItemOpcional
        private List<TipoPropiedad> ObtenerListaItemOpcionalTP()
        {
            List<TipoPropiedad> ltp = ObtenerListaTipoProductos();
            ltp.Insert(0, new TipoPropiedad() { Id_tipoPropiedad = 0, Nombre = "<Seleccione un Item de la Lista>", Descripcion = "" });
            return ltp;
        }
        private List<Localidad> ObtenerListaItemOpcionalLoc()
        {
            List<Localidad> lloc = ObtenerListaLocalidades();
            lloc.Insert(0, new Localidad() { Id_localidad = 0, Nombre = "<Seleccione un Item de la Lista>" });
            return lloc;
        }
       
        //Obtener Listas
        private List<TipoPropiedad> ObtenerListaTipoProductos()
        {
            return mp.cargar_lista_TiposPropiedad();
        }
        
        private List<Localidad> ObtenerListaLocalidades()
        {
            return mp.cargar_lista_Localidades();
        }
        
        private List<Barrio> ObtenerListaBarrio(int id_loc)
        {
            return mp.cargar_lista_barrioXLocalidad(id_loc);
        }

        private void cmbFiltroLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroLocalidad.SelectedValue.ToString() != "<Seleccione un Item de la Lista>")
            {
                cmbFiltroBarrio.Enabled = true;
                var id_loc = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                mp.cargar_lista_barrioXLocalidad(id_loc);
                cmbFiltroBarrio.DisplayMember = "Nombre";
                cmbFiltroBarrio.ValueMember = "Id_barrio";
                cmbFiltroBarrio.DataSource = ObtenerListaBarrio(id_loc);
            }
        }

        private void txtPrecioDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();    
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? id_barrio = null;
            int? id_tipoPropiedad = null;
            //int? id_localidad = null;
            int? nro_hab = null;
            double? precioDesde = null;
            double? precioHasta = null;
            if (cmbFiltroTipoPropiedad.SelectedIndex != 0)
                id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());
            if (cmbFiltroLocalidad.SelectedIndex != 0)
                id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());
            /*if (cmbFiltroBarrio.SelectedIndex != 0)
                id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());*/
            if (cmbFiltroNroHab.SelectedIndex != 0)
                nro_hab = int.Parse(cmbFiltroNroHab.SelectedIndex.ToString());
            if (txtPrecioDesde.Text != "")
                precioDesde = double.Parse(txtPrecioDesde.Text);
            if (txtPrecioHasta.Text != "")
                precioHasta = double.Parse(txtPrecioHasta.Text);
            dgvPropiedades.DataSource = mp.ConsultarPropiedadConFiltrosOrdenados(id_tipoPropiedad, id_barrio, nro_hab, precioDesde, precioHasta);
            dgvPropiedades.DataMember = "PropiedadFiltro";
            dgvPropiedades.Columns[2].Visible = false;

            if (txtPrecioDesde.Text != "" && txtPrecioHasta.Text != "")
            {
                var precioMinimo = int.Parse(txtPrecioDesde.Text);
                var precioMaximo = int.Parse(txtPrecioHasta.Text);
                
                if (precioMinimo >= precioMaximo)
                {
                    MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecioDesde.Focus();
                }
            }
                
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text == "" || txtPrecioDesde.Text == "Mínimo") && (txtPrecioHasta.Text == "" || txtPrecioHasta.Text == "Máximo") && cmbFiltroNroHab.Text == "<Todos los Item>")
            {
                MessageBox.Show("Debe completar por lo menos un filtro para realizar la búsqueda.","Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFiltroTipoPropiedad.Focus();
            }
            
            //Cuando no se encuentra ninguna propiedad
            if (dgvPropiedades.RowCount == 0)
            {
                MessageBox.Show("No se encontró ninguna propiedad que cumpla con los criterios de búsqueda cargados.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar();
            }
        }

        public void limpiar()
        {
            cmbFiltroTipoPropiedad.SelectedIndex = 0;
            cmbFiltroLocalidad.SelectedIndex = 0;
            cmbFiltroNroHab.SelectedIndex = 0;
            txtPrecioDesde.Text = "";
            txtPrecioHasta.Text = "";


            txtPrecioDesde.Visible = false;
            txtAuxDesde.Visible = true;

            txtPrecioHasta.Visible = false;
            txtAuxHasta.Visible = true;

            cmbFiltroBarrio.Enabled = false;

            //Mostrar todas las propiedades en grilla
            dgvPropiedades.DataSource = mp.consultarPropiedades();
            dgvPropiedades.DataMember = "Propiedades";

            //Ocultar id_propiedad
            dgvPropiedades.Columns[2].Visible = false;
        }

        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult res;
            int id_propiedad;
            if (dgvPropiedades.CurrentCell.ColumnIndex == 0)
            {
                res = MessageBox.Show("¿Está seguro de que desea modificar a la propiedad seleccionada?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        id_propiedad = int.Parse(dgvPropiedades.Rows[e.RowIndex].Cells[2].Value.ToString());

                        /*
                         Guardo id_propiedad para usarlo como parámetro en el constructor del ABM Propiedad.
                         Creo una ventana desde aquí para ir al ABM Propiedad.
                         
                         Indicar que estoy haciendo una Modificación en alguna parte de la pantalla y bloquear para que id para que se guarde el cambio sobre el id que paso por parámetro.                         usaria el id para hacer una consulta y mostrarla en una grilla oculta, tomo los datos del select * y con esos datos cargo cada cmb y txt
                         Usar un puntero y setearlo en 1 para saber que es una modificación.
                         Borrar esa indicación al modificar y el puntero setearlo en 0.
                         */

                        //Abre ventana Modificar Propiedad
                        this.Hide();
                        var form = new ModificarPropiedad(id_propiedad);
                        form.Show();
                        
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            if (dgvPropiedades.CurrentCell.ColumnIndex == 1)
            {
                res = MessageBox.Show("¿Está seguro de que desea eliminar a la propiedad seleccionada?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    try
                    {
                        var id = int.Parse(dgvPropiedades.Rows[e.RowIndex].Cells[2].Value.ToString());
                        mp.eliminarPropiedad(id);

                        //consulto luego de eliminar para refrescar la grilla
                        dgvPropiedades.DataSource = mp.consultarPropiedades();
                        dgvPropiedades.DataMember = "Propiedades";
                        //dgvPropiedades.Columns[2].Visible = false;
                        res = MessageBox.Show("La propiedad ha sido eliminada.", "Borrado exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        public void limpiarPrecios()
        {
            if (txtPrecioDesde.Text == "")
            {
                txtPrecioDesde.Visible = false;
                txtAuxDesde.Visible = true;
            }

            if (txtPrecioHasta.Text == "")
            {
                txtPrecioHasta.Visible = false;
                txtAuxHasta.Visible = true;
            }
        }

        private void txtAuxDesde_Click(object sender, EventArgs e)
        {
            txtPrecioDesde.Visible = true;
            txtAuxDesde.Visible = false;
            txtPrecioDesde.Focus();
            
            if (txtPrecioHasta.Text == "")
            {
                txtPrecioHasta.Visible = false;
                txtAuxHasta.Visible = true;
            }    
        }

        private void txtAuxHasta_Click(object sender, EventArgs e)
        {
            txtPrecioHasta.Visible = true;
            txtAuxHasta.Visible = false;
            txtPrecioHasta.Focus();

            if (txtPrecioDesde.Text == "")
            {
                txtPrecioDesde.Visible = false;
                txtAuxDesde.Visible = true;
            }   
        }

        private void cmbFiltroTipoPropiedad_Click(object sender, EventArgs e)
        {
            limpiarPrecios();
        }

        private void cmbFiltroNroHab_Click(object sender, EventArgs e)
        {
            limpiarPrecios();
        }

        private void cmbFiltroLocalidad_Click(object sender, EventArgs e)
        {
            limpiarPrecios();
        }

        private void cmbFiltroBarrio_Click(object sender, EventArgs e)
        {
            limpiarPrecios();
        }
    }
}

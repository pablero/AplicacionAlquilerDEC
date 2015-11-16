using System;
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
            //Cargar combo TipoPropiedad
            cmbFiltroTipoPropiedad.DisplayMember = "Nombre";
            cmbFiltroTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbFiltroTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

            //Cargar combo Localidad
            cmbFiltroLocalidad.DisplayMember = "Nombre";
            cmbFiltroLocalidad.ValueMember = "Id_localidad";
            cmbFiltroLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            cmbFiltroBarrio.Enabled = false;

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
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text == "" || txtPrecioDesde.Text == "Mínimo") && (txtPrecioHasta.Text == "" || txtPrecioHasta.Text == "Máximo"))
            {
                MessageBox.Show("Debe completar por lo menos un filtro para realizar la búsqueda.","Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFiltroTipoPropiedad.Focus();
            }

            //Validaciones del precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") && (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {
                    //Valida que el precio mínimo no supere al precio máximo
                    var precioMinimo = int.Parse(txtPrecioDesde.Text);
                    var precioMaximo = int.Parse(txtPrecioHasta.Text);

                    if (precioMinimo >= precioMaximo)
                    {
                        MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPrecioDesde.Focus();
                    }
                }
            }
            if (txtPrecioDesde.Text == "")
                txtPrecioDesde.Text = "Mínimo";

            if (txtPrecioHasta.Text == "")
                txtPrecioHasta.Text = "Máximo";

            //NO ME SALIO...
            /*
            int? id_tipoPropiedad = null;
            int? id_localidad = null;
            int? id_barrio = null;
            
            dgvPropiedades.Visible = true;

            if (cmbFiltroTipoPropiedad.SelectedItem != null)
            {
                id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());
            }
            if (cmbFiltroLocalidad.SelectedItem != null)
            {
                id_localidad = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
            }
            if (cmbFiltroBarrio.SelectedItem != null)
            {
                id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());
            }

            var pd = txtPrecioDesde.Text;
            var ph = txtPrecioHasta.Text;

            dgvPropiedades.DataSource = mp.consultarPorFiltro(id_tipoPropiedad, id_localidad, id_barrio, pd, ph);
            dgvPropiedades.DataMember = "consultaFiltro";
            */

            //Buscar por tipo de propiedad
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "Mínimo" && txtPrecioHasta.Text == "Máximo")
            {
                int id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());
                dgvPropiedades.DataSource = mp.consultarPropiedadesPorTipo(id_tipoPropiedad);
                dgvPropiedades.DataMember = "Propiedades";
            }

            //Buscar por localidad y barrio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && txtPrecioDesde.Text == "Mínimo" && txtPrecioHasta.Text == "Máximo")
            {
                int id_localidad = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                int id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());
                dgvPropiedades.DataSource = mp.consultarPropiedadesPorLocalidadYBarrio(id_localidad, id_barrio);
                dgvPropiedades.DataMember = "Propiedades";
            }

            //Buscar por precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                //Si no tiene cargado un precio máximo o mínimo lo pone en 0
                if (txtPrecioDesde.Text == "Mínimo" || txtPrecioDesde.Text == "")
                    txtPrecioDesde.Text = "0";

                if (txtPrecioHasta.Text == "Máximo" || txtPrecioHasta.Text == "")
                    txtPrecioHasta.Text = "0";

                //Convierte los precios a entero
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") || (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {
                    //Valida que el precio mínimo no supere al precio máximo
                    var precioMinimo = int.Parse(txtPrecioDesde.Text);
                    
                    var precioMaximo = int.Parse(txtPrecioHasta.Text);

                    if (precioMinimo >= precioMaximo)
                    {
                        MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (precioMaximo == 0)
                        {
                            txtPrecioHasta.Text = "";
                            txtPrecioHasta.Focus();
                            MessageBox.Show("Debe completar el precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            txtPrecioDesde.Focus();
                    }

                    else
                    {
                        int precioInferior = int.Parse(txtPrecioDesde.Text);
                        int precioSuperior = int.Parse(txtPrecioHasta.Text);

                        dgvPropiedades.DataSource = mp.consultarPropiedadesPorPrecio(precioInferior, precioSuperior);
                        dgvPropiedades.DataMember = "Propiedades";
                    }
                } 
            }

            //Buscar por tipo de propiedad, localidad y barrio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && txtPrecioDesde.Text == "Mínimo" && txtPrecioHasta.Text == "Máximo")
            {
                int id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());
                int id_localidad = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                int id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());
                dgvPropiedades.DataSource = mp.consultarPropiedadesPorTipoYUbicacion(id_tipoPropiedad, id_localidad, id_barrio);
                dgvPropiedades.DataMember = "Propiedades";
            }

            //Buscar por tipo de propiedad y precio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                int id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());


                //Si no tiene cargado un precio máximo o mínimo lo pone en 0
                if (txtPrecioDesde.Text == "Mínimo" || txtPrecioDesde.Text == "")
                    txtPrecioDesde.Text = "0";

                if (txtPrecioHasta.Text == "Máximo" || txtPrecioHasta.Text == "")
                    txtPrecioHasta.Text = "0";

                //Convierte los precios a entero
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") || (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {
                    //Valida que el precio mínimo no supere al precio máximo
                    var precioMinimo = int.Parse(txtPrecioDesde.Text);

                    var precioMaximo = int.Parse(txtPrecioHasta.Text);

                    if (precioMinimo >= precioMaximo)
                    {
                        MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (precioMaximo == 0)
                        {
                            txtPrecioHasta.Text = "";
                            txtPrecioHasta.Focus();
                            MessageBox.Show("Debe completar el precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            txtPrecioDesde.Focus();
                    }

                    else
                    {
                        int precioInferior = int.Parse(txtPrecioDesde.Text);
                        int precioSuperior = int.Parse(txtPrecioHasta.Text);

                        dgvPropiedades.DataSource = mp.consultarPropiedadesPorTipoYPrecio(id_tipoPropiedad, precioInferior, precioSuperior);
                        dgvPropiedades.DataMember = "Propiedades";
                    }
                } 
            }

            //Buscar por localidad, barrio y precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                int id_localidad = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                int id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());


                //Si no tiene cargado un precio máximo o mínimo lo pone en 0
                if (txtPrecioDesde.Text == "Mínimo" || txtPrecioDesde.Text == "")
                    txtPrecioDesde.Text = "0";

                if (txtPrecioHasta.Text == "Máximo" || txtPrecioHasta.Text == "")
                    txtPrecioHasta.Text = "0";

                //Convierte los precios a entero
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") || (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {
                    //Valida que el precio mínimo no supere al precio máximo
                    var precioMinimo = int.Parse(txtPrecioDesde.Text);

                    var precioMaximo = int.Parse(txtPrecioHasta.Text);

                    if (precioMinimo >= precioMaximo)
                    {
                        MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (precioMaximo == 0)
                        {
                            txtPrecioHasta.Text = "";
                            txtPrecioHasta.Focus();
                            MessageBox.Show("Debe completar el precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            txtPrecioDesde.Focus();
                    }

                    else
                    {
                        int precioInferior = int.Parse(txtPrecioDesde.Text);
                        int precioSuperior = int.Parse(txtPrecioHasta.Text);

                        dgvPropiedades.DataSource = mp.consultarPropiedadesPorUbicacionYPrecio(id_localidad, id_barrio, precioInferior, precioSuperior);
                        dgvPropiedades.DataMember = "Propiedades";
                    }
                } 
            }

            //Búsqueda completa
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                int id_tipoPropiedad = int.Parse(cmbFiltroTipoPropiedad.SelectedValue.ToString());

                int id_localidad = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                int id_barrio = int.Parse(cmbFiltroBarrio.SelectedValue.ToString());


                //Si no tiene cargado un precio máximo o mínimo lo pone en 0
                if (txtPrecioDesde.Text == "Mínimo" || txtPrecioDesde.Text == "")
                    txtPrecioDesde.Text = "0";

                if (txtPrecioHasta.Text == "Máximo" || txtPrecioHasta.Text == "")
                    txtPrecioHasta.Text = "0";

                //Convierte los precios a entero
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") || (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {
                    //Valida que el precio mínimo no supere al precio máximo
                    var precioMinimo = int.Parse(txtPrecioDesde.Text);

                    var precioMaximo = int.Parse(txtPrecioHasta.Text);

                    if (precioMinimo >= precioMaximo)
                    {
                        MessageBox.Show("El precio mínimo debe ser menor al precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (precioMaximo == 0)
                        {
                            txtPrecioHasta.Text = "";
                            txtPrecioHasta.Focus();
                            MessageBox.Show("Debe completar el precio máximo.", "Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            txtPrecioDesde.Focus();
                    }

                    else
                    {
                        int precioInferior = int.Parse(txtPrecioDesde.Text);
                        int precioSuperior = int.Parse(txtPrecioHasta.Text);

                        dgvPropiedades.DataSource = mp.consultarPropiedadesPorBúsquedaCompleta(id_tipoPropiedad, id_localidad, id_barrio, precioInferior, precioSuperior);
                        dgvPropiedades.DataMember = "Propiedades";
                    }
                }
            }

            //Cuando no se encuentra ninguna propiedad
            if (dgvPropiedades.RowCount == 0)
            {
                MessageBox.Show("No se encontró ninguna propiedad que cumpla con los criterios de búsqueda cargados.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar();
            }
        }

        //Setea "máximo" en el txt cuando no se completa el precio
        private void txtPrecioDesde_Click(object sender, EventArgs e)
        {
            txtPrecioDesde.Text = "";
            if (txtPrecioHasta.Text == "")
                txtPrecioHasta.Text = "Máximo";
        }

        //Setea "mínimo" cuando no se completa el precio
        private void txtPrecioHasta_Click(object sender, EventArgs e)
        {
            txtPrecioHasta.Text = "";
            if (txtPrecioDesde.Text == "")
                txtPrecioDesde.Text = "Mínimo";
        }

        //Al hacer click en algun precio borra "Mínimo" o "Máximo"
        private void cmbFiltroTipoPropiedad_Click(object sender, EventArgs e)
        {
            if (txtPrecioDesde.Text == "")
                txtPrecioDesde.Text = "Mínimo";
        
            if (txtPrecioHasta.Text == "")
                txtPrecioHasta.Text = "Máximo";
        }

        //Al hacer click en una localidad si existe un precio vacio setea "Mínimo" o "Máximo" segun corresponda
        private void cmbFiltroLocalidad_Click(object sender, EventArgs e)
        {
            if (txtPrecioDesde.Text == "")
                txtPrecioDesde.Text = "Mínimo";
        
            if (txtPrecioHasta.Text == "")
                txtPrecioHasta.Text = "Máximo";
        }

        public void limpiar()
        {
            //Cargar combo TipoPropiedad
            cmbFiltroTipoPropiedad.DisplayMember = "Nombre";
            cmbFiltroTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbFiltroTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

            //Cargar combo Localidad
            cmbFiltroLocalidad.DisplayMember = "Nombre";
            cmbFiltroLocalidad.ValueMember = "Id_localidad";
            cmbFiltroLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            cmbFiltroBarrio.Enabled = false;

            //Carga txt de precios
            txtPrecioDesde.Text = "Mínimo";
            txtPrecioHasta.Text = "Máximo";
            cmbFiltroTipoPropiedad.Focus();

            //Mostrar todas las propiedades en grilla
            dgvPropiedades.DataSource = mp.consultarPropiedades();
            dgvPropiedades.DataMember = "Propiedades";
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

                        //Abre ventana ABM Propiedad
                        var form = new ABM_Propiedad();
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
    }
}

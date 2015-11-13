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
            //solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            /*
            // solo acepta una coma, no deberia permitir una coma como primer caracter...
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            */
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
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

            txtPrecioDesde.Text = "";
            txtPrecioHasta.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "" && txtPrecioHasta.Text == "")
            {
                MessageBox.Show("Debe completar alguno de los filtros para realizar la búsqueda.","Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFiltroTipoPropiedad.Focus();
            }

            //buscar por tipo de propiedad
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "" && txtPrecioHasta.Text == "")
            {

            }


            //buscar por localidad y barrio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && txtPrecioDesde.Text == "" && txtPrecioHasta.Text == "")
            {

            }

            //buscar por precio, establecer minimo y maximo tolerable
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "" || txtPrecioHasta.Text != ""))
            {

            }

            //buscar por tipo de propiedad, localidad y barrio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "" && txtPrecioHasta.Text == "")
            {

            }

            //buscar por tipo de propiedad y precio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "" || txtPrecioHasta.Text != ""))
            {

            }

            //buscar por localidad, barrio y precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && (txtPrecioDesde.Text != "" || txtPrecioHasta.Text != ""))
            {

            }        
        }

        
    }
}

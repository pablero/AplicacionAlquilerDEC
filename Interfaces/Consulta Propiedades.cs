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

            //Mostrar todas las propiedades en grilla
            dgvPropiedades.DataSource = mp.consultarPropiedades();
            dgvPropiedades.DataMember = "Propiedades";
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
            
            //Carga txt de precios
            txtPrecioDesde.Text = "Mínimo";
            txtPrecioHasta.Text = "Máximo";
            cmbFiltroTipoPropiedad.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text == "" || txtPrecioDesde.Text == "Mínimo") && (txtPrecioHasta.Text == "" || txtPrecioHasta.Text == "Máximo"))
            {
                MessageBox.Show("Debe completar alguno de los filtros para realizar la búsqueda.","Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbFiltroTipoPropiedad.Focus();
            }

            //Buscar por tipo de propiedad
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "Mínimo" && txtPrecioHasta.Text == "Máximo")
            {

            }


            //Buscar por localidad y barrio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && txtPrecioDesde.Text == "Mínimo" && txtPrecioHasta.Text == "Máximo")
            {

            }

            //Buscar por precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "Mínimo" || txtPrecioHasta.Text != "Máximo"))
            {
                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") && (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                { 
                    //validar menor y mayor
                }

                if ((txtPrecioDesde.Text != "Mínimo" && txtPrecioDesde.Text != "") || (txtPrecioHasta.Text != "" && txtPrecioHasta.Text != "Máximo"))
                {

                }

            }

            //Buscar por tipo de propiedad, localidad y barrio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && txtPrecioDesde.Text == "" && txtPrecioHasta.Text == "")
            {

            }

            //Buscar por tipo de propiedad y precio
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == false && (txtPrecioDesde.Text != "" || txtPrecioHasta.Text != ""))
            {

            }

            //Buscar por localidad, barrio y precio
            if (cmbFiltroTipoPropiedad.Text == "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && (txtPrecioDesde.Text != "" || txtPrecioHasta.Text != ""))
            {

            }

            //Buscar todas las propiedades
            if (cmbFiltroTipoPropiedad.Text != "<Seleccione un Item de la Lista>" && cmbFiltroBarrio.Enabled == true && txtPrecioDesde.Text != "" && txtPrecioHasta.Text != "")
            {
            
            }

            if (txtPrecioDesde.Text == "")
                txtPrecioDesde.Text = "Mínimo";

            if (txtPrecioHasta.Text == "")
                txtPrecioHasta.Text = "Máximo";

            //No se encontro ninguna propiedad
            if (dgvPropiedades.RowCount == 0)
            {
                MessageBox.Show("No se encontró ninguna propiedad que cumpla con los criterios de búsqueda.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                limpiar();
                /*dgvPropiedades.DataSource = mp.consultarPropiedades();
                dgvPropiedades.DataMember = "Localidades";
                //dgvPropiedades.Columns[0].Visible = false;*/
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
        }
        /*
//validar precios
if (txtPrecioDesde.Text != "" && txtPrecioHasta.Text != "")
{
if (Convert.ToInt32(txtPrecioDesde) <= Convert.ToInt32(txtPrecioHasta))
{ 
    MessageBox.Show("El precio mínimo debe ser menor al precio máximo.","Consulta de Propiedades", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
} */     


    }
}

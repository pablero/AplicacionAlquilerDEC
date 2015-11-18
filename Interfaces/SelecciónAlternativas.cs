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
    public partial class Seleccion_Alternativas : Form
    {
        private MapeoPropiedad mp;
        
        public Seleccion_Alternativas()
        {
            InitializeComponent();
            mp = new MapeoPropiedad();  
        }

        private void Seleccion_Alternativas_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

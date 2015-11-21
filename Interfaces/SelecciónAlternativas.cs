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
    public partial class SelecciónAlternativas : Form
    {
        private MapeoPropiedad mp;
        public SelecciónAlternativas()
        {
            InitializeComponent();
            mp = new MapeoPropiedad();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbFiltroTipoPropiedad.SelectedIndex = 0;
            cmbFiltroLocalidad.SelectedIndex = 0;
            cmbFiltoNroHab.SelectedIndex = 0;
            txtPrecioDesde.Text = "";
            txtPrecioHasta.Text = "";

            //Cargar Grilla
            dgvAltCandidatas.DataSource = mp.ConsultarPropiedadSinFiltros();
            dgvAltCandidatas.DataMember = "Propiedad";
            dgvAltCandidatas.Columns[1].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea salir", "Confirmación", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void SelecciónAlternativas_Load(object sender, EventArgs e)
        {
            //Cargar combo TipoPropiedad
            cmbFiltroTipoPropiedad.DisplayMember = "Nombre";
            cmbFiltroTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbFiltroTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

            //Cargar combo Localidad
            cmbFiltroLocalidad.DisplayMember = "Nombre";
            cmbFiltroLocalidad.ValueMember = "Id_localidad";
            cmbFiltroLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            cmbFiltoNroHab.SelectedIndex = 0;

            //Cargar Grilla
            dgvAltCandidatas.DataSource = mp.ConsultarPropiedadSinFiltros();
            dgvAltCandidatas.DataMember = "Propiedad";
            dgvAltCandidatas.Columns[1].Visible = false;
        }

        //Listas con ItemOpcional
        private List<TipoPropiedad> ObtenerListaItemOpcionalTP()
        {
            List<TipoPropiedad> ltp = ObtenerListaTipoProductos();
            ltp.Insert(0, new TipoPropiedad() { Id_tipoPropiedad = 0, Nombre = "<Todos los Items>", Descripcion = "" });
            return ltp;
        }
        private List<Localidad> ObtenerListaItemOpcionalLoc()
        {
            List<Localidad> lloc = ObtenerListaLocalidades();
            lloc.Insert(0, new Localidad() { Id_localidad = 0, Nombre = "<Todos los Items>" });
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
            if (cmbFiltroLocalidad.SelectedValue.ToString() != "<Todos los Items>")
            {
                var id_loc = int.Parse(cmbFiltroLocalidad.SelectedValue.ToString());
                mp.cargar_lista_barrioXLocalidad(id_loc);
                cmbFiltroBarrio.DisplayMember = "Nombre";
                cmbFiltroBarrio.ValueMember = "Id_barrio";
                cmbFiltroBarrio.DataSource = ObtenerListaBarrio(id_loc);
            }
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
            if (cmbFiltoNroHab.SelectedIndex != 0)
                nro_hab = int.Parse(cmbFiltoNroHab.SelectedIndex.ToString());
            if(txtPrecioDesde.Text!="")
                precioDesde = double.Parse(txtPrecioDesde.Text);
            if(txtPrecioHasta.Text!="")
                precioHasta = double.Parse(txtPrecioHasta.Text);
            dgvAltCandidatas.DataSource = mp.ConsultarPropiedadConFiltros(id_tipoPropiedad,id_barrio,nro_hab,precioDesde,precioHasta);
            dgvAltCandidatas.DataMember = "PropiedadFiltro";
            dgvAltCandidatas.Columns[1].Visible = false;
        }

        // Método que exporta a un fichero Excel el contenido de un DataGridView.
        // DataGridView que contiene los datos a exportar.
        // La grilla tiene que tener los pesos arriba y abajo los departamentos que cumplan con los criterios indicados: precio, barrio, estado, requisitos, servicios, antigüedad y número de habitaciones.  
        // Podrían ser 2 exportaciones, una para pesos y otra para criterios.

        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvAltElegidas);
        }

    }
}

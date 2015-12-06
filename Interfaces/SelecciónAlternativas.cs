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
        //private int banderaPaso;
        public SelecciónAlternativas()
        {
            InitializeComponent();
            mp = new MapeoPropiedad();
            //banderaPaso = 0;
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
            dtoPropiedad datos = mp.ConsultarPropiedadSinFiltros();
            
            //Cargar combo TipoPropiedad
            cmbFiltroTipoPropiedad.DisplayMember = "Nombre";
            cmbFiltroTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbFiltroTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

            //Cargar combo Localidad
            cmbFiltroLocalidad.DisplayMember = "Nombre";
            cmbFiltroLocalidad.ValueMember = "Id_localidad";
            cmbFiltroLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            cmbFiltoNroHab.SelectedIndex = 0;

            //Cargar grilla de Criterios
            DataTable data2 = new DataTable();
            data2.Columns.Add(new DataColumn("Criterios", typeof(string)));
            
            data2.Rows.Add("Antigüedad");
            data2.Rows.Add("Barrio");
            data2.Rows.Add("Estado");
            data2.Rows.Add("NroHabitaciones");
            data2.Rows.Add("Precio");
            data2.Rows.Add("Servicios");
            data2.Rows.Add("Requisitos");

            dgvCriterios.DataSource = data2;
            dgvCriterios.Columns["Criterios"].DisplayIndex = 1;                    
            
           
           //Cargar Grilla Alternativas candidatas  
            dgvAltCandidatas.DataSource = datos;
            dgvAltCandidatas.DataMember = "Propiedad";
            dgvAltCandidatas.Columns[1].Visible = false;

            //Inicializar Combo P en 1
            cmbP.SelectedIndex = 0;
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
            /*dgvAltCandidatas.DataSource = mp.ConsultarPropiedadConFiltros(id_tipoPropiedad,id_barrio,nro_hab,precioDesde,precioHasta);
            //dgvAltCandidatas.DataMember = "PropiedadFiltro";
            dgvAltCandidatas.DataMember = "Propiedad";
            dgvAltCandidatas.Columns[1].Visible = false;*/
            dgvAltCandidatas.DataSource = mp.ConsultarPropiedadConFiltros(id_tipoPropiedad, id_barrio, nro_hab, precioDesde, precioHasta);
            //dgvAltCandidatas.DataMember = "PropiedadFiltro";
            dgvAltCandidatas.DataMember = "PropiedadFiltro";
            dgvAltCandidatas.Columns[1].Visible = false;
            cbSelTodosCand.Checked = false;
            cbSelTodosEleg.Checked = false;
        }

        private void btnAgregarTodos_Click(object sender, EventArgs e)
        {
            int c = 0;
           
            //Lista temporal de registros seleccionados
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvAltCandidatas.Rows)
            {
                //Se recupera el campo del checkbox y se agrega a la lista temporal.
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {   //Prueba
                    if (dgvAltElegidas.RowCount != 0)
                    {
                        foreach (DataGridViewRow row2 in dgvAltElegidas.Rows)
                        {
                            if (Convert.ToInt16(row2.Cells["id_propiedad"].Value) == Convert.ToInt16(row.Cells["id_propiedad"].Value))
                            {                                
                                MessageBox.Show("Algunas de las propiedades seleccionadas ya han sido elegidas, se las descartará para evitar duplicación", "Advertencia", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);                                
                                dgvAltCandidatas.Rows.Remove(row);//Eliminar de la grilla de candidatas a la que ya está elegida.
                                //MessageBox.Show(row.Cells["direccion"].ToString(), "La propiedad ya ha sido elegida");
                                c++;
                                
                                break;
                            }
                        }
                    }
                    if (c == 0)//agregue este if
                        rowSelected.Add(row);

                    c = 0;                    

                    //rowSelected.Add(row);
                }
               
            }

            //Agrego el item seleccionado a la grilla destino Alternativas elegidas.
            //Eliminando la fila de la grilla alternativas candidatas.
            foreach (DataGridViewRow row in rowSelected)
            {
                dgvAltElegidas.Rows.Add(new object[] {false,
                                                      row.Cells["id_propiedad"].Value,
                                                      row.Cells["TipoPropiedad"].Value,
                                                      row.Cells["Dirección"].Value,
                                                      row.Cells["Barrio"].Value,
                                                      row.Cells["Localidad"].Value,
                                                      row.Cells["NroHab"].Value,
                                                      row.Cells["Piso"].Value, 
                                                      row.Cells["Depto"].Value,
                                                      row.Cells["Precio"].Value,
                                                      row.Cells["Estado"].Value,
                                                      row.Cells["Servicios"].Value,
                                                      row.Cells["Requisitos"].Value,
                                                      row.Cells["AñosAntigüedad"].Value});
                dgvAltCandidatas.Rows.Remove(row);
            }

        }

        private void btnQuitarTodos_Click(object sender, EventArgs e)
        {
            //Lista temporal de registros seleccionados
            List<DataGridViewRow> rowSelected = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvAltElegidas.Rows)
            {
                //Se recupera el campo del checkbox y se agrega a la lista temporal.
                DataGridViewCheckBoxCell cellSeleccion = row.Cells["Seleccion2"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSeleccion.Value))
                {
                    rowSelected.Add(row);
                }
            }
            //Valida si hay algun registro por eliminar
            if (rowSelected.Count > 0)
            {
                //Propiedad datos = dgvAltCandidatas.DataSource as Propiedad;
                dtoPropiedad datos = dgvAltCandidatas.DataSource as dtoPropiedad;
                foreach (DataGridViewRow row in rowSelected)
                {
                    dtoPropiedad.PropiedadRow propRow = datos.Propiedad.NewPropiedadRow();
                    propRow.id_propiedad = Convert.ToInt16(row.Cells["id_propiedad"].Value);
                    propRow.TipoPropiedad = Convert.ToString(row.Cells["TipoPropiedad"].Value);
                    propRow.Dirección = Convert.ToString(row.Cells["Direccion"].Value);
                    propRow.Barrio = Convert.ToString(row.Cells["Barrio"].Value);
                    propRow.Localidad = Convert.ToString(row.Cells["Localidad"].Value);
                    propRow.NroHab = Convert.ToInt16(row.Cells["NroHab"].Value);
                    propRow.Piso = Convert.ToInt16(row.Cells["Piso"].Value);
                    propRow.Depto = Convert.ToChar(row.Cells["Depto"].Value);
                    propRow.Precio = Convert.ToDouble(row.Cells["Precio"].Value);
                    propRow.Estado = Convert.ToString(row.Cells["Estado"].Value);
                    propRow.Servicios = Convert.ToString(row.Cells["Servicios"].Value);
                    propRow.Requisitos = Convert.ToString(row.Cells["Requisitos"].Value);
                    propRow.AñosAntigüedad = Convert.ToInt16(row.Cells["antiguedad"].Value);
                    datos.Propiedad.Rows.Add(propRow);

                    dgvAltElegidas.Rows.Remove(row);
                }
                dgvAltCandidatas.DataSource = datos;
                dgvAltCandidatas.DataMember = "Propiedad";
                dgvAltCandidatas.Columns[1].Visible = false;
                
            }
            cbSelTodosEleg.Checked = false;
            cbSelTodosCand.Checked = false;
        }

        private void cbSelTodosCand_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvAltCandidatas.Rows)
            {
                if (((CheckBox)sender).Checked)
                {
                    fila.Cells[0].Value = true;
                    //banderaPaso = 1;
                }
                else
                {
                    fila.Cells[0].Value = false;
                    //banderaPaso = 0;
                }
            }
        }

        private void cbSelTodosEleg_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvAltElegidas.Rows)
            {
                if (((CheckBox)sender).Checked)
                {
                    fila.Cells[0].Value = true;
                    //banderaPaso = 1;
                }
                else
                {
                    fila.Cells[0].Value = false;
                    //banderaPaso = 0;
                }
            }
        }

        private void dgvAltCandidatas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAltCandidatas.IsCurrentCellDirty)
            {
                dgvAltCandidatas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        

       
        
    }
}

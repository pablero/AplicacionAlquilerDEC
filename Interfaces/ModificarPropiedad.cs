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
using System.IO;
using System.Drawing.Imaging;
using AlquileresDEC.Interfaces;

namespace Interfaces
{
    public partial class ModificarPropiedad : Form
    {        
        private MapeoPropiedad mp;
        private byte[] foto;
    
        //inicio nuevo
        //Id de la propiedad a modificar - nuevo
        int id;

        public ModificarPropiedad(int id_propiedad)
        {
            InitializeComponent();
            mp = new MapeoPropiedad();
            id = id_propiedad; 
        }
        //fin nuevo

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar combo TipoPropiedad
            cmbTipoPropiedad.DisplayMember = "Nombre";
            cmbTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();
            //cmbTipoPropiedad.DataSource = mp.consultarTipoPropiedadModificar(id);

            //Cargar combo Localidad
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "Id_localidad";
            cmbLocalidad.DataSource = ObtenerListaItemOpcionalLoc();

            //Cargar combo Estado
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "Id_estado";
            cmbEstado.DataSource = ObtenerListaItemOpcionalEst();

            //Cargar combo Requisito
            cmbRequisitos.DisplayMember = "Nombre";
            cmbRequisitos.ValueMember = "Id_estado";
            cmbRequisitos.DataSource = ObtenerListaItemOpcionalReq();

            //Cargar combo Servicio
            cmbServicios.DisplayMember = "Nombre";
            cmbServicios.ValueMember = "Id_servicio";
            cmbServicios.DataSource = ObtenerListaItemOpcionalSs();

            cmbNroHab.SelectedIndex = 1;

            //Foto Ruta relativa
            var ruta = Application.StartupPath;
            ruta = ruta.Substring(0, ruta.Length - 10);
            var imagepath = Path.Combine(ruta, "Resources\\imagenInicio4.jpg");
            pbFoto.Image = Image.FromFile(imagepath);


            //inicio nuevo

            //Para que cargue a la propiedad seleccionada.

            //Mostrar todas las propiedades en grilla
            dgvPropiedades.DataSource = mp.consultarPropiedadesModificar(id);
            dgvPropiedades.DataMember = "Propiedades";
            
            /*
            var ds = new DataSet();
            ds = mp.consultarTipoPropiedadModificar(id);

            int id_tipo = int.Parse(ds.Tables[0].Rows[0][13].ToString());
            cmbTipoPropiedad.SelectedValue = id_tipo;

            //cmbTipoPropiedad.Text = dgvPropiedades.Rows[0].Cells[1].Value.ToString();
            */
            
            cmbTipoPropiedad.Text = dgvPropiedades.Rows[0].Cells[1].Value.ToString();
            cmbLocalidad.Text = dgvPropiedades.Rows[0].Cells[2].Value.ToString();
            cmbBarrio.Text = dgvPropiedades.Rows[0].Cells[3].Value.ToString();
            txtDireccion.Text = dgvPropiedades.Rows[0].Cells[4].Value.ToString();
            txtPiso.Text = dgvPropiedades.Rows[0].Cells[5].Value.ToString();
            txtDepto.Text = dgvPropiedades.Rows[0].Cells[12].Value.ToString();
            cmbNroHab.Text = dgvPropiedades.Rows[0].Cells[6].Value.ToString();
            txtPrecio.Text = dgvPropiedades.Rows[0].Cells[11].Value.ToString();
            cmbEstado.Text = dgvPropiedades.Rows[0].Cells[8].Value.ToString();
            cmbRequisitos.Text = dgvPropiedades.Rows[0].Cells[10].Value.ToString();
            //FALTA fecha de inauguracion...  [7]
            cmbServicios.Text = dgvPropiedades.Rows[0].Cells[9].Value.ToString();
            txtDescrip.Text = dgvPropiedades.Rows[0].Cells[13].Value.ToString();
            //pbFoto.Image = dgvPropiedades.Rows[0].Cells[14].Value.toString();
            /*
            var ms = new MemoryStream(dep.foto);
            pbFoto.Image = Image.FromStream(ms);
        */
            //fin nuevo
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
        private List<Estado> ObtenerListaItemOpcionalEst()
        {
            List<Estado> les = ObtenerListaEstado();
            les.Insert(0, new Estado() { Id_estado = 0, Nombre = "<Seleccione un Item de la Lista>", Calificacion=0 });
            return les;
        }
        private List<Requisito> ObtenerListaItemOpcionalReq()
        {
            List<Requisito> lreq = ObtenerListaRequisitos();
            lreq.Insert(0, new Requisito() { Id_requisito = 0, Nombre = "<Seleccione un Item de la Lista>", Calificacion = 0 });
            return lreq;
        }
        private List<Servicio> ObtenerListaItemOpcionalSs()
        {
            List<Servicio> lss = ObtenerListaServicios();
            lss.Insert(0, new Servicio() { Id_servicio = 0, Nombre = "<Seleccione un Item de la Lista>", Calificacion = 0 });
            return lss;
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
        private List<Estado> ObtenerListaEstado()
        {
            return mp.cargar_lista_Estado();
        }
        private List<Requisito> ObtenerListaRequisitos()
        {
            return mp.cargar_lista_Requisitos();
        }
        private List<Servicio> ObtenerListaServicios()
        {
            return mp.cargar_lista_Servicios();
        }

        public static byte[] ImgToByte(Image imagen)
        {
            var ms = new MemoryStream();
            imagen.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidad.SelectedValue.ToString() != "<Seleccione un Item de la Lista>")
            {
                var id_loc = int.Parse(cmbLocalidad.SelectedValue.ToString());
                mp.cargar_lista_barrioXLocalidad(id_loc);
                cmbBarrio.DisplayMember = "Nombre";
                cmbBarrio.ValueMember = "Id_barrio";
                cmbBarrio.DataSource = ObtenerListaBarrio(id_loc);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            var dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            var result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var form = new Consulta_Propiedades();
            form.Show();
        }
    }
}
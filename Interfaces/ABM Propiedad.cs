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
using System.IO;
using System.Drawing.Imaging;
using AlquileresDEC.Interfaces;


namespace Interfaces
{
    public partial class ABM_Propiedad : Form
    {        
        private MapeoPropiedad mp;
        private byte[] foto;//Convertir la la foto que se encuentra cuando el usuario clikeó guardar a byte para luego comparar con la de abajo.
        private int contador;//Para saber si cargó foto o no.        
        private string guardado;
        private string existe; //Para llamar al método que verifica que no existe ya en la bd para luego poder guardarla en caso de que no.

        public ABM_Propiedad()
        {
            InitializeComponent();
            mp = new MapeoPropiedad();
            contador = 0;            
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

        private void Form1_Load(object sender, EventArgs e)
        {            
            //No Visible
            lbl4.Visible = false;
            lbl5.Visible = false;

            //Cargar combo TipoPropiedad
            cmbTipoPropiedad.DisplayMember = "Nombre";
            cmbTipoPropiedad.ValueMember = "Id_tipoPropiedad";
            cmbTipoPropiedad.DataSource = ObtenerListaItemOpcionalTP();

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

            //mtbFechaInag.ValidatingType = typeof(System.DateTime);
            //mtbFechaInag.TypeValidationCompleted+=new TypeValidationEventHandler(mtbFechaInag_TypeValidationCompleted);
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
                contador++;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var form = new Consulta_Propiedades();
            form.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Control para que el usuario ingrese o seleccione campos obligatorios
            if (txtDireccion.Text=="")
            {
                MessageBox.Show("Ingrese una dirección", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl3.ForeColor = Color.Red;
                txtDireccion.BackColor = Color.Yellow;
                txtDireccion.Focus();
                return;
            }
            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Ingrese un precio en pesos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl6.ForeColor = Color.Red;
                txtPrecio.BackColor = Color.Yellow;
                txtPrecio.Focus();
                return;
            }
            /*if (mtbFechaInag.MaskFull==false)
            {
                MessageBox.Show("Ingrese una fecha de inauguración correctamente", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl9.ForeColor = Color.Red;
                mtbFechaInag.BackColor = Color.Yellow;
                mtbFechaInag.Focus();
                return;
            }*/
            if (cmbTipoPropiedad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un tipo de Propiedad", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl1.ForeColor = Color.Red;             
                cmbTipoPropiedad.Focus();
                return;
            }
            if (cmbLocalidad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una Localidad", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl2.ForeColor = Color.Red;
                cmbLocalidad.Focus();
                return;
            }
            if (cmbEstado.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un estado de la Propiedad", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl7.ForeColor = Color.Red;
                cmbEstado.Focus();
                return;
            }
            if (cmbRequisitos.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione el nivel de Requisitos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl8.ForeColor = Color.Red;
                cmbRequisitos.Focus();
                return;
            }
            if (cmbServicios.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione el nivel de Servicio", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl10.ForeColor = Color.Red;
                cmbServicios.Focus();
                return;
            }
            //Si selecciono departamento debe ingresar un nro. de piso
            if (cmbTipoPropiedad.SelectedIndex == 2 && txtPiso.Text == "")
            {
                MessageBox.Show("Ingrese un piso", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl4.ForeColor = Color.Red;
                txtPiso.BackColor = Color.Yellow;
                txtPiso.Focus();
                return; 
            }
            //Si selecciono departamento debe ingresar un Depto.
            if (cmbTipoPropiedad.SelectedIndex == 2 && txtDepto.Text == "")
            {
                MessageBox.Show("Ingrese un Depto.", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl5.ForeColor = Color.Red;
                txtDepto.BackColor = Color.Yellow;
                txtDepto.Focus();
                return;
            }
            //Controlar el si la fecha ingresada está dentro del rango válido
            //bool res = FechaValida(DateTime.Parse(mtbFechaInag.Text));
            bool res = FechaValida(DateTime.Parse(dtpFechaInaug.Text));
            if (res == false)
            {
                MessageBox.Show("Ingrese una fecha de inauguración correctamente", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl9.ForeColor = Color.Red;                
                dtpFechaInaug.Focus();
                //mtbFechaInag.BackColor = Color.Yellow;
                //mtbFechaInag.Focus();
                return;
            }

            //Foto pasarla a Byte en caso de ser distinta a la foto de inicio
            if (pbFoto.Image != null)
            {
                //p.foto = ImgToByte(pbFotoDeportista.Image);
                foto = ImgToByte(pbFoto.Image);
            }

            //Creo los objetos con los datos cargados por el Usuario.
            Propiedad p = new Propiedad();
            TipoPropiedad tp = new TipoPropiedad();
            //Localidad l = new Localidad();
            Barrio b = new Barrio();
            Estado es = new Estado();
            Requisito req = new Requisito();
            Servicio ss = new Servicio();
            p.Direccion = txtDireccion.Text;
            p.Descripcion = txtDescrip.Text;
            if (txtPiso.Text != "")
                p.Piso = int.Parse(txtPiso.Text);
            else
                p.Piso = 0;
            if(txtDepto.Text != "")
                p.Depto = char.Parse(txtDepto.Text);
            else
                p.Depto='ñ';
            p.FechaIng = DateTime.Parse(dtpFechaInaug.Text);
            p.NroHabitaciones = int.Parse(cmbNroHab.SelectedItem.ToString());
            tp = (TipoPropiedad)cmbTipoPropiedad.SelectedItem;
            //l = (Localidad)cmbLocalidad.SelectedItem;
            b = (Barrio)cmbBarrio.SelectedItem;
            es = (Estado)cmbEstado.SelectedItem;
            req = (Requisito)cmbRequisitos.SelectedItem;
            ss = (Servicio)cmbServicios.SelectedItem;
            p.Id_tipoPropiedad = tp.Id_tipoPropiedad;
            p.Id_barrio = b.Id_barrio;
            p.Id_estado = es.Id_estado;
            p.Id_requisito = req.Id_requisito;
            p.Id_servicio = ss.Id_servicio;
            p.Precio = double.Parse(txtPrecio.Text);
            if (contador > 0)
                p.foto = foto;
            else
                p.foto = null;
            /*if (foto != fotoXDefecto)
                p.foto = foto;
            else
                p.foto = null;*/
            existe = mp.ExistePropiedad(p);           
                if (existe == "No Existe Propiedad")
                {
                    guardado = mp.RegistrarPropiedad(p);
                    if (guardado == "Guardado")
                    {
                        MessageBox.Show("Se Registró correctamente la Propiedad", "Registro Propiedad", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        Limpiar();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("No Guardado, Error de Escritura", "Registro Propiedad", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        Limpiar();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No Guardado, ya existe Propiedad", "Registro Propiedad", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Limpiar();
                    return;
                }

            
        }

        private void cmbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch (cmbTipoPropiedad.SelectedIndex)
            {
                case 0:
                    {
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        break;
                    }
                case 1:
                    {
                        lbl4.Visible = false;
                        lbl5.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        break;
                    }
            }
        }
        private void Limpiar()
        {
            cmbTipoPropiedad.SelectedIndex = 0;
            cmbLocalidad.SelectedIndex = 0;
            cmbRequisitos.SelectedIndex = 0;
            cmbServicios.SelectedIndex = 0;
            cmbNroHab.SelectedIndex = 1;
            cmbEstado.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtDescrip.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";
            txtPrecio.Text = "";
            dtpFechaInaug.Text="";
            //mtbFechaInag.Text = "";

            //Foto Ruta relativa
            var ruta = Application.StartupPath;
            ruta = ruta.Substring(0, ruta.Length - 10);
            var imagepath = Path.Combine(ruta, "Resources\\imagenInicio4.jpg");
            pbFoto.Image = Image.FromFile(imagepath);
            contador = 0;

            cmbTipoPropiedad.Focus();
            this.Seteo();

        }
        //Seteo poner las cajas de texto y asteriscos del color por defecto
        private void Seteo()
        {
            lbl1.ForeColor = Color.Black;
            lbl2.ForeColor = Color.Black;
            lbl3.ForeColor = Color.Black;
            lbl4.ForeColor = Color.Black;
            lbl5.ForeColor = Color.Black;
            lbl6.ForeColor = Color.Black;
            lbl7.ForeColor = Color.Black;
            lbl8.ForeColor = Color.Black;
            lbl9.ForeColor = Color.Black;
            lbl10.ForeColor = Color.Black;
            txtDireccion.BackColor = Color.White;
            txtDepto.BackColor=Color.White;
            txtPiso.BackColor = Color.White;
            txtDescrip.BackColor = Color.White;
            txtPrecio.BackColor = Color.White;
            //mtbFechaInag.BackColor = Color.White;

        }

        //Validaciones de Eventos
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio.MaxLength = 5;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Permiten Números", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)//Puede escribir hasta 49 caracteres ya que eso soporta la bd.
        {
            txtDireccion.MaxLength = 49;
            
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPiso.MaxLength = 2;
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Permiten Números", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDepto.MaxLength = 1;
            if ((char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Solo se Permiten Letras", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDescrip.MaxLength = 49;
        }

        private bool FechaValida(DateTime fecha)
        {
            
            DateTime fechaMin=Convert.ToDateTime("01/01/1910");
            DateTime fechaMax=DateTime.Now;
            if ((fecha >= fechaMin) && (fecha <= fechaMax))
                return true;
            else
                return false;
        }

        private void btnQuitarImag_Click(object sender, EventArgs e)
        {
            //Foto Ruta relativa
            var ruta = Application.StartupPath;
            ruta = ruta.Substring(0, ruta.Length - 10);
            var imagepath = Path.Combine(ruta, "Resources\\imagenInicio4.jpg");
            pbFoto.Image = Image.FromFile(imagepath);
            contador = 0;
        }

        

        /*private void mtbFechaInag_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;
            if (DateTime.TryParse(mtbFechaInag.Text, out fecha))
            {
                MessageBox.Show("Ingrese una fecha de inauguración correctamente", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lbl9.ForeColor = Color.Red;
                mtbFechaInag.BackColor = Color.Yellow;
                mtbFechaInag.Focus();
                return;
            }
        }*/

        /*private void mtbFechaInag_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput)
            {
                MessageBox.Show("Ingrese una fecha de inauguración válida", "Advertencia", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                lbl9.ForeColor = Color.Red;
                mtbFechaInag.BackColor = Color.Yellow;
                mtbFechaInag.Focus();
                e.Cancel=true;
            }
        }*/

        
    }
}

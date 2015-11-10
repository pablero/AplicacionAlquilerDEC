namespace Interfaces
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCargaPropiedad = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNroHab = new System.Windows.Forms.ComboBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mtbFechaInag = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbRequisitos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbCargaPropiedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaPropiedad
            // 
            this.gbCargaPropiedad.Controls.Add(this.txtDescrip);
            this.gbCargaPropiedad.Controls.Add(this.label13);
            this.gbCargaPropiedad.Controls.Add(this.cmbServicios);
            this.gbCargaPropiedad.Controls.Add(this.label12);
            this.gbCargaPropiedad.Controls.Add(this.cmbRequisitos);
            this.gbCargaPropiedad.Controls.Add(this.label11);
            this.gbCargaPropiedad.Controls.Add(this.cmbEstado);
            this.gbCargaPropiedad.Controls.Add(this.label10);
            this.gbCargaPropiedad.Controls.Add(this.mtbFechaInag);
            this.gbCargaPropiedad.Controls.Add(this.label9);
            this.gbCargaPropiedad.Controls.Add(this.btnFoto);
            this.gbCargaPropiedad.Controls.Add(this.txtPrecio);
            this.gbCargaPropiedad.Controls.Add(this.label8);
            this.gbCargaPropiedad.Controls.Add(this.pbFoto);
            this.gbCargaPropiedad.Controls.Add(this.cmbNroHab);
            this.gbCargaPropiedad.Controls.Add(this.label7);
            this.gbCargaPropiedad.Controls.Add(this.txtDepto);
            this.gbCargaPropiedad.Controls.Add(this.txtPiso);
            this.gbCargaPropiedad.Controls.Add(this.txtDireccion);
            this.gbCargaPropiedad.Controls.Add(this.cmbBarrio);
            this.gbCargaPropiedad.Controls.Add(this.cmbLocalidad);
            this.gbCargaPropiedad.Controls.Add(this.cmbTipoPropiedad);
            this.gbCargaPropiedad.Controls.Add(this.label6);
            this.gbCargaPropiedad.Controls.Add(this.label5);
            this.gbCargaPropiedad.Controls.Add(this.label4);
            this.gbCargaPropiedad.Controls.Add(this.label3);
            this.gbCargaPropiedad.Controls.Add(this.label2);
            this.gbCargaPropiedad.Controls.Add(this.label1);
            this.gbCargaPropiedad.Location = new System.Drawing.Point(12, 9);
            this.gbCargaPropiedad.Name = "gbCargaPropiedad";
            this.gbCargaPropiedad.Size = new System.Drawing.Size(728, 337);
            this.gbCargaPropiedad.TabIndex = 0;
            this.gbCargaPropiedad.TabStop = false;
            this.gbCargaPropiedad.Text = "Cargar Propiedad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Barrio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Piso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Depto.";
            // 
            // cmbTipoPropiedad
            // 
            this.cmbTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPropiedad.FormattingEnabled = true;
            this.cmbTipoPropiedad.Location = new System.Drawing.Point(138, 29);
            this.cmbTipoPropiedad.Name = "cmbTipoPropiedad";
            this.cmbTipoPropiedad.Size = new System.Drawing.Size(255, 21);
            this.cmbTipoPropiedad.TabIndex = 1;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(138, 56);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(255, 21);
            this.cmbLocalidad.TabIndex = 3;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(138, 84);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(255, 21);
            this.cmbBarrio.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(138, 111);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(255, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(138, 138);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(53, 20);
            this.txtPiso.TabIndex = 9;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(256, 137);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(55, 20);
            this.txtDepto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nro. de Habitaciones";
            // 
            // cmbNroHab
            // 
            this.cmbNroHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroHab.FormattingEnabled = true;
            this.cmbNroHab.Location = new System.Drawing.Point(139, 164);
            this.cmbNroHab.Name = "cmbNroHab";
            this.cmbNroHab.Size = new System.Drawing.Size(52, 21);
            this.cmbNroHab.TabIndex = 13;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(408, 29);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(297, 188);
            this.pbFoto.TabIndex = 14;
            this.pbFoto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(256, 165);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(135, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(513, 225);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(102, 23);
            this.btnFoto.TabIndex = 25;
            this.btnFoto.Text = "Cargar Imagen";
            this.btnFoto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha Inaguración";
            // 
            // mtbFechaInag
            // 
            this.mtbFechaInag.Location = new System.Drawing.Point(139, 258);
            this.mtbFechaInag.Mask = "00/00/0000";
            this.mtbFechaInag.Name = "mtbFechaInag";
            this.mtbFechaInag.Size = new System.Drawing.Size(80, 20);
            this.mtbFechaInag.TabIndex = 21;
            this.mtbFechaInag.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado de la Propiedad";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(139, 196);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(254, 21);
            this.cmbEstado.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Requisitos para Alquilar";
            // 
            // cmbRequisitos
            // 
            this.cmbRequisitos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequisitos.FormattingEnabled = true;
            this.cmbRequisitos.Location = new System.Drawing.Point(139, 227);
            this.cmbRequisitos.Name = "cmbRequisitos";
            this.cmbRequisitos.Size = new System.Drawing.Size(254, 21);
            this.cmbRequisitos.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Servicios Ofrecidos";
            // 
            // cmbServicios
            // 
            this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(139, 289);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(181, 21);
            this.cmbServicios.TabIndex = 23;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(100, 359);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(131, 23);
            this.btnConsultar.TabIndex = 29;
            this.btnConsultar.Text = "Consultar Propiedades";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(665, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 31;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Descripción";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(408, 271);
            this.txtDescrip.Multiline = true;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(297, 51);
            this.txtDescrip.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(237, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(405, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Presione este botón si desea consultar, modificar o eliminar propiedades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 394);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbCargaPropiedad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Propiedad";
            this.gbCargaPropiedad.ResumeLayout(false);
            this.gbCargaPropiedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaPropiedad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbFechaInag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ComboBox cmbNroHab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbTipoPropiedad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRequisitos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}


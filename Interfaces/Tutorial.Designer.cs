namespace AlquileresDEC.Interfaces
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnABM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUtilidad = new System.Windows.Forms.Button();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.btnCriterios = new System.Windows.Forms.Button();
            this.rtbTitulo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensaje.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMensaje.Location = new System.Drawing.Point(60, 368);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.ReadOnly = true;
            this.rtbMensaje.Size = new System.Drawing.Size(830, 128);
            this.rtbMensaje.TabIndex = 99;
            this.rtbMensaje.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(778, 522);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsultar.Location = new System.Drawing.Point(366, 235);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(200, 56);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar Propiedad";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(690, 235);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(200, 56);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar Propiedad";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSeleccion.Location = new System.Drawing.Point(690, 134);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(200, 56);
            this.btnSeleccion.TabIndex = 4;
            this.btnSeleccion.Text = "Selección de Alternativas";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnABM
            // 
            this.btnABM.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnABM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnABM.Location = new System.Drawing.Point(60, 235);
            this.btnABM.Name = "btnABM";
            this.btnABM.Size = new System.Drawing.Size(200, 56);
            this.btnABM.TabIndex = 5;
            this.btnABM.Text = "Registro de Propiedad";
            this.btnABM.UseVisualStyleBackColor = false;
            this.btnABM.Click += new System.EventHandler(this.btnABM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnUtilidad
            // 
            this.btnUtilidad.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUtilidad.Location = new System.Drawing.Point(60, 27);
            this.btnUtilidad.Name = "btnUtilidad";
            this.btnUtilidad.Size = new System.Drawing.Size(200, 56);
            this.btnUtilidad.TabIndex = 1;
            this.btnUtilidad.Text = "¿Para qué sirve?";
            this.btnUtilidad.UseVisualStyleBackColor = false;
            this.btnUtilidad.Click += new System.EventHandler(this.btnUtilidad_Click);
            // 
            // btnFuncion
            // 
            this.btnFuncion.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFuncion.Location = new System.Drawing.Point(690, 27);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(200, 56);
            this.btnFuncion.TabIndex = 2;
            this.btnFuncion.Text = "¿Cómo funciona?";
            this.btnFuncion.UseVisualStyleBackColor = false;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnCriterios
            // 
            this.btnCriterios.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriterios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCriterios.Location = new System.Drawing.Point(60, 134);
            this.btnCriterios.Name = "btnCriterios";
            this.btnCriterios.Size = new System.Drawing.Size(200, 56);
            this.btnCriterios.TabIndex = 3;
            this.btnCriterios.Text = "Criterios Analizados";
            this.btnCriterios.UseVisualStyleBackColor = false;
            this.btnCriterios.Click += new System.EventHandler(this.btnCriterios_Click);
            // 
            // rtbTitulo
            // 
            this.rtbTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitulo.Font = new System.Drawing.Font("Century Gothic", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbTitulo.Location = new System.Drawing.Point(60, 321);
            this.rtbTitulo.Name = "rtbTitulo";
            this.rtbTitulo.ReadOnly = true;
            this.rtbTitulo.Size = new System.Drawing.Size(830, 41);
            this.rtbTitulo.TabIndex = 98;
            this.rtbTitulo.Text = "";
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 571);
            this.Controls.Add(this.rtbTitulo);
            this.Controls.Add(this.btnCriterios);
            this.Controls.Add(this.btnFuncion);
            this.Controls.Add(this.btnUtilidad);
            this.Controls.Add(this.btnABM);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbMensaje);
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tutorial de Alquilar Propiedad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnABM;
        private System.Windows.Forms.Button btnUtilidad;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.Button btnCriterios;
        private System.Windows.Forms.RichTextBox rtbTitulo;

    }
}
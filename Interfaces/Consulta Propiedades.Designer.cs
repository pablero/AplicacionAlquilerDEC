namespace AlquileresDEC.Interfaces
{
    partial class Consulta_Propiedades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPrecioHasta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFiltroBarrio = new System.Windows.Forms.ComboBox();
            this.cmbFiltroLocalidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltroTipoPropiedad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvPropiedades = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnLimpiar);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.txtPrecioHasta);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txtPrecioDesde);
            this.gbFiltros.Controls.Add(this.label8);
            this.gbFiltros.Controls.Add(this.cmbFiltroBarrio);
            this.gbFiltros.Controls.Add(this.cmbFiltroLocalidad);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.cmbFiltroTipoPropiedad);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.Location = new System.Drawing.Point(20, 20);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Size = new System.Drawing.Size(1100, 174);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Búsqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(567, 129);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(377, 129);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPrecioHasta
            // 
            this.txtPrecioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioHasta.Location = new System.Drawing.Point(353, 74);
            this.txtPrecioHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioHasta.Name = "txtPrecioHasta";
            this.txtPrecioHasta.Size = new System.Drawing.Size(136, 26);
            this.txtPrecioHasta.TabIndex = 4;
            this.txtPrecioHasta.Text = "Máximo";
            this.txtPrecioHasta.Click += new System.EventHandler(this.txtPrecioHasta_Click);
            this.txtPrecioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioHasta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "-";
            // 
            // txtPrecioDesde
            // 
            this.txtPrecioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDesde.Location = new System.Drawing.Point(181, 74);
            this.txtPrecioDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioDesde.Name = "txtPrecioDesde";
            this.txtPrecioDesde.Size = new System.Drawing.Size(132, 26);
            this.txtPrecioDesde.TabIndex = 3;
            this.txtPrecioDesde.Text = "Mínimo";
            this.txtPrecioDesde.Click += new System.EventHandler(this.txtPrecioDesde_Click);
            this.txtPrecioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDesde_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio ($)";
            // 
            // cmbFiltroBarrio
            // 
            this.cmbFiltroBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroBarrio.FormattingEnabled = true;
            this.cmbFiltroBarrio.Location = new System.Drawing.Point(628, 77);
            this.cmbFiltroBarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroBarrio.Name = "cmbFiltroBarrio";
            this.cmbFiltroBarrio.Size = new System.Drawing.Size(380, 28);
            this.cmbFiltroBarrio.TabIndex = 5;
            // 
            // cmbFiltroLocalidad
            // 
            this.cmbFiltroLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroLocalidad.FormattingEnabled = true;
            this.cmbFiltroLocalidad.Location = new System.Drawing.Point(628, 29);
            this.cmbFiltroLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroLocalidad.Name = "cmbFiltroLocalidad";
            this.cmbFiltroLocalidad.Size = new System.Drawing.Size(380, 28);
            this.cmbFiltroLocalidad.TabIndex = 2;
            this.cmbFiltroLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroLocalidad_SelectedIndexChanged);
            this.cmbFiltroLocalidad.Click += new System.EventHandler(this.cmbFiltroLocalidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Localidad";
            // 
            // cmbFiltroTipoPropiedad
            // 
            this.cmbFiltroTipoPropiedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroTipoPropiedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroTipoPropiedad.FormattingEnabled = true;
            this.cmbFiltroTipoPropiedad.Location = new System.Drawing.Point(181, 29);
            this.cmbFiltroTipoPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroTipoPropiedad.Name = "cmbFiltroTipoPropiedad";
            this.cmbFiltroTipoPropiedad.Size = new System.Drawing.Size(307, 28);
            this.cmbFiltroTipoPropiedad.TabIndex = 1;
            this.cmbFiltroTipoPropiedad.Click += new System.EventHandler(this.cmbFiltroTipoPropiedad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.dgvPropiedades);
            this.gbResultados.Location = new System.Drawing.Point(20, 203);
            this.gbResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbResultados.Size = new System.Drawing.Size(1100, 340);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvPropiedades
            // 
            this.dgvPropiedades.AllowUserToAddRows = false;
            this.dgvPropiedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPropiedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPropiedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPropiedades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPropiedades.Location = new System.Drawing.Point(21, 29);
            this.dgvPropiedades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPropiedades.Name = "dgvPropiedades";
            this.dgvPropiedades.ReadOnly = true;
            this.dgvPropiedades.Size = new System.Drawing.Size(1050, 282);
            this.dgvPropiedades.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(20, 566);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1006, 566);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 35);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Consulta_Propiedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 617);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Consulta_Propiedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Propiedades";
            this.Load += new System.EventHandler(this.Consulta_Propiedades_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropiedades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cmbFiltroTipoPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltroBarrio;
        private System.Windows.Forms.ComboBox cmbFiltroLocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvPropiedades;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}
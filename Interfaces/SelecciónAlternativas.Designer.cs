namespace AlquileresDEC.Interfaces
{
    partial class Seleccion_Alternativas
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
            this.gbAlternativasCandidatas = new System.Windows.Forms.GroupBox();
            this.dgvAltCandidatas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.gbAlternativasElegidas = new System.Windows.Forms.GroupBox();
            this.dgvAltElegidas = new System.Windows.Forms.DataGridView();
            this.Seleccionar2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarTodos = new System.Windows.Forms.Button();
            this.btnQuitarTodos = new System.Windows.Forms.Button();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gbNormalizacion = new System.Windows.Forms.GroupBox();
            this.rbMaximo = new System.Windows.Forms.RadioButton();
            this.rbRaiz = new System.Windows.Forms.RadioButton();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.gbSeleccionP = new System.Windows.Forms.GroupBox();
            this.cmbP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCriterios = new System.Windows.Forms.DataGridView();
            this.Criterios = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Objetivo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.gbAlternativasCandidatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltCandidatas)).BeginInit();
            this.gbAlternativasElegidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltElegidas)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbNormalizacion.SuspendLayout();
            this.gbSeleccionP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriterios)).BeginInit();
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
            this.gbFiltros.Location = new System.Drawing.Point(358, 14);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFiltros.Size = new System.Drawing.Size(1334, 182);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Búsqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(659, 129);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(458, 129);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioHasta
            // 
            this.txtPrecioHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioHasta.Location = new System.Drawing.Point(435, 80);
            this.txtPrecioHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioHasta.Name = "txtPrecioHasta";
            this.txtPrecioHasta.Size = new System.Drawing.Size(136, 26);
            this.txtPrecioHasta.TabIndex = 5;
            this.txtPrecioHasta.Text = "Máximo";
            this.txtPrecioHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioHasta.Click += new System.EventHandler(this.txtPrecioHasta_Click);
            this.txtPrecioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioHasta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "-";
            // 
            // txtPrecioDesde
            // 
            this.txtPrecioDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDesde.Location = new System.Drawing.Point(263, 80);
            this.txtPrecioDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioDesde.Name = "txtPrecioDesde";
            this.txtPrecioDesde.Size = new System.Drawing.Size(132, 26);
            this.txtPrecioDesde.TabIndex = 3;
            this.txtPrecioDesde.Text = "Mínimo";
            this.txtPrecioDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecioDesde.Click += new System.EventHandler(this.txtPrecioDesde_Click);
            this.txtPrecioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioDesde_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 80);
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
            this.cmbFiltroBarrio.Location = new System.Drawing.Point(764, 77);
            this.cmbFiltroBarrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroBarrio.Name = "cmbFiltroBarrio";
            this.cmbFiltroBarrio.Size = new System.Drawing.Size(380, 28);
            this.cmbFiltroBarrio.TabIndex = 9;
            // 
            // cmbFiltroLocalidad
            // 
            this.cmbFiltroLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroLocalidad.FormattingEnabled = true;
            this.cmbFiltroLocalidad.Location = new System.Drawing.Point(764, 29);
            this.cmbFiltroLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroLocalidad.Name = "cmbFiltroLocalidad";
            this.cmbFiltroLocalidad.Size = new System.Drawing.Size(380, 28);
            this.cmbFiltroLocalidad.TabIndex = 7;
            this.cmbFiltroLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroLocalidad_SelectedIndexChanged);
            this.cmbFiltroLocalidad.Click += new System.EventHandler(this.cmbFiltroLocalidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Barrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 32);
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
            this.cmbFiltroTipoPropiedad.Location = new System.Drawing.Point(263, 29);
            this.cmbFiltroTipoPropiedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFiltroTipoPropiedad.Name = "cmbFiltroTipoPropiedad";
            this.cmbFiltroTipoPropiedad.Size = new System.Drawing.Size(307, 28);
            this.cmbFiltroTipoPropiedad.TabIndex = 1;
            this.cmbFiltroTipoPropiedad.Click += new System.EventHandler(this.cmbFiltroTipoPropiedad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Propiedad";
            // 
            // gbAlternativasCandidatas
            // 
            this.gbAlternativasCandidatas.Controls.Add(this.dgvAltCandidatas);
            this.gbAlternativasCandidatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlternativasCandidatas.Location = new System.Drawing.Point(358, 217);
            this.gbAlternativasCandidatas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlternativasCandidatas.Name = "gbAlternativasCandidatas";
            this.gbAlternativasCandidatas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlternativasCandidatas.Size = new System.Drawing.Size(572, 363);
            this.gbAlternativasCandidatas.TabIndex = 2;
            this.gbAlternativasCandidatas.TabStop = false;
            this.gbAlternativasCandidatas.Text = "Alternativas Candidatas";
            // 
            // dgvAltCandidatas
            // 
            this.dgvAltCandidatas.AllowUserToAddRows = false;
            this.dgvAltCandidatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAltCandidatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltCandidatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvAltCandidatas.Location = new System.Drawing.Point(18, 29);
            this.dgvAltCandidatas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAltCandidatas.Name = "dgvAltCandidatas";
            this.dgvAltCandidatas.Size = new System.Drawing.Size(531, 306);
            this.dgvAltCandidatas.TabIndex = 15;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(955, 283);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "--->";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(955, 416);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 35);
            this.btnQuitar.TabIndex = 23;
            this.btnQuitar.Text = "<---";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // gbAlternativasElegidas
            // 
            this.gbAlternativasElegidas.Controls.Add(this.dgvAltElegidas);
            this.gbAlternativasElegidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlternativasElegidas.Location = new System.Drawing.Point(1108, 221);
            this.gbAlternativasElegidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlternativasElegidas.Name = "gbAlternativasElegidas";
            this.gbAlternativasElegidas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAlternativasElegidas.Size = new System.Drawing.Size(584, 363);
            this.gbAlternativasElegidas.TabIndex = 17;
            this.gbAlternativasElegidas.TabStop = false;
            this.gbAlternativasElegidas.Text = "Alternativas Elegidas";
            // 
            // dgvAltElegidas
            // 
            this.dgvAltElegidas.AllowUserToAddRows = false;
            this.dgvAltElegidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAltElegidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltElegidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar2});
            this.dgvAltElegidas.Location = new System.Drawing.Point(24, 29);
            this.dgvAltElegidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAltElegidas.Name = "dgvAltElegidas";
            this.dgvAltElegidas.Size = new System.Drawing.Size(531, 306);
            this.dgvAltElegidas.TabIndex = 21;
            // 
            // Seleccionar2
            // 
            this.Seleccionar2.HeaderText = "Seleccionar";
            this.Seleccionar2.Name = "Seleccionar2";
            // 
            // btnAgregarTodos
            // 
            this.btnAgregarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTodos.Location = new System.Drawing.Point(955, 327);
            this.btnAgregarTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarTodos.Name = "btnAgregarTodos";
            this.btnAgregarTodos.Size = new System.Drawing.Size(112, 35);
            this.btnAgregarTodos.TabIndex = 19;
            this.btnAgregarTodos.Text = "--->>";
            this.btnAgregarTodos.UseVisualStyleBackColor = true;
            // 
            // btnQuitarTodos
            // 
            this.btnQuitarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarTodos.Location = new System.Drawing.Point(955, 461);
            this.btnQuitarTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarTodos.Name = "btnQuitarTodos";
            this.btnQuitarTodos.Size = new System.Drawing.Size(112, 35);
            this.btnQuitarTodos.TabIndex = 25;
            this.btnQuitarTodos.Text = "<<---";
            this.btnQuitarTodos.UseVisualStyleBackColor = true;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.btnExcel);
            this.gbParametros.Controls.Add(this.groupBox5);
            this.gbParametros.Controls.Add(this.dgvCriterios);
            this.gbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(358, 607);
            this.gbParametros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbParametros.Size = new System.Drawing.Size(1334, 361);
            this.gbParametros.TabIndex = 23;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros a utilizar en Topsis";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(189, 309);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(182, 35);
            this.btnExcel.TabIndex = 36;
            this.btnExcel.Text = "Exportar A Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gbNormalizacion);
            this.groupBox5.Controls.Add(this.gbSeleccionP);
            this.groupBox5.Location = new System.Drawing.Point(597, 29);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(708, 271);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // gbNormalizacion
            // 
            this.gbNormalizacion.Controls.Add(this.rbMaximo);
            this.gbNormalizacion.Controls.Add(this.rbRaiz);
            this.gbNormalizacion.Controls.Add(this.rbSuma);
            this.gbNormalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNormalizacion.Location = new System.Drawing.Point(34, 29);
            this.gbNormalizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNormalizacion.Name = "gbNormalizacion";
            this.gbNormalizacion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbNormalizacion.Size = new System.Drawing.Size(648, 85);
            this.gbNormalizacion.TabIndex = 29;
            this.gbNormalizacion.TabStop = false;
            this.gbNormalizacion.Text = "Selección de Normalización";
            // 
            // rbMaximo
            // 
            this.rbMaximo.AutoSize = true;
            this.rbMaximo.Location = new System.Drawing.Point(504, 35);
            this.rbMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMaximo.Name = "rbMaximo";
            this.rbMaximo.Size = new System.Drawing.Size(94, 24);
            this.rbMaximo.TabIndex = 32;
            this.rbMaximo.Text = "Máximo";
            this.rbMaximo.UseVisualStyleBackColor = true;
            // 
            // rbRaiz
            // 
            this.rbRaiz.AutoSize = true;
            this.rbRaiz.Location = new System.Drawing.Point(266, 35);
            this.rbRaiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRaiz.Name = "rbRaiz";
            this.rbRaiz.Size = new System.Drawing.Size(70, 24);
            this.rbRaiz.TabIndex = 31;
            this.rbRaiz.Text = "Raíz";
            this.rbRaiz.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuma.Location = new System.Drawing.Point(28, 35);
            this.rbSuma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(76, 24);
            this.rbSuma.TabIndex = 30;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // gbSeleccionP
            // 
            this.gbSeleccionP.Controls.Add(this.cmbP);
            this.gbSeleccionP.Controls.Add(this.label5);
            this.gbSeleccionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionP.Location = new System.Drawing.Point(34, 140);
            this.gbSeleccionP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeleccionP.Name = "gbSeleccionP";
            this.gbSeleccionP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSeleccionP.Size = new System.Drawing.Size(648, 91);
            this.gbSeleccionP.TabIndex = 34;
            this.gbSeleccionP.TabStop = false;
            this.gbSeleccionP.Text = "Selección del valor de P";
            // 
            // cmbP
            // 
            this.cmbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbP.FormattingEnabled = true;
            this.cmbP.Location = new System.Drawing.Point(242, 37);
            this.cmbP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbP.Name = "cmbP";
            this.cmbP.Size = new System.Drawing.Size(238, 28);
            this.cmbP.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "P=";
            // 
            // dgvCriterios
            // 
            this.dgvCriterios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCriterios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criterios,
            this.Objetivo});
            this.dgvCriterios.Location = new System.Drawing.Point(18, 29);
            this.dgvCriterios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCriterios.Name = "dgvCriterios";
            this.dgvCriterios.Size = new System.Drawing.Size(554, 271);
            this.dgvCriterios.TabIndex = 27;
            // 
            // Criterios
            // 
            this.Criterios.HeaderText = "Criterios";
            this.Criterios.Name = "Criterios";
            // 
            // Objetivo
            // 
            this.Objetivo.HeaderText = "Objetivo";
            this.Objetivo.Items.AddRange(new object[] {
            "Maximizar",
            "Minimizar"});
            this.Objetivo.Name = "Objetivo";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(764, 981);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(166, 60);
            this.btnGenerar.TabIndex = 38;
            this.btnGenerar.Text = "Generar Solución Topsis";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1017, 978);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 60);
            this.btnSalir.TabIndex = 40;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Seleccion_Alternativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 1051);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.btnQuitarTodos);
            this.Controls.Add(this.btnAgregarTodos);
            this.Controls.Add(this.gbAlternativasElegidas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.gbAlternativasCandidatas);
            this.Controls.Add(this.gbFiltros);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Seleccion_Alternativas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Alternativas";
            this.Load += new System.EventHandler(this.Seleccion_Alternativas_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbAlternativasCandidatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltCandidatas)).EndInit();
            this.gbAlternativasElegidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltElegidas)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.gbNormalizacion.ResumeLayout(false);
            this.gbNormalizacion.PerformLayout();
            this.gbSeleccionP.ResumeLayout(false);
            this.gbSeleccionP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCriterios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPrecioHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFiltroBarrio;
        private System.Windows.Forms.ComboBox cmbFiltroLocalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltroTipoPropiedad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAlternativasCandidatas;
        private System.Windows.Forms.DataGridView dgvAltCandidatas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox gbAlternativasElegidas;
        private System.Windows.Forms.DataGridView dgvAltElegidas;
        private System.Windows.Forms.Button btnAgregarTodos;
        private System.Windows.Forms.Button btnQuitarTodos;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar2;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gbNormalizacion;
        private System.Windows.Forms.RadioButton rbMaximo;
        private System.Windows.Forms.RadioButton rbRaiz;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.GroupBox gbSeleccionP;
        private System.Windows.Forms.ComboBox cmbP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCriterios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Criterios;
        private System.Windows.Forms.DataGridViewComboBoxColumn Objetivo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}
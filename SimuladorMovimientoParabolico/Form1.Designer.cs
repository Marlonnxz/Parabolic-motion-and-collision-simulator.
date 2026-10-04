namespace SimuladorMovimientoParabolico
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblSubtituloApp = new System.Windows.Forms.Label();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.grpEntradas = new System.Windows.Forms.GroupBox();
            this.btnNuevoObjetivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.lblDt = new System.Windows.Forms.Label();
            this.txtGravedad = new System.Windows.Forms.TextBox();
            this.lblGravedad = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtV0 = new System.Windows.Forms.TextBox();
            this.lblV0 = new System.Windows.Forms.Label();
            this.txtY0 = new System.Windows.Forms.TextBox();
            this.lblY0 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.grpTiempoReal = new System.Windows.Forms.GroupBox();
            this.lblInfoObjetivo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblVang = new System.Windows.Forms.Label();
            this.lblVmag = new System.Windows.Forms.Label();
            this.lblVy = new System.Windows.Forms.Label();
            this.lblVx = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.grpTeorico = new System.Windows.Forms.GroupBox();
            this.lblTeoVelImpactoMag = new System.Windows.Forms.Label();
            this.lblTeoVelImpacto = new System.Windows.Forms.Label();
            this.lblTeoVelHmax = new System.Windows.Forms.Label();
            this.lblTeoAlcance = new System.Windows.Forms.Label();
            this.lblTeoTvuelo = new System.Windows.Forms.Label();
            this.lblTeoXhmax = new System.Windows.Forms.Label();
            this.lblTeoThmax = new System.Windows.Forms.Label();
            this.lblTeoHmax = new System.Windows.Forms.Label();
            this.grpAnimacion = new System.Windows.Forms.GroupBox();
            this.picAnimacion = new System.Windows.Forms.PictureBox();
            this.grpGraficas = new System.Windows.Forms.GroupBox();
            this.chartGraficas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbTipoGrafica = new System.Windows.Forms.ComboBox();
            this.lblSelGrafica = new System.Windows.Forms.Label();
            this.tabResultados = new System.Windows.Forms.TabControl();
            this.tabComparacion = new System.Windows.Forms.TabPage();
            this.dgvComparacion = new System.Windows.Forms.DataGridView();
            this.colMetrica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSimulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colErrorRel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabColisiones = new System.Windows.Forms.TabPage();
            this.dgvColisiones = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVxAntes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVyAntes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVmagAntes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVangAntes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVxDespues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVyDespues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVmagDespues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVangDespues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.grpEntradas.SuspendLayout();
            this.grpTiempoReal.SuspendLayout();
            this.grpTeorico.SuspendLayout();
            this.grpAnimacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimacion)).BeginInit();
            this.grpGraficas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficas)).BeginInit();
            this.tabResultados.SuspendLayout();
            this.tabComparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).BeginInit();
            this.tabColisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblIntegrantes);
            this.pnlHeader.Controls.Add(this.lblSubtituloApp);
            this.pnlHeader.Controls.Add(this.lblTituloApp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1290, 48);
            this.pnlHeader.TabIndex = 7;
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntegrantes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblIntegrantes.Location = new System.Drawing.Point(740, 14);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(536, 20);
            this.lblIntegrantes.TabIndex = 2;
            this.lblIntegrantes.Text = "Equipo: Marlon Delgado • Edwar Fonseca • Sebastian Quijano";
            this.lblIntegrantes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtituloApp
            // 
            this.lblSubtituloApp.AutoSize = true;
            this.lblSubtituloApp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubtituloApp.Location = new System.Drawing.Point(15, 27);
            this.lblSubtituloApp.Name = "lblSubtituloApp";
            this.lblSubtituloApp.Size = new System.Drawing.Size(465, 13);
            this.lblSubtituloApp.TabIndex = 1;
            this.lblSubtituloApp.Text = "Universidad Pedagógica y Tecnológica de Colombia (UPTC) • Simulación de Computado" +
    "res";
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblTituloApp.Location = new System.Drawing.Point(14, 6);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(395, 19);
            this.lblTituloApp.TabIndex = 0;
            this.lblTituloApp.Text = "SIMULADOR DE MOVIMIENTO PARABÓLICO Y COLISIONES";
            // 
            // grpEntradas
            // 
            this.grpEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpEntradas.Controls.Add(this.btnNuevoObjetivo);
            this.grpEntradas.Controls.Add(this.btnReiniciar);
            this.grpEntradas.Controls.Add(this.btnPausar);
            this.grpEntradas.Controls.Add(this.btnIniciar);
            this.grpEntradas.Controls.Add(this.txtDt);
            this.grpEntradas.Controls.Add(this.lblDt);
            this.grpEntradas.Controls.Add(this.txtGravedad);
            this.grpEntradas.Controls.Add(this.lblGravedad);
            this.grpEntradas.Controls.Add(this.txtAngulo);
            this.grpEntradas.Controls.Add(this.lblAngulo);
            this.grpEntradas.Controls.Add(this.txtV0);
            this.grpEntradas.Controls.Add(this.lblV0);
            this.grpEntradas.Controls.Add(this.txtY0);
            this.grpEntradas.Controls.Add(this.lblY0);
            this.grpEntradas.Controls.Add(this.txtX0);
            this.grpEntradas.Controls.Add(this.lblX0);
            this.grpEntradas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEntradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.grpEntradas.Location = new System.Drawing.Point(12, 56);
            this.grpEntradas.Name = "grpEntradas";
            this.grpEntradas.Size = new System.Drawing.Size(295, 290);
            this.grpEntradas.TabIndex = 1;
            this.grpEntradas.TabStop = false;
            this.grpEntradas.Text = "Condiciones Iniciales";
            // 
            // btnNuevoObjetivo
            // 
            this.btnNuevoObjetivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnNuevoObjetivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoObjetivo.FlatAppearance.BorderSize = 0;
            this.btnNuevoObjetivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoObjetivo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoObjetivo.ForeColor = System.Drawing.Color.White;
            this.btnNuevoObjetivo.Location = new System.Drawing.Point(150, 252);
            this.btnNuevoObjetivo.Name = "btnNuevoObjetivo";
            this.btnNuevoObjetivo.Size = new System.Drawing.Size(132, 28);
            this.btnNuevoObjetivo.TabIndex = 15;
            this.btnNuevoObjetivo.Text = "Nuevo Objetivo";
            this.btnNuevoObjetivo.UseVisualStyleBackColor = false;
            this.btnNuevoObjetivo.Click += new System.EventHandler(this.btnNuevoObjetivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.FlatAppearance.BorderSize = 0;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(12, 252);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(130, 28);
            this.btnReiniciar.TabIndex = 14;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.Color.White;
            this.btnPausar.Location = new System.Drawing.Point(150, 218);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(132, 28);
            this.btnPausar.TabIndex = 13;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = false;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(12, 218);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(130, 28);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar Simulación";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtDt
            // 
            this.txtDt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtDt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtDt.Location = new System.Drawing.Point(170, 178);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(112, 23);
            this.txtDt.TabIndex = 11;
            this.txtDt.Text = "0.02";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblDt.Location = new System.Drawing.Point(12, 181);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(66, 15);
            this.lblDt.TabIndex = 10;
            this.lblDt.Text = "Paso Δt (s):";
            // 
            // txtGravedad
            // 
            this.txtGravedad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtGravedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGravedad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGravedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtGravedad.Location = new System.Drawing.Point(170, 148);
            this.txtGravedad.Name = "txtGravedad";
            this.txtGravedad.Size = new System.Drawing.Size(112, 23);
            this.txtGravedad.TabIndex = 9;
            this.txtGravedad.Text = "9.81";
            // 
            // lblGravedad
            // 
            this.lblGravedad.AutoSize = true;
            this.lblGravedad.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravedad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblGravedad.Location = new System.Drawing.Point(12, 151);
            this.lblGravedad.Name = "lblGravedad";
            this.lblGravedad.Size = new System.Drawing.Size(96, 15);
            this.lblGravedad.TabIndex = 8;
            this.lblGravedad.Text = "Gravedad (m/s²):";
            // 
            // txtAngulo
            // 
            this.txtAngulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtAngulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAngulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtAngulo.Location = new System.Drawing.Point(170, 118);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(112, 23);
            this.txtAngulo.TabIndex = 7;
            this.txtAngulo.Text = "45";
            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAngulo.Location = new System.Drawing.Point(12, 121);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(65, 15);
            this.lblAngulo.TabIndex = 6;
            this.lblAngulo.Text = "Ángulo (°):";
            // 
            // txtV0
            // 
            this.txtV0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtV0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtV0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtV0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtV0.Location = new System.Drawing.Point(170, 88);
            this.txtV0.Name = "txtV0";
            this.txtV0.Size = new System.Drawing.Size(112, 23);
            this.txtV0.TabIndex = 5;
            this.txtV0.Text = "35";
            // 
            // lblV0
            // 
            this.lblV0.AutoSize = true;
            this.lblV0.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblV0.Location = new System.Drawing.Point(12, 91);
            this.lblV0.Name = "lblV0";
            this.lblV0.Size = new System.Drawing.Size(109, 15);
            this.lblV0.TabIndex = 4;
            this.lblV0.Text = "Velocidad V0 (m/s):";
            // 
            // txtY0
            // 
            this.txtY0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtY0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtY0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtY0.Location = new System.Drawing.Point(170, 58);
            this.txtY0.Name = "txtY0";
            this.txtY0.Size = new System.Drawing.Size(112, 23);
            this.txtY0.TabIndex = 3;
            this.txtY0.Text = "20";
            // 
            // lblY0
            // 
            this.lblY0.AutoSize = true;
            this.lblY0.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblY0.Location = new System.Drawing.Point(12, 61);
            this.lblY0.Name = "lblY0";
            this.lblY0.Size = new System.Drawing.Size(114, 15);
            this.lblY0.TabIndex = 2;
            this.lblY0.Text = "Altura Inicial Y0 (m):";
            // 
            // txtX0
            // 
            this.txtX0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtX0.Location = new System.Drawing.Point(170, 28);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(112, 23);
            this.txtX0.TabIndex = 1;
            this.txtX0.Text = "0";
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblX0.Location = new System.Drawing.Point(12, 31);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(93, 15);
            this.lblX0.TabIndex = 0;
            this.lblX0.Text = "Posición X0 (m):";
            // 
            // grpTiempoReal
            // 
            this.grpTiempoReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpTiempoReal.Controls.Add(this.lblInfoObjetivo);
            this.grpTiempoReal.Controls.Add(this.lblEstado);
            this.grpTiempoReal.Controls.Add(this.lblVang);
            this.grpTiempoReal.Controls.Add(this.lblVmag);
            this.grpTiempoReal.Controls.Add(this.lblVy);
            this.grpTiempoReal.Controls.Add(this.lblVx);
            this.grpTiempoReal.Controls.Add(this.lblPosicion);
            this.grpTiempoReal.Controls.Add(this.lblTiempo);
            this.grpTiempoReal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTiempoReal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.grpTiempoReal.Location = new System.Drawing.Point(12, 352);
            this.grpTiempoReal.Name = "grpTiempoReal";
            this.grpTiempoReal.Size = new System.Drawing.Size(295, 205);
            this.grpTiempoReal.TabIndex = 2;
            this.grpTiempoReal.TabStop = false;
            this.grpTiempoReal.Text = "Variables en Tiempo Real";
            // 
            // lblInfoObjetivo
            // 
            this.lblInfoObjetivo.AutoSize = true;
            this.lblInfoObjetivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoObjetivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblInfoObjetivo.Location = new System.Drawing.Point(12, 180);
            this.lblInfoObjetivo.Name = "lblInfoObjetivo";
            this.lblInfoObjetivo.Size = new System.Drawing.Size(122, 13);
            this.lblInfoObjetivo.TabIndex = 7;
            this.lblInfoObjetivo.Text = "Objetivo: [0 - 0], Y=0 m";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
            this.lblEstado.Location = new System.Drawing.Point(12, 160);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(102, 15);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado: En espera";
            // 
            // lblVang
            // 
            this.lblVang.AutoSize = true;
            this.lblVang.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.lblVang.Location = new System.Drawing.Point(12, 138);
            this.lblVang.Name = "lblVang";
            this.lblVang.Size = new System.Drawing.Size(91, 15);
            this.lblVang.TabIndex = 5;
            this.lblVang.Text = "Ángulo θ: 0.00 °";
            // 
            // lblVmag
            // 
            this.lblVmag.AutoSize = true;
            this.lblVmag.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVmag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(114)))), ((int)(((byte)(182)))));
            this.lblVmag.Location = new System.Drawing.Point(12, 115);
            this.lblVmag.Name = "lblVmag";
            this.lblVmag.Size = new System.Drawing.Size(133, 15);
            this.lblVmag.TabIndex = 4;
            this.lblVmag.Text = "Magnitud |V|: 0.00 m/s";
            // 
            // lblVy
            // 
            this.lblVy.AutoSize = true;
            this.lblVy.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblVy.Location = new System.Drawing.Point(12, 92);
            this.lblVy.Name = "lblVy";
            this.lblVy.Size = new System.Drawing.Size(125, 15);
            this.lblVy.TabIndex = 3;
            this.lblVy.Text = "Velocidad Vy: 0.00 m/s";
            // 
            // lblVx
            // 
            this.lblVx.AutoSize = true;
            this.lblVx.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblVx.Location = new System.Drawing.Point(12, 69);
            this.lblVx.Name = "lblVx";
            this.lblVx.Size = new System.Drawing.Size(124, 15);
            this.lblVx.TabIndex = 2;
            this.lblVx.Text = "Velocidad Vx: 0.00 m/s";
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.lblPosicion.Location = new System.Drawing.Point(12, 46);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(156, 15);
            this.lblPosicion.TabIndex = 1;
            this.lblPosicion.Text = "Posición (x, y): (0.00, 0.00) m";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(191)))), ((int)(((byte)(36)))));
            this.lblTiempo.Location = new System.Drawing.Point(12, 23);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(94, 15);
            this.lblTiempo.TabIndex = 0;
            this.lblTiempo.Text = "Tiempo: 0.000 s";
            // 
            // grpTeorico
            // 
            this.grpTeorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpTeorico.Controls.Add(this.lblTeoVelImpactoMag);
            this.grpTeorico.Controls.Add(this.lblTeoVelImpacto);
            this.grpTeorico.Controls.Add(this.lblTeoVelHmax);
            this.grpTeorico.Controls.Add(this.lblTeoAlcance);
            this.grpTeorico.Controls.Add(this.lblTeoTvuelo);
            this.grpTeorico.Controls.Add(this.lblTeoXhmax);
            this.grpTeorico.Controls.Add(this.lblTeoThmax);
            this.grpTeorico.Controls.Add(this.lblTeoHmax);
            this.grpTeorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTeorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.grpTeorico.Location = new System.Drawing.Point(12, 563);
            this.grpTeorico.Name = "grpTeorico";
            this.grpTeorico.Size = new System.Drawing.Size(295, 202);
            this.grpTeorico.TabIndex = 3;
            this.grpTeorico.TabStop = false;
            this.grpTeorico.Text = "Resultados Teóricos (Analíticos)";
            // 
            // lblTeoVelImpactoMag
            // 
            this.lblTeoVelImpactoMag.AutoSize = true;
            this.lblTeoVelImpactoMag.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoVelImpactoMag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoVelImpactoMag.Location = new System.Drawing.Point(12, 178);
            this.lblTeoVelImpactoMag.Name = "lblTeoVelImpactoMag";
            this.lblTeoVelImpactoMag.Size = new System.Drawing.Size(188, 13);
            this.lblTeoVelImpactoMag.TabIndex = 7;
            this.lblTeoVelImpactoMag.Text = "Magnitud y ángulo: |V|=0.0, θ=0.0°";
            // 
            // lblTeoVelImpacto
            // 
            this.lblTeoVelImpacto.AutoSize = true;
            this.lblTeoVelImpacto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoVelImpacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoVelImpacto.Location = new System.Drawing.Point(12, 158);
            this.lblTeoVelImpacto.Name = "lblTeoVelImpacto";
            this.lblTeoVelImpacto.Size = new System.Drawing.Size(172, 13);
            this.lblTeoVelImpacto.TabIndex = 6;
            this.lblTeoVelImpacto.Text = "Vel. Impacto: Vx=0.0, Vy=0.0 m/s";
            // 
            // lblTeoVelHmax
            // 
            this.lblTeoVelHmax.AutoSize = true;
            this.lblTeoVelHmax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoVelHmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoVelHmax.Location = new System.Drawing.Point(12, 136);
            this.lblTeoVelHmax.Name = "lblTeoVelHmax";
            this.lblTeoVelHmax.Size = new System.Drawing.Size(175, 13);
            this.lblTeoVelHmax.TabIndex = 5;
            this.lblTeoVelHmax.Text = "Vel. en Hmáx: Vx=0.0, Vy=0.0 m/s";
            // 
            // lblTeoAlcance
            // 
            this.lblTeoAlcance.AutoSize = true;
            this.lblTeoAlcance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoAlcance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoAlcance.Location = new System.Drawing.Point(12, 114);
            this.lblTeoAlcance.Name = "lblTeoAlcance";
            this.lblTeoAlcance.Size = new System.Drawing.Size(112, 13);
            this.lblTeoAlcance.TabIndex = 4;
            this.lblTeoAlcance.Text = "Alcance Total: 0.00 m";
            // 
            // lblTeoTvuelo
            // 
            this.lblTeoTvuelo.AutoSize = true;
            this.lblTeoTvuelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoTvuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoTvuelo.Location = new System.Drawing.Point(12, 92);
            this.lblTeoTvuelo.Name = "lblTeoTvuelo";
            this.lblTeoTvuelo.Size = new System.Drawing.Size(128, 13);
            this.lblTeoTvuelo.TabIndex = 3;
            this.lblTeoTvuelo.Text = "Tiempo de Vuelo: 0.00 s";
            // 
            // lblTeoXhmax
            // 
            this.lblTeoXhmax.AutoSize = true;
            this.lblTeoXhmax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoXhmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoXhmax.Location = new System.Drawing.Point(12, 69);
            this.lblTeoXhmax.Name = "lblTeoXhmax";
            this.lblTeoXhmax.Size = new System.Drawing.Size(129, 13);
            this.lblTeoXhmax.TabIndex = 2;
            this.lblTeoXhmax.Text = "Posición X Hmáx: 0.00 m";
            // 
            // lblTeoThmax
            // 
            this.lblTeoThmax.AutoSize = true;
            this.lblTeoThmax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoThmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoThmax.Location = new System.Drawing.Point(12, 46);
            this.lblTeoThmax.Name = "lblTeoThmax";
            this.lblTeoThmax.Size = new System.Drawing.Size(115, 13);
            this.lblTeoThmax.TabIndex = 1;
            this.lblTeoThmax.Text = "Instante Hmáx: 0.00 s";
            // 
            // lblTeoHmax
            // 
            this.lblTeoHmax.AutoSize = true;
            this.lblTeoHmax.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeoHmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTeoHmax.Location = new System.Drawing.Point(12, 23);
            this.lblTeoHmax.Name = "lblTeoHmax";
            this.lblTeoHmax.Size = new System.Drawing.Size(119, 13);
            this.lblTeoHmax.TabIndex = 0;
            this.lblTeoHmax.Text = "Altura Máxima: 0.00 m";
            // 
            // grpAnimacion
            // 
            this.grpAnimacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpAnimacion.Controls.Add(this.picAnimacion);
            this.grpAnimacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnimacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.grpAnimacion.Location = new System.Drawing.Point(317, 56);
            this.grpAnimacion.Name = "grpAnimacion";
            this.grpAnimacion.Size = new System.Drawing.Size(475, 425);
            this.grpAnimacion.TabIndex = 4;
            this.grpAnimacion.TabStop = false;
            this.grpAnimacion.Text = "Animación en Escena (Escala Métrica Real)";
            // 
            // picAnimacion
            // 
            this.picAnimacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.picAnimacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnimacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAnimacion.Location = new System.Drawing.Point(3, 19);
            this.picAnimacion.Name = "picAnimacion";
            this.picAnimacion.Size = new System.Drawing.Size(469, 403);
            this.picAnimacion.TabIndex = 0;
            this.picAnimacion.TabStop = false;
            this.picAnimacion.Paint += new System.Windows.Forms.PaintEventHandler(this.picAnimacion_Paint);
            // 
            // grpGraficas
            // 
            this.grpGraficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.grpGraficas.Controls.Add(this.chartGraficas);
            this.grpGraficas.Controls.Add(this.cmbTipoGrafica);
            this.grpGraficas.Controls.Add(this.lblSelGrafica);
            this.grpGraficas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGraficas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.grpGraficas.Location = new System.Drawing.Point(802, 56);
            this.grpGraficas.Name = "grpGraficas";
            this.grpGraficas.Size = new System.Drawing.Size(476, 425);
            this.grpGraficas.TabIndex = 5;
            this.grpGraficas.TabStop = false;
            this.grpGraficas.Text = "Representación Gráfica";
            // 
            // chartGraficas
            // 
            this.chartGraficas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea1.AxisX.LabelStyle.Format = "0.##";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            chartArea1.AxisY.LabelStyle.Format = "0.##";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            chartArea1.Name = "ChartArea1";
            this.chartGraficas.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            legend1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartGraficas.Legends.Add(legend1);
            this.chartGraficas.Location = new System.Drawing.Point(10, 55);
            this.chartGraficas.Name = "chartGraficas";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            series1.Legend = "Legend1";
            series1.Name = "Curva";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(63)))), ((int)(((byte)(94)))));
            series2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            series2.Legend = "Legend1";
            series2.MarkerSize = 8;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "PuntosClave";
            this.chartGraficas.Series.Add(series1);
            this.chartGraficas.Series.Add(series2);
            this.chartGraficas.Size = new System.Drawing.Size(456, 360);
            this.chartGraficas.TabIndex = 2;
            this.chartGraficas.Text = "chart1";
            // 
            // cmbTipoGrafica
            // 
            this.cmbTipoGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cmbTipoGrafica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGrafica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoGrafica.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoGrafica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cmbTipoGrafica.FormattingEnabled = true;
            this.cmbTipoGrafica.Items.AddRange(new object[] {
            "1. y vs. t (Posición vertical vs. tiempo)",
            "2. x vs. t (Posición horizontal vs. tiempo)",
            "3. y vs. x (Trayectoria del objeto)",
            "4. vx vs. t (Velocidad horizontal vs. tiempo)",
            "5. vy vs. t (Velocidad vertical vs. tiempo)",
            "6. |v| vs. t (Magnitud de velocidad vs. tiempo)",
            "7. θ vs. t (Ángulo del vector velocidad vs. tiempo)"});
            this.cmbTipoGrafica.Location = new System.Drawing.Point(125, 23);
            this.cmbTipoGrafica.Name = "cmbTipoGrafica";
            this.cmbTipoGrafica.Size = new System.Drawing.Size(341, 23);
            this.cmbTipoGrafica.TabIndex = 1;
            this.cmbTipoGrafica.SelectedIndexChanged += new System.EventHandler(this.cmbTipoGrafica_SelectedIndexChanged);
            // 
            // lblSelGrafica
            // 
            this.lblSelGrafica.AutoSize = true;
            this.lblSelGrafica.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelGrafica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblSelGrafica.Location = new System.Drawing.Point(10, 26);
            this.lblSelGrafica.Name = "lblSelGrafica";
            this.lblSelGrafica.Size = new System.Drawing.Size(110, 15);
            this.lblSelGrafica.TabIndex = 0;
            this.lblSelGrafica.Text = "Seleccionar Gráfica:";
            // 
            // tabResultados
            // 
            this.tabResultados.Controls.Add(this.tabComparacion);
            this.tabResultados.Controls.Add(this.tabColisiones);
            this.tabResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResultados.ItemSize = new System.Drawing.Size(260, 26);
            this.tabResultados.Location = new System.Drawing.Point(317, 488);
            this.tabResultados.Name = "tabResultados";
            this.tabResultados.Padding = new System.Drawing.Point(18, 5);
            this.tabResultados.SelectedIndex = 0;
            this.tabResultados.Size = new System.Drawing.Size(961, 277);
            this.tabResultados.TabIndex = 6;
            // 
            // tabComparacion
            // 
            this.tabComparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tabComparacion.Controls.Add(this.dgvComparacion);
            this.tabComparacion.Location = new System.Drawing.Point(4, 30);
            this.tabComparacion.Name = "tabComparacion";
            this.tabComparacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabComparacion.Size = new System.Drawing.Size(953, 243);
            this.tabComparacion.TabIndex = 0;
            this.tabComparacion.Text = "1. Comparación Modelo Teórico vs Simulación (Efecto Δt)";
            // 
            // dgvComparacion
            // 
            this.dgvComparacion.AllowUserToAddRows = false;
            this.dgvComparacion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(37)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvComparacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvComparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComparacion.ColumnHeadersHeight = 32;
            this.dgvComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMetrica,
            this.colTeorico,
            this.colSimulado,
            this.colDiferencia,
            this.colErrorRel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComparacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvComparacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComparacion.EnableHeadersVisualStyles = false;
            this.dgvComparacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.dgvComparacion.Location = new System.Drawing.Point(3, 3);
            this.dgvComparacion.Name = "dgvComparacion";
            this.dgvComparacion.ReadOnly = true;
            this.dgvComparacion.RowHeadersVisible = false;
            this.dgvComparacion.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComparacion.Size = new System.Drawing.Size(947, 237);
            this.dgvComparacion.TabIndex = 0;
            // 
            // colMetrica
            // 
            this.colMetrica.FillWeight = 160F;
            this.colMetrica.HeaderText = "Variable / Métrica";
            this.colMetrica.Name = "colMetrica";
            this.colMetrica.ReadOnly = true;
            // 
            // colTeorico
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTeorico.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTeorico.FillWeight = 90F;
            this.colTeorico.HeaderText = "Valor Teórico (Analítico)";
            this.colTeorico.Name = "colTeorico";
            this.colTeorico.ReadOnly = true;
            // 
            // colSimulado
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSimulado.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSimulado.FillWeight = 90F;
            this.colSimulado.HeaderText = "Valor Simulado (Numérico)";
            this.colSimulado.Name = "colSimulado";
            this.colSimulado.ReadOnly = true;
            // 
            // colDiferencia
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDiferencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.colDiferencia.FillWeight = 85F;
            this.colDiferencia.HeaderText = "Diferencia Absoluta";
            this.colDiferencia.Name = "colDiferencia";
            this.colDiferencia.ReadOnly = true;
            // 
            // colErrorRel
            // 
            this.colErrorRel.FillWeight = 75F;
            this.colErrorRel.HeaderText = "Error Relativo (%)";
            this.colErrorRel.Name = "colErrorRel";
            this.colErrorRel.ReadOnly = true;
            // 
            // tabColisiones
            // 
            this.tabColisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tabColisiones.Controls.Add(this.dgvColisiones);
            this.tabColisiones.Location = new System.Drawing.Point(4, 30);
            this.tabColisiones.Name = "tabColisiones";
            this.tabColisiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabColisiones.Size = new System.Drawing.Size(953, 243);
            this.tabColisiones.TabIndex = 1;
            this.tabColisiones.Text = "2. Registro Cronológico de Colisiones y Rebotes";
            // 
            // dgvColisiones
            // 
            this.dgvColisiones.AllowUserToAddRows = false;
            this.dgvColisiones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(78)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvColisiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvColisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColisiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvColisiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvColisiones.ColumnHeadersHeight = 32;
            this.dgvColisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvColisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colTipo,
            this.colTiempo,
            this.colPosX,
            this.colPosY,
            this.colVxAntes,
            this.colVyAntes,
            this.colVmagAntes,
            this.colVangAntes,
            this.colVxDespues,
            this.colVyDespues,
            this.colVmagDespues,
            this.colVangDespues});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColisiones.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvColisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColisiones.EnableHeadersVisualStyles = false;
            this.dgvColisiones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(78)))), ((int)(((byte)(74)))));
            this.dgvColisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvColisiones.Name = "dgvColisiones";
            this.dgvColisiones.ReadOnly = true;
            this.dgvColisiones.RowHeadersVisible = false;
            this.dgvColisiones.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvColisiones.Size = new System.Drawing.Size(947, 237);
            this.dgvColisiones.TabIndex = 0;
            // 
            // colNum
            // 
            this.colNum.FillWeight = 40F;
            this.colNum.HeaderText = "#";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.FillWeight = 110F;
            this.colTipo.HeaderText = "Tipo de Evento";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colTiempo
            // 
            this.colTiempo.FillWeight = 70F;
            this.colTiempo.HeaderText = "Tiempo (s)";
            this.colTiempo.Name = "colTiempo";
            this.colTiempo.ReadOnly = true;
            // 
            // colPosX
            // 
            this.colPosX.FillWeight = 70F;
            this.colPosX.HeaderText = "Pos X (m)";
            this.colPosX.Name = "colPosX";
            this.colPosX.ReadOnly = true;
            // 
            // colPosY
            // 
            this.colPosY.FillWeight = 70F;
            this.colPosY.HeaderText = "Pos Y (m)";
            this.colPosY.Name = "colPosY";
            this.colPosY.ReadOnly = true;
            // 
            // colVxAntes
            // 
            this.colVxAntes.FillWeight = 65F;
            this.colVxAntes.HeaderText = "Vx Antes";
            this.colVxAntes.Name = "colVxAntes";
            this.colVxAntes.ReadOnly = true;
            // 
            // colVyAntes
            // 
            this.colVyAntes.FillWeight = 65F;
            this.colVyAntes.HeaderText = "Vy Antes";
            this.colVyAntes.Name = "colVyAntes";
            this.colVyAntes.ReadOnly = true;
            // 
            // colVmagAntes
            // 
            this.colVmagAntes.FillWeight = 65F;
            this.colVmagAntes.HeaderText = "|V| Antes";
            this.colVmagAntes.Name = "colVmagAntes";
            this.colVmagAntes.ReadOnly = true;
            // 
            // colVangAntes
            // 
            this.colVangAntes.FillWeight = 65F;
            this.colVangAntes.HeaderText = "θ Antes";
            this.colVangAntes.Name = "colVangAntes";
            this.colVangAntes.ReadOnly = true;
            // 
            // colVxDespues
            // 
            this.colVxDespues.FillWeight = 65F;
            this.colVxDespues.HeaderText = "Vx Desp";
            this.colVxDespues.Name = "colVxDespues";
            this.colVxDespues.ReadOnly = true;
            // 
            // colVyDespues
            // 
            this.colVyDespues.FillWeight = 65F;
            this.colVyDespues.HeaderText = "Vy Desp";
            this.colVyDespues.Name = "colVyDespues";
            this.colVyDespues.ReadOnly = true;
            // 
            // colVmagDespues
            // 
            this.colVmagDespues.FillWeight = 65F;
            this.colVmagDespues.HeaderText = "|V| Desp";
            this.colVmagDespues.Name = "colVmagDespues";
            this.colVmagDespues.ReadOnly = true;
            // 
            // colVangDespues
            // 
            this.colVangDespues.FillWeight = 65F;
            this.colVangDespues.HeaderText = "θ Desp";
            this.colVangDespues.Name = "colVangDespues";
            this.colVangDespues.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1290, 775);
            this.Controls.Add(this.tabResultados);
            this.Controls.Add(this.grpGraficas);
            this.Controls.Add(this.grpAnimacion);
            this.Controls.Add(this.grpTeorico);
            this.Controls.Add(this.grpTiempoReal);
            this.Controls.Add(this.grpEntradas);
            this.Controls.Add(this.pnlHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación de Movimiento Parabólico - Taller 2 Primer Corte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpEntradas.ResumeLayout(false);
            this.grpEntradas.PerformLayout();
            this.grpTiempoReal.ResumeLayout(false);
            this.grpTiempoReal.PerformLayout();
            this.grpTeorico.ResumeLayout(false);
            this.grpTeorico.PerformLayout();
            this.grpAnimacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimacion)).EndInit();
            this.grpGraficas.ResumeLayout(false);
            this.grpGraficas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraficas)).EndInit();
            this.tabResultados.ResumeLayout(false);
            this.tabComparacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).EndInit();
            this.tabColisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColisiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Label lblSubtituloApp;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.GroupBox grpEntradas;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.Label lblY0;
        private System.Windows.Forms.TextBox txtY0;
        private System.Windows.Forms.Label lblV0;
        private System.Windows.Forms.TextBox txtV0;
        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Label lblGravedad;
        private System.Windows.Forms.TextBox txtGravedad;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnNuevoObjetivo;
        private System.Windows.Forms.GroupBox grpTiempoReal;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblVx;
        private System.Windows.Forms.Label lblVy;
        private System.Windows.Forms.Label lblVmag;
        private System.Windows.Forms.Label lblVang;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblInfoObjetivo;
        private System.Windows.Forms.GroupBox grpTeorico;
        private System.Windows.Forms.Label lblTeoHmax;
        private System.Windows.Forms.Label lblTeoThmax;
        private System.Windows.Forms.Label lblTeoXhmax;
        private System.Windows.Forms.Label lblTeoTvuelo;
        private System.Windows.Forms.Label lblTeoAlcance;
        private System.Windows.Forms.Label lblTeoVelHmax;
        private System.Windows.Forms.Label lblTeoVelImpacto;
        private System.Windows.Forms.Label lblTeoVelImpactoMag;
        private System.Windows.Forms.GroupBox grpAnimacion;
        private System.Windows.Forms.PictureBox picAnimacion;
        private System.Windows.Forms.GroupBox grpGraficas;
        private System.Windows.Forms.Label lblSelGrafica;
        private System.Windows.Forms.ComboBox cmbTipoGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraficas;
        private System.Windows.Forms.TabControl tabResultados;
        private System.Windows.Forms.TabPage tabComparacion;
        private System.Windows.Forms.DataGridView dgvComparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMetrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSimulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colErrorRel;
        private System.Windows.Forms.TabPage tabColisiones;
        private System.Windows.Forms.DataGridView dgvColisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVxAntes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVyAntes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVmagAntes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVangAntes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVxDespues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVyDespues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVmagDespues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVangDespues;
    }
}

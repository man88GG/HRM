namespace Capa_Vista.Vista_Nomina
{
    partial class frmNomina
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
            this.tbpNomina = new System.Windows.Forms.TabControl();
            this.Planilla = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbPeriPlanilla = new System.Windows.Forms.ComboBox();
            this.dgvPlanillaTotales = new System.Windows.Forms.DataGridView();
            this.clmTotalDed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPeriodoPLanilla = new System.Windows.Forms.Label();
            this.lblPlanillaPer = new System.Windows.Forms.Label();
            this.dgvPlanillaPer = new System.Windows.Forms.DataGridView();
            this.lblPlanillaDed = new System.Windows.Forms.Label();
            this.dgvPlanillaDed = new System.Windows.Forms.DataGridView();
            this.tbpDedPer = new System.Windows.Forms.TabPage();
            this.lblPercep = new System.Windows.Forms.Label();
            this.dgvPercep = new System.Windows.Forms.DataGridView();
            this.lblDeduc = new System.Windows.Forms.Label();
            this.dgvDeduc = new System.Windows.Forms.DataGridView();
            this.tbpHorasDias = new System.Windows.Forms.TabPage();
            this.btnHorasDiasActualizar = new System.Windows.Forms.Button();
            this.cmbHorasDias = new System.Windows.Forms.ComboBox();
            this.lblHorasDiasPeriodo = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.dgvDias = new System.Windows.Forms.DataGridView();
            this.lblHoras = new System.Windows.Forms.Label();
            this.dgvHoras = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGestPlanCrear = new System.Windows.Forms.Button();
            this.dtpGestPlanFin = new System.Windows.Forms.DateTimePicker();
            this.dtpGestPlanIni = new System.Windows.Forms.DateTimePicker();
            this.txtGestPlanNom = new System.Windows.Forms.TextBox();
            this.lblGestPlanFin = new System.Windows.Forms.Label();
            this.lblGestPlanInicio = new System.Windows.Forms.Label();
            this.lblGestPlanNom = new System.Windows.Forms.Label();
            this.tbpNomina.SuspendLayout();
            this.Planilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).BeginInit();
            this.tbpDedPer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).BeginInit();
            this.tbpHorasDias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpNomina
            // 
            this.tbpNomina.Controls.Add(this.Planilla);
            this.tbpNomina.Controls.Add(this.tbpDedPer);
            this.tbpNomina.Controls.Add(this.tbpHorasDias);
            this.tbpNomina.Controls.Add(this.tabPage1);
            this.tbpNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpNomina.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpNomina.Location = new System.Drawing.Point(0, 0);
            this.tbpNomina.Margin = new System.Windows.Forms.Padding(4);
            this.tbpNomina.Name = "tbpNomina";
            this.tbpNomina.SelectedIndex = 0;
            this.tbpNomina.Size = new System.Drawing.Size(1178, 684);
            this.tbpNomina.TabIndex = 0;
            // 
            // Planilla
            // 
            this.Planilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.Planilla.Controls.Add(this.btnActualizar);
            this.Planilla.Controls.Add(this.cmbPeriPlanilla);
            this.Planilla.Controls.Add(this.dgvPlanillaTotales);
            this.Planilla.Controls.Add(this.lblPeriodoPLanilla);
            this.Planilla.Controls.Add(this.lblPlanillaPer);
            this.Planilla.Controls.Add(this.dgvPlanillaPer);
            this.Planilla.Controls.Add(this.lblPlanillaDed);
            this.Planilla.Controls.Add(this.dgvPlanillaDed);
            this.Planilla.Location = new System.Drawing.Point(4, 26);
            this.Planilla.Margin = new System.Windows.Forms.Padding(4);
            this.Planilla.Name = "Planilla";
            this.Planilla.Padding = new System.Windows.Forms.Padding(4);
            this.Planilla.Size = new System.Drawing.Size(1170, 654);
            this.Planilla.TabIndex = 2;
            this.Planilla.Text = "Planilla";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1060, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 26);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbPeriPlanilla
            // 
            this.cmbPeriPlanilla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPeriPlanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriPlanilla.FormattingEnabled = true;
            this.cmbPeriPlanilla.Location = new System.Drawing.Point(550, 9);
            this.cmbPeriPlanilla.Name = "cmbPeriPlanilla";
            this.cmbPeriPlanilla.Size = new System.Drawing.Size(248, 25);
            this.cmbPeriPlanilla.TabIndex = 19;
            // 
            // dgvPlanillaTotales
            // 
            this.dgvPlanillaTotales.AllowUserToAddRows = false;
            this.dgvPlanillaTotales.AllowUserToDeleteRows = false;
            this.dgvPlanillaTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaTotales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTotalDed,
            this.clmTotalPer,
            this.clmTotal});
            this.dgvPlanillaTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlanillaTotales.Location = new System.Drawing.Point(4, 500);
            this.dgvPlanillaTotales.Name = "dgvPlanillaTotales";
            this.dgvPlanillaTotales.ReadOnly = true;
            this.dgvPlanillaTotales.RowHeadersWidth = 51;
            this.dgvPlanillaTotales.RowTemplate.Height = 24;
            this.dgvPlanillaTotales.Size = new System.Drawing.Size(1162, 150);
            this.dgvPlanillaTotales.TabIndex = 18;
            // 
            // clmTotalDed
            // 
            this.clmTotalDed.HeaderText = "Total de Deducciones";
            this.clmTotalDed.MinimumWidth = 6;
            this.clmTotalDed.Name = "clmTotalDed";
            this.clmTotalDed.ReadOnly = true;
            // 
            // clmTotalPer
            // 
            this.clmTotalPer.HeaderText = "Total de Percepciones";
            this.clmTotalPer.MinimumWidth = 6;
            this.clmTotalPer.Name = "clmTotalPer";
            this.clmTotalPer.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.MinimumWidth = 6;
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // lblPeriodoPLanilla
            // 
            this.lblPeriodoPLanilla.AutoSize = true;
            this.lblPeriodoPLanilla.Location = new System.Drawing.Point(369, 12);
            this.lblPeriodoPLanilla.Name = "lblPeriodoPLanilla";
            this.lblPeriodoPLanilla.Size = new System.Drawing.Size(134, 17);
            this.lblPeriodoPLanilla.TabIndex = 16;
            this.lblPeriodoPLanilla.Text = "Periodo de Planilla:";
            // 
            // lblPlanillaPer
            // 
            this.lblPlanillaPer.AutoSize = true;
            this.lblPlanillaPer.Location = new System.Drawing.Point(833, 37);
            this.lblPlanillaPer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlanillaPer.Name = "lblPlanillaPer";
            this.lblPlanillaPer.Size = new System.Drawing.Size(95, 17);
            this.lblPlanillaPer.TabIndex = 15;
            this.lblPlanillaPer.Text = "Percepciones";
            // 
            // dgvPlanillaPer
            // 
            this.dgvPlanillaPer.AllowUserToAddRows = false;
            this.dgvPlanillaPer.AllowUserToDeleteRows = false;
            this.dgvPlanillaPer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaPer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaPer.Location = new System.Drawing.Point(588, 62);
            this.dgvPlanillaPer.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaPer.Name = "dgvPlanillaPer";
            this.dgvPlanillaPer.ReadOnly = true;
            this.dgvPlanillaPer.RowHeadersWidth = 51;
            this.dgvPlanillaPer.RowTemplate.Height = 24;
            this.dgvPlanillaPer.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaPer.TabIndex = 12;
            // 
            // lblPlanillaDed
            // 
            this.lblPlanillaDed.AutoSize = true;
            this.lblPlanillaDed.Location = new System.Drawing.Point(221, 22);
            this.lblPlanillaDed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPlanillaDed.Name = "lblPlanillaDed";
            this.lblPlanillaDed.Size = new System.Drawing.Size(91, 17);
            this.lblPlanillaDed.TabIndex = 14;
            this.lblPlanillaDed.Text = "Deducciones";
            // 
            // dgvPlanillaDed
            // 
            this.dgvPlanillaDed.AllowUserToAddRows = false;
            this.dgvPlanillaDed.AllowUserToDeleteRows = false;
            this.dgvPlanillaDed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanillaDed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanillaDed.Location = new System.Drawing.Point(5, 62);
            this.dgvPlanillaDed.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPlanillaDed.Name = "dgvPlanillaDed";
            this.dgvPlanillaDed.ReadOnly = true;
            this.dgvPlanillaDed.RowHeadersWidth = 51;
            this.dgvPlanillaDed.RowTemplate.Height = 24;
            this.dgvPlanillaDed.Size = new System.Drawing.Size(577, 427);
            this.dgvPlanillaDed.TabIndex = 13;
            // 
            // tbpDedPer
            // 
            this.tbpDedPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDedPer.Controls.Add(this.lblPercep);
            this.tbpDedPer.Controls.Add(this.dgvPercep);
            this.tbpDedPer.Controls.Add(this.lblDeduc);
            this.tbpDedPer.Controls.Add(this.dgvDeduc);
            this.tbpDedPer.Location = new System.Drawing.Point(4, 26);
            this.tbpDedPer.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Name = "tbpDedPer";
            this.tbpDedPer.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDedPer.Size = new System.Drawing.Size(1170, 654);
            this.tbpDedPer.TabIndex = 4;
            this.tbpDedPer.Text = "Deducciones/Percepciones";
            // 
            // lblPercep
            // 
            this.lblPercep.AutoSize = true;
            this.lblPercep.Location = new System.Drawing.Point(855, 15);
            this.lblPercep.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPercep.Name = "lblPercep";
            this.lblPercep.Size = new System.Drawing.Size(95, 17);
            this.lblPercep.TabIndex = 11;
            this.lblPercep.Text = "Percepciones";
            // 
            // dgvPercep
            // 
            this.dgvPercep.AllowUserToAddRows = false;
            this.dgvPercep.AllowUserToDeleteRows = false;
            this.dgvPercep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPercep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercep.Location = new System.Drawing.Point(597, 40);
            this.dgvPercep.Margin = new System.Windows.Forms.Padding(5);
            this.dgvPercep.Name = "dgvPercep";
            this.dgvPercep.ReadOnly = true;
            this.dgvPercep.RowHeadersWidth = 51;
            this.dgvPercep.RowTemplate.Height = 24;
            this.dgvPercep.Size = new System.Drawing.Size(573, 615);
            this.dgvPercep.TabIndex = 8;
            // 
            // lblDeduc
            // 
            this.lblDeduc.AutoSize = true;
            this.lblDeduc.Location = new System.Drawing.Point(150, 15);
            this.lblDeduc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeduc.Name = "lblDeduc";
            this.lblDeduc.Size = new System.Drawing.Size(91, 17);
            this.lblDeduc.TabIndex = 10;
            this.lblDeduc.Text = "Deducciones";
            // 
            // dgvDeduc
            // 
            this.dgvDeduc.AllowUserToAddRows = false;
            this.dgvDeduc.AllowUserToDeleteRows = false;
            this.dgvDeduc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeduc.Location = new System.Drawing.Point(-4, 40);
            this.dgvDeduc.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDeduc.Name = "dgvDeduc";
            this.dgvDeduc.ReadOnly = true;
            this.dgvDeduc.RowHeadersWidth = 51;
            this.dgvDeduc.RowTemplate.Height = 24;
            this.dgvDeduc.Size = new System.Drawing.Size(574, 615);
            this.dgvDeduc.TabIndex = 9;
            // 
            // tbpHorasDias
            // 
            this.tbpHorasDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpHorasDias.Controls.Add(this.btnHorasDiasActualizar);
            this.tbpHorasDias.Controls.Add(this.cmbHorasDias);
            this.tbpHorasDias.Controls.Add(this.lblHorasDiasPeriodo);
            this.tbpHorasDias.Controls.Add(this.lblDias);
            this.tbpHorasDias.Controls.Add(this.dgvDias);
            this.tbpHorasDias.Controls.Add(this.lblHoras);
            this.tbpHorasDias.Controls.Add(this.dgvHoras);
            this.tbpHorasDias.Location = new System.Drawing.Point(4, 26);
            this.tbpHorasDias.Margin = new System.Windows.Forms.Padding(4);
            this.tbpHorasDias.Name = "tbpHorasDias";
            this.tbpHorasDias.Padding = new System.Windows.Forms.Padding(4);
            this.tbpHorasDias.Size = new System.Drawing.Size(1170, 654);
            this.tbpHorasDias.TabIndex = 5;
            this.tbpHorasDias.Text = "Horas/Dias";
            // 
            // btnHorasDiasActualizar
            // 
            this.btnHorasDiasActualizar.Location = new System.Drawing.Point(1060, 11);
            this.btnHorasDiasActualizar.Name = "btnHorasDiasActualizar";
            this.btnHorasDiasActualizar.Size = new System.Drawing.Size(102, 26);
            this.btnHorasDiasActualizar.TabIndex = 20;
            this.btnHorasDiasActualizar.Text = "Actualizar";
            this.btnHorasDiasActualizar.UseVisualStyleBackColor = true;
            this.btnHorasDiasActualizar.Click += new System.EventHandler(this.btnHorasDiasActualizar_Click);
            // 
            // cmbHorasDias
            // 
            this.cmbHorasDias.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorasDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorasDias.FormattingEnabled = true;
            this.cmbHorasDias.Location = new System.Drawing.Point(550, 9);
            this.cmbHorasDias.Name = "cmbHorasDias";
            this.cmbHorasDias.Size = new System.Drawing.Size(248, 25);
            this.cmbHorasDias.TabIndex = 19;
            // 
            // lblHorasDiasPeriodo
            // 
            this.lblHorasDiasPeriodo.AutoSize = true;
            this.lblHorasDiasPeriodo.Location = new System.Drawing.Point(369, 12);
            this.lblHorasDiasPeriodo.Name = "lblHorasDiasPeriodo";
            this.lblHorasDiasPeriodo.Size = new System.Drawing.Size(134, 17);
            this.lblHorasDiasPeriodo.TabIndex = 16;
            this.lblHorasDiasPeriodo.Text = "Periodo de Planilla:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(869, 37);
            this.lblDias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(91, 17);
            this.lblDias.TabIndex = 15;
            this.lblDias.Text = "Total de Dias";
            // 
            // dgvDias
            // 
            this.dgvDias.AllowUserToAddRows = false;
            this.dgvDias.AllowUserToDeleteRows = false;
            this.dgvDias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDias.Location = new System.Drawing.Point(588, 62);
            this.dgvDias.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDias.Name = "dgvDias";
            this.dgvDias.ReadOnly = true;
            this.dgvDias.RowHeadersWidth = 51;
            this.dgvDias.RowTemplate.Height = 24;
            this.dgvDias.Size = new System.Drawing.Size(577, 579);
            this.dgvDias.TabIndex = 12;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(205, 37);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(101, 17);
            this.lblHoras.TabIndex = 14;
            this.lblHoras.Text = "Total de Horas";
            // 
            // dgvHoras
            // 
            this.dgvHoras.AllowUserToAddRows = false;
            this.dgvHoras.AllowUserToDeleteRows = false;
            this.dgvHoras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoras.Location = new System.Drawing.Point(5, 62);
            this.dgvHoras.Margin = new System.Windows.Forms.Padding(5);
            this.dgvHoras.Name = "dgvHoras";
            this.dgvHoras.ReadOnly = true;
            this.dgvHoras.RowHeadersWidth = 51;
            this.dgvHoras.RowTemplate.Height = 24;
            this.dgvHoras.Size = new System.Drawing.Size(577, 579);
            this.dgvHoras.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tabPage1.Controls.Add(this.btnGestPlanCrear);
            this.tabPage1.Controls.Add(this.dtpGestPlanFin);
            this.tabPage1.Controls.Add(this.dtpGestPlanIni);
            this.tabPage1.Controls.Add(this.txtGestPlanNom);
            this.tabPage1.Controls.Add(this.lblGestPlanFin);
            this.tabPage1.Controls.Add(this.lblGestPlanInicio);
            this.tabPage1.Controls.Add(this.lblGestPlanNom);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1170, 654);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Gestion Planilla";
            // 
            // btnGestPlanCrear
            // 
            this.btnGestPlanCrear.Location = new System.Drawing.Point(497, 205);
            this.btnGestPlanCrear.Name = "btnGestPlanCrear";
            this.btnGestPlanCrear.Size = new System.Drawing.Size(144, 26);
            this.btnGestPlanCrear.TabIndex = 6;
            this.btnGestPlanCrear.Text = "Crear Planilla";
            this.btnGestPlanCrear.UseVisualStyleBackColor = true;
            this.btnGestPlanCrear.Click += new System.EventHandler(this.btnGestPlanCrear_Click);
            // 
            // dtpGestPlanFin
            // 
            this.dtpGestPlanFin.Location = new System.Drawing.Point(311, 147);
            this.dtpGestPlanFin.Name = "dtpGestPlanFin";
            this.dtpGestPlanFin.Size = new System.Drawing.Size(330, 23);
            this.dtpGestPlanFin.TabIndex = 5;
            // 
            // dtpGestPlanIni
            // 
            this.dtpGestPlanIni.Location = new System.Drawing.Point(311, 86);
            this.dtpGestPlanIni.Name = "dtpGestPlanIni";
            this.dtpGestPlanIni.Size = new System.Drawing.Size(330, 23);
            this.dtpGestPlanIni.TabIndex = 4;
            this.dtpGestPlanIni.ValueChanged += new System.EventHandler(this.dtpGestPlanIni_ValueChanged);
            // 
            // txtGestPlanNom
            // 
            this.txtGestPlanNom.Location = new System.Drawing.Point(311, 28);
            this.txtGestPlanNom.Name = "txtGestPlanNom";
            this.txtGestPlanNom.Size = new System.Drawing.Size(330, 23);
            this.txtGestPlanNom.TabIndex = 3;
            // 
            // lblGestPlanFin
            // 
            this.lblGestPlanFin.AutoSize = true;
            this.lblGestPlanFin.Location = new System.Drawing.Point(32, 154);
            this.lblGestPlanFin.Name = "lblGestPlanFin";
            this.lblGestPlanFin.Size = new System.Drawing.Size(226, 17);
            this.lblGestPlanFin.TabIndex = 2;
            this.lblGestPlanFin.Text = "Fecha de Finalización del Periodo";
            // 
            // lblGestPlanInicio
            // 
            this.lblGestPlanInicio.AutoSize = true;
            this.lblGestPlanInicio.Location = new System.Drawing.Point(32, 93);
            this.lblGestPlanInicio.Name = "lblGestPlanInicio";
            this.lblGestPlanInicio.Size = new System.Drawing.Size(186, 17);
            this.lblGestPlanInicio.TabIndex = 1;
            this.lblGestPlanInicio.Text = "Fecha de Inicio del Periodo";
            // 
            // lblGestPlanNom
            // 
            this.lblGestPlanNom.AutoSize = true;
            this.lblGestPlanNom.Location = new System.Drawing.Point(32, 35);
            this.lblGestPlanNom.Name = "lblGestPlanNom";
            this.lblGestPlanNom.Size = new System.Drawing.Size(132, 17);
            this.lblGestPlanNom.TabIndex = 0;
            this.lblGestPlanNom.Text = "Nombre de Planilla";
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1178, 684);
            this.Controls.Add(this.tbpNomina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNomina";
            this.Text = "311 - Datos Nómina General";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            this.tbpNomina.ResumeLayout(false);
            this.Planilla.ResumeLayout(false);
            this.Planilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaTotales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanillaDed)).EndInit();
            this.tbpDedPer.ResumeLayout(false);
            this.tbpDedPer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeduc)).EndInit();
            this.tbpHorasDias.ResumeLayout(false);
            this.tbpHorasDias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoras)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpNomina;
        private System.Windows.Forms.TabPage Planilla;
        private System.Windows.Forms.TabPage tbpDedPer;
        private System.Windows.Forms.Label lblPercep;
        private System.Windows.Forms.DataGridView dgvPercep;
        private System.Windows.Forms.Label lblDeduc;
        private System.Windows.Forms.DataGridView dgvDeduc;
        private System.Windows.Forms.Label lblPlanillaPer;
        private System.Windows.Forms.DataGridView dgvPlanillaPer;
        private System.Windows.Forms.Label lblPlanillaDed;
        private System.Windows.Forms.DataGridView dgvPlanillaDed;
        private System.Windows.Forms.Label lblPeriodoPLanilla;
        private System.Windows.Forms.ComboBox cmbPeriPlanilla;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TabPage tbpHorasDias;
        private System.Windows.Forms.Button btnHorasDiasActualizar;
        private System.Windows.Forms.ComboBox cmbHorasDias;
        private System.Windows.Forms.Label lblHorasDiasPeriodo;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DataGridView dgvDias;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.DataGridView dgvHoras;
        private System.Windows.Forms.DataGridView dgvPlanillaTotales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnGestPlanCrear;
        private System.Windows.Forms.DateTimePicker dtpGestPlanFin;
        private System.Windows.Forms.DateTimePicker dtpGestPlanIni;
        private System.Windows.Forms.TextBox txtGestPlanNom;
        private System.Windows.Forms.Label lblGestPlanFin;
        private System.Windows.Forms.Label lblGestPlanInicio;
        private System.Windows.Forms.Label lblGestPlanNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalDed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
    }
}
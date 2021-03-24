namespace Capa_Vista.Vista_Nomina
{
    partial class frmEmpleadoNomina
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
            this.tbcEmpleadoNomina = new System.Windows.Forms.TabControl();
            this.tbpIngresarEmpleDedPer = new System.Windows.Forms.TabPage();
            this.txtIngresoFechFin = new System.Windows.Forms.TextBox();
            this.btnIngresarBuscar = new System.Windows.Forms.Button();
            this.lblTipoCobro = new System.Windows.Forms.Label();
            this.btnIngresoEmpleadoDedPer = new System.Windows.Forms.Button();
            this.gbxIngresoTipoCob = new System.Windows.Forms.GroupBox();
            this.rbtnIngresoDed = new System.Windows.Forms.RadioButton();
            this.rbtnIngresoPerc = new System.Windows.Forms.RadioButton();
            this.cmbIngresoFecPLan = new System.Windows.Forms.ComboBox();
            this.cmbIngresoDedPer = new System.Windows.Forms.ComboBox();
            this.txtIngresoNomEmp = new System.Windows.Forms.TextBox();
            this.txtIngresoIdEmp = new System.Windows.Forms.TextBox();
            this.lblFecPlanIngreso = new System.Windows.Forms.Label();
            this.lblPerceDeducIngreso = new System.Windows.Forms.Label();
            this.lblNomEmpleIngreso = new System.Windows.Forms.Label();
            this.lblIdEmpIngreso = new System.Windows.Forms.Label();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.txtBuscarFechaFin = new System.Windows.Forms.TextBox();
            this.lblTotalPer = new System.Windows.Forms.Label();
            this.lblTotalDed = new System.Windows.Forms.Label();
            this.txtTotalDed = new System.Windows.Forms.TextBox();
            this.txtTotalPer = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbBuscarPeriodoPlanilla = new System.Windows.Forms.ComboBox();
            this.dgvPerEpm = new System.Windows.Forms.DataGridView();
            this.dgvDedEmp = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarFecPlanilla = new System.Windows.Forms.Label();
            this.txtBuscarPuestoEmp = new System.Windows.Forms.TextBox();
            this.lblBuscarPuestoEmp = new System.Windows.Forms.Label();
            this.txtBuscarNomEmp = new System.Windows.Forms.TextBox();
            this.lblBuscarNomEmp = new System.Windows.Forms.Label();
            this.txtBuscarIdEmp = new System.Windows.Forms.TextBox();
            this.lbBuscarIDEmp = new System.Windows.Forms.Label();
            this.tbpEliminarEmpleDedPer = new System.Windows.Forms.TabPage();
            this.txtEliminarFechFin = new System.Windows.Forms.TextBox();
            this.lblTipoCobroEliminar = new System.Windows.Forms.Label();
            this.btnEliminarBuscar = new System.Windows.Forms.Button();
            this.btnEliminarEmpleadoDedPer = new System.Windows.Forms.Button();
            this.gbxEliminarTipoCob = new System.Windows.Forms.GroupBox();
            this.rbtnEliminarDed = new System.Windows.Forms.RadioButton();
            this.rbtnEliminarPer = new System.Windows.Forms.RadioButton();
            this.cmbEliminarFechPlan = new System.Windows.Forms.ComboBox();
            this.cmbEliminarDedPer = new System.Windows.Forms.ComboBox();
            this.txtEliminarNomEmp = new System.Windows.Forms.TextBox();
            this.txtEliminarIdEmp = new System.Windows.Forms.TextBox();
            this.lblEliminarFechPlan = new System.Windows.Forms.Label();
            this.lblEliminarDedPer = new System.Windows.Forms.Label();
            this.lblEliminarNomEmp = new System.Windows.Forms.Label();
            this.lblEliminarIdEmp = new System.Windows.Forms.Label();
            this.tbcEmpleadoNomina.SuspendLayout();
            this.tbpIngresarEmpleDedPer.SuspendLayout();
            this.gbxIngresoTipoCob.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerEpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDedEmp)).BeginInit();
            this.tbpEliminarEmpleDedPer.SuspendLayout();
            this.gbxEliminarTipoCob.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEmpleadoNomina
            // 
            this.tbcEmpleadoNomina.Controls.Add(this.tbpIngresarEmpleDedPer);
            this.tbcEmpleadoNomina.Controls.Add(this.tbpBuscar);
            this.tbcEmpleadoNomina.Controls.Add(this.tbpEliminarEmpleDedPer);
            this.tbcEmpleadoNomina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEmpleadoNomina.Location = new System.Drawing.Point(0, 0);
            this.tbcEmpleadoNomina.Name = "tbcEmpleadoNomina";
            this.tbcEmpleadoNomina.SelectedIndex = 0;
            this.tbcEmpleadoNomina.Size = new System.Drawing.Size(832, 532);
            this.tbcEmpleadoNomina.TabIndex = 0;
            // 
            // tbpIngresarEmpleDedPer
            // 
            this.tbpIngresarEmpleDedPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpIngresarEmpleDedPer.Controls.Add(this.txtIngresoFechFin);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.btnIngresarBuscar);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblTipoCobro);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.btnIngresoEmpleadoDedPer);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.gbxIngresoTipoCob);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.cmbIngresoFecPLan);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.cmbIngresoDedPer);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.txtIngresoNomEmp);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.txtIngresoIdEmp);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblFecPlanIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblPerceDeducIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblNomEmpleIngreso);
            this.tbpIngresarEmpleDedPer.Controls.Add(this.lblIdEmpIngreso);
            this.tbpIngresarEmpleDedPer.Location = new System.Drawing.Point(4, 26);
            this.tbpIngresarEmpleDedPer.Name = "tbpIngresarEmpleDedPer";
            this.tbpIngresarEmpleDedPer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIngresarEmpleDedPer.Size = new System.Drawing.Size(824, 502);
            this.tbpIngresarEmpleDedPer.TabIndex = 0;
            this.tbpIngresarEmpleDedPer.Text = "Ingresar";
            // 
            // txtIngresoFechFin
            // 
            this.txtIngresoFechFin.Enabled = false;
            this.txtIngresoFechFin.Location = new System.Drawing.Point(380, 166);
            this.txtIngresoFechFin.Name = "txtIngresoFechFin";
            this.txtIngresoFechFin.Size = new System.Drawing.Size(133, 23);
            this.txtIngresoFechFin.TabIndex = 22;
            // 
            // btnIngresarBuscar
            // 
            this.btnIngresarBuscar.Location = new System.Drawing.Point(559, 230);
            this.btnIngresarBuscar.Name = "btnIngresarBuscar";
            this.btnIngresarBuscar.Size = new System.Drawing.Size(158, 29);
            this.btnIngresarBuscar.TabIndex = 21;
            this.btnIngresarBuscar.Text = "Buscar Empleado";
            this.btnIngresarBuscar.UseVisualStyleBackColor = true;
            this.btnIngresarBuscar.Click += new System.EventHandler(this.btnIngresarBuscar_Click);
            // 
            // lblTipoCobro
            // 
            this.lblTipoCobro.AutoSize = true;
            this.lblTipoCobro.Location = new System.Drawing.Point(7, 98);
            this.lblTipoCobro.Name = "lblTipoCobro";
            this.lblTipoCobro.Size = new System.Drawing.Size(108, 17);
            this.lblTipoCobro.TabIndex = 20;
            this.lblTipoCobro.Text = "Tipo de Cobro:";
            // 
            // btnIngresoEmpleadoDedPer
            // 
            this.btnIngresoEmpleadoDedPer.Location = new System.Drawing.Point(727, 230);
            this.btnIngresoEmpleadoDedPer.Name = "btnIngresoEmpleadoDedPer";
            this.btnIngresoEmpleadoDedPer.Size = new System.Drawing.Size(91, 29);
            this.btnIngresoEmpleadoDedPer.TabIndex = 17;
            this.btnIngresoEmpleadoDedPer.Text = "Ingresar";
            this.btnIngresoEmpleadoDedPer.UseVisualStyleBackColor = true;
            this.btnIngresoEmpleadoDedPer.Click += new System.EventHandler(this.btnIngresoEmpleadoDedPer_Click);
            // 
            // gbxIngresoTipoCob
            // 
            this.gbxIngresoTipoCob.Controls.Add(this.rbtnIngresoDed);
            this.gbxIngresoTipoCob.Controls.Add(this.rbtnIngresoPerc);
            this.gbxIngresoTipoCob.Location = new System.Drawing.Point(234, 81);
            this.gbxIngresoTipoCob.Name = "gbxIngresoTipoCob";
            this.gbxIngresoTipoCob.Size = new System.Drawing.Size(279, 43);
            this.gbxIngresoTipoCob.TabIndex = 16;
            this.gbxIngresoTipoCob.TabStop = false;
            // 
            // rbtnIngresoDed
            // 
            this.rbtnIngresoDed.AutoSize = true;
            this.rbtnIngresoDed.Location = new System.Drawing.Point(6, 15);
            this.rbtnIngresoDed.Name = "rbtnIngresoDed";
            this.rbtnIngresoDed.Size = new System.Drawing.Size(95, 21);
            this.rbtnIngresoDed.TabIndex = 0;
            this.rbtnIngresoDed.TabStop = true;
            this.rbtnIngresoDed.Text = "Deducción";
            this.rbtnIngresoDed.UseVisualStyleBackColor = true;
            this.rbtnIngresoDed.CheckedChanged += new System.EventHandler(this.rbtnIngresoDed_CheckedChanged);
            // 
            // rbtnIngresoPerc
            // 
            this.rbtnIngresoPerc.AutoSize = true;
            this.rbtnIngresoPerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.rbtnIngresoPerc.Location = new System.Drawing.Point(153, 15);
            this.rbtnIngresoPerc.Name = "rbtnIngresoPerc";
            this.rbtnIngresoPerc.Size = new System.Drawing.Size(99, 21);
            this.rbtnIngresoPerc.TabIndex = 1;
            this.rbtnIngresoPerc.TabStop = true;
            this.rbtnIngresoPerc.Text = "Percepción";
            this.rbtnIngresoPerc.UseVisualStyleBackColor = false;
            this.rbtnIngresoPerc.CheckedChanged += new System.EventHandler(this.rbtnIngresoPerc_CheckedChanged);
            // 
            // cmbIngresoFecPLan
            // 
            this.cmbIngresoFecPLan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbIngresoFecPLan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngresoFecPLan.FormattingEnabled = true;
            this.cmbIngresoFecPLan.Location = new System.Drawing.Point(232, 165);
            this.cmbIngresoFecPLan.Name = "cmbIngresoFecPLan";
            this.cmbIngresoFecPLan.Size = new System.Drawing.Size(141, 25);
            this.cmbIngresoFecPLan.TabIndex = 15;
            this.cmbIngresoFecPLan.SelectedIndexChanged += new System.EventHandler(this.cmbIngresoFecPLan_SelectedIndexChanged);
            // 
            // cmbIngresoDedPer
            // 
            this.cmbIngresoDedPer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbIngresoDedPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIngresoDedPer.FormattingEnabled = true;
            this.cmbIngresoDedPer.Location = new System.Drawing.Point(232, 130);
            this.cmbIngresoDedPer.Name = "cmbIngresoDedPer";
            this.cmbIngresoDedPer.Size = new System.Drawing.Size(280, 25);
            this.cmbIngresoDedPer.TabIndex = 14;
            // 
            // txtIngresoNomEmp
            // 
            this.txtIngresoNomEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIngresoNomEmp.Enabled = false;
            this.txtIngresoNomEmp.Location = new System.Drawing.Point(234, 54);
            this.txtIngresoNomEmp.Name = "txtIngresoNomEmp";
            this.txtIngresoNomEmp.Size = new System.Drawing.Size(278, 23);
            this.txtIngresoNomEmp.TabIndex = 13;
            // 
            // txtIngresoIdEmp
            // 
            this.txtIngresoIdEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIngresoIdEmp.Location = new System.Drawing.Point(233, 17);
            this.txtIngresoIdEmp.Name = "txtIngresoIdEmp";
            this.txtIngresoIdEmp.Size = new System.Drawing.Size(280, 23);
            this.txtIngresoIdEmp.TabIndex = 12;
            // 
            // lblFecPlanIngreso
            // 
            this.lblFecPlanIngreso.AutoSize = true;
            this.lblFecPlanIngreso.Location = new System.Drawing.Point(7, 173);
            this.lblFecPlanIngreso.Name = "lblFecPlanIngreso";
            this.lblFecPlanIngreso.Size = new System.Drawing.Size(96, 17);
            this.lblFecPlanIngreso.TabIndex = 11;
            this.lblFecPlanIngreso.Text = "Fecha Planilla";
            // 
            // lblPerceDeducIngreso
            // 
            this.lblPerceDeducIngreso.AutoSize = true;
            this.lblPerceDeducIngreso.Location = new System.Drawing.Point(7, 138);
            this.lblPerceDeducIngreso.Name = "lblPerceDeducIngreso";
            this.lblPerceDeducIngreso.Size = new System.Drawing.Size(170, 17);
            this.lblPerceDeducIngreso.TabIndex = 10;
            this.lblPerceDeducIngreso.Text = "Deducción o Percepción:";
            // 
            // lblNomEmpleIngreso
            // 
            this.lblNomEmpleIngreso.AutoSize = true;
            this.lblNomEmpleIngreso.Location = new System.Drawing.Point(7, 61);
            this.lblNomEmpleIngreso.Name = "lblNomEmpleIngreso";
            this.lblNomEmpleIngreso.Size = new System.Drawing.Size(135, 17);
            this.lblNomEmpleIngreso.TabIndex = 9;
            this.lblNomEmpleIngreso.Text = "Nombre Empleado:";
            // 
            // lblIdEmpIngreso
            // 
            this.lblIdEmpIngreso.AutoSize = true;
            this.lblIdEmpIngreso.Location = new System.Drawing.Point(7, 24);
            this.lblIdEmpIngreso.Name = "lblIdEmpIngreso";
            this.lblIdEmpIngreso.Size = new System.Drawing.Size(96, 17);
            this.lblIdEmpIngreso.TabIndex = 8;
            this.lblIdEmpIngreso.Text = "ID Empleado:";
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpBuscar.Controls.Add(this.txtBuscarFechaFin);
            this.tbpBuscar.Controls.Add(this.lblTotalPer);
            this.tbpBuscar.Controls.Add(this.lblTotalDed);
            this.tbpBuscar.Controls.Add(this.txtTotalDed);
            this.tbpBuscar.Controls.Add(this.txtTotalPer);
            this.tbpBuscar.Controls.Add(this.btnLimpiar);
            this.tbpBuscar.Controls.Add(this.cmbBuscarPeriodoPlanilla);
            this.tbpBuscar.Controls.Add(this.dgvPerEpm);
            this.tbpBuscar.Controls.Add(this.dgvDedEmp);
            this.tbpBuscar.Controls.Add(this.btnBuscar);
            this.tbpBuscar.Controls.Add(this.lblBuscarFecPlanilla);
            this.tbpBuscar.Controls.Add(this.txtBuscarPuestoEmp);
            this.tbpBuscar.Controls.Add(this.lblBuscarPuestoEmp);
            this.tbpBuscar.Controls.Add(this.txtBuscarNomEmp);
            this.tbpBuscar.Controls.Add(this.lblBuscarNomEmp);
            this.tbpBuscar.Controls.Add(this.txtBuscarIdEmp);
            this.tbpBuscar.Controls.Add(this.lbBuscarIDEmp);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 26);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(824, 502);
            this.tbpBuscar.TabIndex = 2;
            this.tbpBuscar.Text = "Buscar";
            // 
            // txtBuscarFechaFin
            // 
            this.txtBuscarFechaFin.Enabled = false;
            this.txtBuscarFechaFin.Location = new System.Drawing.Point(380, 123);
            this.txtBuscarFechaFin.Name = "txtBuscarFechaFin";
            this.txtBuscarFechaFin.Size = new System.Drawing.Size(133, 23);
            this.txtBuscarFechaFin.TabIndex = 19;
            // 
            // lblTotalPer
            // 
            this.lblTotalPer.AutoSize = true;
            this.lblTotalPer.Location = new System.Drawing.Point(558, 415);
            this.lblTotalPer.Name = "lblTotalPer";
            this.lblTotalPer.Size = new System.Drawing.Size(134, 17);
            this.lblTotalPer.TabIndex = 18;
            this.lblTotalPer.Text = "Total Percepciones:";
            // 
            // lblTotalDed
            // 
            this.lblTotalDed.AutoSize = true;
            this.lblTotalDed.Location = new System.Drawing.Point(115, 415);
            this.lblTotalDed.Name = "lblTotalDed";
            this.lblTotalDed.Size = new System.Drawing.Size(130, 17);
            this.lblTotalDed.TabIndex = 17;
            this.lblTotalDed.Text = "Total Deducciones:";
            // 
            // txtTotalDed
            // 
            this.txtTotalDed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalDed.Enabled = false;
            this.txtTotalDed.Location = new System.Drawing.Point(119, 438);
            this.txtTotalDed.Name = "txtTotalDed";
            this.txtTotalDed.Size = new System.Drawing.Size(156, 23);
            this.txtTotalDed.TabIndex = 16;
            // 
            // txtTotalPer
            // 
            this.txtTotalPer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalPer.Enabled = false;
            this.txtTotalPer.Location = new System.Drawing.Point(562, 438);
            this.txtTotalPer.Name = "txtTotalPer";
            this.txtTotalPer.Size = new System.Drawing.Size(156, 23);
            this.txtTotalPer.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(626, 122);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(92, 27);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbBuscarPeriodoPlanilla
            // 
            this.cmbBuscarPeriodoPlanilla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbBuscarPeriodoPlanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPeriodoPlanilla.FormattingEnabled = true;
            this.cmbBuscarPeriodoPlanilla.Location = new System.Drawing.Point(217, 122);
            this.cmbBuscarPeriodoPlanilla.Name = "cmbBuscarPeriodoPlanilla";
            this.cmbBuscarPeriodoPlanilla.Size = new System.Drawing.Size(157, 25);
            this.cmbBuscarPeriodoPlanilla.TabIndex = 13;
            this.cmbBuscarPeriodoPlanilla.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPeriodoPlanilla_SelectedIndexChanged);
            // 
            // dgvPerEpm
            // 
            this.dgvPerEpm.AllowUserToAddRows = false;
            this.dgvPerEpm.AllowUserToDeleteRows = false;
            this.dgvPerEpm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPerEpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerEpm.Location = new System.Drawing.Point(415, 164);
            this.dgvPerEpm.Name = "dgvPerEpm";
            this.dgvPerEpm.ReadOnly = true;
            this.dgvPerEpm.RowHeadersWidth = 51;
            this.dgvPerEpm.RowTemplate.Height = 24;
            this.dgvPerEpm.Size = new System.Drawing.Size(406, 232);
            this.dgvPerEpm.TabIndex = 11;
            // 
            // dgvDedEmp
            // 
            this.dgvDedEmp.AllowUserToAddRows = false;
            this.dgvDedEmp.AllowUserToDeleteRows = false;
            this.dgvDedEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDedEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDedEmp.Location = new System.Drawing.Point(3, 164);
            this.dgvDedEmp.Name = "dgvDedEmp";
            this.dgvDedEmp.ReadOnly = true;
            this.dgvDedEmp.RowHeadersWidth = 51;
            this.dgvDedEmp.RowTemplate.Height = 24;
            this.dgvDedEmp.Size = new System.Drawing.Size(406, 232);
            this.dgvDedEmp.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(724, 122);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 28);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblBuscarFecPlanilla
            // 
            this.lblBuscarFecPlanilla.AutoSize = true;
            this.lblBuscarFecPlanilla.Location = new System.Drawing.Point(20, 130);
            this.lblBuscarFecPlanilla.Name = "lblBuscarFecPlanilla";
            this.lblBuscarFecPlanilla.Size = new System.Drawing.Size(134, 17);
            this.lblBuscarFecPlanilla.TabIndex = 7;
            this.lblBuscarFecPlanilla.Text = "Periodo de Planilla:";
            // 
            // txtBuscarPuestoEmp
            // 
            this.txtBuscarPuestoEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarPuestoEmp.Enabled = false;
            this.txtBuscarPuestoEmp.Location = new System.Drawing.Point(217, 89);
            this.txtBuscarPuestoEmp.Name = "txtBuscarPuestoEmp";
            this.txtBuscarPuestoEmp.Size = new System.Drawing.Size(296, 23);
            this.txtBuscarPuestoEmp.TabIndex = 5;
            // 
            // lblBuscarPuestoEmp
            // 
            this.lblBuscarPuestoEmp.AutoSize = true;
            this.lblBuscarPuestoEmp.Location = new System.Drawing.Point(20, 96);
            this.lblBuscarPuestoEmp.Name = "lblBuscarPuestoEmp";
            this.lblBuscarPuestoEmp.Size = new System.Drawing.Size(149, 17);
            this.lblBuscarPuestoEmp.TabIndex = 4;
            this.lblBuscarPuestoEmp.Text = "Puesto del Empleado:";
            // 
            // txtBuscarNomEmp
            // 
            this.txtBuscarNomEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarNomEmp.Enabled = false;
            this.txtBuscarNomEmp.Location = new System.Drawing.Point(217, 56);
            this.txtBuscarNomEmp.Name = "txtBuscarNomEmp";
            this.txtBuscarNomEmp.Size = new System.Drawing.Size(296, 23);
            this.txtBuscarNomEmp.TabIndex = 3;
            // 
            // lblBuscarNomEmp
            // 
            this.lblBuscarNomEmp.AutoSize = true;
            this.lblBuscarNomEmp.Location = new System.Drawing.Point(20, 63);
            this.lblBuscarNomEmp.Name = "lblBuscarNomEmp";
            this.lblBuscarNomEmp.Size = new System.Drawing.Size(160, 17);
            this.lblBuscarNomEmp.TabIndex = 2;
            this.lblBuscarNomEmp.Text = "Nombre del Empleado:";
            // 
            // txtBuscarIdEmp
            // 
            this.txtBuscarIdEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuscarIdEmp.Location = new System.Drawing.Point(217, 23);
            this.txtBuscarIdEmp.Name = "txtBuscarIdEmp";
            this.txtBuscarIdEmp.Size = new System.Drawing.Size(296, 23);
            this.txtBuscarIdEmp.TabIndex = 1;
            // 
            // lbBuscarIDEmp
            // 
            this.lbBuscarIDEmp.AutoSize = true;
            this.lbBuscarIDEmp.Location = new System.Drawing.Point(20, 30);
            this.lbBuscarIDEmp.Name = "lbBuscarIDEmp";
            this.lbBuscarIDEmp.Size = new System.Drawing.Size(96, 17);
            this.lbBuscarIDEmp.TabIndex = 0;
            this.lbBuscarIDEmp.Text = "ID Empleado:";
            // 
            // tbpEliminarEmpleDedPer
            // 
            this.tbpEliminarEmpleDedPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpEliminarEmpleDedPer.Controls.Add(this.txtEliminarFechFin);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblTipoCobroEliminar);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.btnEliminarBuscar);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.btnEliminarEmpleadoDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.gbxEliminarTipoCob);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.cmbEliminarFechPlan);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.cmbEliminarDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.txtEliminarNomEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.txtEliminarIdEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarFechPlan);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarDedPer);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarNomEmp);
            this.tbpEliminarEmpleDedPer.Controls.Add(this.lblEliminarIdEmp);
            this.tbpEliminarEmpleDedPer.Location = new System.Drawing.Point(4, 26);
            this.tbpEliminarEmpleDedPer.Name = "tbpEliminarEmpleDedPer";
            this.tbpEliminarEmpleDedPer.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminarEmpleDedPer.Size = new System.Drawing.Size(824, 502);
            this.tbpEliminarEmpleDedPer.TabIndex = 1;
            this.tbpEliminarEmpleDedPer.Text = "Eliminar";
            // 
            // txtEliminarFechFin
            // 
            this.txtEliminarFechFin.Location = new System.Drawing.Point(385, 165);
            this.txtEliminarFechFin.Name = "txtEliminarFechFin";
            this.txtEliminarFechFin.Size = new System.Drawing.Size(127, 23);
            this.txtEliminarFechFin.TabIndex = 21;
            // 
            // lblTipoCobroEliminar
            // 
            this.lblTipoCobroEliminar.AutoSize = true;
            this.lblTipoCobroEliminar.Location = new System.Drawing.Point(7, 98);
            this.lblTipoCobroEliminar.Name = "lblTipoCobroEliminar";
            this.lblTipoCobroEliminar.Size = new System.Drawing.Size(108, 17);
            this.lblTipoCobroEliminar.TabIndex = 20;
            this.lblTipoCobroEliminar.Text = "Tipo de Cobro:";
            // 
            // btnEliminarBuscar
            // 
            this.btnEliminarBuscar.Location = new System.Drawing.Point(565, 199);
            this.btnEliminarBuscar.Name = "btnEliminarBuscar";
            this.btnEliminarBuscar.Size = new System.Drawing.Size(154, 29);
            this.btnEliminarBuscar.TabIndex = 19;
            this.btnEliminarBuscar.Text = "Buscar Empleado";
            this.btnEliminarBuscar.UseVisualStyleBackColor = true;
            this.btnEliminarBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarEmpleadoDedPer
            // 
            this.btnEliminarEmpleadoDedPer.Location = new System.Drawing.Point(725, 199);
            this.btnEliminarEmpleadoDedPer.Name = "btnEliminarEmpleadoDedPer";
            this.btnEliminarEmpleadoDedPer.Size = new System.Drawing.Size(91, 29);
            this.btnEliminarEmpleadoDedPer.TabIndex = 17;
            this.btnEliminarEmpleadoDedPer.Text = "Eliminar";
            this.btnEliminarEmpleadoDedPer.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleadoDedPer.Click += new System.EventHandler(this.btnEliminarEmpleadoDedPer_Click);
            // 
            // gbxEliminarTipoCob
            // 
            this.gbxEliminarTipoCob.Controls.Add(this.rbtnEliminarDed);
            this.gbxEliminarTipoCob.Controls.Add(this.rbtnEliminarPer);
            this.gbxEliminarTipoCob.Location = new System.Drawing.Point(234, 81);
            this.gbxEliminarTipoCob.Name = "gbxEliminarTipoCob";
            this.gbxEliminarTipoCob.Size = new System.Drawing.Size(279, 43);
            this.gbxEliminarTipoCob.TabIndex = 16;
            this.gbxEliminarTipoCob.TabStop = false;
            // 
            // rbtnEliminarDed
            // 
            this.rbtnEliminarDed.AutoSize = true;
            this.rbtnEliminarDed.Location = new System.Drawing.Point(6, 15);
            this.rbtnEliminarDed.Name = "rbtnEliminarDed";
            this.rbtnEliminarDed.Size = new System.Drawing.Size(95, 21);
            this.rbtnEliminarDed.TabIndex = 0;
            this.rbtnEliminarDed.TabStop = true;
            this.rbtnEliminarDed.Text = "Deducción";
            this.rbtnEliminarDed.UseVisualStyleBackColor = true;
            this.rbtnEliminarDed.CheckedChanged += new System.EventHandler(this.rbtnEliminarDed_CheckedChanged);
            // 
            // rbtnEliminarPer
            // 
            this.rbtnEliminarPer.AutoSize = true;
            this.rbtnEliminarPer.Location = new System.Drawing.Point(153, 15);
            this.rbtnEliminarPer.Name = "rbtnEliminarPer";
            this.rbtnEliminarPer.Size = new System.Drawing.Size(99, 21);
            this.rbtnEliminarPer.TabIndex = 1;
            this.rbtnEliminarPer.TabStop = true;
            this.rbtnEliminarPer.Text = "Percepción";
            this.rbtnEliminarPer.UseVisualStyleBackColor = true;
            this.rbtnEliminarPer.CheckedChanged += new System.EventHandler(this.rbtnEliminarPer_CheckedChanged);
            // 
            // cmbEliminarFechPlan
            // 
            this.cmbEliminarFechPlan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEliminarFechPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarFechPlan.FormattingEnabled = true;
            this.cmbEliminarFechPlan.Location = new System.Drawing.Point(232, 165);
            this.cmbEliminarFechPlan.Name = "cmbEliminarFechPlan";
            this.cmbEliminarFechPlan.Size = new System.Drawing.Size(146, 25);
            this.cmbEliminarFechPlan.TabIndex = 15;
            this.cmbEliminarFechPlan.SelectedIndexChanged += new System.EventHandler(this.cmbEliminarFechPlan_SelectedIndexChanged);
            // 
            // cmbEliminarDedPer
            // 
            this.cmbEliminarDedPer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEliminarDedPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminarDedPer.FormattingEnabled = true;
            this.cmbEliminarDedPer.Location = new System.Drawing.Point(232, 130);
            this.cmbEliminarDedPer.Name = "cmbEliminarDedPer";
            this.cmbEliminarDedPer.Size = new System.Drawing.Size(280, 25);
            this.cmbEliminarDedPer.TabIndex = 14;
            // 
            // txtEliminarNomEmp
            // 
            this.txtEliminarNomEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEliminarNomEmp.Enabled = false;
            this.txtEliminarNomEmp.Location = new System.Drawing.Point(234, 54);
            this.txtEliminarNomEmp.Name = "txtEliminarNomEmp";
            this.txtEliminarNomEmp.Size = new System.Drawing.Size(280, 23);
            this.txtEliminarNomEmp.TabIndex = 13;
            // 
            // txtEliminarIdEmp
            // 
            this.txtEliminarIdEmp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEliminarIdEmp.Location = new System.Drawing.Point(233, 17);
            this.txtEliminarIdEmp.Name = "txtEliminarIdEmp";
            this.txtEliminarIdEmp.Size = new System.Drawing.Size(280, 23);
            this.txtEliminarIdEmp.TabIndex = 12;
            // 
            // lblEliminarFechPlan
            // 
            this.lblEliminarFechPlan.AutoSize = true;
            this.lblEliminarFechPlan.Location = new System.Drawing.Point(7, 173);
            this.lblEliminarFechPlan.Name = "lblEliminarFechPlan";
            this.lblEliminarFechPlan.Size = new System.Drawing.Size(96, 17);
            this.lblEliminarFechPlan.TabIndex = 11;
            this.lblEliminarFechPlan.Text = "Fecha Planilla";
            // 
            // lblEliminarDedPer
            // 
            this.lblEliminarDedPer.AutoSize = true;
            this.lblEliminarDedPer.Location = new System.Drawing.Point(7, 138);
            this.lblEliminarDedPer.Name = "lblEliminarDedPer";
            this.lblEliminarDedPer.Size = new System.Drawing.Size(170, 17);
            this.lblEliminarDedPer.TabIndex = 10;
            this.lblEliminarDedPer.Text = "Deducción o Percepción:";
            // 
            // lblEliminarNomEmp
            // 
            this.lblEliminarNomEmp.AutoSize = true;
            this.lblEliminarNomEmp.Location = new System.Drawing.Point(7, 61);
            this.lblEliminarNomEmp.Name = "lblEliminarNomEmp";
            this.lblEliminarNomEmp.Size = new System.Drawing.Size(135, 17);
            this.lblEliminarNomEmp.TabIndex = 9;
            this.lblEliminarNomEmp.Text = "Nombre Empleado:";
            // 
            // lblEliminarIdEmp
            // 
            this.lblEliminarIdEmp.AutoSize = true;
            this.lblEliminarIdEmp.Location = new System.Drawing.Point(7, 24);
            this.lblEliminarIdEmp.Name = "lblEliminarIdEmp";
            this.lblEliminarIdEmp.Size = new System.Drawing.Size(96, 17);
            this.lblEliminarIdEmp.TabIndex = 8;
            this.lblEliminarIdEmp.Text = "ID Empleado:";
            // 
            // frmEmpleadoNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(832, 532);
            this.Controls.Add(this.tbcEmpleadoNomina);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleadoNomina";
            this.Text = "313 - Cobros Del Empleado";
            this.Load += new System.EventHandler(this.frmEmpleadoNomina_Load);
            this.tbcEmpleadoNomina.ResumeLayout(false);
            this.tbpIngresarEmpleDedPer.ResumeLayout(false);
            this.tbpIngresarEmpleDedPer.PerformLayout();
            this.gbxIngresoTipoCob.ResumeLayout(false);
            this.gbxIngresoTipoCob.PerformLayout();
            this.tbpBuscar.ResumeLayout(false);
            this.tbpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerEpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDedEmp)).EndInit();
            this.tbpEliminarEmpleDedPer.ResumeLayout(false);
            this.tbpEliminarEmpleDedPer.PerformLayout();
            this.gbxEliminarTipoCob.ResumeLayout(false);
            this.gbxEliminarTipoCob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEmpleadoNomina;
        private System.Windows.Forms.TabPage tbpIngresarEmpleDedPer;
        private System.Windows.Forms.Button btnIngresoEmpleadoDedPer;
        private System.Windows.Forms.GroupBox gbxIngresoTipoCob;
        private System.Windows.Forms.RadioButton rbtnIngresoDed;
        private System.Windows.Forms.RadioButton rbtnIngresoPerc;
        private System.Windows.Forms.ComboBox cmbIngresoFecPLan;
        private System.Windows.Forms.ComboBox cmbIngresoDedPer;
        private System.Windows.Forms.TextBox txtIngresoNomEmp;
        private System.Windows.Forms.TextBox txtIngresoIdEmp;
        private System.Windows.Forms.Label lblFecPlanIngreso;
        private System.Windows.Forms.Label lblPerceDeducIngreso;
        private System.Windows.Forms.Label lblNomEmpleIngreso;
        private System.Windows.Forms.Label lblIdEmpIngreso;
        private System.Windows.Forms.TabPage tbpEliminarEmpleDedPer;
        private System.Windows.Forms.Button btnEliminarEmpleadoDedPer;
        private System.Windows.Forms.GroupBox gbxEliminarTipoCob;
        private System.Windows.Forms.RadioButton rbtnEliminarDed;
        private System.Windows.Forms.RadioButton rbtnEliminarPer;
        private System.Windows.Forms.ComboBox cmbEliminarFechPlan;
        private System.Windows.Forms.ComboBox cmbEliminarDedPer;
        private System.Windows.Forms.TextBox txtEliminarNomEmp;
        private System.Windows.Forms.TextBox txtEliminarIdEmp;
        private System.Windows.Forms.Label lblEliminarFechPlan;
        private System.Windows.Forms.Label lblEliminarDedPer;
        private System.Windows.Forms.Label lblEliminarNomEmp;
        private System.Windows.Forms.Label lblEliminarIdEmp;
        private System.Windows.Forms.Button btnEliminarBuscar;
        private System.Windows.Forms.Label lblTipoCobro;
        private System.Windows.Forms.Label lblTipoCobroEliminar;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TextBox txtBuscarPuestoEmp;
        private System.Windows.Forms.Label lblBuscarPuestoEmp;
        private System.Windows.Forms.TextBox txtBuscarNomEmp;
        private System.Windows.Forms.Label lblBuscarNomEmp;
        private System.Windows.Forms.TextBox txtBuscarIdEmp;
        private System.Windows.Forms.Label lbBuscarIDEmp;
        private System.Windows.Forms.DataGridView dgvPerEpm;
        private System.Windows.Forms.DataGridView dgvDedEmp;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarFecPlanilla;
        private System.Windows.Forms.Button btnIngresarBuscar;
        private System.Windows.Forms.ComboBox cmbBuscarPeriodoPlanilla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotalPer;
        private System.Windows.Forms.Label lblTotalDed;
        private System.Windows.Forms.TextBox txtTotalDed;
        private System.Windows.Forms.TextBox txtTotalPer;
        private System.Windows.Forms.TextBox txtIngresoFechFin;
        private System.Windows.Forms.TextBox txtBuscarFechaFin;
        private System.Windows.Forms.TextBox txtEliminarFechFin;
    }
}
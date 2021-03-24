namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmEmpCapacitado
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
            this.tbcCapacitacion = new System.Windows.Forms.TabControl();
            this.tbpAsignacion = new System.Windows.Forms.TabPage();
            this.txtCodiCapa = new System.Windows.Forms.TextBox();
            this.gbxDetCap = new System.Windows.Forms.GroupBox();
            this.txtCodigoEncabezado = new System.Windows.Forms.TextBox();
            this.lblCodigoC = new System.Windows.Forms.Label();
            this.lblFeFin = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblFeIni = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.dtpFechIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechFin = new System.Windows.Forms.DateTimePicker();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.lblHoras = new System.Windows.Forms.Label();
            this.btnIngresoCurso = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtBusqCodEmp = new System.Windows.Forms.TextBox();
            this.lblCodEmp = new System.Windows.Forms.Label();
            this.gbxDatEmp = new System.Windows.Forms.GroupBox();
            this.txtEstEmp = new System.Windows.Forms.TextBox();
            this.txtDeptEmp = new System.Windows.Forms.TextBox();
            this.txtNombEmp = new System.Windows.Forms.TextBox();
            this.lblEstao = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.tbpResultados = new System.Windows.Forms.TabPage();
            this.gbxDatEmpR = new System.Windows.Forms.GroupBox();
            this.txtCapR = new System.Windows.Forms.TextBox();
            this.lblCapR = new System.Windows.Forms.Label();
            this.btnBuscarR = new System.Windows.Forms.Button();
            this.txtCodEmpR = new System.Windows.Forms.TextBox();
            this.txtNombEmpR = new System.Windows.Forms.TextBox();
            this.lblCodEmpR = new System.Windows.Forms.Label();
            this.lblNombEmpR = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvCompIng = new System.Windows.Forms.DataGridView();
            this.gbxIngresoR = new System.Windows.Forms.GroupBox();
            this.btnBuscarCap = new System.Windows.Forms.Button();
            this.cmbCodigoCap = new System.Windows.Forms.ComboBox();
            this.btnIngresarCompetencia = new System.Windows.Forms.Button();
            this.lblCodCap = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbcCapacitacion.SuspendLayout();
            this.tbpAsignacion.SuspendLayout();
            this.gbxDetCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.gbxDatEmp.SuspendLayout();
            this.tbpResultados.SuspendLayout();
            this.gbxDatEmpR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompIng)).BeginInit();
            this.gbxIngresoR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCapacitacion
            // 
            this.tbcCapacitacion.Controls.Add(this.tbpAsignacion);
            this.tbcCapacitacion.Controls.Add(this.tbpResultados);
            this.tbcCapacitacion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcCapacitacion.Location = new System.Drawing.Point(14, 15);
            this.tbcCapacitacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbcCapacitacion.Name = "tbcCapacitacion";
            this.tbcCapacitacion.SelectedIndex = 0;
            this.tbcCapacitacion.Size = new System.Drawing.Size(934, 414);
            this.tbcCapacitacion.TabIndex = 0;
            // 
            // tbpAsignacion
            // 
            this.tbpAsignacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpAsignacion.Controls.Add(this.txtCodiCapa);
            this.tbpAsignacion.Controls.Add(this.gbxDetCap);
            this.tbpAsignacion.Controls.Add(this.btnIngresoCurso);
            this.tbpAsignacion.Controls.Add(this.lblCodigo);
            this.tbpAsignacion.Controls.Add(this.btnBuscarEmp);
            this.tbpAsignacion.Controls.Add(this.txtBusqCodEmp);
            this.tbpAsignacion.Controls.Add(this.lblCodEmp);
            this.tbpAsignacion.Controls.Add(this.gbxDatEmp);
            this.tbpAsignacion.Location = new System.Drawing.Point(4, 25);
            this.tbpAsignacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpAsignacion.Name = "tbpAsignacion";
            this.tbpAsignacion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpAsignacion.Size = new System.Drawing.Size(926, 385);
            this.tbpAsignacion.TabIndex = 0;
            this.tbpAsignacion.Text = "Asignación";
            // 
            // txtCodiCapa
            // 
            this.txtCodiCapa.Location = new System.Drawing.Point(201, 12);
            this.txtCodiCapa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodiCapa.Name = "txtCodiCapa";
            this.txtCodiCapa.Size = new System.Drawing.Size(313, 23);
            this.txtCodiCapa.TabIndex = 13;
            this.txtCodiCapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // gbxDetCap
            // 
            this.gbxDetCap.Controls.Add(this.txtCodigoEncabezado);
            this.gbxDetCap.Controls.Add(this.lblCodigoC);
            this.gbxDetCap.Controls.Add(this.lblFeFin);
            this.gbxDetCap.Controls.Add(this.cmbCurso);
            this.gbxDetCap.Controls.Add(this.lblFeIni);
            this.gbxDetCap.Controls.Add(this.lblCurso);
            this.gbxDetCap.Controls.Add(this.dtpFechIni);
            this.gbxDetCap.Controls.Add(this.dtpFechFin);
            this.gbxDetCap.Controls.Add(this.nudHoras);
            this.gbxDetCap.Controls.Add(this.lblHoras);
            this.gbxDetCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetCap.Location = new System.Drawing.Point(530, 60);
            this.gbxDetCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Name = "gbxDetCap";
            this.gbxDetCap.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDetCap.Size = new System.Drawing.Size(388, 178);
            this.gbxDetCap.TabIndex = 21;
            this.gbxDetCap.TabStop = false;
            this.gbxDetCap.Text = "Detalles de Capacitación";
            // 
            // txtCodigoEncabezado
            // 
            this.txtCodigoEncabezado.Location = new System.Drawing.Point(134, 17);
            this.txtCodigoEncabezado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigoEncabezado.Name = "txtCodigoEncabezado";
            this.txtCodigoEncabezado.Size = new System.Drawing.Size(248, 23);
            this.txtCodigoEncabezado.TabIndex = 11;
            this.txtCodigoEncabezado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodigoC
            // 
            this.lblCodigoC.AutoSize = true;
            this.lblCodigoC.Location = new System.Drawing.Point(7, 20);
            this.lblCodigoC.Name = "lblCodigoC";
            this.lblCodigoC.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoC.TabIndex = 10;
            this.lblCodigoC.Text = "Codigo";
            // 
            // lblFeFin
            // 
            this.lblFeFin.AutoSize = true;
            this.lblFeFin.Location = new System.Drawing.Point(7, 116);
            this.lblFeFin.Name = "lblFeFin";
            this.lblFeFin.Size = new System.Drawing.Size(108, 16);
            this.lblFeFin.TabIndex = 8;
            this.lblFeFin.Text = "Fecha de termino";
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(133, 48);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(248, 24);
            this.cmbCurso.TabIndex = 7;
            // 
            // lblFeIni
            // 
            this.lblFeIni.AutoSize = true;
            this.lblFeIni.Location = new System.Drawing.Point(7, 85);
            this.lblFeIni.Name = "lblFeIni";
            this.lblFeIni.Size = new System.Drawing.Size(95, 16);
            this.lblFeIni.TabIndex = 6;
            this.lblFeIni.Text = "Fecha de Inicio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(7, 51);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(43, 16);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso";
            // 
            // dtpFechIni
            // 
            this.dtpFechIni.Location = new System.Drawing.Point(134, 80);
            this.dtpFechIni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechIni.Name = "dtpFechIni";
            this.dtpFechIni.Size = new System.Drawing.Size(248, 23);
            this.dtpFechIni.TabIndex = 4;
            // 
            // dtpFechFin
            // 
            this.dtpFechFin.Location = new System.Drawing.Point(133, 111);
            this.dtpFechFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechFin.Name = "dtpFechFin";
            this.dtpFechFin.Size = new System.Drawing.Size(248, 23);
            this.dtpFechFin.TabIndex = 3;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(301, 142);
            this.nudHoras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(80, 23);
            this.nudHoras.TabIndex = 1;
            this.nudHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(7, 149);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(42, 16);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas";
            // 
            // btnIngresoCurso
            // 
            this.btnIngresoCurso.Location = new System.Drawing.Point(840, 349);
            this.btnIngresoCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresoCurso.Name = "btnIngresoCurso";
            this.btnIngresoCurso.Size = new System.Drawing.Size(80, 28);
            this.btnIngresoCurso.TabIndex = 9;
            this.btnIngresoCurso.Text = "Ingresar";
            this.btnIngresoCurso.UseVisualStyleBackColor = true;
            this.btnIngresoCurso.Click += new System.EventHandler(this.btnIngresoCurso_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(149, 16);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo de Capacitación";
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.Location = new System.Drawing.Point(831, 7);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(87, 28);
            this.btnBuscarEmp.TabIndex = 18;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.UseVisualStyleBackColor = true;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // txtBusqCodEmp
            // 
            this.txtBusqCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqCodEmp.Location = new System.Drawing.Point(664, 7);
            this.txtBusqCodEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqCodEmp.Name = "txtBusqCodEmp";
            this.txtBusqCodEmp.Size = new System.Drawing.Size(159, 23);
            this.txtBusqCodEmp.TabIndex = 17;
            this.txtBusqCodEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblCodEmp
            // 
            this.lblCodEmp.AutoSize = true;
            this.lblCodEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmp.Location = new System.Drawing.Point(526, 11);
            this.lblCodEmp.Name = "lblCodEmp";
            this.lblCodEmp.Size = new System.Drawing.Size(113, 16);
            this.lblCodEmp.TabIndex = 16;
            this.lblCodEmp.Text = "Código Empleado";
            // 
            // gbxDatEmp
            // 
            this.gbxDatEmp.Controls.Add(this.txtEstEmp);
            this.gbxDatEmp.Controls.Add(this.txtDeptEmp);
            this.gbxDatEmp.Controls.Add(this.txtNombEmp);
            this.gbxDatEmp.Controls.Add(this.lblEstao);
            this.gbxDatEmp.Controls.Add(this.lblNom);
            this.gbxDatEmp.Controls.Add(this.lblDept);
            this.gbxDatEmp.Enabled = false;
            this.gbxDatEmp.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatEmp.Location = new System.Drawing.Point(7, 60);
            this.gbxDatEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmp.Name = "gbxDatEmp";
            this.gbxDatEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmp.Size = new System.Drawing.Size(514, 178);
            this.gbxDatEmp.TabIndex = 19;
            this.gbxDatEmp.TabStop = false;
            this.gbxDatEmp.Text = "Datos del Empleado";
            // 
            // txtEstEmp
            // 
            this.txtEstEmp.Location = new System.Drawing.Point(194, 141);
            this.txtEstEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstEmp.Name = "txtEstEmp";
            this.txtEstEmp.Size = new System.Drawing.Size(313, 23);
            this.txtEstEmp.TabIndex = 15;
            this.txtEstEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // txtDeptEmp
            // 
            this.txtDeptEmp.Location = new System.Drawing.Point(195, 82);
            this.txtDeptEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptEmp.Name = "txtDeptEmp";
            this.txtDeptEmp.Size = new System.Drawing.Size(313, 23);
            this.txtDeptEmp.TabIndex = 14;
            this.txtDeptEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // txtNombEmp
            // 
            this.txtNombEmp.Location = new System.Drawing.Point(194, 24);
            this.txtNombEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombEmp.Name = "txtNombEmp";
            this.txtNombEmp.Size = new System.Drawing.Size(313, 23);
            this.txtNombEmp.TabIndex = 13;
            this.txtNombEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // lblEstao
            // 
            this.lblEstao.AutoSize = true;
            this.lblEstao.Location = new System.Drawing.Point(6, 142);
            this.lblEstao.Name = "lblEstao";
            this.lblEstao.Size = new System.Drawing.Size(131, 16);
            this.lblEstao.TabIndex = 12;
            this.lblEstao.Text = "Estado del Empleado";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(138, 16);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nombre del Empleado";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(6, 85);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(156, 16);
            this.lblDept.TabIndex = 11;
            this.lblDept.Text = "Departamento de Trabajo";
            // 
            // tbpResultados
            // 
            this.tbpResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpResultados.Controls.Add(this.gbxDatEmpR);
            this.tbpResultados.Controls.Add(this.lblTitulo);
            this.tbpResultados.Controls.Add(this.dgvCompIng);
            this.tbpResultados.Controls.Add(this.gbxIngresoR);
            this.tbpResultados.Location = new System.Drawing.Point(4, 25);
            this.tbpResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpResultados.Name = "tbpResultados";
            this.tbpResultados.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbpResultados.Size = new System.Drawing.Size(926, 385);
            this.tbpResultados.TabIndex = 1;
            this.tbpResultados.Text = "Resultados";
            // 
            // gbxDatEmpR
            // 
            this.gbxDatEmpR.Controls.Add(this.txtCapR);
            this.gbxDatEmpR.Controls.Add(this.lblCapR);
            this.gbxDatEmpR.Controls.Add(this.btnBuscarR);
            this.gbxDatEmpR.Controls.Add(this.txtCodEmpR);
            this.gbxDatEmpR.Controls.Add(this.txtNombEmpR);
            this.gbxDatEmpR.Controls.Add(this.lblCodEmpR);
            this.gbxDatEmpR.Controls.Add(this.lblNombEmpR);
            this.gbxDatEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatEmpR.Location = new System.Drawing.Point(10, 11);
            this.gbxDatEmpR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmpR.Name = "gbxDatEmpR";
            this.gbxDatEmpR.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatEmpR.Size = new System.Drawing.Size(908, 110);
            this.gbxDatEmpR.TabIndex = 23;
            this.gbxDatEmpR.TabStop = false;
            this.gbxDatEmpR.Text = "Datos del Empleado";
            // 
            // txtCapR
            // 
            this.txtCapR.Enabled = false;
            this.txtCapR.Location = new System.Drawing.Point(175, 63);
            this.txtCapR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapR.Name = "txtCapR";
            this.txtCapR.Size = new System.Drawing.Size(313, 23);
            this.txtCapR.TabIndex = 23;
            this.txtCapR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // lblCapR
            // 
            this.lblCapR.AutoSize = true;
            this.lblCapR.Location = new System.Drawing.Point(7, 66);
            this.lblCapR.Name = "lblCapR";
            this.lblCapR.Size = new System.Drawing.Size(91, 16);
            this.lblCapR.TabIndex = 22;
            this.lblCapR.Text = "Departamento";
            // 
            // btnBuscarR
            // 
            this.btnBuscarR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarR.Location = new System.Drawing.Point(813, 27);
            this.btnBuscarR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarR.Name = "btnBuscarR";
            this.btnBuscarR.Size = new System.Drawing.Size(87, 28);
            this.btnBuscarR.TabIndex = 21;
            this.btnBuscarR.Text = "Buscar";
            this.btnBuscarR.UseVisualStyleBackColor = true;
            this.btnBuscarR.Click += new System.EventHandler(this.btnBuscarR_Click);
            // 
            // txtCodEmpR
            // 
            this.txtCodEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodEmpR.Location = new System.Drawing.Point(699, 30);
            this.txtCodEmpR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodEmpR.Name = "txtCodEmpR";
            this.txtCodEmpR.Size = new System.Drawing.Size(107, 23);
            this.txtCodEmpR.TabIndex = 20;
            this.txtCodEmpR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // txtNombEmpR
            // 
            this.txtNombEmpR.Enabled = false;
            this.txtNombEmpR.Location = new System.Drawing.Point(175, 27);
            this.txtNombEmpR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombEmpR.Name = "txtNombEmpR";
            this.txtNombEmpR.Size = new System.Drawing.Size(313, 23);
            this.txtNombEmpR.TabIndex = 13;
            this.txtNombEmpR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letra);
            // 
            // lblCodEmpR
            // 
            this.lblCodEmpR.AutoSize = true;
            this.lblCodEmpR.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEmpR.Location = new System.Drawing.Point(530, 33);
            this.lblCodEmpR.Name = "lblCodEmpR";
            this.lblCodEmpR.Size = new System.Drawing.Size(113, 16);
            this.lblCodEmpR.TabIndex = 19;
            this.lblCodEmpR.Text = "Código Empleado";
            // 
            // lblNombEmpR
            // 
            this.lblNombEmpR.AutoSize = true;
            this.lblNombEmpR.Location = new System.Drawing.Point(7, 31);
            this.lblNombEmpR.Name = "lblNombEmpR";
            this.lblNombEmpR.Size = new System.Drawing.Size(138, 16);
            this.lblNombEmpR.TabIndex = 10;
            this.lblNombEmpR.Text = "Nombre del Empleado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(7, 207);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 18);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Capacitación Realizada";
            // 
            // dgvCompIng
            // 
            this.dgvCompIng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCompIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompIng.Location = new System.Drawing.Point(7, 233);
            this.dgvCompIng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCompIng.Name = "dgvCompIng";
            this.dgvCompIng.Size = new System.Drawing.Size(911, 147);
            this.dgvCompIng.TabIndex = 8;
            // 
            // gbxIngresoR
            // 
            this.gbxIngresoR.Controls.Add(this.btnBuscarCap);
            this.gbxIngresoR.Controls.Add(this.cmbCodigoCap);
            this.gbxIngresoR.Controls.Add(this.btnIngresarCompetencia);
            this.gbxIngresoR.Controls.Add(this.lblCodCap);
            this.gbxIngresoR.Controls.Add(this.txtResultado);
            this.gbxIngresoR.Controls.Add(this.lblResultado);
            this.gbxIngresoR.Location = new System.Drawing.Point(7, 128);
            this.gbxIngresoR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxIngresoR.Name = "gbxIngresoR";
            this.gbxIngresoR.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxIngresoR.Size = new System.Drawing.Size(911, 75);
            this.gbxIngresoR.TabIndex = 7;
            this.gbxIngresoR.TabStop = false;
            this.gbxIngresoR.Text = "Ingreso de Resultados";
            // 
            // btnBuscarCap
            // 
            this.btnBuscarCap.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCap.Location = new System.Drawing.Point(404, 30);
            this.btnBuscarCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCap.Name = "btnBuscarCap";
            this.btnBuscarCap.Size = new System.Drawing.Size(87, 26);
            this.btnBuscarCap.TabIndex = 24;
            this.btnBuscarCap.Text = "Buscar";
            this.btnBuscarCap.UseVisualStyleBackColor = true;
            this.btnBuscarCap.Click += new System.EventHandler(this.btnBuscarCap_Click);
            // 
            // cmbCodigoCap
            // 
            this.cmbCodigoCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoCap.FormattingEnabled = true;
            this.cmbCodigoCap.Location = new System.Drawing.Point(178, 32);
            this.cmbCodigoCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCodigoCap.Name = "cmbCodigoCap";
            this.cmbCodigoCap.Size = new System.Drawing.Size(220, 24);
            this.cmbCodigoCap.TabIndex = 25;
            // 
            // btnIngresarCompetencia
            // 
            this.btnIngresarCompetencia.Location = new System.Drawing.Point(816, 32);
            this.btnIngresarCompetencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIngresarCompetencia.Name = "btnIngresarCompetencia";
            this.btnIngresarCompetencia.Size = new System.Drawing.Size(87, 23);
            this.btnIngresarCompetencia.TabIndex = 4;
            this.btnIngresarCompetencia.Text = "INGRESAR";
            this.btnIngresarCompetencia.UseVisualStyleBackColor = true;
            this.btnIngresarCompetencia.Click += new System.EventHandler(this.btnIngresarCompetencia_Click);
            // 
            // lblCodCap
            // 
            this.lblCodCap.AutoSize = true;
            this.lblCodCap.Location = new System.Drawing.Point(10, 35);
            this.lblCodCap.Name = "lblCodCap";
            this.lblCodCap.Size = new System.Drawing.Size(131, 16);
            this.lblCodCap.TabIndex = 24;
            this.lblCodCap.Text = "Codigo Capacitación";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Location = new System.Drawing.Point(702, 32);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(107, 23);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(533, 35);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(163, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado de Capacitación";
            // 
            // frmEmpCapacitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(962, 442);
            this.Controls.Add(this.tbcCapacitacion);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpCapacitado";
            this.Text = "303 - Capacitaciones";
            this.tbcCapacitacion.ResumeLayout(false);
            this.tbpAsignacion.ResumeLayout(false);
            this.tbpAsignacion.PerformLayout();
            this.gbxDetCap.ResumeLayout(false);
            this.gbxDetCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.gbxDatEmp.ResumeLayout(false);
            this.gbxDatEmp.PerformLayout();
            this.tbpResultados.ResumeLayout(false);
            this.tbpResultados.PerformLayout();
            this.gbxDatEmpR.ResumeLayout(false);
            this.gbxDatEmpR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompIng)).EndInit();
            this.gbxIngresoR.ResumeLayout(false);
            this.gbxIngresoR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCapacitacion;
        private System.Windows.Forms.TabPage tbpAsignacion;
        private System.Windows.Forms.TabPage tbpResultados;
        private System.Windows.Forms.GroupBox gbxDetCap;
        private System.Windows.Forms.Label lblFeFin;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblFeIni;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DateTimePicker dtpFechIni;
        private System.Windows.Forms.DateTimePicker dtpFechFin;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.TextBox txtBusqCodEmp;
        private System.Windows.Forms.Label lblCodEmp;
        private System.Windows.Forms.GroupBox gbxDatEmp;
        private System.Windows.Forms.TextBox txtEstEmp;
        private System.Windows.Forms.TextBox txtDeptEmp;
        private System.Windows.Forms.TextBox txtNombEmp;
        private System.Windows.Forms.Label lblEstao;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Button btnIngresoCurso;
        private System.Windows.Forms.GroupBox gbxDatEmpR;
        private System.Windows.Forms.TextBox txtCapR;
        private System.Windows.Forms.Label lblCapR;
        private System.Windows.Forms.Button btnBuscarR;
        private System.Windows.Forms.TextBox txtCodEmpR;
        private System.Windows.Forms.TextBox txtNombEmpR;
        private System.Windows.Forms.Label lblCodEmpR;
        private System.Windows.Forms.Label lblNombEmpR;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvCompIng;
        private System.Windows.Forms.GroupBox gbxIngresoR;
        private System.Windows.Forms.Button btnIngresarCompetencia;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCodigoEncabezado;
        private System.Windows.Forms.Label lblCodigoC;
        private System.Windows.Forms.TextBox txtCodiCapa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbCodigoCap;
        private System.Windows.Forms.Label lblCodCap;
        private System.Windows.Forms.Button btnBuscarCap;
    }
}
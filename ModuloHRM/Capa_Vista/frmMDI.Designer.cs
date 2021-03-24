namespace Capa_Vista
{
    partial class frmMDI
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
            this.mspMDI = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPuestosMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartamentoMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiposDeCompetenciasMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFaltasMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarFaltaMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCapacitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMantenimientosDeCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleadosProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditarEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAscenderEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDespedirEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReclutamientoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarReclutaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEntrevistaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContratacionProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNominaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarDatosGeneralesDeNominaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeduccionesPercepccionesProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeducciónPercepciónEmpleadoProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiControlDeHorasDíasProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesarrolloProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarCompetenciasProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacionProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresarNuevaCapacitacionProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngresoDeCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHerramientas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeleccionReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleadosReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNominaReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDesarrolloReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompetenciasReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCapacitacionReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.mspMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mspMDI
            // 
            this.mspMDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(74)))), ((int)(((byte)(181)))));
            this.mspMDI.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mspMDI.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mspMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiMantenimientos,
            this.tsmiProcesos,
            this.tsmiHerramientas,
            this.tsmiReportes,
            this.tsmiAyuda});
            this.mspMDI.Location = new System.Drawing.Point(0, 0);
            this.mspMDI.Name = "mspMDI";
            this.mspMDI.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mspMDI.Size = new System.Drawing.Size(731, 24);
            this.mspMDI.TabIndex = 0;
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCerrarSesion});
            this.tsmiInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(48, 20);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.ToolTipText = "Opciones de Sesión";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(150, 22);
            this.tsmiCerrarSesion.Text = "Cerrar Sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // tsmiMantenimientos
            // 
            this.tsmiMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPuestosMantenimientos,
            this.tsmiDepartamentoMantenimientos,
            this.tsmiTiposDeCompetenciasMantenimientos,
            this.tsmiFaltasMantenimientos,
            this.tsmiCapacitacion});
            this.tsmiMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiMantenimientos.Name = "tsmiMantenimientos";
            this.tsmiMantenimientos.Size = new System.Drawing.Size(108, 20);
            this.tsmiMantenimientos.Text = "Mantenimientos";
            this.tsmiMantenimientos.ToolTipText = "Mantenimientos del Módulo";
            // 
            // tsmiPuestosMantenimientos
            // 
            this.tsmiPuestosMantenimientos.Name = "tsmiPuestosMantenimientos";
            this.tsmiPuestosMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiPuestosMantenimientos.Text = "Puestos";
            this.tsmiPuestosMantenimientos.Click += new System.EventHandler(this.tsmiPuestosMantenimientos_Click);
            // 
            // tsmiDepartamentoMantenimientos
            // 
            this.tsmiDepartamentoMantenimientos.Name = "tsmiDepartamentoMantenimientos";
            this.tsmiDepartamentoMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiDepartamentoMantenimientos.Text = "Departamentos Empresariales";
            this.tsmiDepartamentoMantenimientos.Click += new System.EventHandler(this.tsmiDepartamentoMantenimientos_Click);
            // 
            // tsmiTiposDeCompetenciasMantenimientos
            // 
            this.tsmiTiposDeCompetenciasMantenimientos.Name = "tsmiTiposDeCompetenciasMantenimientos";
            this.tsmiTiposDeCompetenciasMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiTiposDeCompetenciasMantenimientos.Text = "Tipos De Competencias";
            this.tsmiTiposDeCompetenciasMantenimientos.Click += new System.EventHandler(this.tsmiTiposDeCompetenciasMantenimientos_Click);
            // 
            // tsmiFaltasMantenimientos
            // 
            this.tsmiFaltasMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarFaltaMantenimientos});
            this.tsmiFaltasMantenimientos.Name = "tsmiFaltasMantenimientos";
            this.tsmiFaltasMantenimientos.Size = new System.Drawing.Size(243, 22);
            this.tsmiFaltasMantenimientos.Text = "Faltas";
            // 
            // tsmiIngresarFaltaMantenimientos
            // 
            this.tsmiIngresarFaltaMantenimientos.Name = "tsmiIngresarFaltaMantenimientos";
            this.tsmiIngresarFaltaMantenimientos.Size = new System.Drawing.Size(150, 22);
            this.tsmiIngresarFaltaMantenimientos.Text = "Ingresar Falta";
            this.tsmiIngresarFaltaMantenimientos.Click += new System.EventHandler(this.tsmiIngresarFaltaMantenimientos_Click);
            // 
            // tsmiCapacitacion
            // 
            this.tsmiCapacitacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMantenimientosDeCapacitaciones,
            this.tsmiMantenimientosDeCursos});
            this.tsmiCapacitacion.Name = "tsmiCapacitacion";
            this.tsmiCapacitacion.Size = new System.Drawing.Size(243, 22);
            this.tsmiCapacitacion.Text = "Capacitación";
            // 
            // tsmiMantenimientosDeCapacitaciones
            // 
            this.tsmiMantenimientosDeCapacitaciones.Name = "tsmiMantenimientosDeCapacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Size = new System.Drawing.Size(268, 22);
            this.tsmiMantenimientosDeCapacitaciones.Text = "Mantenimientos de Capacitaciones";
            this.tsmiMantenimientosDeCapacitaciones.Click += new System.EventHandler(this.tsmiMantenimientosDeCapacitaciones_Click);
            // 
            // tsmiMantenimientosDeCursos
            // 
            this.tsmiMantenimientosDeCursos.Name = "tsmiMantenimientosDeCursos";
            this.tsmiMantenimientosDeCursos.Size = new System.Drawing.Size(268, 22);
            this.tsmiMantenimientosDeCursos.Text = "Mantenimientos de Cursos";
            this.tsmiMantenimientosDeCursos.Click += new System.EventHandler(this.tsmiMantenimientosDeCursos_Click);
            // 
            // tsmiProcesos
            // 
            this.tsmiProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleadosProceso,
            this.tsmiReclutamientoProceso,
            this.tsmiEntrevistaProceso,
            this.tsmiContratacionProceso,
            this.tsmiNominaProceso,
            this.tsmiDesarrolloProceso,
            this.tsmiCapacitacionProceso});
            this.tsmiProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiProcesos.Name = "tsmiProcesos";
            this.tsmiProcesos.Size = new System.Drawing.Size(70, 20);
            this.tsmiProcesos.Text = "Procesos";
            // 
            // tsmiEmpleadosProceso
            // 
            this.tsmiEmpleadosProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditarEmpleadoProceso,
            this.tsmiAscenderEmpleadoProceso,
            this.tsmiDespedirEmpleadoProceso});
            this.tsmiEmpleadosProceso.Name = "tsmiEmpleadosProceso";
            this.tsmiEmpleadosProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiEmpleadosProceso.Text = "Empleados";
            // 
            // tsmiEditarEmpleadoProceso
            // 
            this.tsmiEditarEmpleadoProceso.Name = "tsmiEditarEmpleadoProceso";
            this.tsmiEditarEmpleadoProceso.Size = new System.Drawing.Size(188, 22);
            this.tsmiEditarEmpleadoProceso.Text = "Editar Empleado";
            this.tsmiEditarEmpleadoProceso.Click += new System.EventHandler(this.tsmiEditarEmpleadoProceso_Click);
            // 
            // tsmiAscenderEmpleadoProceso
            // 
            this.tsmiAscenderEmpleadoProceso.Name = "tsmiAscenderEmpleadoProceso";
            this.tsmiAscenderEmpleadoProceso.Size = new System.Drawing.Size(188, 22);
            this.tsmiAscenderEmpleadoProceso.Text = "Ascender Empleado";
            this.tsmiAscenderEmpleadoProceso.Click += new System.EventHandler(this.tsmiAscenderEmpleadoProceso_Click);
            // 
            // tsmiDespedirEmpleadoProceso
            // 
            this.tsmiDespedirEmpleadoProceso.Name = "tsmiDespedirEmpleadoProceso";
            this.tsmiDespedirEmpleadoProceso.Size = new System.Drawing.Size(188, 22);
            this.tsmiDespedirEmpleadoProceso.Text = "Despedir Empleado";
            this.tsmiDespedirEmpleadoProceso.Click += new System.EventHandler(this.tsmiDespedirEmpleadoProceso_Click);
            // 
            // tsmiReclutamientoProceso
            // 
            this.tsmiReclutamientoProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarReclutaProceso});
            this.tsmiReclutamientoProceso.Name = "tsmiReclutamientoProceso";
            this.tsmiReclutamientoProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiReclutamientoProceso.Text = "Reclutamiento";
            // 
            // tsmiIngresarReclutaProceso
            // 
            this.tsmiIngresarReclutaProceso.Name = "tsmiIngresarReclutaProceso";
            this.tsmiIngresarReclutaProceso.Size = new System.Drawing.Size(218, 22);
            this.tsmiIngresarReclutaProceso.Text = "Ingresar/Editar Reclutado";
            this.tsmiIngresarReclutaProceso.Click += new System.EventHandler(this.tsmiIngresarReclutaProceso_Click);
            // 
            // tsmiEntrevistaProceso
            // 
            this.tsmiEntrevistaProceso.Name = "tsmiEntrevistaProceso";
            this.tsmiEntrevistaProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiEntrevistaProceso.Text = "Entrevista";
            this.tsmiEntrevistaProceso.Click += new System.EventHandler(this.tsmiEntrevistaProceso_Click);
            // 
            // tsmiContratacionProceso
            // 
            this.tsmiContratacionProceso.Name = "tsmiContratacionProceso";
            this.tsmiContratacionProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiContratacionProceso.Text = "Contratación";
            this.tsmiContratacionProceso.Click += new System.EventHandler(this.tsmiContratacionProceso_Click);
            // 
            // tsmiNominaProceso
            // 
            this.tsmiNominaProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarDatosGeneralesDeNominaProceso,
            this.tsmiDeduccionesPercepccionesProceso,
            this.tsmiDeducciónPercepciónEmpleadoProceso,
            this.tsmiControlDeHorasDíasProceso});
            this.tsmiNominaProceso.Name = "tsmiNominaProceso";
            this.tsmiNominaProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiNominaProceso.Text = "Nómina";
            // 
            // tsmiBuscarDatosGeneralesDeNominaProceso
            // 
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Name = "tsmiBuscarDatosGeneralesDeNominaProceso";
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Size = new System.Drawing.Size(270, 22);
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Text = "Buscar Datos Generales de Nómina";
            this.tsmiBuscarDatosGeneralesDeNominaProceso.Click += new System.EventHandler(this.tsmiBuscarDatosGeneralesDeNominaProceso_Click);
            // 
            // tsmiDeduccionesPercepccionesProceso
            // 
            this.tsmiDeduccionesPercepccionesProceso.Name = "tsmiDeduccionesPercepccionesProceso";
            this.tsmiDeduccionesPercepccionesProceso.Size = new System.Drawing.Size(270, 22);
            this.tsmiDeduccionesPercepccionesProceso.Text = "Deducciones / Percepcciones";
            this.tsmiDeduccionesPercepccionesProceso.Click += new System.EventHandler(this.tsmiDeduccionesPercepccionesProceso_Click);
            // 
            // tsmiDeducciónPercepciónEmpleadoProceso
            // 
            this.tsmiDeducciónPercepciónEmpleadoProceso.Name = "tsmiDeducciónPercepciónEmpleadoProceso";
            this.tsmiDeducciónPercepciónEmpleadoProceso.Size = new System.Drawing.Size(270, 22);
            this.tsmiDeducciónPercepciónEmpleadoProceso.Text = "Deducción / Percepción Empleado";
            this.tsmiDeducciónPercepciónEmpleadoProceso.Click += new System.EventHandler(this.tsmiDeducciónPercepciónEmpleadoProceso_Click);
            // 
            // tsmiControlDeHorasDíasProceso
            // 
            this.tsmiControlDeHorasDíasProceso.Name = "tsmiControlDeHorasDíasProceso";
            this.tsmiControlDeHorasDíasProceso.Size = new System.Drawing.Size(270, 22);
            this.tsmiControlDeHorasDíasProceso.Text = "Control de Horas / Días";
            this.tsmiControlDeHorasDíasProceso.Click += new System.EventHandler(this.tsmiControlDeHorasDíasProceso_Click);
            // 
            // tsmiDesarrolloProceso
            // 
            this.tsmiDesarrolloProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarCompetenciasProceso});
            this.tsmiDesarrolloProceso.Name = "tsmiDesarrolloProceso";
            this.tsmiDesarrolloProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiDesarrolloProceso.Text = "Desarrollo";
            // 
            // tsmiIngresarCompetenciasProceso
            // 
            this.tsmiIngresarCompetenciasProceso.Name = "tsmiIngresarCompetenciasProceso";
            this.tsmiIngresarCompetenciasProceso.Size = new System.Drawing.Size(204, 22);
            this.tsmiIngresarCompetenciasProceso.Text = "Ingresar Competencias";
            this.tsmiIngresarCompetenciasProceso.Click += new System.EventHandler(this.tsmiIngresarCompetenciasProceso_Click);
            // 
            // tsmiCapacitacionProceso
            // 
            this.tsmiCapacitacionProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngresarNuevaCapacitacionProceso,
            this.tsmiIngresoDeCursos});
            this.tsmiCapacitacionProceso.Name = "tsmiCapacitacionProceso";
            this.tsmiCapacitacionProceso.Size = new System.Drawing.Size(152, 22);
            this.tsmiCapacitacionProceso.Text = "Capacitación";
            // 
            // tsmiIngresarNuevaCapacitacionProceso
            // 
            this.tsmiIngresarNuevaCapacitacionProceso.Name = "tsmiIngresarNuevaCapacitacionProceso";
            this.tsmiIngresarNuevaCapacitacionProceso.Size = new System.Drawing.Size(234, 22);
            this.tsmiIngresarNuevaCapacitacionProceso.Text = "Ingresar Nueva Capacitación";
            this.tsmiIngresarNuevaCapacitacionProceso.Click += new System.EventHandler(this.tsmiIngresarNuevaCapacitacionProceso_Click);
            // 
            // tsmiIngresoDeCursos
            // 
            this.tsmiIngresoDeCursos.Name = "tsmiIngresoDeCursos";
            this.tsmiIngresoDeCursos.Size = new System.Drawing.Size(234, 22);
            this.tsmiIngresoDeCursos.Text = "Ingreso de Cursos";
            this.tsmiIngresoDeCursos.Click += new System.EventHandler(this.tsmiIngresoDeCursos_Click);
            // 
            // tsmiHerramientas
            // 
            this.tsmiHerramientas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiHerramientas.Name = "tsmiHerramientas";
            this.tsmiHerramientas.Size = new System.Drawing.Size(94, 20);
            this.tsmiHerramientas.Text = "Herramientas";
            // 
            // tsmiReportes
            // 
            this.tsmiReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeleccionReporte,
            this.tsmiNominaReporte,
            this.tsmiDesarrolloReporte,
            this.tsmiCapacitacionReporte});
            this.tsmiReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsmiReportes.Name = "tsmiReportes";
            this.tsmiReportes.Size = new System.Drawing.Size(70, 20);
            this.tsmiReportes.Text = "Reportes";
            // 
            // tsmiSeleccionReporte
            // 
            this.tsmiSeleccionReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEmpleadosReporte});
            this.tsmiSeleccionReporte.Name = "tsmiSeleccionReporte";
            this.tsmiSeleccionReporte.Size = new System.Drawing.Size(180, 22);
            this.tsmiSeleccionReporte.Text = "Selección";
            // 
            // tsmiEmpleadosReporte
            // 
            this.tsmiEmpleadosReporte.Name = "tsmiEmpleadosReporte";
            this.tsmiEmpleadosReporte.Size = new System.Drawing.Size(137, 22);
            this.tsmiEmpleadosReporte.Text = "Empleados";
            this.tsmiEmpleadosReporte.Click += new System.EventHandler(this.tsmiEmpleadosReporte_Click);
            // 
            // tsmiNominaReporte
            // 
            this.tsmiNominaReporte.Name = "tsmiNominaReporte";
            this.tsmiNominaReporte.Size = new System.Drawing.Size(180, 22);
            this.tsmiNominaReporte.Text = "Nómina";
            this.tsmiNominaReporte.Click += new System.EventHandler(this.tsmiNominaReporte_Click);
            // 
            // tsmiDesarrolloReporte
            // 
            this.tsmiDesarrolloReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompetenciasReporte});
            this.tsmiDesarrolloReporte.Name = "tsmiDesarrolloReporte";
            this.tsmiDesarrolloReporte.Size = new System.Drawing.Size(180, 22);
            this.tsmiDesarrolloReporte.Text = "Desarrollo";
            // 
            // tsmiCompetenciasReporte
            // 
            this.tsmiCompetenciasReporte.Name = "tsmiCompetenciasReporte";
            this.tsmiCompetenciasReporte.Size = new System.Drawing.Size(154, 22);
            this.tsmiCompetenciasReporte.Text = "Competencias";
            this.tsmiCompetenciasReporte.Click += new System.EventHandler(this.tsmiCompetenciasReporte_Click);
            // 
            // tsmiCapacitacionReporte
            // 
            this.tsmiCapacitacionReporte.Name = "tsmiCapacitacionReporte";
            this.tsmiCapacitacionReporte.Size = new System.Drawing.Size(180, 22);
            this.tsmiCapacitacionReporte.Text = "Capacitación";
            this.tsmiCapacitacionReporte.Click += new System.EventHandler(this.tsmiCapacitacionReporte_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(55, 20);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(0, 410);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(731, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(31)))), ((int)(((byte)(70)))));
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 24);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(731, 406);
            this.pnlContenedor.TabIndex = 1;
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 430);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.mspMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mspMDI;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "301 - Módulo de Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mspMDI.ResumeLayout(false);
            this.mspMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mspMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcesos;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmiHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmiReclutamientoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiNominaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesarrolloProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarCompetenciasProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacionProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeleccionReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleadosReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiNominaReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiDesarrolloReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompetenciasReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacionReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeduccionesPercepccionesProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiPuestosMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartamentoMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarNuevaCapacitacionProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarReclutaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiposDeCompetenciasMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaltasMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresarFaltaMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleadosProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditarEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiAscenderEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDespedirEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntrevistaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiContratacionProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarDatosGeneralesDeNominaProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeducciónPercepciónEmpleadoProceso;
        private System.Windows.Forms.ToolStripMenuItem tsmiControlDeHorasDíasProceso;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiCapacitacion;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCapacitaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiMantenimientosDeCursos;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngresoDeCursos;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}
namespace Capa_Vista.Vista_Capacitacion
{
    partial class frmIngresoCurso
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer tmrDGVCurso;
            this.gbxCursos = new System.Windows.Forms.GroupBox();
            this.btnAgregarCap = new System.Windows.Forms.Button();
            this.lsvInfoCap = new System.Windows.Forms.ListView();
            this.clmhCodigoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCursoCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmhCapacitador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            tmrDGVCurso = new System.Windows.Forms.Timer(this.components);
            this.gbxCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDGVCurso
            // 
            tmrDGVCurso.Enabled = true;
            tmrDGVCurso.Interval = 5000;
            tmrDGVCurso.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbxCursos
            // 
            this.gbxCursos.Controls.Add(this.btnAgregarCap);
            this.gbxCursos.Controls.Add(this.lsvInfoCap);
            this.gbxCursos.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCursos.Location = new System.Drawing.Point(14, 15);
            this.gbxCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCursos.Name = "gbxCursos";
            this.gbxCursos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCursos.Size = new System.Drawing.Size(639, 394);
            this.gbxCursos.TabIndex = 0;
            this.gbxCursos.TabStop = false;
            this.gbxCursos.Text = "Cursos";
            // 
            // btnAgregarCap
            // 
            this.btnAgregarCap.Location = new System.Drawing.Point(547, 357);
            this.btnAgregarCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarCap.Name = "btnAgregarCap";
            this.btnAgregarCap.Size = new System.Drawing.Size(83, 28);
            this.btnAgregarCap.TabIndex = 1;
            this.btnAgregarCap.Text = "Cursos";
            this.btnAgregarCap.UseVisualStyleBackColor = true;
            this.btnAgregarCap.Click += new System.EventHandler(this.btnAgregarCap_Click);
            // 
            // lsvInfoCap
            // 
            this.lsvInfoCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmhCodigoCap,
            this.clmhCursoCap,
            this.clmhCapacitador});
            this.lsvInfoCap.HideSelection = false;
            this.lsvInfoCap.Location = new System.Drawing.Point(7, 27);
            this.lsvInfoCap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvInfoCap.Name = "lsvInfoCap";
            this.lsvInfoCap.Size = new System.Drawing.Size(622, 322);
            this.lsvInfoCap.TabIndex = 0;
            this.lsvInfoCap.UseCompatibleStateImageBehavior = false;
            this.lsvInfoCap.View = System.Windows.Forms.View.Details;
            // 
            // clmhCodigoCap
            // 
            this.clmhCodigoCap.Text = "Codigo";
            this.clmhCodigoCap.Width = 67;
            // 
            // clmhCursoCap
            // 
            this.clmhCursoCap.Text = "Curso";
            this.clmhCursoCap.Width = 165;
            // 
            // clmhCapacitador
            // 
            this.clmhCapacitador.Text = "Capacitador";
            this.clmhCapacitador.Width = 263;
            // 
            // frmIngresoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.gbxCursos);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresoCurso";
            this.Text = "304 - Ingreso Cursos";
            this.gbxCursos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCursos;
        private System.Windows.Forms.ListView lsvInfoCap;
        private System.Windows.Forms.Button btnAgregarCap;
        private System.Windows.Forms.ColumnHeader clmhCodigoCap;
        private System.Windows.Forms.ColumnHeader clmhCursoCap;
        private System.Windows.Forms.ColumnHeader clmhCapacitador;
    }
}
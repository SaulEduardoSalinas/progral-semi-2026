namespace Parcial2_2
{
    partial class frmPrincipal
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

        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ssPrincipal = new System.Windows.Forms.StatusStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAplicaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.ssPrincipal.SuspendLayout();
            this.SuspendLayout();

            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuAplicaciones});
            this.mnuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.mnuPrincipal.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.mnuPrincipal.Size = new System.Drawing.Size(1000, 31);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Name = "mnuPrincipal";

            this.ssPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSesion,
            this.tslReloj});
            this.ssPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.ssPrincipal.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssPrincipal.Location = new System.Drawing.Point(0, 596);
            this.ssPrincipal.Size = new System.Drawing.Size(1000, 24);
            this.ssPrincipal.SizingGrip = false;
            this.ssPrincipal.TabIndex = 1;
            this.ssPrincipal.Name = "ssPrincipal";

            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCerrarSesion,
            this.mnuSeparador1,
            this.mnuSalir});
            this.mnuArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuArchivo.Text = "&Archivo";
            this.mnuArchivo.Name = "mnuArchivo";

            this.mnuCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuCerrarSesion.Text = "Cerrar sesión";
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Click += new System.EventHandler(this.mnuCerrarSesion_Click);

            this.mnuSeparador1.Name = "mnuSeparador1";

            this.mnuSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);

            this.mnuAplicaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlumnos,
            this.mnuDocentes,
            this.mnuMaterias,
            this.mnuPeriodos,
            this.mnuNotas,
            this.mnuSeparador2,
            this.mnuUsuarios});
            this.mnuAplicaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuAplicaciones.Text = "A&plicaciones";
            this.mnuAplicaciones.Name = "mnuAplicaciones";

            this.mnuAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuAlumnos.Text = "Alumnos";
            this.mnuAlumnos.Name = "mnuAlumnos";
            this.mnuAlumnos.Click += new System.EventHandler(this.abrirOpcion_Click);

            this.mnuMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Click += new System.EventHandler(this.abrirOpcion_Click);

            this.mnuPeriodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuPeriodos.Text = "Períodos";
            this.mnuPeriodos.Name = "mnuPeriodos";
            this.mnuPeriodos.Click += new System.EventHandler(this.abrirOpcion_Click);

            this.mnuNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuNotas.Text = "Notas";
            this.mnuNotas.Name = "mnuNotas";
            this.mnuNotas.Click += new System.EventHandler(this.abrirOpcion_Click);

            this.mnuUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.abrirOpcion_Click);

            this.mnuDocentes.Enabled = false;
            this.mnuDocentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(132)))));
            this.mnuDocentes.Text = "Docentes (sin formulario)";
            this.mnuDocentes.Name = "mnuDocentes";

            this.mnuSeparador2.Name = "mnuSeparador2";

            this.tslSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.tslSesion.Text = "Sesión";
            this.tslSesion.Name = "tslSesion";

            this.tslReloj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.tslReloj.Spring = true;
            this.tslReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslReloj.Name = "tslReloj";

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.ssPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Académico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ssPrincipal.ResumeLayout(false);
            this.ssPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.StatusStrip ssPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator mnuSeparador1;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAplicaciones;
        private System.Windows.Forms.ToolStripMenuItem mnuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuPeriodos;
        private System.Windows.Forms.ToolStripMenuItem mnuNotas;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuDocentes;
        private System.Windows.Forms.ToolStripSeparator mnuSeparador2;
        private System.Windows.Forms.ToolStripStatusLabel tslSesion;
        private System.Windows.Forms.ToolStripStatusLabel tslReloj;
    }
}

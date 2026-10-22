namespace Parcial2_2
{
    partial class frmNotas
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
            System.Windows.Forms.DataGridViewCellStyle estiloAlterno = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaPeriodo = new System.Windows.Forms.Label();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.colAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLab1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLab2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(1000, 72);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 12);
            this.lblTitulo.Text = "Notas";
            this.lblTitulo.Name = "lblTitulo";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Text = "Edita LAB 1, LAB 2 y PARCIAL · la NF se recalcula al instante";
            this.lblSubtitulo.Name = "lblSubtitulo";

            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblMateria.Location = new System.Drawing.Point(24, 90);
            this.lblMateria.Text = "MATERIA";
            this.lblMateria.Name = "lblMateria";

            this.cboMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMateria.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.cboMateria.Location = new System.Drawing.Point(24, 110);
            this.cboMateria.Size = new System.Drawing.Size(320, 25);
            this.cboMateria.TabIndex = 1;
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.SelectedIndexChanged += new System.EventHandler(this.filtro_Changed);

            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblPeriodo.Location = new System.Drawing.Point(360, 90);
            this.lblPeriodo.Text = "PERÍODO";
            this.lblPeriodo.Name = "lblPeriodo";

            this.cboPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.cboPeriodo.Location = new System.Drawing.Point(360, 110);
            this.cboPeriodo.Size = new System.Drawing.Size(200, 25);
            this.cboPeriodo.TabIndex = 2;
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.SelectedIndexChanged += new System.EventHandler(this.filtro_Changed);

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblFecha.Location = new System.Drawing.Point(576, 90);
            this.lblFecha.Text = "INICIO DEL PERÍODO";
            this.lblFecha.Name = "lblFecha";

            this.lblFechaPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.lblFechaPeriodo.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblFechaPeriodo.Location = new System.Drawing.Point(576, 110);
            this.lblFechaPeriodo.Size = new System.Drawing.Size(200, 27);
            this.lblFechaPeriodo.Text = "—";
            this.lblFechaPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFechaPeriodo.Name = "lblFechaPeriodo";

            estiloAlterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            estiloEncabezado.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            estiloEncabezado.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloEncabezado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(200)))));
            estiloEncabezado.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            estiloEncabezado.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            estiloEncabezado.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(186)))), ((int)(((byte)(200)))));
            estiloEncabezado.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            estiloCelda.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            estiloCelda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            estiloCelda.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estiloCelda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            estiloCelda.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            estiloCelda.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            estiloCelda.SelectionForeColor = System.Drawing.Color.White;
            estiloCelda.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAlumno,
            this.colLab1,
            this.colLab2,
            this.colParcial,
            this.colNF});
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToResizeRows = false;
            this.dgvNotas.AlternatingRowsDefaultCellStyle = estiloAlterno;
            this.dgvNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dgvNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNotas.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            this.dgvNotas.ColumnHeadersHeight = 36;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNotas.DefaultCellStyle = estiloCelda;
            this.dgvNotas.EnableHeadersVisualStyles = false;
            this.dgvNotas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.dgvNotas.Location = new System.Drawing.Point(24, 150);
            this.dgvNotas.MultiSelect = false;
            this.dgvNotas.RowHeadersVisible = false;
            this.dgvNotas.Size = new System.Drawing.Size(952, 330);
            this.dgvNotas.TabIndex = 30;
            this.dgvNotas.RowTemplate.Height = 32;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvNotas_CellValidating);
            this.dgvNotas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotas_CellEndEdit);
            this.dgvNotas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNotas_DataError);

            this.colAlumno.DataPropertyName = "nombre";
            this.colAlumno.HeaderText = "Alumno";
            this.colAlumno.Name = "colAlumno";
            this.colAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAlumno.ReadOnly = true;

            this.colLab1.DataPropertyName = "lab1";
            this.colLab1.HeaderText = "LAB 1 · 30 %";
            this.colLab1.Name = "colLab1";
            this.colLab1.Width = 130;
            this.colLab1.DefaultCellStyle.Format = "N2";

            this.colLab2.DataPropertyName = "lab2";
            this.colLab2.HeaderText = "LAB 2 · 30 %";
            this.colLab2.Name = "colLab2";
            this.colLab2.Width = 130;
            this.colLab2.DefaultCellStyle.Format = "N2";

            this.colParcial.DataPropertyName = "parcial";
            this.colParcial.HeaderText = "PARCIAL · 40 %";
            this.colParcial.Name = "colParcial";
            this.colParcial.Width = 140;
            this.colParcial.DefaultCellStyle.Format = "N2";

            this.colNF.DataPropertyName = "nf";
            this.colNF.HeaderText = "NF";
            this.colNF.Name = "colNF";
            this.colNF.Width = 100;
            this.colNF.ReadOnly = true;
            this.colNF.DefaultCellStyle.Format = "N2";
            this.colNF.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.colNF.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblResumen.Location = new System.Drawing.Point(24, 494);
            this.lblResumen.Text = "Promedio NF: —";
            this.lblResumen.Name = "lblResumen";

            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblMensaje.Location = new System.Drawing.Point(24, 524);
            this.lblMensaje.Size = new System.Drawing.Size(700, 24);
            this.lblMensaje.Text = "";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensaje.Name = "lblMensaje";

            this.btnDescartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(74)))), ((int)(((byte)(90)))));
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartar.ForeColor = System.Drawing.Color.White;
            this.btnDescartar.Location = new System.Drawing.Point(752, 494);
            this.btnDescartar.Size = new System.Drawing.Size(108, 38);
            this.btnDescartar.TabIndex = 5;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = false;
            this.btnDescartar.FlatAppearance.BorderSize = 0;
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);

            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(164)))), ((int)(((byte)(108)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(868, 494);
            this.btnGuardar.Size = new System.Drawing.Size(108, 38);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 572);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.lblFechaPeriodo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas";
            this.Name = "frmNotas";
            this.Load += new System.EventHandler(this.frmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaPeriodo;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNF;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnGuardar;
    }
}

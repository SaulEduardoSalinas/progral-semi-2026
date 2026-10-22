namespace Parcial2_2
{
    partial class frmPeriodos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle estiloAlterno = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle estiloCelda = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.bnPeriodos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnPrimero = new System.Windows.Forms.ToolStripButton();
            this.bnAnterior = new System.Windows.Forms.ToolStripButton();
            this.bnPosicion = new System.Windows.Forms.ToolStripTextBox();
            this.bnTotal = new System.Windows.Forms.ToolStripLabel();
            this.bnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.bnUltimo = new System.Windows.Forms.ToolStripButton();
            this.bnSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.bnAgregar = new System.Windows.Forms.ToolStripButton();
            this.bnEliminar = new System.Windows.Forms.ToolStripButton();
            this.bnGuardar = new System.Windows.Forms.ToolStripButton();
            this.bnDescartar = new System.Windows.Forms.ToolStripButton();
            this.pnlFicha = new System.Windows.Forms.Panel();
            this.lblFicha = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvPeriodos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.bsPeriodos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeriodos)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.bnPeriodos.SuspendLayout();
            this.pnlFicha.SuspendLayout();
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
            this.lblTitulo.Text = "Períodos";
            this.lblTitulo.Name = "lblTitulo";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 46);
            this.lblSubtitulo.Text = "Ciclos académicos · los cambios se envían al pulsar Guardar";
            this.lblSubtitulo.Name = "lblSubtitulo";

            this.bnPeriodos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnPrimero,
            this.bnAnterior,
            this.bnPosicion,
            this.bnTotal,
            this.bnSiguiente,
            this.bnUltimo,
            this.bnSeparador,
            this.bnAgregar,
            this.bnEliminar,
            this.bnGuardar,
            this.bnDescartar});
            this.bnPeriodos.AddNewItem = this.bnAgregar;
            this.bnPeriodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.bnPeriodos.BindingSource = this.bsPeriodos;
            this.bnPeriodos.CountItem = this.bnTotal;
            this.bnPeriodos.CountItemFormat = "/ {0}";
            this.bnPeriodos.DeleteItem = null;
            this.bnPeriodos.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPeriodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnPeriodos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnPeriodos.Location = new System.Drawing.Point(0, 72);
            this.bnPeriodos.MoveFirstItem = this.bnPrimero;
            this.bnPeriodos.MoveLastItem = this.bnUltimo;
            this.bnPeriodos.MoveNextItem = this.bnSiguiente;
            this.bnPeriodos.MovePreviousItem = this.bnAnterior;
            this.bnPeriodos.Padding = new System.Windows.Forms.Padding(18, 4, 0, 4);
            this.bnPeriodos.PositionItem = this.bnPosicion;
            this.bnPeriodos.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnPeriodos.Size = new System.Drawing.Size(1000, 33);
            this.bnPeriodos.TabIndex = 1;
            this.bnPeriodos.Name = "bnPeriodos";

            this.bnPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnPrimero.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnPrimero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnPrimero.Text = "«";
            this.bnPrimero.Name = "bnPrimero";

            this.bnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnAnterior.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnAnterior.Text = "‹";
            this.bnAnterior.Name = "bnAnterior";

            this.bnPosicion.AutoSize = false;
            this.bnPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.bnPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnPosicion.Size = new System.Drawing.Size(36, 25);
            this.bnPosicion.Text = "0";
            this.bnPosicion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bnPosicion.Name = "bnPosicion";

            this.bnTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.bnTotal.Text = "/ {0}";
            this.bnTotal.Name = "bnTotal";

            this.bnSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnSiguiente.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnSiguiente.Text = "›";
            this.bnSiguiente.Name = "bnSiguiente";

            this.bnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnUltimo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnUltimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.bnUltimo.Text = "»";
            this.bnUltimo.Name = "bnUltimo";

            this.bnSeparador.Name = "bnSeparador";

            this.bnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.bnAgregar.Text = "+ Agregar";
            this.bnAgregar.Name = "bnAgregar";

            this.bnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);

            this.bnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnGuardar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(210)))), ((int)(((byte)(140)))));
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);

            this.bnDescartar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bnDescartar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.bnDescartar.Text = "Descartar";
            this.bnDescartar.Name = "bnDescartar";
            this.bnDescartar.Click += new System.EventHandler(this.bnDescartar_Click);

            this.pnlFicha.Controls.Add(this.dtpFecha);
            this.pnlFicha.Controls.Add(this.lblFecha);
            this.pnlFicha.Controls.Add(this.txtPeriodo);
            this.pnlFicha.Controls.Add(this.lblPeriodo);
            this.pnlFicha.Controls.Add(this.lblIdValor);
            this.pnlFicha.Controls.Add(this.lblId);
            this.pnlFicha.Controls.Add(this.lblFicha);
            this.pnlFicha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.pnlFicha.Location = new System.Drawing.Point(24, 124);
            this.pnlFicha.Size = new System.Drawing.Size(340, 230);
            this.pnlFicha.TabIndex = 1;
            this.pnlFicha.Name = "pnlFicha";

            this.lblFicha.AutoSize = true;
            this.lblFicha.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lblFicha.Location = new System.Drawing.Point(14, 14);
            this.lblFicha.Text = "PERÍODO SELECCIONADO";
            this.lblFicha.Name = "lblFicha";

            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblId.Location = new System.Drawing.Point(14, 44);
            this.lblId.Text = "ID";
            this.lblId.Name = "lblId";

            this.lblIdValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.lblIdValor.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblIdValor.Location = new System.Drawing.Point(16, 64);
            this.lblIdValor.Size = new System.Drawing.Size(90, 25);
            this.lblIdValor.Text = "";
            this.lblIdValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIdValor.Name = "lblIdValor";

            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblPeriodo.Location = new System.Drawing.Point(14, 104);
            this.lblPeriodo.Text = "Nombre del período";
            this.lblPeriodo.Name = "lblPeriodo";

            this.txtPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeriodo.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.txtPeriodo.Location = new System.Drawing.Point(16, 124);
            this.txtPeriodo.Size = new System.Drawing.Size(308, 25);
            this.txtPeriodo.TabIndex = 0;
            this.txtPeriodo.MaxLength = 30;
            this.txtPeriodo.Name = "txtPeriodo";

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.lblFecha.Location = new System.Drawing.Point(14, 164);
            this.lblFecha.Text = "Fecha de inicio";
            this.lblFecha.Name = "lblFecha";

            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
            this.dtpFecha.Font = new System.Drawing.Font("Bahnschrift", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFecha.Location = new System.Drawing.Point(16, 184);
            this.dtpFecha.Size = new System.Drawing.Size(308, 25);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Name = "dtpFecha";

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
            this.dgvPeriodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colPeriodo,
            this.colFecha});
            this.dgvPeriodos.AllowUserToAddRows = false;
            this.dgvPeriodos.AllowUserToDeleteRows = false;
            this.dgvPeriodos.AllowUserToResizeRows = false;
            this.dgvPeriodos.AlternatingRowsDefaultCellStyle = estiloAlterno;
            this.dgvPeriodos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.dgvPeriodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPeriodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPeriodos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeriodos.ColumnHeadersDefaultCellStyle = estiloEncabezado;
            this.dgvPeriodos.ColumnHeadersHeight = 36;
            this.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPeriodos.DefaultCellStyle = estiloCelda;
            this.dgvPeriodos.EnableHeadersVisualStyles = false;
            this.dgvPeriodos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.dgvPeriodos.Location = new System.Drawing.Point(384, 124);
            this.dgvPeriodos.MultiSelect = false;
            this.dgvPeriodos.RowHeadersVisible = false;
            this.dgvPeriodos.Size = new System.Drawing.Size(592, 230);
            this.dgvPeriodos.TabIndex = 30;
            this.dgvPeriodos.RowTemplate.Height = 32;
            this.dgvPeriodos.ReadOnly = true;
            this.dgvPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeriodos.TabStop = false;
            this.dgvPeriodos.Name = "dgvPeriodos";

            this.colId.DataPropertyName = "idPeriodo";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Width = 60;

            this.colPeriodo.DataPropertyName = "periodo";
            this.colPeriodo.HeaderText = "Período";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            this.colFecha.DataPropertyName = "fecha";
            this.colFecha.HeaderText = "Inicio";
            this.colFecha.Name = "colFecha";
            this.colFecha.Width = 140;
            this.colFecha.DefaultCellStyle.Format = "d";

            this.lblMensaje.AutoEllipsis = true;
            this.lblMensaje.Font = new System.Drawing.Font("Bahnschrift", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.lblMensaje.Location = new System.Drawing.Point(24, 370);
            this.lblMensaje.Size = new System.Drawing.Size(952, 24);
            this.lblMensaje.Text = "";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensaje.Name = "lblMensaje";

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 424);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvPeriodos);
            this.Controls.Add(this.pnlFicha);
            this.Controls.Add(this.bnPeriodos);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Períodos";
            this.Name = "frmPeriodos";
            this.Load += new System.EventHandler(this.frmPeriodos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeriodos)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.bnPeriodos.ResumeLayout(false);
            this.bnPeriodos.PerformLayout();
            this.pnlFicha.ResumeLayout(false);
            this.pnlFicha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.BindingNavigator bnPeriodos;
        private System.Windows.Forms.ToolStripButton bnPrimero;
        private System.Windows.Forms.ToolStripButton bnAnterior;
        private System.Windows.Forms.ToolStripTextBox bnPosicion;
        private System.Windows.Forms.ToolStripLabel bnTotal;
        private System.Windows.Forms.ToolStripButton bnSiguiente;
        private System.Windows.Forms.ToolStripButton bnUltimo;
        private System.Windows.Forms.ToolStripSeparator bnSeparador;
        private System.Windows.Forms.ToolStripButton bnAgregar;
        private System.Windows.Forms.ToolStripButton bnEliminar;
        private System.Windows.Forms.ToolStripButton bnGuardar;
        private System.Windows.Forms.ToolStripButton bnDescartar;
        private System.Windows.Forms.Panel pnlFicha;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvPeriodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.BindingSource bsPeriodos;
    }
}

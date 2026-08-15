namespace miPrimeraAplicacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            btn = new Button();
            txtNum2 = new TextBox();
            lblNUm2 = new Label();
            lblRespuesta = new Label();
            grbOpciones = new GroupBox();
            rdbFactorial = new RadioButton();
            rdbRaiz = new RadioButton();
            rdbExponente = new RadioButton();
            rdbDivision = new RadioButton();
            rdbMultiplicacion = new RadioButton();
            rdbResta = new RadioButton();
            rdbSuma = new RadioButton();
            cboOpciones = new ComboBox();
            lblOpciones = new Label();
            grbOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Times New Roman", 13.8F);
            lblNum1.Location = new Point(40, 71);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(75, 26);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Num1:";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(144, 70);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 2;
            // 
            // btn
            // 
            btn.Font = new Font("Times New Roman", 13.8F);
            btn.Location = new Point(118, 301);
            btn.Name = "btn";
            btn.Size = new Size(190, 84);
            btn.TabIndex = 3;
            btn.Text = "Calcular";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(144, 155);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 5;
            // 
            // lblNUm2
            // 
            lblNUm2.AutoSize = true;
            lblNUm2.Font = new Font("Times New Roman", 13.8F);
            lblNUm2.Location = new Point(40, 145);
            lblNUm2.Name = "lblNUm2";
            lblNUm2.Size = new Size(75, 26);
            lblNUm2.TabIndex = 4;
            lblNUm2.Text = "Num2:";
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Times New Roman", 13.8F);
            lblRespuesta.Location = new Point(57, 223);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(121, 26);
            lblRespuesta.TabIndex = 6;
            lblRespuesta.Text = "Respuesta ?";
            // 
            // grbOpciones
            // 
            grbOpciones.Controls.Add(rdbFactorial);
            grbOpciones.Controls.Add(rdbRaiz);
            grbOpciones.Controls.Add(rdbExponente);
            grbOpciones.Controls.Add(rdbDivision);
            grbOpciones.Controls.Add(rdbMultiplicacion);
            grbOpciones.Controls.Add(rdbResta);
            grbOpciones.Controls.Add(rdbSuma);
            grbOpciones.Location = new Point(400, 85);
            grbOpciones.Name = "grbOpciones";
            grbOpciones.Size = new Size(191, 361);
            grbOpciones.TabIndex = 7;
            grbOpciones.TabStop = false;
            grbOpciones.Text = "Opciones";
            // 
            // rdbFactorial
            // 
            rdbFactorial.AutoSize = true;
            rdbFactorial.Location = new Point(6, 302);
            rdbFactorial.Name = "rdbFactorial";
            rdbFactorial.Size = new Size(86, 24);
            rdbFactorial.TabIndex = 6;
            rdbFactorial.TabStop = true;
            rdbFactorial.Text = "Factorial";
            rdbFactorial.UseVisualStyleBackColor = true;
            // 
            // rdbRaiz
            // 
            rdbRaiz.AutoSize = true;
            rdbRaiz.Location = new Point(20, 258);
            rdbRaiz.Name = "rdbRaiz";
            rdbRaiz.Size = new Size(58, 24);
            rdbRaiz.TabIndex = 5;
            rdbRaiz.TabStop = true;
            rdbRaiz.Text = "Raiz";
            rdbRaiz.UseVisualStyleBackColor = true;
            // 
            // rdbExponente
            // 
            rdbExponente.AutoSize = true;
            rdbExponente.Location = new Point(20, 216);
            rdbExponente.Name = "rdbExponente";
            rdbExponente.Size = new Size(100, 24);
            rdbExponente.TabIndex = 4;
            rdbExponente.TabStop = true;
            rdbExponente.Text = "Exponente";
            rdbExponente.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            rdbDivision.AutoSize = true;
            rdbDivision.Location = new Point(20, 167);
            rdbDivision.Name = "rdbDivision";
            rdbDivision.Size = new Size(87, 24);
            rdbDivision.TabIndex = 3;
            rdbDivision.TabStop = true;
            rdbDivision.Text = "Division ";
            rdbDivision.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplicacion
            // 
            rdbMultiplicacion.AutoSize = true;
            rdbMultiplicacion.Location = new Point(20, 126);
            rdbMultiplicacion.Name = "rdbMultiplicacion";
            rdbMultiplicacion.Size = new Size(124, 24);
            rdbMultiplicacion.TabIndex = 2;
            rdbMultiplicacion.TabStop = true;
            rdbMultiplicacion.Text = "Multiplicacion";
            rdbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            rdbResta.AutoSize = true;
            rdbResta.Location = new Point(20, 82);
            rdbResta.Name = "rdbResta";
            rdbResta.Size = new Size(70, 24);
            rdbResta.TabIndex = 1;
            rdbResta.TabStop = true;
            rdbResta.Text = "Resta ";
            rdbResta.UseVisualStyleBackColor = true;
            // 
            // rdbSuma
            // 
            rdbSuma.AutoSize = true;
            rdbSuma.Location = new Point(20, 36);
            rdbSuma.Name = "rdbSuma";
            rdbSuma.Size = new Size(67, 24);
            rdbSuma.TabIndex = 0;
            rdbSuma.TabStop = true;
            rdbSuma.Text = "Suma";
            rdbSuma.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            cboOpciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOpciones.FormattingEnabled = true;
            cboOpciones.Items.AddRange(new object[] { "Suma", "Resta", "Multiplicacion ", "Division", "Exponente", "Raiz", "Factorial" });
            cboOpciones.Location = new Point(133, 12);
            cboOpciones.Name = "cboOpciones";
            cboOpciones.Size = new Size(417, 28);
            cboOpciones.TabIndex = 8;
            // 
            // lblOpciones
            // 
            lblOpciones.AutoSize = true;
            lblOpciones.Font = new Font("Times New Roman", 13.8F);
            lblOpciones.Location = new Point(31, 14);
            lblOpciones.Name = "lblOpciones";
            lblOpciones.Size = new Size(101, 26);
            lblOpciones.TabIndex = 9;
            lblOpciones.Text = "opciones:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 511);
            Controls.Add(lblOpciones);
            Controls.Add(cboOpciones);
            Controls.Add(grbOpciones);
            Controls.Add(lblRespuesta);
            Controls.Add(txtNum2);
            Controls.Add(lblNUm2);
            Controls.Add(btn);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Calculador basicaa";
            Load += Form1_Load;
            grbOpciones.ResumeLayout(false);
            grbOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private Button btn;
        private TextBox txtNum2;
        private Label lblNUm2;
        private Label lblRespuesta;
        private GroupBox grbOpciones;
        private RadioButton rdbSuma;
        private RadioButton rdbFactorial;
        private RadioButton rdbRaiz;
        private RadioButton rdbExponente;
        private RadioButton rdbDivision;
        private RadioButton rdbMultiplicacion;
        private RadioButton rdbResta;
        private ComboBox cboOpciones;
        private Label lblOpciones;
    }
}

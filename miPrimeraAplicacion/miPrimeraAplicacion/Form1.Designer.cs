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
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Times New Roman", 13.8F);
            lblNum1.Location = new Point(40, 69);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(81, 26);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Num1 :";
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
            lblNUm2.Size = new Size(81, 26);
            lblNUm2.TabIndex = 4;
            lblNUm2.Text = "Num2 :";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 478);
            Controls.Add(lblRespuesta);
            Controls.Add(txtNum2);
            Controls.Add(lblNUm2);
            Controls.Add(btn);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Calculador basicaa";
            Load += Form1_Load;
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
    }
}

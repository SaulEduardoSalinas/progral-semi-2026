using System;
using System.Windows.Forms;

namespace sistema_gestion_del_tiempo_y_la_demanada_primer_nivel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.btn1.Click += new EventHandler(this.btn1_Click);
            this.btn2.Click += new EventHandler(this.btn2_Click);
            this.btn3.Click += new EventHandler(this.btn3_Click);
            this.Load += new EventHandler(this.Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbo1.Items.Count == 0)
            {
                cbo1.Items.Add("A+");
                cbo1.Items.Add("A-");
                cbo1.Items.Add("B+");
                cbo1.Items.Add("B-");
                cbo1.Items.Add("AB+");
                cbo1.Items.Add("AB-");
                cbo1.Items.Add("O+");
                cbo1.Items.Add("O-");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string nombreCompleto = txt1.Text.Trim();
            string expediente = txt2.Text.Trim();
            string edad = txt3.Text.Trim();
            string genero = cbo3.Text.Trim();
            string cedulaDui = txt5.Text.Trim();
            string direccion = txt6.Text.Trim();
            string telefono = txt7.Text.Trim();
            string tipoSangre = cbo1.Text.Trim();
            string triage = cbo2.Text.Trim();
            
                

            if (string.IsNullOrEmpty(nombreCompleto) || string.IsNullOrEmpty(expediente) || string.IsNullOrEmpty(cedulaDui))
            {
                MessageBox.Show("Por favor, complete al menos el Nombre, N° Expediente y Cédula/DUI.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resumen = $"--- DATOS REGISTRADOS ---\n" +
                             $"1. Nombre: {nombreCompleto}\n" +
                             $"2. Expediente: {expediente}\n" +
                             $"3. Edad: {edad}\n" +
                             $"4. Género: {genero}\n" +
                             $"5. Cédula/DUI: {cedulaDui}\n" +
                             $"6. Dirección: {direccion}\n" +
                             $"7. Teléfono: {telefono}\n" +
                             $"{8}. Tipo de Sangre: {tipoSangre}\n" +
                                $"{9}. Triage/Prioridad: {triage}\n";



            MessageBox.Show(resumen, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string expediente = txt2.Text.Trim();

            if (string.IsNullOrEmpty(expediente))
            {
                MessageBox.Show("Ingrese un N° de Expediente para verificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"El expediente N° '{expediente}' se encuentra activo en el sistema.", "Verificación de Expediente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea volver al menú principal?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();    

            }
        }
    }
}
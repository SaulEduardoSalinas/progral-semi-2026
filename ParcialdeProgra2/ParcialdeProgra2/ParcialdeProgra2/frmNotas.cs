using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class frmNotas : Form
    {
        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private DataTable tabla;
        private bool cargando = true;

        private const string FORMULA_NF = "lab1 * 0.3 + lab2 * 0.3 + parcial * 0.4";
        private const decimal NOTA_APROBACION = 6.0m;

        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            dgvNotas.AutoGenerateColumns = false;
            try
            {
                DataSet ds = bd.crearDs();
                cboMateria.DisplayMember = "nombre";
                cboMateria.ValueMember = "idMateria";
                cboMateria.DataSource = ds.Tables["materias"];

                cboPeriodo.DisplayMember = "periodo";
                cboPeriodo.ValueMember = "idPeriodo";
                cboPeriodo.DataSource = ds.Tables["periodos"];
            }
            catch (Exception ex)
            {
                mensaje("No se pudieron cargar materias y períodos: " + ex.Message, true);
                return;
            }
            cargando = false;
            cargarNotas();
        }

        private void filtro_Changed(object sender, EventArgs e)
        {
            if (cargando) return;

            if (tabla != null && tabla.GetChanges() != null &&
                MessageBox.Show("Hay notas modificadas sin guardar. ¿Guardarlas antes de cambiar?", "Notas",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                guardar();
            }
            cargarNotas();
        }

        private void cargarNotas()
        {
            if (!(cboMateria.SelectedValue is int) || !(cboPeriodo.SelectedValue is int)) return;

            try
            {
                tabla = bd.notasDe((int)cboMateria.SelectedValue, (int)cboPeriodo.SelectedValue);
                tabla.Columns.Add("nf", typeof(decimal), FORMULA_NF);
                dgvNotas.DataSource = tabla;

                DataRowView periodo = cboPeriodo.SelectedItem as DataRowView;
                lblFechaPeriodo.Text = periodo == null ? "—" : ((DateTime)periodo["fecha"]).ToString("dd 'de' MMMM yyyy");

                mensaje(tabla.Rows.Count == 0 ? "No hay notas registradas para esta materia en este período." : "", false);
                actualizarResumen();
            }
            catch (Exception ex)
            {
                mensaje("No se pudieron cargar las notas: " + ex.Message, true);
            }
        }

        private void actualizarResumen()
        {
            if (tabla == null || tabla.Rows.Count == 0)
            {
                lblResumen.Text = "Promedio NF: —";
                return;
            }
            decimal promedio = Convert.ToDecimal(tabla.Compute("AVG(nf)", ""));
            int aprobados = tabla.Select("nf >= " + NOTA_APROBACION.ToString(CultureInfo.InvariantCulture)).Length;
            lblResumen.Text = "Promedio NF: " + promedio.ToString("N2") + "   ·   Aprobados (NF ≥ 6.0): " +
                              aprobados + " de " + tabla.Rows.Count;
        }

        private void dgvNotas_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columna = dgvNotas.Columns[e.ColumnIndex].Name;
            if (columna != "colLab1" && columna != "colLab2" && columna != "colParcial") return;

            decimal nota;
            string texto = e.FormattedValue.ToString().Replace(',', '.');
            if (!decimal.TryParse(texto, NumberStyles.Number, CultureInfo.InvariantCulture, out nota) || nota < 0 || nota > 10)
            {
                mensaje("Las notas van de 0 a 10 (por ejemplo 8.5).", true);
                e.Cancel = true;
            }
        }

        private void dgvNotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            actualizarResumen();
            if (tabla != null && tabla.GetChanges() != null)
                mensaje("Cambios sin guardar.", false);
        }

        private void dgvNotas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            mensaje("Valor no válido. Usa números entre 0 y 10.", true);
            e.Cancel = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void guardar()
        {
            dgvNotas.EndEdit();
            if (tabla == null) return;
            try
            {
                int n = bd.guardarNotas(tabla);
                mensaje(n == 0 ? "No había cambios que guardar." : n + " nota(s) guardada(s).", false, true);
            }
            catch (Exception ex)
            {
                mensaje("Error al guardar: " + ex.Message, true);
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (tabla == null) return;
            dgvNotas.CancelEdit();
            tabla.RejectChanges();
            actualizarResumen();
            mensaje("Cambios descartados.", false);
        }

        private void mensaje(string texto, bool esError, bool esExito = false)
        {
            lblMensaje.ForeColor = esError ? Color.FromArgb(255, 107, 107)
                                 : esExito ? Color.FromArgb(80, 210, 140) : Color.FromArgb(154, 160, 174);
            lblMensaje.Text = texto;
        }
    }
}

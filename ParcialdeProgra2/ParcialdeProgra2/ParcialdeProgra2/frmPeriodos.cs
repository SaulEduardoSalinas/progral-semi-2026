using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class frmPeriodos : Form
    {
        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private DataTable periodos;

        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            dgvPeriodos.AutoGenerateColumns = false;
            dgvPeriodos.DataSource = bsPeriodos;
            cargar();

            Binding id = lblIdValor.DataBindings.Add("Text", bsPeriodos, "idPeriodo", true);
            id.Format += (s, ev) => { if (ev.Value is int && (int)ev.Value < 0) ev.Value = "nuevo"; };
            txtPeriodo.DataBindings.Add("Text", bsPeriodos, "periodo", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpFecha.DataBindings.Add("Value", bsPeriodos, "fecha", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void cargar()
        {
            try
            {
                periodos = bd.crearDs().Tables["periodos"];
            }
            catch (Exception ex)
            {
                mensaje("No se pudieron cargar los períodos: " + ex.Message, true);
                return;
            }
            DataColumn id = periodos.Columns["idPeriodo"];
            id.AutoIncrementSeed = -1;
            id.AutoIncrementStep = -1;
            periodos.Columns["periodo"].DefaultValue = "Nuevo período";
            periodos.Columns["fecha"].DefaultValue = DateTime.Today;

            bsPeriodos.DataSource = periodos;
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView fila = bsPeriodos.Current as DataRowView;
            if (fila == null) return;

            if (MessageBox.Show("¿Quitar el período «" + fila["periodo"] + "»?\nSe eliminará al pulsar Guardar.",
                    "Eliminar período", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bsPeriodos.RemoveCurrent();
                mensaje("Cambios pendientes: pulsa Guardar para enviarlos.", false);
            }
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            Validate();
            bsPeriodos.EndEdit();

            foreach (DataRow fila in periodos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted && fila["periodo"].ToString().Trim() == "")
                {
                    mensaje("Hay un período sin nombre. Escríbelo antes de guardar.", true);
                    return;
                }
            }

            try
            {
                int filas = bd.guardarPeriodos(periodos);
                cargar();
                mensaje(filas == 0 ? "No había cambios que guardar." : filas + " cambio(s) guardado(s).", false, true);
            }
            catch (SqlException ex)
            {
                cargar();
                mensaje(ex.Number == 547
                    ? "No se puede eliminar un período que ya tiene notas. Se recargaron los datos."
                    : "Error de base de datos: " + ex.Message, true);
            }
        }

        private void bnDescartar_Click(object sender, EventArgs e)
        {
            bsPeriodos.CancelEdit();
            periodos.RejectChanges();
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

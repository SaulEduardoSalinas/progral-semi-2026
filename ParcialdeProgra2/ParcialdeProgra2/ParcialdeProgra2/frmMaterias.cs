using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class frmMaterias : Form
    {
        private enum Modo { Consulta, Agregando, Editando }

        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private readonly Dictionary<Button, Color> colores = new Dictionary<Button, Color>();
        private Modo modo = Modo.Consulta;

        public frmMaterias()
        {
            InitializeComponent();
            foreach (Button b in new[] { btnAgregar, btnModificar, btnEliminar, btnGuardar, btnCancelar })
                colores[b] = b.BackColor;
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.DataSource = bsMaterias;
            cboCriterio.SelectedIndex = 0;
            cargar(null);
            aplicarModo(Modo.Consulta);
        }

        private void cargar(int? codigoSeleccionar)
        {
            try
            {
                bsMaterias.DataSource = bd.crearDs().Tables["materias"];
            }
            catch (Exception ex)
            {
                mensaje("No se pudo cargar la tabla de materias: " + ex.Message, true);
                return;
            }
            aplicarFiltro();

            if (codigoSeleccionar.HasValue)
            {
                int pos = bsMaterias.Find("codigo", codigoSeleccionar.Value);
                if (pos >= 0) bsMaterias.Position = pos;
            }
            mostrarActual();
        }

        private void bsMaterias_CurrentChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Consulta) mostrarActual();
        }

        private void mostrarActual()
        {
            DataRowView fila = bsMaterias.Current as DataRowView;
            if (fila == null)
            {
                txtId.Clear(); txtCodigo.Clear(); txtNombre.Clear(); nudUv.Value = 4;
                lblPosicion.Text = "0 / 0";
                return;
            }
            txtId.Text = fila["idMateria"].ToString();
            txtCodigo.Text = fila["codigo"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            nudUv.Value = Math.Max(nudUv.Minimum, Math.Min(nudUv.Maximum, Convert.ToDecimal(fila["uv"])));
            lblPosicion.Text = (bsMaterias.Position + 1) + " / " + bsMaterias.Count;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (bsMaterias.DataSource == null) return;
            aplicarFiltro();
            mostrarActual();
        }

        private void aplicarFiltro()
        {
            string texto = txtBuscar.Text.Trim();
            if (texto == "")
            {
                bsMaterias.Filter = null;
            }
            else if (cboCriterio.SelectedIndex == 1)
            {
                int codigo;
                bsMaterias.Filter = int.TryParse(texto, out codigo)
                    ? "CONVERT(codigo, 'System.String') LIKE '" + codigo + "%'"
                    : "1 = 0";
            }
            else
            {
                texto = texto.Replace("'", "''").Replace("[", "").Replace("]", "").Replace("*", "").Replace("%", "");
                bsMaterias.Filter = "nombre LIKE '%" + texto + "%'";
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e) { bsMaterias.MoveFirst(); }
        private void btnAnterior_Click(object sender, EventArgs e) { bsMaterias.MovePrevious(); }
        private void btnSiguiente_Click(object sender, EventArgs e) { bsMaterias.MoveNext(); }
        private void btnUltimo_Click(object sender, EventArgs e) { bsMaterias.MoveLast(); }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            aplicarModo(Modo.Agregando);
            txtId.Text = "nuevo";
            txtCodigo.Clear();
            txtNombre.Clear();
            nudUv.Value = 4;
            mensaje("", false);
            txtCodigo.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bsMaterias.Current == null) return;
            aplicarModo(Modo.Editando);
            mensaje("", false);
            txtCodigo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            aplicarModo(Modo.Consulta);
            mensaje("", false);
            mostrarActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView fila = bsMaterias.Current as DataRowView;
            if (fila == null) return;

            if (MessageBox.Show("¿Eliminar la materia «" + fila["nombre"] + "»?\nTambién se borrarán sus notas.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                bd.mantenimientoMaterias(Conexion_base_datos.ELIMINAR,
                    new Dictionary<string, object> { { "idMateria", (int)fila["idMateria"] } });
                cargar(null);
                mensaje("Materia eliminada.", false, true);
            }
            catch (Exception ex)
            {
                mensaje("No se pudo eliminar: " + ex.Message, true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(txtCodigo.Text.Trim(), out codigo) || codigo <= 0)
            {
                mensaje("El código de la materia debe ser un número entero.", true);
                txtCodigo.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                mensaje("El nombre de la materia es obligatorio.", true);
                txtNombre.Focus();
                return;
            }

            var campos = new Dictionary<string, object>
            {
                { "codigo", codigo },
                { "nombre", txtNombre.Text.Trim() },
                { "uv", (int)nudUv.Value }
            };
            if (modo == Modo.Editando) campos["idMateria"] = int.Parse(txtId.Text);

            try
            {
                bd.mantenimientoMaterias(modo == Modo.Agregando ? Conexion_base_datos.AGREGAR : Conexion_base_datos.MODIFICAR, campos);
            }
            catch (SqlException ex)
            {
                mensaje(ex.Number == 2627 || ex.Number == 2601
                    ? "Ya existe una materia con el código " + codigo + "."
                    : "Error de base de datos: " + ex.Message, true);
                return;
            }

            bool eraNueva = modo == Modo.Agregando;
            aplicarModo(Modo.Consulta);
            cargar(codigo);
            mensaje(eraNueva ? "Materia agregada." : "Cambios guardados.", false, true);
        }

        private void aplicarModo(Modo nuevo)
        {
            modo = nuevo;
            bool consultando = modo == Modo.Consulta;

            foreach (TextBox t in new[] { txtCodigo, txtNombre })
            {
                t.ReadOnly = consultando;
                t.BackColor = consultando ? Color.FromArgb(34, 37, 46) : Color.FromArgb(44, 48, 64);
            }
            nudUv.Enabled = !consultando;
            dgvMaterias.Enabled = consultando;
            txtBuscar.Enabled = consultando;
            cboCriterio.Enabled = consultando;
            foreach (Button b in new[] { btnPrimero, btnAnterior, btnSiguiente, btnUltimo }) b.Enabled = consultando;

            activar(btnAgregar, consultando);
            activar(btnModificar, consultando);
            activar(btnEliminar, consultando);
            activar(btnGuardar, !consultando);
            activar(btnCancelar, !consultando);

            lblFicha.Text = modo == Modo.Agregando ? "NUEVA MATERIA" : modo == Modo.Editando ? "EDITANDO MATERIA" : "FICHA DE LA MATERIA";
        }

        private void activar(Button b, bool activo)
        {
            b.Enabled = activo;
            b.BackColor = activo ? colores[b] : Color.FromArgb(52, 55, 66);
        }

        private void mensaje(string texto, bool esError, bool esExito = false)
        {
            lblMensaje.ForeColor = esError ? Color.FromArgb(255, 107, 107)
                                 : esExito ? Color.FromArgb(80, 210, 140) : Color.FromArgb(154, 160, 174);
            lblMensaje.Text = texto;
        }
    }
}

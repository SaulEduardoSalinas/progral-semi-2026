using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class Form1 : Form
    {
        private enum Modo { Consulta, Agregando, Editando }

        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private readonly Dictionary<Button, Color> colores = new Dictionary<Button, Color>();
        private Modo modo = Modo.Consulta;

        private static readonly Regex reTelefono = new Regex(@"^(\d{8}|\d{4}-\d{4})?$");

        public Form1()
        {
            InitializeComponent();
            foreach (Button b in new[] { btnAgregar, btnModificar, btnEliminar, btnGuardar, btnCancelar })
                colores[b] = b.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvAlumnos.AutoGenerateColumns = false;
            dgvAlumnos.DataSource = bsAlumnos;
            cargar(null);
            aplicarModo(Modo.Consulta);
        }

        private void cargar(string codigoSeleccionar)
        {
            try
            {
                bsAlumnos.DataSource = bd.crearDs().Tables["alumnos"];
            }
            catch (Exception ex)
            {
                mensaje("No se pudo cargar la tabla de alumnos: " + ex.Message, true);
                return;
            }
            aplicarFiltro();

            if (codigoSeleccionar != null)
            {
                int pos = bsAlumnos.Find("codigo", codigoSeleccionar);
                if (pos >= 0) bsAlumnos.Position = pos;
            }
            mostrarActual();
        }

        private void bsAlumnos_CurrentChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Consulta) mostrarActual();
        }

        private void mostrarActual()
        {
            DataRowView fila = bsAlumnos.Current as DataRowView;
            if (fila == null)
            {
                limpiar();
                lblPosicion.Text = "0 / 0";
                return;
            }
            txtId.Text = fila["idAlumno"].ToString();
            txtCodigo.Text = fila["codigo"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            txtDireccion.Text = fila["direccion"].ToString();
            txtTelefono.Text = fila["telefono"].ToString();
            lblPosicion.Text = (bsAlumnos.Position + 1) + " / " + bsAlumnos.Count;
        }

        private void limpiar()
        {
            foreach (TextBox t in new[] { txtId, txtCodigo, txtNombre, txtDireccion, txtTelefono }) t.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            aplicarFiltro();
            mostrarActual();
        }

        private void aplicarFiltro()
        {
            string texto = txtBuscar.Text.Trim().Replace("'", "''").Replace("[", "").Replace("]", "")
                                                .Replace("*", "").Replace("%", "");
            bsAlumnos.Filter = texto == "" ? null
                : "codigo LIKE '%" + texto + "%' OR nombre LIKE '%" + texto + "%'";
        }

        private void btnPrimero_Click(object sender, EventArgs e) { bsAlumnos.MoveFirst(); }
        private void btnAnterior_Click(object sender, EventArgs e) { bsAlumnos.MovePrevious(); }
        private void btnSiguiente_Click(object sender, EventArgs e) { bsAlumnos.MoveNext(); }
        private void btnUltimo_Click(object sender, EventArgs e) { bsAlumnos.MoveLast(); }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            aplicarModo(Modo.Agregando);
            limpiar();
            txtId.Text = "nuevo";
            mensaje("", false);
            txtCodigo.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bsAlumnos.Current == null) return;
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
            DataRowView fila = bsAlumnos.Current as DataRowView;
            if (fila == null) return;

            if (MessageBox.Show("¿Eliminar a «" + fila["nombre"] + "»?\nTambién se borrarán sus notas.",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                bd.mantenimientoAlumnos(Conexion_base_datos.ELIMINAR,
                    new Dictionary<string, object> { { "idAlumno", (int)fila["idAlumno"] } });
                cargar(null);
                mensaje("Alumno eliminado.", false, true);
            }
            catch (Exception ex)
            {
                mensaje("No se pudo eliminar: " + ex.Message, true);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string error = validar();
            if (error != null)
            {
                mensaje(error, true);
                return;
            }

            var campos = new Dictionary<string, object>
            {
                { "codigo", txtCodigo.Text.Trim().ToUpper() },
                { "nombre", txtNombre.Text.Trim() },
                { "direccion", txtDireccion.Text.Trim() },
                { "telefono", txtTelefono.Text.Trim() }
            };
            if (modo == Modo.Editando) campos["idAlumno"] = int.Parse(txtId.Text);

            try
            {
                bd.mantenimientoAlumnos(modo == Modo.Agregando ? Conexion_base_datos.AGREGAR : Conexion_base_datos.MODIFICAR, campos);
            }
            catch (SqlException ex)
            {
                mensaje(ex.Number == 2627 || ex.Number == 2601
                    ? "Ya existe un alumno con el código «" + campos["codigo"] + "»."
                    : "Error de base de datos: " + ex.Message, true);
                return;
            }

            bool eraNuevo = modo == Modo.Agregando;
            aplicarModo(Modo.Consulta);
            cargar((string)campos["codigo"]);
            mensaje(eraNuevo ? "Alumno agregado." : "Cambios guardados.", false, true);
        }

        private string validar()
        {
            if (txtCodigo.Text.Trim() == "") { txtCodigo.Focus(); return "El código es obligatorio."; }
            if (txtNombre.Text.Trim().Length < 3) { txtNombre.Focus(); return "Escribe el nombre completo del alumno."; }
            if (!reTelefono.IsMatch(txtTelefono.Text.Trim())) { txtTelefono.Focus(); return "Teléfono no válido. Usa el formato 0000-0000."; }
            return null;
        }

        private void aplicarModo(Modo nuevo)
        {
            modo = nuevo;
            bool consultando = modo == Modo.Consulta;

            foreach (TextBox t in new[] { txtCodigo, txtNombre, txtDireccion, txtTelefono })
            {
                t.ReadOnly = consultando;
                t.BackColor = consultando ? Color.FromArgb(34, 37, 46) : Color.FromArgb(44, 48, 64);
            }
            dgvAlumnos.Enabled = consultando;
            txtBuscar.Enabled = consultando;
            foreach (Button b in new[] { btnPrimero, btnAnterior, btnSiguiente, btnUltimo }) b.Enabled = consultando;

            activar(btnAgregar, consultando);
            activar(btnModificar, consultando);
            activar(btnEliminar, consultando);
            activar(btnGuardar, !consultando);
            activar(btnCancelar, !consultando);

            lblFicha.Text = modo == Modo.Agregando ? "NUEVO ALUMNO" : modo == Modo.Editando ? "EDITANDO ALUMNO" : "FICHA DEL ALUMNO";
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

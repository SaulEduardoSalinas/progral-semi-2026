using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class frm_usuario : Form
    {
        private enum Modo { Consulta, Agregando, Editando }

        private readonly Conexion_base_datos bd = new Conexion_base_datos();
        private readonly Dictionary<Button, Color> coloresOriginales = new Dictionary<Button, Color>();
        private Modo modo = Modo.Consulta;

        private static readonly Regex reUsuario = new Regex(@"^.{6,16}$");
        private static readonly Regex reClave = new Regex(@"^(?=.*[A-Za-z])(?=.*\d).+$");
        private static readonly Regex reTelefono = new Regex(@"^(\d{8}|\d{4}-\d{4})?$");

        private static readonly Color colorError = Color.FromArgb(255, 107, 107);
        private static readonly Color colorExito = Color.FromArgb(80, 210, 140);
        private static readonly Color colorApagado = Color.FromArgb(52, 55, 66);

        private readonly bool soloRegistro;
        public string UsuarioRegistrado { get; private set; }

        public frm_usuario() : this("")
        {
        }

        public frm_usuario(bool soloRegistro) : this("")
        {
            this.soloRegistro = soloRegistro;
        }

        public frm_usuario(string nombreSesion)
        {
            InitializeComponent();
            lblSesion.Text = nombreSesion == "" ? "Administración de cuentas" : "Sesión iniciada como " + nombreSesion;

            foreach (Button b in new[] { btnAgregar, btnModificar, btnEliminar, btnGuardar, btnCancelar })
            {
                coloresOriginales[b] = b.BackColor;
            }
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            if (soloRegistro)
            {
                Text = "Registrarse";
                lblTitulo.Text = "Crear una cuenta";
                lblSesion.Text = "Usuarios registrados en el sistema";
                StartPosition = FormStartPosition.CenterParent;
            }
            dgvUsuarios.DataSource = bsUsuarios;
            cargar(null);
            aplicarModo(Modo.Consulta);
        }

        private void cargar(int? idSeleccionar)
        {
            try
            {
                DataSet ds = bd.crearDs();
                bsUsuarios.DataSource = ds.Tables["usuarios"];
            }
            catch (Exception ex)
            {
                mensaje("No se pudo cargar la tabla de usuarios: " + ex.Message, true);
                return;
            }

            formatearTabla();

            if (idSeleccionar.HasValue)
            {
                int pos = bsUsuarios.Find("idUsuario", idSeleccionar.Value);
                if (pos >= 0) bsUsuarios.Position = pos;
            }
            mostrarActual();
        }

        private void formatearTabla()
        {
            if (dgvUsuarios.Columns.Count == 0) return;

            dgvUsuarios.Columns["clave"].Visible = false;
            dgvUsuarios.Columns["idUsuario"].HeaderText = "ID";
            dgvUsuarios.Columns["idUsuario"].FillWeight = 35;
            dgvUsuarios.Columns["usuario"].HeaderText = "Usuario";
            dgvUsuarios.Columns["nombre"].HeaderText = "Nombre";
            dgvUsuarios.Columns["direccion"].HeaderText = "Dirección";
            dgvUsuarios.Columns["telefono"].HeaderText = "Teléfono";
            dgvUsuarios.Columns["telefono"].FillWeight = 60;
        }

        private void bsUsuarios_CurrentChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Consulta) mostrarActual();
        }

        private void mostrarActual()
        {
            DataRowView fila = bsUsuarios.Current as DataRowView;
            if (fila == null)
            {
                limpiar();
                lblPosicion.Text = "0 / 0";
                return;
            }

            txtIdUsuario.Text = fila["idUsuario"].ToString();
            txtUsuario.Text = fila["usuario"].ToString();
            txtClave.Text = fila["clave"].ToString();
            txtConfirmar.Text = fila["clave"].ToString();
            txtNombre.Text = fila["nombre"].ToString();
            txtDireccion.Text = fila["direccion"].ToString();
            txtTelefono.Text = fila["telefono"].ToString();
            lblPosicion.Text = (bsUsuarios.Position + 1) + " / " + bsUsuarios.Count;
        }

        private void limpiar()
        {
            foreach (TextBox t in new[] { txtIdUsuario, txtUsuario, txtClave, txtConfirmar, txtNombre, txtDireccion, txtTelefono })
            {
                t.Clear();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e) { bsUsuarios.MoveFirst(); }
        private void btnAnterior_Click(object sender, EventArgs e) { bsUsuarios.MovePrevious(); }
        private void btnSiguiente_Click(object sender, EventArgs e) { bsUsuarios.MoveNext(); }
        private void btnUltimo_Click(object sender, EventArgs e) { bsUsuarios.MoveLast(); }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            aplicarModo(Modo.Agregando);
            limpiar();
            txtIdUsuario.Text = "nuevo";
            txtUsuario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (bsUsuarios.Current == null) return;
            aplicarModo(Modo.Editando);
            txtConfirmar.Clear();
            mensaje("Vuelve a escribir la clave en «Confirmar clave» para guardar.", false);
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            aplicarModo(Modo.Consulta);
            mensaje("", false);
            mostrarActual();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRowView fila = bsUsuarios.Current as DataRowView;
            if (fila == null) return;

            string usuario = fila["usuario"].ToString();
            if (MessageBox.Show("¿Eliminar definitivamente a «" + usuario + "»?", "Confirmar eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Dictionary<string, object> campos = new Dictionary<string, object>();
                campos["idUsuario"] = (int)fila["idUsuario"];
                bd.mantenimiento_usuarios_USSS139126(Conexion_base_datos.ELIMINAR, campos);
                cargar(null);
                mensaje("Usuario «" + usuario + "» eliminado.", false, true);
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

            Dictionary<string, object> campos = new Dictionary<string, object>();
            campos["idUsuario"] = modo == Modo.Editando ? int.Parse(txtIdUsuario.Text) : 0;
            campos["usuario"] = txtUsuario.Text.Trim();
            campos["clave"] = txtClave.Text;
            campos["nombre"] = txtNombre.Text.Trim();
            campos["direccion"] = txtDireccion.Text.Trim();
            campos["telefono"] = txtTelefono.Text.Trim();

            char operacion = modo == Modo.Agregando ? Conexion_base_datos.AGREGAR : Conexion_base_datos.MODIFICAR;

            try
            {
                bd.mantenimiento_usuarios_USSS139126(operacion, campos);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    mensaje("El usuario «" + campos["usuario"] + "» ya existe. Elige otro.", true);
                else
                    mensaje("Error de base de datos: " + ex.Message, true);
                return;
            }

            string guardado = (string)campos["usuario"];
            if (modo == Modo.Agregando) UsuarioRegistrado = guardado;
            aplicarModo(Modo.Consulta);
            cargar(null);

            int pos = bsUsuarios.Find("usuario", guardado);
            if (pos >= 0) bsUsuarios.Position = pos;

            mensaje(operacion == Conexion_base_datos.AGREGAR ? "Usuario agregado correctamente." : "Cambios guardados.", false, true);
        }

        private string validar()
        {
            string usuario = txtUsuario.Text.Trim();

            if (!reUsuario.IsMatch(usuario))
            {
                txtUsuario.Focus();
                return "El usuario debe tener entre 6 y 16 caracteres (tiene " + usuario.Length + ").";
            }
            if (txtClave.Text != txtConfirmar.Text)
            {
                txtConfirmar.Focus();
                return "La confirmación no coincide con la clave. No se guardó.";
            }
            if (!reClave.IsMatch(txtClave.Text))
            {
                txtClave.Focus();
                return "La clave debe llevar letras y números. No se guardó.";
            }
            if (txtNombre.Text.Trim() == "")
            {
                txtNombre.Focus();
                return "El nombre es obligatorio.";
            }
            if (!reTelefono.IsMatch(txtTelefono.Text.Trim()))
            {
                txtTelefono.Focus();
                return "Teléfono no válido. Usa el formato 0000-0000.";
            }
            return null;
        }

        private void aplicarModo(Modo nuevo)
        {
            modo = nuevo;
            bool consultando = modo == Modo.Consulta;

            foreach (TextBox t in new[] { txtUsuario, txtClave, txtConfirmar, txtNombre, txtDireccion, txtTelefono })
            {
                t.ReadOnly = consultando;
                t.BackColor = consultando ? Color.FromArgb(34, 37, 46) : Color.FromArgb(44, 48, 64);
            }

            dgvUsuarios.Enabled = consultando;
            btnPrimero.Enabled = consultando;
            btnAnterior.Enabled = consultando;
            btnSiguiente.Enabled = consultando;
            btnUltimo.Enabled = consultando;

            activar(btnAgregar, consultando);
            activar(btnModificar, consultando);
            activar(btnEliminar, consultando);
            activar(btnGuardar, !consultando);
            activar(btnCancelar, !consultando);

            lblFicha.Text = modo == Modo.Agregando ? "NUEVO USUARIO"
                          : modo == Modo.Editando ? "EDITANDO USUARIO"
                          : "FICHA DEL USUARIO";
        }

        private void activar(Button b, bool activo)
        {
            b.Enabled = activo;
            b.BackColor = activo ? coloresOriginales[b] : colorApagado;
        }

        private void mensaje(string texto, bool esError, bool esExito = false)
        {
            lblMensaje.ForeColor = esError ? colorError : (esExito ? colorExito : Color.FromArgb(154, 160, 174));
            lblMensaje.Text = texto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (soloRegistro)
                DialogResult = UsuarioRegistrado != null ? DialogResult.OK : DialogResult.Cancel;
            else
                Close();
        }
    }
}

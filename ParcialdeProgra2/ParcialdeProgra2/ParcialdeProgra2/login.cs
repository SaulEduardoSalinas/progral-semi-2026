using System;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class login : Form
    {
        private readonly Conexion_base_datos bd = new Conexion_base_datos();

        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            lblError.ForeColor = System.Drawing.Color.FromArgb(255, 107, 107);
            string usuario = txtUsuario.Text.Trim();

            if (usuario.Length == 0 || txtClave.Text.Length == 0)
            {
                lblError.Text = "Completa el usuario y la clave.";
                return;
            }

            string nombre;
            try
            {
                nombre = bd.iniciarSesion(usuario, txtClave.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexión con la base de datos.\n" +
                    "¿Ya ejecutaste script_parcial2_2.sql?\n\n" + ex.Message,
                    "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nombre == null)
            {
                lblError.Text = "Acceso denegado: usuario no registrado o clave incorrecta.";
                txtClave.Clear();
                txtClave.Focus();
                return;
            }

            abrirSistema(nombre);
        }

        private void abrirSistema(string nombre)
        {
            frmPrincipal principal = new frmPrincipal(nombre);
            principal.FormClosed += (s, e) =>
            {
                if (principal.CerrarSesion)
                {
                    txtClave.Clear();
                    lblError.Text = "";
                    Show();
                    txtUsuario.Focus();
                }
                else
                {
                    Close();
                }
            };

            Hide();
            principal.Show();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using (frm_usuario registro = new frm_usuario(true))
            {
                if (registro.ShowDialog(this) == DialogResult.OK)
                {
                    txtUsuario.Text = registro.UsuarioRegistrado;
                    txtClave.Clear();
                    lblError.ForeColor = System.Drawing.Color.FromArgb(80, 210, 140);
                    lblError.Text = "Cuenta creada. Escribe tu clave para entrar.";
                    txtClave.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

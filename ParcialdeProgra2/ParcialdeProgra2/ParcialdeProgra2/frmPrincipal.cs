using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parcial2_2
{
    public partial class frmPrincipal : Form
    {
        private readonly string nombreSesion;

        public bool CerrarSesion { get; private set; }

        public frmPrincipal() : this("")
        {
        }

        public frmPrincipal(string nombre)
        {
            InitializeComponent();
            nombreSesion = nombre;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            mnuAlumnos.Tag = typeof(Form1);
            mnuMaterias.Tag = typeof(frmMaterias);
            mnuPeriodos.Tag = typeof(frmPeriodos);
            mnuNotas.Tag = typeof(frmNotas);
            mnuUsuarios.Tag = typeof(frm_usuario);

            ToolStripProfessionalRenderer oscuro = new ToolStripProfessionalRenderer(new ColoresOscuros());
            oscuro.RoundedEdges = false;
            mnuPrincipal.Renderer = oscuro;
            ssPrincipal.Renderer = oscuro;

            foreach (Control c in Controls)
            {
                if (c is MdiClient) c.BackColor = Color.FromArgb(24, 26, 32);
            }

            tslSesion.Text = "● " + nombreSesion;
            tslReloj.Text = DateTime.Now.ToString("dddd d 'de' MMMM, yyyy");
        }

        private void abrirOpcion_Click(object sender, EventArgs e)
        {
            Type tipo = (Type)((ToolStripItem)sender).Tag;

            foreach (Form hijo in MdiChildren)
            {
                if (hijo.GetType() == tipo)
                {
                    hijo.Activate();
                    return;
                }
                hijo.Close();
            }

            Form nuevo = (Form)Activator.CreateInstance(tipo);
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            CerrarSesion = true;
            Close();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class ColoresOscuros : ProfessionalColorTable
        {
            private static readonly Color fondo = Color.FromArgb(34, 37, 46);
            private static readonly Color resalte = Color.FromArgb(58, 52, 96);
            private static readonly Color borde = Color.FromArgb(60, 64, 80);

            public override Color MenuStripGradientBegin { get { return fondo; } }
            public override Color MenuStripGradientEnd { get { return fondo; } }
            public override Color StatusStripGradientBegin { get { return fondo; } }
            public override Color StatusStripGradientEnd { get { return fondo; } }
            public override Color ToolStripDropDownBackground { get { return fondo; } }
            public override Color ImageMarginGradientBegin { get { return fondo; } }
            public override Color ImageMarginGradientMiddle { get { return fondo; } }
            public override Color ImageMarginGradientEnd { get { return fondo; } }
            public override Color MenuBorder { get { return borde; } }
            public override Color MenuItemBorder { get { return resalte; } }
            public override Color MenuItemSelected { get { return resalte; } }
            public override Color MenuItemSelectedGradientBegin { get { return resalte; } }
            public override Color MenuItemSelectedGradientEnd { get { return resalte; } }
            public override Color MenuItemPressedGradientBegin { get { return resalte; } }
            public override Color MenuItemPressedGradientEnd { get { return resalte; } }
            public override Color SeparatorDark { get { return borde; } }
            public override Color SeparatorLight { get { return fondo; } }
        }
    }
}

using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
            lbl_bienvenido.Text = "Bienvenido "+Consultas.usuarioActual;
            lbl_nombre.Text = Consultas.obtenerNombre();
            lbl_apellido.Text = Consultas.obetenerApellido();

            if (Consultas.obtenerDepartamento() == 3)
            {
                btm_panelAdmin.Hide();
                btm_panelVigilante.Hide();
            }
            
            if (Consultas.obtenerDepartamento() == 2)
            {
                btm_panelAdmin.Hide();
            }
        }


        private void btm_verEntradas_Click(object sender, EventArgs e)
        {
            Principal windows = new Principal();
            windows.Show();
            this.Hide();
        }

        private void btm_panelVigilante_Click(object sender, EventArgs e)
        {
            PanelVigilante windows = new PanelVigilante();
            windows.Show();
            this.Hide();
        }

        private void btm_panelAdmin_Click(object sender, EventArgs e)
        {
            PanelAdmin windows = new PanelAdmin();
            windows.Show();
            this.Hide();
        }
    }
}
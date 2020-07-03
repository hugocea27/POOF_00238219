using System;
using System.Windows.Forms;

namespace Parcial
{
    public partial class PanelVigilante : Form
    {
        public PanelVigilante()
        {
            InitializeComponent();
        }

        private void btm_entrada_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nonquery =
                    $"insert into registro(id_usuario, entrada, temperatura, fecha) values ('{txt_idempleado.Text}', true, " +
                    $"{txt_temperatura.Text}, '{txt_fechayhora.Text}' )";
                ConexionBD.nonQuery(nonquery);
                MessageBox.Show("Registro guardado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos válidos");
            }
        }

        private void btm_salida_Click(object sender, EventArgs e)
        {
            try
            {
                string nonquery =
                    $"insert into registro(id_usuario, entrada, temperatura, fecha) values ('{txt_idempleado.Text}', false, " +
                    $"{txt_temperatura.Text}, '{txt_fechayhora.Text}' )";
                ConexionBD.nonQuery(nonquery);
                MessageBox.Show("Registro guardado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos válidos");
            }
        }
    }
}
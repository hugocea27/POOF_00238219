using System.Windows.Forms;

namespace Parcial
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            string query = $"SELECT fecha, entrada FROM registro WHERE id_usuario='{Consultas.usuarioActual}' ORDER BY id_registro DESC;";
            var dt = ConexionBD.query(query);
            dgw_registro.DataSource = dt;
        }
    }
}
using System;
using System.Windows.Forms;

namespace Parcial
{
    public partial class PanelAdmin : Form
    {
        public PanelAdmin()
        {
            InitializeComponent();
            string query = $"SELECT * from usuario";
            var dt = ConexionBD.query(query);
            dgw_usuarios.DataSource = dt;
            
            string query2 = $"SELECT * FROM REGISTRO";
            var dt2 = ConexionBD.query(query2);
            dgw_registro.DataSource = dt2;
            
            string query3 = $"SELECT d.nombre, count(u.id_Departamento) as frecuencia FROM REGISTRO r, DEPARTAMENTO d, USUARIO u WHERE r.id_Usuario = u.id_Usuario AND" +
                            $" d.id_Departamento = u.id_Departamento GROUP BY d.id_Departamento ORDER BY frecuencia DESC LIMIT 1";
            var dt3 = ConexionBD.query(query3);
            dgw_departamentos.DataSource = dt3;
            
        }

        private void btm_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nonquery =
                    $"insert into usuario(id_usuario, id_departamento, contra, nombre, apellido, dui)" +
                    $"values('{txt_carnet.Text}', {txt_iddepartamento.Text}, '{txt_contra.Text}', '{txt_nombre.Text}'," +
                    $"'{txt_apellido.Text}','{txt_dui.Text}')";
                ConexionBD.nonQuery(nonquery);
                MessageBox.Show("Registro guardado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos validos");
            }
        }

        private void btm_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string nonquery = $"DELETE FROM usuario WHERE id_usuario='{txt_eliminarcarnet.Text}'";
                MessageBox.Show("Usuario eliminado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese datos validos");
            }
        }
        
        
    }
}
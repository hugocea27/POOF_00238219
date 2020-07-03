using System;

namespace Parcial
{
    public class Consultas
    {
        public static string usuarioActual;
        
        public static int logeo(string usuario, string contra)
        {
            try
            {
                string query =
                    $"select id_departamento from usuario where id_usuario = '{usuario}' and contra = '{contra}'";
                var dt = ConexionBD.query(query);
                var dr = dt.Rows[0];
                return Convert.ToInt16(dr[0]);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string obtenerNombre()
        {
            string query = $"select nombre from usuario where id_usuario = '{usuarioActual}'";
            var dt = ConexionBD.query(query);
            var dr = dt.Rows[0];
            var  nombre = dr[0].ToString();

            return nombre;
        }
        
        public static string obetenerApellido()
        {
            string query = $"select apellido from usuario where id_usuario = '{usuarioActual}'";
            var dt = ConexionBD.query(query);
            var dr = dt.Rows[0];
            var  apellido = dr[0].ToString();

            return apellido;
        }

        public static int obtenerDepartamento()
        {
            string query =
                $"select id_departamento from usuario where id_usuario = '{usuarioActual}'";
            var dt = ConexionBD.query(query);
            var dr = dt.Rows[0];
            return Convert.ToInt16(dr[0]);
        }
    }
}
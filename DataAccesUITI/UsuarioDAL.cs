using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccesUITI
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int DPI { get; set; }
    }
    public class UsuarioDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";

        public UsuarioDAL() { }

        public List<Usuario> GetUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Usuario", conn))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    System.Data.DataTable dataUsuario = new System.Data.DataTable();
                    using (System.Data.SqlClient.SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataUsuario.Load(reader);
                    }
                    foreach (System.Data.DataRow item in dataUsuario.Rows)
                    {
                        usuarios.Add(new Usuario
                        {
                            IdUsuario = Convert.ToInt32(item["IdUsuario"]),
                            NombreUsuario = item["NombreUsuario"].ToString(),
                            Contrasena = item["Contrasena"].ToString() 
                            
                        });
                    }
                }
            }
            return usuarios;
        }
        public bool InsertUsuario(Usuario usuarios)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO UsuarioEstudiante VALUES('{usuarios.NombreUsuario}','{usuarios.Contrasena}','{usuarios.DPI}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool UpdateUsuario(Usuario usuarios)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE UsuarioEstudiante SET NombreUsuario='{usuarios.NombreUsuario}', Contrasena='{usuarios.Contrasena}' WHERE IdUsuario={usuarios.IdUsuario}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool DeleteUsuario(int idUsuario)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM UsuarioEstudiante WHERE IdUsuario={idUsuario}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ValidarLogin(string nombreUsuario, string contrasena)
        {

            Usuario usuario = GetUsuario().FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuario != null && usuario.Contrasena == contrasena)
            {
                return true;
            }
            return false;
        }
    }

}

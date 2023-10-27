using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesUITI
{
    public class UsuarioDAL
    {
        public class Usuario
        {
            public int IdUsuario { get; set; }
            public string NombreUsuario { get; set; }
            public string Contrasena { get; set; } 
        }

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

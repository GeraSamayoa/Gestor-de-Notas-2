using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesUITI
{
    public class UsuarioDocente
    {
        public int IdUsuarioDocente { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int DPI { get; set; }
    }
    public class UsuarioDocenteDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";

        public UsuarioDocenteDAL () {}

        public List<UsuarioDocente> GetUsuarioDocentes ()
        {
            List<UsuarioDocente> usuarioDocentes = new List<UsuarioDocente>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM UsuarioDocente", conn))
                {
                    comando.CommandType = System.Data.CommandType.Text;
                    System.Data.DataTable dataUsuarioDocente = new System.Data.DataTable();
                    using (System.Data.SqlClient.SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataUsuarioDocente.Load(reader);
                    }
                    foreach (System.Data.DataRow item in dataUsuarioDocente.Rows)
                    {
                        usuarioDocentes.Add(new UsuarioDocente
                        {
                            IdUsuarioDocente = Convert.ToInt32(item["IdUsuarioDocente"]),
                            NombreUsuario = item["Usuario"].ToString(),
                            
                            Contrasena = item["Contrasena"].ToString() 
                        });
                    }
                }
            }
            return usuarioDocentes;
        }
        public bool InsertUsuarioDocente(UsuarioDocente usuarioDocentes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO UsuarioDocente VALUES('{usuarioDocentes.NombreUsuario}','{usuarioDocentes.Contrasena}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    int filas = comando.ExecuteNonQuery();
                    if (filas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
            public bool UpdateUsuarioDocente(UsuarioDocente usuarioDocentes)
        {
                using (SqlConnection conn = new SqlConnection(conexion))
            {
                    conn.Open();
                    string sql = $"UPDATE UsuarioDocente SET NombreUsuario = '{usuarioDocentes.NombreUsuario}', Contrasena = '{usuarioDocentes.Contrasena}' WHERE IdUsuarioDocente = {usuarioDocentes.IdUsuarioDocente}";
                    using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                        int filas = comando.ExecuteNonQuery();
                        if (filas > 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
            public bool DeleteUsuarioDocente(int IdUsuarioDocente)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM UsuarioDocente WHERE IdUsuarioDocente = {IdUsuarioDocente}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    int filas = comando.ExecuteNonQuery();
                    if (filas > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
        public bool ValidarLoginDocente (string nombreUsuario, string contrasena)
        {
            UsuarioDocente usuarioDocente = GetUsuarioDocentes().FirstOrDefault(u => u.NombreUsuario == nombreUsuario);

            if (usuarioDocente != null && usuarioDocente.Contrasena == contrasena)
            {
                return true;
            }
            return false;
        }
    }
}

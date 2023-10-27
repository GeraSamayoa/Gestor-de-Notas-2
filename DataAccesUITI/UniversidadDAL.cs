using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Backend;

namespace DataAcces
{
    public class UniversidadDAL
    {
        string conexion = @"data source= ASOFIMP\asofi; initial catalog= UITI; user id=sa; password=1908pass;";
        public UniversidadDAL()
        {

        }
        public List<Universidad> GetUniversidad()
        {
            List<Universidad> universidades = new List<Universidad>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Universidad", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataUniversidad = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataUniversidad.Load(reader);
                    }
                    foreach (DataRow item in dataUniversidad.Rows)
                    {
                        universidades.Add(new Universidad
                        {
                            IdUniversidad = Convert.ToInt32(item["IdUniversidad"]),
                            NombreUniversidad = item["NombreUniversidad"].ToString(),
                            Direccion = item["Direccion"].ToString()

                        }
                        );

                    }
                }
            }
            return universidades;

        }
        public bool InsertUniversidad(Universidad universidades)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Universidad VALUES({universidades.IdUniversidad},'{universidades.NombreUniversidad}','{universidades.Direccion}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateUniversidad(Universidad universidades)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Universidad SET NombreCajero = '{universidades.NombreUniversidad}',Direccion= '{universidades.Direccion}'WHERE IdUniversidad = {universidades.IdUniversidad}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteUniversidad(Universidad universidades)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Universidad WHERE IdUniversidad = {universidades.IdUniversidad}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}

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
    public class SeccionDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public SeccionDAL()
        {

        }
        public List<Seccion> GetSeccion()
        {
            List<Seccion> secciones = new List<Seccion>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Seccion", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataSeccion = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataSeccion.Load(reader);
                    }
                    foreach (DataRow item in dataSeccion.Rows)
                    {
                        secciones.Add(new Seccion
                        {
                            IdSeccion = Convert.ToInt32(item["IdSeccion"]),
                            Tipo = Convert.ToChar(item["Tipo"])
                        }
                        );

                    }
                }
            }
            return secciones;

        }
        public bool InsertSeccion(Seccion secciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Seccion VALUES({secciones.IdSeccion},'{secciones.Tipo}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateSeccion(Seccion secciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Seccion SET Tipo = '{secciones.Tipo}'WHERE IdUniversidad = {secciones.IdSeccion}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteSeccion(Seccion secciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Seccion WHERE IdSeccion = {secciones.IdSeccion}";
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


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
    public class JornadaDAL
    {

        string conexion = @"data source= ASOFIMP\asofimp; initial catalog= UITI; user id=sa; password=1908pass;";
        public JornadaDAL()
        {

        }
        public List<Jornada> GetJornada()
        {
            List<Jornada> jornadas = new List<Jornada>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Jornada", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataJornada = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataJornada.Load(reader);
                    }
                    foreach (DataRow item in dataJornada.Rows)
                    {
                        jornadas.Add(new Jornada
                        {
                            IdJornada = Convert.ToInt32(item["IdJornada"]),
                            Tipo = item["Tipo"].ToString(),
                            Estatus = Convert.ToBoolean(item["Estatus"]),

                        }
                        );

                    }
                }
            }
            return jornadas;

        }
        public bool InsertJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Jornada VALUES({jornadas.IdJornada},'{jornadas.IdJornada}','{jornadas.Tipo}','{jornadas.Estatus}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Jornada SET Tipo = '{jornadas.Tipo}',Estatus= '{jornadas.Estatus}'WHERE IdJornada = {jornadas.IdJornada}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Jornada WHERE IdJornada = {jornadas.IdJornada}";
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


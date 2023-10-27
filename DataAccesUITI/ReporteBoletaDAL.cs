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
    public class ReporteBoletaDAL
    {

        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public ReporteBoletaDAL()
        {

        }
        public List<ReporteBoletaCalifaciones> GetReporteBoletaCalifaciones()
        {
            List<ReporteBoletaCalifaciones> reporteBoletaCalifaciones = new List<ReporteBoletaCalifaciones>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM ReporteBoletaCalifaciones", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataReporteBoletaCalifaciones = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataReporteBoletaCalifaciones.Load(reader);
                    }
                    foreach (DataRow item in dataReporteBoletaCalifaciones.Rows)
                    {
                        reporteBoletaCalifaciones.Add(new ReporteBoletaCalifaciones
                        {
                            IdBoletaCalificaciones = Convert.ToInt32(item["IdBoletaCalificaciones"]),
                            FechaBoleta = Convert.ToDateTime(item["FechaBoleta"])

                        }
                        );

                    }
                }
            }
            return reporteBoletaCalifaciones;

        }
        public bool InsertReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO ReporteBoletaCalifaciones VALUES({reporteBoletaCalifaciones.IdBoletaCalificaciones},'{reporteBoletaCalifaciones.FechaBoleta}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE ReporteBoletaCalifaciones SET FechaBoleta = '{reporteBoletaCalifaciones.FechaBoleta}'WHERE IdBoletaCalificaciones= {reporteBoletaCalifaciones.IdBoletaCalificaciones}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteUniversidad(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM ReporteBoletaCalifaciones WHERE IdUniversidad = {reporteBoletaCalifaciones.IdBoletaCalificaciones}";
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

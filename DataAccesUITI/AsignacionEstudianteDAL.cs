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
    public class AsignacionEstudianteDAL
    {

        string conexion = @"data source= ASOFIMP\asofimp; initial catalog= UITI; user id=sa; password=1908pass;";
        public AsignacionEstudianteDAL()
        {

        }
        public List<AsignacionEstudiante> GetAsignacionEstudiante()
        {
            List<AsignacionEstudiante> asignacionesEstudiante = new List<AsignacionEstudiante>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM AsignacionEstudiante", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataAsignacionEstudiante = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataAsignacionEstudiante.Load(reader);
                    }
                    foreach (DataRow item in dataAsignacionEstudiante.Rows)
                    {
                        asignacionesEstudiante.Add(new AsignacionEstudiante
                        {
                            IdAsignacionEstudiante = Convert.ToInt32(item["IdAsignacionEstudiante"]),
                            FechaAsignacion = Convert.ToDateTime(item["FechaAsignacion"]),
                            Estado = item["Estado"].ToString()


                        }
                        );

                    }
                }
            }
            return asignacionesEstudiante;

        }
        public bool InsertAsignacionEstudiante(AsignacionEstudiante asignacionesEstudiante)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO AsignacionEstudiante VALUES({asignacionesEstudiante.IdAsignacionEstudiante},{asignacionesEstudiante.FechaAsignacion},{asignacionesEstudiante.Estado}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateAsignacionEstudiante(AsignacionEstudiante asignacionesEstudiante)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE AsignacionEstudiante SET FechaAsignacion = '{asignacionesEstudiante.FechaAsignacion},'{asignacionesEstudiante.Estado}'WHERE IdAsignacionEstudiante= {asignacionesEstudiante.IdAsignacionEstudiante}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteAsignacionEstudiante(AsignacionEstudiante asignacionesEstudiante)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM AsignacionEstudiante WHERE IdAsignacionDocente = {asignacionesEstudiante.IdAsignacionEstudiante}";
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

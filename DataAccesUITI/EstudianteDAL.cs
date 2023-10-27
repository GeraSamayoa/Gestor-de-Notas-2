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
    public class EstudianteDAL
    {
        string conexion = @"data source= ASOFIMP\asofi; initial catalog= UITI; user id=sa; password=1908pass;";
        public EstudianteDAL()
        {

        }
        public List<Estudiante> GetEstudiante()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Estudiante", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataEstudiante = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataEstudiante.Load(reader);
                    }
                    foreach (DataRow item in dataEstudiante.Rows)
                    {
                        estudiantes.Add(new Estudiante
                        {
                            NoCarne = Convert.ToInt32(item["NoCarne"]),
                            Estatus = item["Estatus"].ToString(),
                            //FechaIngreso = Convert.ToDateTime(item["FechaIngreso"]),
                            Contrasenia = item["Contrasenia"].ToString()
                        }
                        );

                    }
                }
            }
            return estudiantes;

        }
        public bool InsertEstudiante(Estudiante estudiantes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Estudiante VALUES({estudiantes.NoCarne},'{estudiantes.Estatus}','{estudiantes.Contrasenia}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateEstudiante(Estudiante estudiantes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Estudiante SET Estatus = '{estudiantes.Estatus}',Contrasenia= '{estudiantes.Contrasenia}'WHERE NoCarne = {estudiantes.NoCarne}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteEstudiante(Estudiante estudiantes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Estudiante WHERE IdEstudiante = {estudiantes.NoCarne}";
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

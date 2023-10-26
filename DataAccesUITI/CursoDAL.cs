using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAcces
{
    public class CursoDAL
    {
        string conexion = @"data source= DESKTOP-LIBT4K5\SQLEXPRESS; initial catalog= UITI; user id=sa; password=00123456;";
        public CursoDAL()
        {

        }
        public List<Curso> GetCurso()
        {
            List<Curso> cursos = new List<Curso>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Curso", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataCurso = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataCurso.Load(reader);
                    }
                    foreach (DataRow item in dataCurso.Rows)
                    {
                        cursos.Add(new Curso
                        {
                            IdCurso = Convert.ToInt32(item["IdCurso"]),
                            NombreCurso = item["NombreCurso"].ToString(),
                            HoraInicio = TimeSpan.Parse(item["HoraInicio"].ToString()),
                            HoraFinal = TimeSpan.Parse(item["HoraFinal"].ToString()),
                            Estatus = Convert.ToBoolean(item["IdCurso"])

                        }
                        );

                    }
                }
            }
            return cursos;

        }
        public bool InsertCurso(Curso cursos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Curso VALUES({cursos.IdCurso},'{cursos.NombreCurso}','{cursos.HoraInicio}','{cursos.HoraFinal}','{cursos.Estatus}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateCurso(Curso cursos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Curso SET NombreCurso = '{cursos.NombreCurso}','{cursos.HoraInicio}','{cursos.HoraFinal}','{cursos.Estatus}'WHERE IdCurso = {cursos.IdCurso}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteCurso(Curso cursos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Curso WHERE IdCurso = {cursos.IdCurso}";
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
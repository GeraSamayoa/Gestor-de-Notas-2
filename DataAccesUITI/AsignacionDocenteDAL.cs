using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Backend;

namespace DataAcces
{
    public class AsignacionDocenteDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";

        public AsignacionDocenteDAL()
        {
        }

        public List<AsignacionDocente> GetAsignacionDocente()
        {
            List<AsignacionDocente> asignacionesDocente = new List<AsignacionDocente>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM AsignacionDocente", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataAsignacionDocente = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataAsignacionDocente.Load(reader);
                    }
                    foreach (DataRow item in dataAsignacionDocente.Rows)
                    {
                        asignacionesDocente.Add(new AsignacionDocente
                        {
                            IdAsignacionDocente = Convert.ToInt32(item["IdAsignacionDocente"]),
                            fecha = Convert.ToDateTime(item["fecha"])
                        });
                    }
                }
            }
            return asignacionesDocente;
        }

        //public bool InsertAsignacionDocente(AsignacionDocente asignacionesDocente)
        //{
        //    using (SqlConnection conn = new SqlConnection(conexion))
        //    {
        //        conn.Open();
        //        string sql = $"INSERT INTO AsignacionDocente VALUES({{asignacionesDocente.fecha}')";
        //        using (SqlCommand comando = new SqlCommand(sql, conn))
        //        {
        //            comando.CommandType = CommandType.Text;
        //            comando.ExecuteNonQuery();
        //        }
        //    }
        //    return true;
        //}

        public bool UpdateAsignacionDocente(AsignacionDocente asignacionesDocente)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE AsignacionDocente SET fecha = '{asignacionesDocente.fecha}' WHERE IdUniversidad = {asignacionesDocente.IdAsignacionDocente}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool DeleteAsignacionDocente(AsignacionDocente asignacionesDocente)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM AsignacionDocente WHERE IdAsignacionDocente = {asignacionesDocente.IdAsignacionDocente}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool GuardarAsignacionDocente(AsignacionDocente asignacion)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = "INSERT INTO AsignacionDocente (IdDocente, IdJornada, IdCarrera, IdCurso, IdSeccion) VALUES (@IdDocente, @IdJornada, @IdCarrera, @IdCurso, @IdSeccion)";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@IdDocente", asignacion.Docente.IdDocente);
                    comando.Parameters.AddWithValue("@IdJornada", asignacion.Jornada.IdJornada);
                    comando.Parameters.AddWithValue("@IdCarrera", asignacion.Carrera.IdCarrera);
                    comando.Parameters.AddWithValue("@IdCurso", asignacion.Curso.IdCurso);
                    comando.Parameters.AddWithValue("@IdSeccion", asignacion.Seccion.IdSeccion);
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}

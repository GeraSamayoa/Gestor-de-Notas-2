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
    internal class RegistroNotasDAL
    {

        string conexion = @"data source= ASOFIMP\asofimp; initial catalog= UITI; user id=sa; password=1908pass;";
        public RegistroNotasDAL()
        {

        }
        public List<RegistroNotas> GetRegistroNotas()
        {
            List<RegistroNotas> registroNotas = new List<RegistroNotas>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM RegistroNotas", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataRegistroNotas = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataRegistroNotas.Load(reader);
                    }
                    foreach (DataRow item in dataRegistroNotas.Rows)
                    {
                        registroNotas.Add(new RegistroNotas
                        {
                            IdNota = Convert.ToInt32(item["IdNota"]),
                            TipoDeNotas = item["TipodeNotas"].ToString(),
                            NotaAlumno = Convert.ToInt32(item["NotaAlumno"]),
                            Zona = Convert.ToInt32(item["Zona"]),
                            NotaTotal = Convert.ToInt32(item["NotaTotal"]),
                          

                        }
                        );

                    }
                }
            }
            return registroNotas;

        }
        public bool InsertRegistroNotas(RegistroNotas registroNotas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO RegistroNotas VALUES({registroNotas.IdNota},'{registroNotas.TipoDeNotas}','{registroNotas.Zona},'{registroNotas.NotaTotal}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateRegistroNotas(RegistroNotas registroNotas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE RegistroNotas SET TipoDeNotas = '{registroNotas.TipoDeNotas}','{registroNotas.Zona},'{registroNotas.NotaTotal}'WHERE IdNota = {registroNotas.IdNota}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteRegistroNotas(RegistroNotas registroNotas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM RegistroNotas WHERE IdUniversidad = {registroNotas.IdNota}";
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

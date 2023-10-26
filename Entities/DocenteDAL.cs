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
    public class DocenteDAL
    {
        string conexion = @"data source= ASOFIMP\asofimp; initial catalog= UITI; user id=sa; password=1908pass;";
        public DocenteDAL()
        {

        }
        public List<Docente> GetDocente()
        {
            List<Docente> docentes = new List<Docente>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Docente", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataDocente = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataDocente.Load(reader);
                    }
                    foreach (DataRow item in dataDocente.Rows)
                    {
                        docentes.Add(new Docente
                        {
                            IdDocente = Convert.ToInt32(item["IdDocente"]),
                            Estatus = Convert.ToChar(item["Estatus"])

                        }
                        );

                    }
                }
            }
            return docentes;

        }
        public bool InsertDocente(Docente docentes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Docente VALUES({universidades.IdUniversidad},'{universidades.NombreUniversidad}','{universidades.Direccion}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateDocente(Docente docentes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Docente SET Estatus = '{docentes.Estatus}'WHERE IdDocente = {docentes.IdDocente}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteDocente(Docente docentes)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Docente WHERE IdDocente = {docentes.IdDocente}";
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

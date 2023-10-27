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
    public class CicloDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=00123456;";
        public CicloDAL()
        {

        }
        public List<Ciclo> GetCiclo()
        {
            List<Ciclo> ciclos = new List<Ciclo>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Ciclo", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataCiclo = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataCiclo.Load(reader);
                    }
                    foreach (DataRow item in dataCiclo.Rows)
                    {
                        ciclos.Add(new Ciclo
                        {
                            IdCiclo = Convert.ToInt32(item["IdCiclo"]),
                            TipoCiclo = item["TipoCiclo"].ToString(),

                        }
                        );

                    }
                }
            }
            return ciclos;

        }
        public bool InsertCiclo(Ciclo ciclos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Ciclo VALUES({ciclos.IdCiclo},'{ciclos.TipoCiclo}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateCiclo(Ciclo ciclos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Ciclo SET TipoCiclo = '{ciclos.TipoCiclo}'WHERE IdCiclo = {ciclos.IdCiclo}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteCiclo(Ciclo ciclos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Ciclo WHERE Idciclo = {ciclos.IdCiclo}";
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

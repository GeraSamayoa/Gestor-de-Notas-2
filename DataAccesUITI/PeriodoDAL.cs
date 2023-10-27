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
    public class PeriodoDAL
    {

        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public PeriodoDAL()
        {

        }
        public List<Periodo> GetPeriodo()
        {
            List<Periodo> periodos = new List<Periodo>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Periodo", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataPeriodo = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataPeriodo.Load(reader);
                    }
                    foreach (DataRow item in dataPeriodo.Rows)
                    {
                        periodos.Add(new Periodo
                        {
                            IdPeriodo = Convert.ToInt32(item["IdPeriodo"]),
                            NombrePeriodo = item["NombrePeriodo"].ToString()

                        }
                        );

                    }
                }
            }
            return periodos;

        }
        public bool InsertPeriodo(Periodo periodos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Periodo VALUES({periodos.IdPeriodo},'{periodos.NombrePeriodo}')";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdatePeriodo(Periodo periodos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Periodo SET NombrePeriodo = '{periodos.NombrePeriodo}'WHERE IdPeriodo = {periodos.IdPeriodo}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeletePeriodo(Periodo periodos)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Periodo WHERE IdPeriodo = {periodos.IdPeriodo}";
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


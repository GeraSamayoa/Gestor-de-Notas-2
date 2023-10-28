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
    public class CarreraDAL
    {
        string conexion = @"data source=ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public CarreraDAL()
        {

        }
        public List<Carrera> GetCarrera()
        {
            List<Carrera> carreras = new List<Carrera>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Carrera", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataCarrera = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataCarrera.Load(reader);
                    }
                    foreach (DataRow item in dataCarrera.Rows)
                    {
                        carreras.Add(new Carrera
                        {
                            IdCarrera = Convert.ToInt32(item["IdCarrera"]),
                            NombreCarrera = item["NombreCarrera"].ToString(),
                            Estatus = Convert.ToChar(item["Estatus"])

                        }
                        );

                    }
                }
            }
            return carreras;

        }
        public bool InsertCarrera(Carrera carreras)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                //INSERT INTO	Carrera VALUES('NombreCarrera','IdCiclo','IdJornada','IdUniversidad',1);
                string sql = $"INSERT INTO Carrera VALUES('{carreras.NombreCarrera}',{carreras.IdCiclo},{carreras.IdJornada},1,1)";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdateCarrera(Carrera carreras)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Carrera SET NombreCarrera = '{carreras.NombreCarrera}',Estatus= '{carreras.Estatus}'WHERE IdCarrera = {carreras.IdCarrera}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteCarrera(Carrera carreras)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Carrera WHERE IdCarrera = {carreras.IdCarrera}";
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
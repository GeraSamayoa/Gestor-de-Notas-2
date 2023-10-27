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
    public class PersonaDAL
    {
        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public PersonaDAL()
        {

        }
        public List<Persona> GetPersona()
        {
            List<Persona> personas = new List<Persona>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Persona", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataPersona = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataPersona.Load(reader);
                    }
                    foreach (DataRow item in dataPersona.Rows)
                    {
                        personas.Add(new Persona
                        {
                            IdPersona = Convert.ToInt32(item["DPI"]),
                            Nombre = item["Nombre"].ToString(),
                            Apellido = item["Apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"]),
                            Genero = item["Genero"].ToString()

                        }
                        );

                    }
                }
            }
            return personas;

        }
        public bool InsertPersona(Persona personas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"INSERT INTO Persona VALUES({personas.IdPersona},'{personas.Nombre}','{personas.Apellido}','{personas.FechaNacimiento}','{personas.Genero}',1)";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool UpdatePersona(Persona personas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Persona SET Nombre = '{personas.Nombre}',Apellido= '{personas.Apellido},FechaNacimiento= '{personas.FechaNacimiento},Genero= '{personas.Genero}'WHERE IdPersona = {personas.IdPersona}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeletePersona(Persona personas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Persona WHERE IdPersona = {personas.IdPersona}";
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


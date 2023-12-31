﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Backend;
namespace DataAcces
{
    public class JornadaDAL
    {

        string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";
        public JornadaDAL()
        {

        }
        public List<Jornada> GetJornada()
        {
            List<Jornada> jornadas = new List<Jornada>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand comando = new SqlCommand("SELECT * FROM Jornada", conn))
                {
                    comando.CommandType = CommandType.Text;
                    DataTable dataJornada = new DataTable();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        dataJornada.Load(reader);
                    }
                    foreach (DataRow item in dataJornada.Rows)
                    {
                        jornadas.Add(new Jornada
                        {
                            IdJornada = Convert.ToInt32(item["IdJornada"]),
                            TipoJornada = item["Tipo"].ToString(),
                            Estatus = Convert.ToBoolean(item["Estatus"]),

                        }
                        );

                    }
                }
            }
            return jornadas;

        }
        public bool InsertJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    string sql = $"INSERT INTO Jornada VALUES('{jornadas.TipoJornada}',1)";
                    using (SqlCommand comando = new SqlCommand(sql, conn))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                
            }
        }

        public int SetIdJornada(Jornada jornada)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"SELECT IdJornada from Jornada WHERE Tipo ='{jornada.TipoJornada}'";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    int idJornada = Convert.ToInt32(comando.ExecuteScalar());
                    return idJornada;
                }
                
            }
    
        }

        public bool UpdateJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"UPDATE Jornada SET Tipo = '{jornadas.TipoJornada}',Estatus= '{jornadas.Estatus}'WHERE IdJornada = {jornadas.IdJornada}";
                using (SqlCommand comando = new SqlCommand(sql, conn))
                {
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
        public bool DeleteJornada(Jornada jornadas)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string sql = $"DELETE FROM Jornada WHERE IdJornada = {jornadas.IdJornada}";
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


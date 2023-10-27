﻿using Backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesUITI
{
    public class Repositorio
    {
 
            private string conexion = @"data source= ASOFIMP; initial catalog= UITI; user id=sa; password=1908pass;";

        public List<Docente> ObtenerDocentes()
        {
            List<Docente> listaDocentes = new List<Docente>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Docente", conn))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Docente docente = new Docente
                            {
                                IdDocente = Convert.ToInt32(reader["IdDocente"]),
                                Estatus = Convert.ToChar(reader["Estatus"]),
                                Nombre = reader["Nombre"].ToString(),
                            };
                            listaDocentes.Add(docente);
                        }
                    }
                }
            }
            return listaDocentes;
        }
        public List<Curso> ObtenerCursos()
        {
            List<Curso> listaCursos = new List<Curso>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Curso", conn))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Curso curso = new Curso
                            {
                                IdCurso = Convert.ToInt32(reader["IdCurso"]),
                                NombreCurso = reader["NombreCurso"].ToString(),
                                //Estatus = Convert.ToChar(reader["Estatus"]),
                            };
                            listaCursos.Add(curso);
                        }
                    }
                }
            }
            return listaCursos;
        }
        public List<Carrera> ObtenerCarreras()
        {
            List<Carrera> listaCarreras = new List<Carrera>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Carrera", conn))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Carrera carrera = new Carrera                            {
                                IdCarrera = Convert.ToInt32(reader["IdCarrera"]),
                                NombreCarrera = reader["NombreCarrera"].ToString(),
                                //Estatus = Convert.ToChar(reader["Estatus"]),
                            };
                            listaCarreras.Add(carrera);
                        }
                    }
                }
            }
            return listaCarreras;

        }
        public List<Jornada> ObtenerJornadas()
        {
            List<Jornada> listaJornadas = new List<Jornada>();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                using (SqlCommand comando = new SqlCommand("SELECT * FROM Jornada", conn))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Carrera carrera = new Carrera
                            {
                                IdCarrera = Convert.ToInt32(reader["IdCarrera"]),
                                NombreCarrera = reader["NombreCarrera"].ToString(),
                                //Estatus = Convert.ToChar(reader["Estatus"]),
                            };
                            listaCarreras.Add(carrera);
                        }
                    }
                }
               
            }
            return listaJornadas;
        }
    }
}
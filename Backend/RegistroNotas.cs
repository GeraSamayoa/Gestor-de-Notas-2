using System;
using System.Collections.Generic;

namespace Backend
{
    public class RegistroNotas
    {
        public Docente Docentes { get; set; }
        public List<Docente> docentes { get; set; }
        public Carrera Carreras { get; set; }
        public List<Carrera> carreras { get; set; }
        public Jornada Jornada { get; set; }
        public List<Jornada> jornadas { get; set; }
        public Ciclo Ciclos { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Seccion Secciones { get; set; }
        public List<Seccion> secciones { get; set; }
        public Curso Cursos { get; set; }
        public List<Curso> cursos { get; set; }
        public Periodo Periodos { get; set; }
        public List<Periodo> periodos { get; set; }
        public Estudiante IdEstudiantes { get; set; }
        public List<Estudiante> estudiantes { get; set; }
        public AsignacionEstudiante IdAsignaciones { get; set; }
        public List<AsignacionEstudiante> asignaciones { get; set; }

        public int IdNota { get; set; }
        public string TipoDeNotas { get; set; }
        public int NotaAlumno { get; set; }
        public int Zona { get; set; }
        public int NotaTotal { get; set; }

        //Tipos de notas constantes
        public static List<string> tipoDeNotas = new List<string>() { "Primer Parcial", "Segundo Parcial", "Actividades", "Examen Final" };

        //Lista de notas
        public static List<RegistroNotas> ListaRegistroNotas = new List<RegistroNotas>();

        public RegistroNotas(int idNota, int notaAlumno, int zona, int notaTotal)
        {
            docentes = new List<Docente>();
            carreras = new List<Carrera>();
            jornadas = new List<Jornada>();
            ciclos = new List<Ciclo>();
            secciones = new List<Seccion>();
            cursos = new List<Curso>();
            periodos = new List<Periodo>();
            estudiantes = new List<Estudiante>();
            asignaciones = new List<AsignacionEstudiante>();
            IdNota = idNota;

            //Validar y asignar el tipo de notas
            if (tipoDeNotas.Contains(TipoDeNotas))
            {
                this.TipoDeNotas = TipoDeNotas;
            }
            else
            {
                throw new ArgumentException("Tipo de notas no válido.");
            }

            //Validar las notas
            if (notaAlumno >= 0 && notaAlumno <= 100)
            {
                NotaAlumno = notaAlumno;
            }
            else
            {
                throw new ArgumentException("Nota de alumno no válida.");
            }

            Zona = zona;
            NotaTotal = notaTotal;
        }


        //Metodo para agregar registro de notas
        public void AgregarRegistroNotas(RegistroNotas registroNotas)
        {
            //Realiza validaciones antes de agregar
            if (registroNotas.NotaAlumno < 0 || registroNotas.NotaAlumno > 100)
            {
                throw new ArgumentException("Nota de alumno no válida.");
            }
            if (!tipoDeNotas.Contains(registroNotas.TipoDeNotas))
            {
                throw new ArgumentException("Tipo de notas no válido.");
            }

            //Calcula Zona y acumula las notas
            switch (registroNotas.TipoDeNotas)
            {
                case "Primer Parcial":
                    registroNotas.Zona = registroNotas.NotaAlumno;
                    break;
                case "Segundo Parcial":
                    registroNotas.Zona += registroNotas.NotaAlumno;
                    break;
                case "Actividades":
                    registroNotas.Zona += registroNotas.NotaAlumno;
                    break;
                case "Examen Final":
                    registroNotas.NotaTotal = registroNotas.Zona + registroNotas.NotaAlumno;
                    break;
            }

            //Agrega el registro de notas
            ListaRegistroNotas.Add(registroNotas);
        }

        //Metodo para eliminar registro de notas
        public void EliminarRegistroNotas(RegistroNotas registroNotas)
        {
            ListaRegistroNotas.Remove(registroNotas);
        }

        //Metodo para modificar registro de notas
        public void ModificarRegistroNotas(int indice, RegistroNotas registroNotas)
        {
            ListaRegistroNotas[indice] = registroNotas;
        }

        //Metodo para mostrar registro de notas
        public List<RegistroNotas> MostrarRegistroNotas()
        {
            return ListaRegistroNotas;
        }
    }
    }
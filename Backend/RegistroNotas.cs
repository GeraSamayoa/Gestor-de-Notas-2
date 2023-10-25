using System.Collections.Generic;
using System;

namespace Backend
{
    public class RegistroNotas
    {
        public int IdNota { get; set; }
        public string TipoDeNotas { get; set; }
        public int NotaAlumno { get; set; }
        public int Zona { get; set; }
        public int NotaTotal { get; set; }
        public string EstatusAprobacion
        {
            get
            {
                if (NotaTotal >= 61)
                {
                    return "Aprobado";
                }
                else
                {
                    return "Reprobado";
                }
            }
        }
        public Docente Docente { get; set; }
        public Carrera Carrera { get; set; }
        public Jornada Jornada { get; set; }
        public Ciclo Ciclo { get; set; }
        public Seccion Seccion { get; set; }
        public Curso Curso { get; set; }
        public Periodo Periodo { get; set; }
        public Estudiante Estudiante { get; set; }
        public AsignacionEstudiante Asignacion { get; set; }

        // Tipos de notas constantes
        public static List<string> TiposDeNotas = new List<string>() { "Primer Parcial", "Segundo Parcial", "Actividades", "Examen Final" };

        // Lista de notas
        public static List<RegistroNotas> ListaRegistroNotas = new List<RegistroNotas>();

        public RegistroNotas(int idNota, int notaAlumno, int zona, int notaTotal)
        {
            IdNota = idNota;
            NotaAlumno = ValidarNotaAlumno(notaAlumno);
            TipoDeNotas = ValidarTipoDeNotas(TipoDeNotas);
            Zona = zona;
            NotaTotal = notaTotal;
        }

        private int ValidarNotaAlumno(int nota)
        {
            if (nota < 0 || nota > 100)
                throw new ArgumentException("Nota de alumno no válida.");
            return nota;
        }

        private string ValidarTipoDeNotas(string tipo)
        {
            if (!TiposDeNotas.Contains(tipo))
                throw new ArgumentException("Tipo de notas no válido.");
            return tipo;
        }

        public void AgregarRegistroNotas(RegistroNotas registroNotas)
        {
            // Calcula Zona y acumula las notas
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
        }

    }
    }
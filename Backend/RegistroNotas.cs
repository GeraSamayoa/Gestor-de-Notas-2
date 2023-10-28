using System;
using System.Collections.Generic;

namespace Backend
{
    public class RegistroNotas
    {
        public int IdNota { get; set; }
        public int NotaPrimerParcial { get; set; }
        public int NotaSegundoParcial { get; set; }
        public int NotaActividades { get; set; }
        public int NotaExamenFinal { get; set; }
        public int Zona{ get; set;}
        public int NotaTotal{get; set;}
        public string EstatusAprobacion
        {
            get; set;
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

        // Lista de notas
        public static List<RegistroNotas> ListaRegistroNotas = new List<RegistroNotas>();

        //public RegistroNotas(int idNota, int notaPrimerParcial, int notaSegundoParcial, int notaActividades, int notaExamenFinal)
        //{
          //  IdNota = idNota;
            //NotaPrimerParcial = ValidarNota(notaPrimerParcial);
            //NotaSegundoParcial = ValidarNota(notaSegundoParcial);
            //NotaActividades = ValidarNota(notaActividades);
            //NotaExamenFinal = ValidarNota(notaExamenFinal);
        //}

        private int ValidarNota(int nota)
        {
            if (nota < 0 || nota > 100)
                throw new ArgumentException("Nota no válida.");
            return nota;
        }
    }
}
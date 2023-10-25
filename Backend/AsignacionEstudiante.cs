using System.Collections.Generic;
using System;

namespace Backend
{
    public class AsignacionEstudiante
    {
        public int IdAsignacionEstudiante { get; set; }
        public Estudiante Estudiante { get; set; }
        public Docente Docente { get; set; }
        public Seccion Seccion { get; set; }
        public Ciclo Ciclo { get; set; }
        public Jornada Jornada { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public Periodo Periodo { get; set; }
        public string Estado { get; set; }
        public Curso Curso { get; set; }
        public Carrera Carrera { get; set; }

        public AsignacionEstudiante(int idAsignacionEstudiante, DateTime fechaAsignacion, string estado)
        {
            IdAsignacionEstudiante = idAsignacionEstudiante;
            FechaAsignacion = fechaAsignacion;
            Estado = estado;
        }

        // Lista de asignaciones
        public static List<AsignacionEstudiante> listaAsignacionesEstudiantes = new List<AsignacionEstudiante>();


    }
}

using System.Collections.Generic;
using System;

namespace Backend
{
    public class ReporteBoletaCalifaciones
    {
        public int IdBoletaCalificaciones { get; set; }
        public DateTime FechaBoleta { get; set; }
        public Estudiante Estudiante { get; set; }
        public AsignacionEstudiante Asignacion { get; set; }
        public Ciclo Ciclo { get; set; }
        public Curso Curso { get; set; }
        public RegistroNotas RegistroNotas { get; set; }
        public List<string> TipoDeNotas { get; set; }
        public List<RegistroNotas> Notas { get; set; }


        public static List<ReporteBoletaCalifaciones> ListaReporteBoletaCalifaciones = new List<ReporteBoletaCalifaciones>();


    }
}

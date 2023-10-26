using System;
using System.Collections.Generic;

namespace Backend
{
    public class AsignacionDocente
    {
        public int IdAsignacionDocente { get; set; }
        public DateTime fecha { get; set; }
        public Docente Docente { get; set; }
        public Seccion Seccion { get; set; }
        public Ciclo Ciclo { get; set; }
        public Jornada Jornada { get; set; }
        public Curso Curso { get; set; }
        public Carrera Carrera { get; set; }

        public static List<AsignacionDocente> ListaAsignacionesDocentes = new List<AsignacionDocente>();

        public List<AsignacionDocente> MostrarAsignaciones()
        {
            return ListaAsignacionesDocentes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Curso
    {
        public List<Ciclo> ciclo { get; set; }
        public List<Seccion> seccion{ get; set; }

        public int IdCurso {  get; set; }

        public string NombreCurso { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFinal { get; set; }

        public bool Estatus { get; set; }

        public Curso(int idcurso, string nombrecurso, TimeSpan inicio,TimeSpan final) 
        { 
            IdCurso = idcurso;
            NombreCurso = nombrecurso;
            HoraInicio = new TimeSpan();
            HoraFinal = new TimeSpan();
            Estatus = true;
            ciclo = new List<Ciclo>();
            seccion= new List<Seccion>();
        }

        public List<Curso> CursoList;

        public void RepositorioCurso()
        {
            CursoList = new List<Curso>();
        }


    }
}

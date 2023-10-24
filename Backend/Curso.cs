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

        public int IdCurso {  get; set; }

        public string NombreCurso { get; set; }

        public int CantidadPorSemana { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFinal { get; set; }

        public bool status { get; set; }

        public Curso(int idcurso, string nombrecurso, int cantidadAlaSemana , TimeSpan inicio,TimeSpan final) 
        { 
            this.IdCurso = idcurso;
            this.NombreCurso = nombrecurso;
            this.CantidadPorSemana = cantidadAlaSemana;
            this.HoraInicio = new TimeSpan();
            this.HoraFinal = new TimeSpan();
            this.status = true;
            this.ciclo = new List<Ciclo>();
        }

        public List<Curso> CursoList;

        public void RepositorioCurso()
        {
            CursoList = new List<Curso>();
        }

        public void AgregarCurso(Curso curso) 
        {
            CursoList.Add(curso);
        }

        public void EliminarCurso (Curso curso)
        {
            CursoList.Remove(curso);
        }
    }
}

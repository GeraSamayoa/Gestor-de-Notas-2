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

 

        public List<Curso> CursoList;

        public void RepositorioCurso()
        {
            CursoList = new List<Curso>();
        }


    }
}

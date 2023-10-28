using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Curso
    {
        public Ciclo Ciclo { get; set; }
        public Seccion Seccion { get; set; }

        public Universidad Universidad { get; set; }
        public Carrera Carrera { get; set; }
        public Jornada Jornada { get; set; }

        public int IdCurso { get; set; }

        public string NombreCurso { get; set; }

        public string HoraInicio { get; set; }

        public string HoraFinal { get; set; }

        public bool Estatus { get; set; }

 

        public List<Curso> CursoList;

        public void RepositorioCurso()
        {
            CursoList = new List<Curso>();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Docente:Persona
    {
        public int IdDocente {  get; set; }
        //
        public AsignacionDocente IdAsignacionDocente { get; set; }
        public char Estatus { get; set; }

        public List<Docente> listaDocente = new List<Docente>();
        

    }
}

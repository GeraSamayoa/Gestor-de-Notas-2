using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Seccion
    {
        public int IdSeccion { get; set; }
        public char Tipo { get; set; }


        public List<Seccion> listaSeccion = new List<Seccion>();

    }
}
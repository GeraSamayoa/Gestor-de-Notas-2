using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Ciclo
    {

        public int IdCiclo { get; set; }
        public string TipoCiclo { get; set; }

        //Asociacion Ciclo y Curso

        public Ciclo (int idCiclo, string tipociclo)
        {
            IdCiclo = idCiclo;
            TipoCiclo = tipociclo;
        }
    }
}

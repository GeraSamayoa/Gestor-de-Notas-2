using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Periodo
    {
        public int IdPeriodo { get; set; }

        public string NombrePeriodo { get; set; }
        
       // public Periodo(int idperiodo, string nombreperiodo)
       // { 
         //   this.IdPeriodo = idperiodo;
           // this.NombrePeriodo = nombreperiodo;
        //}

        public List<Periodo> PeriodoList;

        public void RepositorioPeriodo()
        {
            PeriodoList = new List<Periodo>();
        } 


    }
}

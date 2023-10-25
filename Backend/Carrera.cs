using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Carrera
    {
        public string idCarrera { get; set; }
        public string NameCarrera { get; set; }
        public Ciclo IdCiclo { get; set; }
        public Jornada IdJornada { get; set; }
        public bool status { get; set; }
        public Universidad IdUniversidad { get; set; }
        public List<Ciclo> ciclo { get; set; }
        public Carrera(string idcarrera, string namecarrera, Ciclo ciclos)
        {
            this.idCarrera = idcarrera;
            this.NameCarrera = namecarrera;
            this.status = true;
            ciclo = new List<Ciclo>();
            this.ciclo.Add(ciclos);


    }
        public List<Carrera> CarreraList;

        public void RepositorioCarrera()
        {
            CarreraList = new List<Carrera>();
        }

        public void AgregarCarrera(Carrera carrera)
        {
            CarreraList.Add(carrera);
        }

        public void EliminarCarrera(Carrera carrera)
        {
            CarreraList.Remove(carrera);
        }


        public Carrera carrera { get; set; }

      

    }
}


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

        public int idCiclo { get; set; }

        public bool status { get; set; }

        public Carrera(string idcarrera, string namecarrera, int idciclo, TimeSpan idjornada)
        {
            this.idCarrera = idcarrera;
            this.NameCarrera = namecarrera;
            this.idCiclo = idciclo;
            this.status = true;
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
    }
}


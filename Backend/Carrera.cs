using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Carrera
    {
        public string IdCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public List<Ciclo> Ciclos { get; set; } = new List<Ciclo>();
        public List<Jornada> Jornadas { get; set; } = new List<Jornada>();
        public bool Status { get; set; }
        public Universidad Universidad { get; set; }

        private List<Carrera> carreraList;

        public Carrera(string idCarrera, string nombreCarrera,bool status, Ciclo ciclo)
        {
            this.IdCarrera = idCarrera;
            this.NombreCarrera = nombreCarrera;
            this.Status = true;
            this.carreraList = new List<Carrera>();
            Ciclos = new List<Ciclo>();
            this.Ciclos.Add(ciclo);
        }

    }
}
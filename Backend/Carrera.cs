using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string NombreCarrera { get; set; }
        public List<Ciclo> Ciclos { get; set; } = new List<Ciclo>();
        public List<Jornada> Jornadas { get; set; } = new List<Jornada>();
        public bool Estatus { get; set; }
        public Universidad Universidad { get; set; }

        private List<Carrera> carreraList;

        public Carrera(int idCarrera, string nombreCarrera,bool estatus, Ciclo ciclo)
        {
            this.IdCarrera = idCarrera;
            this.NombreCarrera = nombreCarrera;
            this.Estatus = true;
            this.carreraList = new List<Carrera>();
            Ciclos = new List<Ciclo>();
            this.Ciclos.Add(ciclo);
        }


    }
}
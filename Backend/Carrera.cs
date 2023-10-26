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






    }
}
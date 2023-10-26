using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Jornada
    {
        //Atributos
        public int IdJornada { get; set; }

        public string Tipo { get; set; }

        public bool Estatus { get; set;}

        //Metodo Constructor
        public Jornada (int idJornada, string tipo, bool status)
        {
            this.IdJornada = idJornada;
            this.Tipo = tipo;
            this.Estatus = status;
        }

        // Creacion de listas

        public List<Jornada> jornadas;

        public void RepositorioJornada() 
        {
            jornadas = new List<Jornada>();
        }

      

    }
}

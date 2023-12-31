﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Universidad
    {
        public int IdUniversidad { get; set; }
        public string NombreUniversidad { get; set; }
        public string Direccion { get; set; }
        public List<Carrera> Carreras { get; set; }

        //Dependencia de persona

        public List <Persona>Personas { get; set; }
       

        public Universidad ()
        {
            Personas = new List<Persona>();
            Carreras = new List<Carrera>();

        }
        public Persona Obtener (int idPersona)
        {
            var persona = Personas.Find(x => x.IdPersona == idPersona);
            return persona;
        }

  
    }
}

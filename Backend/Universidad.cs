using System;
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

        public bool Guardar (Persona persona)
        {
            Personas.Add(persona);
            return true;
        }

        public Persona Obtener (int idPersona)
        {
            var persona = Personas.Find(x => x.IdPersona == idPersona);
            return persona;
        }

        // Métodos para gestionar carreras
        public void AgregarCarrera(Carrera carrera)
        {
            Carreras.Add(carrera);
            carrera.Universidad = this; // Asociar la carrera a esta universidad
        }

        public void EliminarCarrera(Carrera carrera)
        {
            Carreras.Remove(carrera);
            carrera.Universidad = null; // Desasociar la carrera de esta universidad
        }
    }
}

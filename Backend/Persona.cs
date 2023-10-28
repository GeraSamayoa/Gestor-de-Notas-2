using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        public int IdPersona {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Genero {  get; set; }

 

        public List <Universidad> Universidades { get; set; }
        


        
    }
}

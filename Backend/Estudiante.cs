using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Estudiante:Persona
    {
       public int NoCarne {  get; set; }
        //Tomar en cuenta :D
       public AsignacionEstudiante IdAsignacionEstudiante {  get; set; }
        public char Estatus {  get; set; }
       public DateTime FehcaIngreso { get; set; }
       public string Contrasenia { get; set; }

       public Estudiante(int nocarne, char estatus, DateTime fechaingreso, string contrasenia, int idpersona, string nombre, string apellido, DateTime fechanacimiento, string genero)
            :base(idpersona, nombre, apellido, fechanacimiento, genero) { 
            this.NoCarne = nocarne;
            this.Estatus = estatus;
            this.FehcaIngreso = fechaingreso;
            this.Contrasenia = contrasenia;

       }

        public List<Estudiante> listaEstudiante = new List<Estudiante>();


    }
}

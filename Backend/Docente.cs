using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Docente:Persona
    {
        public int IdDocente {  get; set; }
        //
        public AsignacionDocente IdAsignacionDocente { get; set; }
        public char Estatus { get; set; }

        public Docente(int idDocente, char estatus, int idpersona, string nombre, string apellido, DateTime fechanacimiento, string genero)
            :base(idpersona, nombre, apellido, fechanacimiento, genero) {
            this.IdDocente = idDocente;
            this.Estatus = estatus;
        }

        public List<Docente> listaDocente = new List<Docente>();
        
        public void AgregarDocente(Docente docente)
        {
            listaDocente.Add(docente);
        }
        
        public void EliminarDocente(Docente docente)
        {
            listaDocente.Remove(docente);
        }
    }
}

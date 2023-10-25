using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Seccion
    {
        public int IdSeccion { get; set; }
        public char Tipo { get; set; }
        public Curso idCurso { get; set; }
        public Ciclo idCiclo { get; set; }

        public Seccion(int IdSeccion, char Tipo)
        {
            this.IdSeccion = IdSeccion;
            this.Tipo = Tipo;
        }
        public List<Seccion> listaSeccion = new List<Seccion>();
        //Metodo para agregar Seccion
        public void AgregarSeccion(Seccion seccion)
        {
            listaSeccion.Add(seccion);
        }
        //Metodo para eliminar Seccion
        public void EliminarSeccion(Seccion seccion)
        {
            listaSeccion.Remove(seccion);
        }
    }
}
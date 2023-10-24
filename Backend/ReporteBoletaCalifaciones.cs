using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class ReporteBoletaCalifaciones
    {
        public int IdBoletaCalificaciones {  get; set; }
        public DateTime FechaBoleta { get; set; }
        public Estudiante estudiante { get; set; }
        public List<Estudiante> estudiantes { get; set; }
        public AsignacionEstudiante asignacion { get; set; }
        public List<AsignacionEstudiante> asignaciones { get; set; }
        public Ciclo ciclo { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Curso curso { get; set; }
        public List<Curso> cursos { get; set; }
        public RegistroNotas registroNotas { get; set; }
        public List<string> tipoDeNotas { get; set; }
        public List<RegistroNotas> notas { get; set; }
        
        //Metodo Constructor
        public ReporteBoletaCalifaciones(int idBoletaCalificaciones, DateTime fechaBoleta)
        {
            IdBoletaCalificaciones = idBoletaCalificaciones;
            FechaBoleta = fechaBoleta;
            estudiantes = new List<Estudiante>();
            asignaciones = new List<AsignacionEstudiante>();
            ciclos = new List<Ciclo>();
            cursos = new List<Curso>();
            tipoDeNotas = new List<string>();
            notas = new List<RegistroNotas>();
        }

        public List<ReporteBoletaCalifaciones> listaReporteBoletaCalifaciones = new List<ReporteBoletaCalifaciones>();
        //Metodo para agregar Calificaciones
        public void AgregarReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones.Add(reporteBoletaCalifaciones);
        }
        //Metodo para eliminar Calificaciones
        public void EliminarReporteBoletaCalifaciones(ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones.Remove(reporteBoletaCalifaciones);
        }
        //Metodo para modificar Calificaciones
        public void ModificarReporteBoletaCalifaciones(int indice, ReporteBoletaCalifaciones reporteBoletaCalifaciones)
        {
            listaReporteBoletaCalifaciones[indice] = reporteBoletaCalifaciones;
        }
        //Metodo para mostrar Calificaciones
        public List<ReporteBoletaCalifaciones> MostrarReporteBoletaCalifaciones()
        {
            return listaReporteBoletaCalifaciones;
        }
        //Método para obotener Calificaciones
        public List<ReporteBoletaCalifaciones> ObtenerBoletaCalificaciones(int idBoletaCalificaciones)
        {
            List<ReporteBoletaCalifaciones> listaBoletaCalificaciones = new List<ReporteBoletaCalifaciones>();
            foreach (var item in listaReporteBoletaCalifaciones)
            {
                if (item.IdBoletaCalificaciones == idBoletaCalificaciones)
                {
                    listaBoletaCalificaciones.Add(item);
                }
            }
            return listaBoletaCalificaciones;
        }
    }
}

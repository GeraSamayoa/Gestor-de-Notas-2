using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class AsignacionEstudiante
    {
 

        public int IdAsignacionEstudiante { get; set; }
        public Estudiante IdNumeroCarne { get; set; } //Estudiante
        public List<Estudiante> estudiantes { get; set; }
        public Docente IdDocente { get; set; }
        public List<Docente> docentes { get; set; }    
        public Seccion IdSeccion { get; set; }
        public List<Seccion> secciones { get; set; }
        public Ciclo IdCiclo { get; set; }
        public List<Ciclo> ciclos { get; set; }
        public Jornada IdJornada { get; set; }
        public List<Jornada> jornadas { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public Periodo IdPeriodo { get; set; }
        public List<Periodo> periodos { get; set; }
        public string Estado { get; set; }
        public Curso IdCurso { get; set; }
        public List<Curso> cursos { get; set; }
        public Carrera IdCarrera { get; set; }
        public List<Carrera> carreras { get; set; }

        //Metodo constructor
        public AsignacionEstudiante(int idAsignacionEstudiante, DateTime fechaAsignacion,string estado)
        {
            IdAsignacionEstudiante = idAsignacionEstudiante;
            estudiantes = new List<Estudiante>();
            carreras = new List<Carrera>();
            periodos = new List<Periodo>();
            jornadas = new List<Jornada>();
            ciclos = new List<Ciclo>();
            cursos = new List<Curso>();
            secciones = new List<Seccion>();
            docentes = new List<Docente>();
            FechaAsignacion = fechaAsignacion;
            Estado = estado;
        }
        //Lista de asignaciones
        public List<AsignacionEstudiante> listaAsignacionesEstudiantes = new List<AsignacionEstudiante>();
        //Metodo para agregar asignaciones
        public void AgregarAsignacion(AsignacionEstudiante asignacionEstudiante)
        {
            listaAsignacionesEstudiantes.Add(asignacionEstudiante);
        }
        //Metodo para eliminar asignaciones
        public void EliminarAsignacion(AsignacionEstudiante asignacionEstudiante)
        {
            listaAsignacionesEstudiantes.Remove(asignacionEstudiante);
        }
        //Metodo para modificar asignaciones
        public void ModificarAsignacion(int indice, AsignacionEstudiante asignacionEstudiante)
        {
            listaAsignacionesEstudiantes[indice] = asignacionEstudiante;
        }
        //Metodo para mostrar asignaciones
        public List<AsignacionEstudiante> MostrarAsignacion()
        {
            return listaAsignacionesEstudiantes;
        }
        
}
    }

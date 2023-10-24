using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class AsignacionDocente
    {
            public int IdAsignacionDocente { get; set; }
            public Docente IdDocente { get; set; }
            public List<Docente> docentes { get; set; }
            public Seccion IdSeccion { get; set; }
            public List<Seccion> secciones { get; set; }
            public Ciclo IdCiclo { get; set; }
            public List<Ciclo> ciclos { get; set; }
            public Jornada IdJornada { get; set; }
            public List<Jornada> jornadas { get; set; }
           // public DateTime FechaAsignacion { get; set; }
           /* public Periodo IdPeriodo { get; set; }
            public List<Periodo> periodos { get; set; }*/
            public Curso IdCurso { get; set; }
            public List<Curso> cursos { get; set; }
            public Carrera IdCarrera { get; set; }
            public List<Carrera> carreras { get; set; }



            //Metodo constructor
            public AsignacionDocente(int idAsignacionDocente, DateTime fechaAsignacion)
            {
                IdAsignacionDocente = idAsignacionDocente;
                docentes = new List<Docente>(); 
                carreras = new List<Carrera>();
                //periodos = new List<Periodo>();
                jornadas = new List<Jornada>();
                ciclos = new List<Ciclo>();
                cursos = new List<Curso>();
                secciones = new List<Seccion>();
               // FechaAsignacion = fechaAsignacion;
            }
            //Lista de asignaciones
            public List<AsignacionDocente> listaAsignacionesDocentes = new List<AsignacionDocente>();
            //Metodo para agregar asignaciones
            public void AgregarAsignacion(AsignacionDocente asignacionDocente)
            {
                listaAsignacionesDocentes.Add(asignacionDocente);
            }
            //Metodo para eliminar asignaciones
            public void EliminarAsignacion(AsignacionDocente asignacionDocente)
            {
                listaAsignacionesDocentes.Remove(asignacionDocente);
            }
            //Metodo para modificar asignaciones
            public void ModificarAsignacion(int indice, AsignacionDocente asignacionDocente)
            {
                listaAsignacionesDocentes[indice] = asignacionDocente;
            }
            //Metodo para mostrar asignaciones
            public List<AsignacionDocente> MostrarAsignacion()
            {
                return listaAsignacionesDocentes;
            }

        }
    }


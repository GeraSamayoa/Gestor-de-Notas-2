using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Backend;
using DataAcces;
using DataAccesUITI;

namespace Frontend
{
    public partial class AsignacionEstudiante : Form
    {
        public Repositorio repositorio = new Repositorio();

        public AsignacionEstudiante()
        {
            InitializeComponent();
            CargarEstudiantes();
            CargarCursos();
            CargarCarreras();
            CargarJornadas();
            CargarSecciones();
        }

        private void CargarEstudiantes()
        {
            List<Estudiante> estudiantes = repositorio.ObtenerEstudiantes();
            comboBoxNCarneEst.DataSource = estudiantes;
            comboBoxNCarneEst.DisplayMember = "Nombre";
            comboBoxNCarneEst.ValueMember = "Carne";
        }

        private void CargarCursos()
        {
            List<Curso> cursos = repositorio.ObtenerCursos();
            comboBoxCursoEstudiante.DataSource = cursos;
            comboBoxCursoEstudiante.DisplayMember = "NombreCurso";
            comboBoxCursoEstudiante.ValueMember = "IdCurso";
        }

        private void CargarCarreras()
        {
            List<Carrera> carreras = repositorio.ObtenerCarreras();
            comboBoxCarreraEstudiante.DataSource = carreras;
            comboBoxCarreraEstudiante.DisplayMember = "NombreCarrera";
            comboBoxCarreraEstudiante.ValueMember = "IdCarrera";
        }

        private void CargarJornadas()
        {
            List<Jornada> jornadas = repositorio.ObtenerJornadas();
            comboBoxJornadaEstudiante.DataSource = jornadas;
            comboBoxJornadaEstudiante.DisplayMember = "NombreJornada";
            comboBoxJornadaEstudiante.ValueMember = "IdJornada";
        }

        private void CargarSecciones()
        {
            List<Seccion> secciones = repositorio.ObtenerSecciones();
            comboBoxSeccionEstudiante.DataSource = secciones;
            comboBoxSeccionEstudiante.DisplayMember = "NombreSeccion";
            comboBoxSeccionEstudiante.ValueMember = "IdSeccion";
        }

        private void btnAgregarAsigEstudiante_Click(object sender, EventArgs e)
        {
            int noCarneSeleccionado = (int)comboBoxNCarneEst.SelectedValue;
            int idJornadaSeleccionada = (int)comboBoxJornadaEstudiante.SelectedValue;
            int idCarreraSeleccionada = (int)comboBoxCarreraEstudiante.SelectedValue;
            int idCursoSeleccionado = (int)comboBoxCursoEstudiante.SelectedValue;
            int idSeccionSeleccionada = (int)comboBoxSeccionEstudiante.SelectedValue;

            Backend.AsignacionEstudiante asignacion = new Backend.AsignacionEstudiante
            {
                Estudiante = new Estudiante { NoCarne = noCarneSeleccionado },
                Jornada = new Jornada { IdJornada = idJornadaSeleccionada },
                Carrera = new Carrera { IdCarrera = idCarreraSeleccionada },
                Curso = new Curso { IdCurso = idCursoSeleccionado },
                Seccion = new Seccion { IdSeccion = idSeccionSeleccionada }
            };

            AsignacionEstudianteDAL dal = new AsignacionEstudianteDAL();
            if (dal.GuardarAsignacionEstudiante(asignacion))
            {
                MessageBox.Show("Asignación guardada correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la asignación");
            }
        }
    }
}

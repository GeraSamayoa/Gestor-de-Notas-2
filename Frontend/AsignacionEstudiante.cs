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
            comboBoxNCarneEst.ValueMember = "NoCarne";
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
            int IdEstudianteSeleccionado = (int)comboBoxNCarneEst.SelectedValue;
            int idJornadaSeleccionada = (int)comboBoxJornadaEstudiante.SelectedValue;
            int idCarreraSeleccionada = (int)comboBoxCarreraEstudiante.SelectedValue;
            int idCursoSeleccionado = (int)comboBoxCursoEstudiante.SelectedValue;
            int idSeccionSeleccionada = (int)comboBoxSeccionEstudiante.SelectedValue;

            Backend.AsignacionEstudiante asignacion = new Backend.AsignacionEstudiante
            {
                Estudiante = new Estudiante { NoCarne = IdEstudianteSeleccionado },
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
        private void btnActualizarAsigEst_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarAsigEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void AsignacionEstudiante_Load(object sender, EventArgs e)
        {
            /*
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Seccion' Puede moverla o quitarla según sea necesario.
            this.seccionTableAdapter.Fill(this.uITIDataSet.Seccion);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Jornada' Puede moverla o quitarla según sea necesario.
            this.jornadaTableAdapter.Fill(this.uITIDataSet.Jornada);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.uITIDataSet.Carrera);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.uITIDataSet.Curso);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.uITIDataSet.Estudiante);*/

        }

        private void comboBoxNCarneEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estudianteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSalirAsigEstudiante_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por usar el sistema");
                this.Close();
            }
        }
    }
}

using Backend;
using DataAcces;
using DataAccesUITI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class AsignacionDocente : Form
       
    {
        public Repositorio repositorio = new Repositorio();
        public AsignacionDocente()
        {
            InitializeComponent();
            CargarDocentes();
            CargarCursos();
            CargarCarreras();
            CargarJornadas();
            CargarSecciones();
        }

        private void CargarDocentes()
        {
            List<Docente> docentes = repositorio.ObtenerDocentes();
            comboBoxIDdocente.DataSource = docentes;
            comboBoxIDdocente.DisplayMember = "Nombre"; 
            comboBoxIDdocente.ValueMember = "IdDocente";
        }
        private void CargarCursos()
        {
            List<Curso> cursos = repositorio.ObtenerCursos();
            comboBoxCursoDocente.DataSource = cursos;
            comboBoxCursoDocente.DisplayMember = "NombreCurso";
            comboBoxCursoDocente.ValueMember = "IdCurso";
        }
        private void CargarCarreras()
        {
            List<Carrera> carreras = repositorio.ObtenerCarreras();
            comboBoxCarreraDocente.DataSource = carreras;
            comboBoxCarreraDocente.DisplayMember = "NombreCarrera";
            comboBoxCarreraDocente.ValueMember = "IdCarrera";
        }
        private void CargarJornadas()
        {
            List<Jornada> jornadas = repositorio.ObtenerJornadas();
            comboBoxJornadaDocente.DataSource = jornadas;
            comboBoxJornadaDocente.DisplayMember = "NombreJornada";
            comboBoxJornadaDocente.ValueMember = "IdJornada";
        }
        private void CargarSecciones()
        {
            List<Seccion> secciones = repositorio.ObtenerSecciones();
            comboBoxSeccionDocente.DataSource = secciones;
            comboBoxSeccionDocente.DisplayMember = "Tipo"; 
            comboBoxSeccionDocente.ValueMember = "IdSeccion";
        }

        private void btnActualizarAsigDocente_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAsigDocente_Click(object sender, EventArgs e)
        {

                int idDocenteSeleccionado = (int)comboBoxIDdocente.SelectedValue;
                int idJornadaSeleccionada = (int)comboBoxJornadaDocente.SelectedValue;
                int idCarreraSeleccionada = (int)comboBoxCarreraDocente.SelectedValue;
                int idCursoSeleccionado = (int)comboBoxCursoDocente.SelectedValue;
                int idSeccionSeleccionada = (int)comboBoxSeccionDocente.SelectedValue;

                Backend.AsignacionDocente asignacion = new Backend.AsignacionDocente
                {
                    Docente = new Docente { IdDocente = idDocenteSeleccionado },
                    Jornada = new Jornada { IdJornada = idJornadaSeleccionada },
                    Carrera = new Carrera { IdCarrera = idCarreraSeleccionada },
                    Curso = new Curso { IdCurso = idCursoSeleccionado },
                    Seccion = new Seccion { IdSeccion = idSeccionSeleccionada },
                };

                AsignacionDocenteDAL dal = new AsignacionDocenteDAL();
                if (dal.GuardarAsignacionDocente(asignacion))
                {
                    MessageBox.Show("Asignación guardada correctamente");
                }
                else
                {
                    MessageBox.Show("Hubo un error al guardar la asignación");
                }
            



        }

        private void AsignacionDocente_Load(object sender, EventArgs e)
        {
            /*// TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Seccion' Puede moverla o quitarla según sea necesario.
            this.seccionTableAdapter.Fill(this.uITIDataSet.Seccion);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Jornada' Puede moverla o quitarla según sea necesario.
            this.jornadaTableAdapter.Fill(this.uITIDataSet.Jornada);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.uITIDataSet.Carrera);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.uITIDataSet.Curso);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Docente' Puede moverla o quitarla según sea necesario.
            this.docenteTableAdapter.Fill(this.uITIDataSet.Docente);*/

        }

        private void btnSalirAsigDocente_Click(object sender, EventArgs e)
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

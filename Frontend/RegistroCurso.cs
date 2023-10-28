using Backend;
using DataAcces;
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
    public partial class RegistroCurso : Form
    {
        Administrador admin;
        CursoDAL cursoDAL;

        public RegistroCurso()
        {
            InitializeComponent();
            admin = new Administrador();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCurso_Load(object sender, EventArgs e)
        {
           

        }

        public void btnAgregarCurso_Click(object sender, EventArgs e)
        {

            int IdCarreraSeleccionado = (int)comboBoxCarrera.SelectedValue;
            int IdCicloSeleccionado = (int)comboboxCiclo.SelectedValue;
            int IdJornadaSeleccionado = (int)comboBoxJornada.SelectedValue;
            int IdSeccionSeleccionado = (int)comboBoxSeccion.SelectedValue;

            Backend.Curso curso = new Backend.Curso
            {
                Carrera = new Carrera { IdCarrera = IdCarreraSeleccionado },
                Ciclo = new Ciclo { IdCiclo = IdCicloSeleccionado },
                Jornada = new Jornada { IdJornada = IdJornadaSeleccionado },
                Seccion = new Seccion { IdSeccion = IdSeccionSeleccionado }
            };

            CursoDAL dal = new CursoDAL();
            if (dal.InsertCurso(curso)) 
            {
                MessageBox.Show("Asignación guardada correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la asignación");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            admin.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxHoraInicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

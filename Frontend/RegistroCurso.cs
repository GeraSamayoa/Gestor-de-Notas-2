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
            //cursoDAL = new CursoDAL(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.uITIDataSet1.Curso);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter1.Fill(this.uITIDataSet1.Carrera);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Ciclo' Puede moverla o quitarla según sea necesario.
            this.cicloTableAdapter1.Fill(this.uITIDataSet1.Ciclo);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Universidad' Puede moverla o quitarla según sea necesario.
            this.universidadTableAdapter1.Fill(this.uITIDataSet1.Universidad);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Jornada' Puede moverla o quitarla según sea necesario.
            this.jornadaTableAdapter1.Fill(this.uITIDataSet1.Jornada);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Seccion' Puede moverla o quitarla según sea necesario.
            this.seccionTableAdapter1.Fill(this.uITIDataSet1.Seccion);


        }

        public void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            Curso curso1 = new Curso();

            int IdCarreraSeleccionado = (int)comboBoxCarrera.SelectedValue;
            int IdCicloSeleccionado = (int)comboboxCiclo.SelectedValue;
            int IdJornadaSeleccionado = (int)comboBoxJornada.SelectedValue;
            int IdSeccionSeleccionado = (int)comboBoxSeccion.SelectedValue;


            //cursoDAL.InsertCurso(curso1);

            Backend.Curso curso = new Backend.Curso
            {
                Carrera = new Carrera { IdCarrera = IdCarreraSeleccionado },
                Ciclo = new Ciclo { IdCiclo = IdCicloSeleccionado },
                Jornada = new Jornada { IdJornada = IdJornadaSeleccionado },
                Seccion = new Seccion { IdSeccion = IdSeccionSeleccionado },
              
            };

            CursoDAL dal = new CursoDAL();
            curso.NombreCurso = txtNombreCurso.Text;
            curso.HoraInicio = comboBoxHoraInicio.Text;
            curso.HoraFinal = comboBoxHoraFinal.Text;
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

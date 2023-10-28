using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Backend;
using DataAcces; 
using DataAccesUITI;

namespace Frontend
{
    public partial class BoletaCalificaciones : Form
    {
        Repositorio repositorio = new Repositorio();

        public BoletaCalificaciones()
        {
            InitializeComponent();
            CargarEstudiantes();
        }

        private void CargarEstudiantes()
        {
            List<Estudiante> estudiantes = repositorio.ObtenerEstudiantes();
 
        }

        private void comboBoxEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CargarNotasDelEstudiante(int numeroCarne)
        {
            List<Backend.RegistroNotas> notas = repositorio.ObtenerNotasPorEstudiante(numeroCarne);
            dvgCalificaciones.DataSource = notas;
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Gracias por usar el sistema");
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        
        }

        private void BoletaCalificaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet1.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.uITIDataSet1.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.ReporteBoleta' Puede moverla o quitarla según sea necesario.
            this.reporteBoletaTableAdapter.Fill(this.uITIDataSet.ReporteBoleta);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.RegistroNotas' Puede moverla o quitarla según sea necesario.
            this.registroNotasTableAdapter.Fill(this.uITIDataSet.RegistroNotas);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

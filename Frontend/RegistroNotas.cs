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
    public partial class RegistroNotas : Form
    {
        public Repositorio repositorio = new Repositorio();
        RegistroNotasDAL registroNotasDAL;
        public RegistroNotas()
        {
            InitializeComponent();;
            CargarEstudiantes();
            CargarDocentes();
            registroNotasDAL = new RegistroNotasDAL();
 

        }
        private void CargarDocentes()
        {
            List<Docente> docentes = repositorio.ObtenerDocentes();
            comboBoxDocente.DataSource = docentes;
            comboBoxDocente.DisplayMember = "Nombre";
            comboBoxDocente.ValueMember = "IdDocente";
        }

        private void CargarEstudiantes()
        {
            List<Estudiante> estudiantes = repositorio.ObtenerEstudiantes();
            comboBoxEstudianteAisgNota.DataSource = estudiantes;
            comboBoxEstudianteAisgNota.DisplayMember = "Nombre";
            comboBoxEstudianteAisgNota.ValueMember = "NoCarne";
        }
        private void btnAgregarRegEstudiante_Click(object sender, EventArgs e)
        {
            Backend.RegistroNotas registroNotas1 = new Backend.RegistroNotas();
           
            registroNotasDAL.GuardarRegistroNota(registroNotas1);
            dgvRegEstudiante.DataSource = registroNotasDAL.GetRegistroNotas();

            int idDocenteSeleccionado = (int)comboBoxDocente.SelectedValue;
            int IdEstudianteSeleccionado = (int)comboBoxEstudianteAisgNota.SelectedValue;

            Backend.RegistroNotas registroNotas = new Backend.RegistroNotas
            {
                Docente = new Docente { IdDocente = idDocenteSeleccionado },
                Estudiante = new Estudiante { NoCarne = IdEstudianteSeleccionado },
            };

            RegistroNotasDAL dal = new RegistroNotasDAL();
            if (dal.GuardarRegistroNota(registroNotas))
            {
                MessageBox.Show("Asignación guardada correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un error al guardar la asignación");
            }

           // int Zona = int.Parse(txtPrimerP.Text) + int.Parse(txtSegundoP.Text) + int.Parse(txtActividades.Text);

            // Agregar los resultados al DataGridView
            //dgvRegEstudiante.Rows.Add("Primer Parcial", int.Parse(txtPrimerP.Text));
            //dgvRegEstudiante.Rows.Add("Segundo Parcial", int.Parse(txtSegundoP.Text));
            //dgvRegEstudiante.Rows.Add("Actividades", int.Parse(txtActividades.Text));
            //dgvRegEstudiante.Rows.Add("Zona", Zona);

            //int NotaFinal = int.Parse(txtPrimerP.Text) + int.Parse(txtSegundoP.Text) + int.Parse(txtActividades.Text)+int.Parse(txtExamenF.Text) ;

            // Agregar los resultados al DataGridView
            //dgvRegEstudiante.Rows.Add("Primer Parcial", int.Parse(txtPrimerP.Text));
            //dgvRegEstudiante.Rows.Add("Segundo Parcial", int.Parse(txtSegundoP.Text));
            //dgvRegEstudiante.Rows.Add("Actividades", int.Parse(txtActividades.Text));
            //dgvRegEstudiante.Rows.Add("ExamenFinal", int.Parse(txtExamenF.Text));
            //dgvRegEstudiante.Rows.Add("NotaFinal", NotaFinal);





        }

        /*private void btnAgregarRegEstudiante_Click(object sender, EventArgs e)
        {

        }*/
    }
}

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
    public partial class RegistroDocente : Form
    {
        DocenteDAL docenteDAL;
        PersonaDAL personaDAL;
        UsuarioDocenteDAL usuarioDocenteDAL;
        public RegistroDocente()
        {
            InitializeComponent();
            docenteDAL = new DocenteDAL();
            personaDAL = new PersonaDAL();
            usuarioDocenteDAL = new UsuarioDocenteDAL();

            dgvRegDocente.DataSource = docenteDAL.GetDocente();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            login loginShow = new login();
            loginShow.Show();
            MessageBox.Show("Registro Exitoso");
            MessageBox.Show("Por favor inicie sesion a continuacion");
            this.Hide();
        }

        private void btnAgregarRegDocente_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            Persona persona = new Persona();
            UsuarioDocente usuarioDocente = new UsuarioDocente();
            docente.IdPersona = int.Parse(txtDPIDocente.Text);
            usuarioDocente.Contrasena = txtContraseniaDocente.Text;
            persona.Nombre = txtNombreDocente.Text;
            persona.Apellido = txtApellidoDocente.Text;
            usuarioDocente.NombreUsuario = txtUsuarioDocente.Text;
            usuarioDocente.DPI = int.Parse(txtDPIDocente.Text);
            persona.Genero = txtGeneroDocente.Text;
            persona.IdPersona = int.Parse(txtDPIDocente.Text);
            //persona.FechaNacimiento = dateTimePicker1.Value;
            docente.Nombre = txtNombreDocente.Text;
            docente.Apellido = txtApellidoDocente.Text;
            docente.Estatus = char.Parse(txtEstatusDocente.Text);

            personaDAL.InsertPersona(persona);
            usuarioDocenteDAL.InsertUsuarioDocente(usuarioDocente);
            docenteDAL.InsertDocente(docente);
            dgvRegDocente.DataSource = personaDAL.GetPersona();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirRegistroDocente_Click(object sender, EventArgs e)
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

﻿
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
    public partial class registroEstudiante : Form
    {
        EstudianteDAL estudianteDAL;
        PersonaDAL personaDAL;
        public registroEstudiante()
        {
            InitializeComponent();
            estudianteDAL = new EstudianteDAL();
            personaDAL = new PersonaDAL();

            dgvRegEstudiante.DataSource = estudianteDAL.GetEstudiante();
            dgvRegEstudiante.DataSource = personaDAL.GetPersona();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            EstudianteMenu registroEstudiante = new EstudianteMenu();
            registroEstudiante.Show();
        }

        private void btnAgregarRegEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            Persona persona = new Persona();
            estudiante.IdPersona = int.Parse(txtDPI.Text);
            estudiante.Contrasenia = txtContraseña.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            lbUsuario.Text = txtUsuario.Text;
            persona.Genero = txtGenero.Text;
            persona.IdPersona = int.Parse(txtDPI.Text);
            persona.FechaNacimiento = dateTimePicker1.Value;
            estudiante.Estatus = char.Parse(txtEstatus.Text);

            personaDAL.InsertPersona(persona);
            estudianteDAL.InsertEstudiante(estudiante);
            dgvRegEstudiante.DataSource = personaDAL.GetPersona();
            //dgvRegEstudiante.DataSource = estudianteDAL.GetEstudiante();
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            Persona persona = new Persona();
            estudiante.NoCarne = int.Parse(txtDPI.Text);
            //estudiante.Contrasenia = txtContraseña.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Genero = txtGenero.Text;

            estudianteDAL.UpdateEstudiante(estudiante);
            personaDAL.UpdatePersona(persona);
            dgvRegEstudiante.DataSource = estudianteDAL.GetEstudiante();
            dgvRegEstudiante.DataSource = personaDAL.GetPersona();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            Persona persona = new Persona();
            estudiante.NoCarne = int.Parse(txtDPI.Text);
            //estudiante.Contrasenia = txtContraseña.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Genero = txtGenero.Text;

            estudianteDAL.DeleteEstudiante(estudiante);
            personaDAL.DeletePersona(persona);
            //dgvRegEstudiante.DataSource = estudianteDAL.GetEstudiante();
            //dgvRegEstudiante.DataSource = personaDAL.GetPersona();

        }

        private void registroEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

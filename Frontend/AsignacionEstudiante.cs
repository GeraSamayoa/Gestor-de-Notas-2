﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAcces;
using Backend;
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
            comboBoxNCarneEst.ValueMember = "IdEstudiante";
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
            

        }

        private void btnActualizarAsigEst_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarAsigEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}

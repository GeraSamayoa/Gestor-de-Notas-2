﻿using System;
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
            comboBoxEstudiantes.DataSource = estudiantes;
            comboBoxEstudiantes.DisplayMember = "Nombre";
            comboBoxEstudiantes.ValueMember = "NoCarne";
        }

        private void comboBoxEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstudiantes.SelectedValue != null && comboBoxEstudiantes.SelectedValue.GetType() != typeof(string))
            {
                int numeroCarne = Convert.ToInt32(comboBoxEstudiantes.SelectedValue);
                CargarNotasDelEstudiante(numeroCarne);
            }
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
            if (comboBoxEstudiantes.SelectedValue != null && comboBoxEstudiantes.SelectedValue.GetType() != typeof(string))
            {
                int numeroCarne = Convert.ToInt32(comboBoxEstudiantes.SelectedValue);
                CargarNotasDelEstudiante(numeroCarne);
            }
        }
    }
}

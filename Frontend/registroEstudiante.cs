﻿
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

        public registroEstudiante()
        {
            InitializeComponent();
    
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            EstudianteMenu registroEstudiante = new EstudianteMenu();
            registroEstudiante.Show();
        }

        private void btnAgregarRegEstudiante_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void registroEstudiante_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
        public RegistroDocente()
        {
            InitializeComponent();
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            DocenteMenu RegistroDocente = new DocenteMenu();
            RegistroDocente.Show();
        }
    }
}
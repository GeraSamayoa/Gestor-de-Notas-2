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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegDocente_Click(object sender, EventArgs e)
        {
            RegistroDocente login = new RegistroDocente();
            login.Show();
        }

        private void buttonRegEstudiante_Click(object sender, EventArgs e)
        {
            registroEstudiante login = new registroEstudiante();
            login.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Administrador login = new Administrador();
            login.Show();
        }
    }
}

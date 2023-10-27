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
    public partial class Administrador : Form
    {
        RegistroCarrera administrador;
        RegistroCurso registroCurso;
        ReportesAdmin reportesAdmin;
        public Administrador()
        {
            InitializeComponent();
            administrador = new RegistroCarrera();
            registroCurso = new RegistroCurso();
            reportesAdmin = new ReportesAdmin();
        }

        private void btnRegistroCarrera_Click(object sender, EventArgs e)
        {
            administrador.Show();
            Close();

        }

        private void btnRegistroCurso_Click(object sender, EventArgs e)
        {
            registroCurso.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportesAdmin.Show();
            Close();
        }
    }
}

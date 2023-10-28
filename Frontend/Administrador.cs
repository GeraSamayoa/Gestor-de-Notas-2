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
    
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnRegistroCarrera_Click(object sender, EventArgs e)
        {
            RegistroCarrera registroCarrera = new RegistroCarrera();
            registroCarrera.Show();
            Close();
        }

        private void btnRegistroCurso_Click(object sender, EventArgs e)
        {
            RegistroCurso registroCurso = new RegistroCurso();
            registroCurso.Show(); 
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportesAdmin reportesAdmin = new ReportesAdmin();
            reportesAdmin.Show();
            Close();
        }
    }
}

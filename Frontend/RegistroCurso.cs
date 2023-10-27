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
    public partial class RegistroCurso : Form
    {
        Administrador admin;

        public RegistroCurso()
        {
            InitializeComponent();
            admin = new Administrador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Ciclo' Puede moverla o quitarla según sea necesario.
            this.cicloTableAdapter.Fill(this.uITIDataSet.Ciclo);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.uITIDataSet.Carrera);

        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            admin.Show();
            Close();
        }
    }
}

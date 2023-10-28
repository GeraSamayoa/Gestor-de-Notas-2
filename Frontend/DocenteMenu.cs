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
    public partial class DocenteMenu : Form
    {
        public DocenteMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarse_Click(object sender, EventArgs e)
        {
            AsignacionDocente DocenteMenu= new AsignacionDocente();
            DocenteMenu.Show();

        }

        private void btnAsignarNotas_Click(object sender, EventArgs e)
        {
            RegistroNotas DocenteMenu = new RegistroNotas();
            DocenteMenu.Show();
            this.Close();
        }

        private void btnSalirDocente_Click(object sender, EventArgs e)
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

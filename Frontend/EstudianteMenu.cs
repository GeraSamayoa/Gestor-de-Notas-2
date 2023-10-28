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
    public partial class EstudianteMenu : Form
    {
        public EstudianteMenu()
        {
            InitializeComponent();
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            BoletaCalificaciones EstudianteMenu= new BoletaCalificaciones();
            EstudianteMenu.Show();
            this.Hide();
        }

        private void btnAsignarseEstudiante_Click(object sender, EventArgs e)
        {
            AsignacionEstudiante EstudianteMenu = new AsignacionEstudiante();
            EstudianteMenu.Show();
      
        }

        private void btnSalirEstudiante_Click(object sender, EventArgs e)
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

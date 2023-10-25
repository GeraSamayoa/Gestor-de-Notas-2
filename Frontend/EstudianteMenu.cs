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
        }

        private void btnAsignarseEstudiante_Click(object sender, EventArgs e)
        {
            AsignacionEstudiante EstudianteMenu = new AsignacionEstudiante();
            EstudianteMenu.Show();
        }
    }
}

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
    public partial class BIENVENIDA : Form
    {
        public BIENVENIDA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            login BIENVENIDA = new login();
            BIENVENIDA.Show();
            this.Close();

        }

        private void BIENVENIDA_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirBienvenida_Click(object sender, EventArgs e)
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

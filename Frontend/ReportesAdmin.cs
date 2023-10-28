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
    public partial class ReportesAdmin : Form
    {
        public ReportesAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportesAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet3.Docentes' Puede moverla o quitarla según sea necesario.
            this.docentesTableAdapter.Fill(this.uITIDataSet3.Docentes);
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet2.Estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.uITIDataSet2.Estudiantes);

        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

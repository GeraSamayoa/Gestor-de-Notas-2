using Backend;
using DataAcces;
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
    public partial class RegistroCarrera : Form
    {
        //Cambiar de 
        Administrador admin;
        //Data Acces
        CarreraDAL carreraDAL;
        CicloDAL cicloDAL;
        JornadaDAL jornadaDAL;
        PeriodoDAL periodoDAL;

        public RegistroCarrera()
        {
            InitializeComponent();
            admin = new Administrador();
            carreraDAL = new CarreraDAL();
            cicloDAL = new CicloDAL();
            jornadaDAL = new JornadaDAL();
            periodoDAL = new PeriodoDAL();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistroCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uITIDataSet.Universidad' Puede moverla o quitarla según sea necesario.
            this.universidadTableAdapter.Fill(this.uITIDataSet.Universidad);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            admin.Show();
            Close();
        }

        private void btnAgregarCarrera_Click(object sender, EventArgs e)
        {
           //Clases
            Carrera carrera = new Carrera();
            Ciclo ciclo = new Ciclo();
            Jornada jornada = new Jornada();
            Periodo periodo = new Periodo();

            //Asignacion de los valores CARRERA
            carrera.NombreCarrera = txtNombreCarrera.Text;
            carrera.Estatus = Convert.ToChar(comboBoxEstatus.Text);

            //Asignacion de valores Ciclo
            ciclo.TipoCiclo = textBoxCiclo.Text;

            //Asignacion de valores Jornada
            jornada.TipoJornada = textBoxJornada.Text;

            //asignacion de valores Periodo
            periodo.TipoPeriodo = textBoxPeriodo.Text;

            //Asignar valores a los DAL
           
            periodoDAL.InsertPeriodo(periodo);
            jornadaDAL.InsertJornada(jornada);

            //prueba

            if (cicloDAL.InsertCiclo(ciclo) == false)
            {
                carrera.IdCiclo = cicloDAL.SetIdCiclo(ciclo);
            }
            else 
            {
                cicloDAL.InsertCiclo(ciclo);
                carrera.IdCiclo = cicloDAL.SetIdCiclo(ciclo);
            }

            if (jornadaDAL.InsertJornada(jornada) == false)
            {
                carrera.IdJornada = jornadaDAL.SetIdJornada(jornada);
            }
            else 
            {
                jornadaDAL.InsertJornada(jornada);
                carrera.IdJornada = jornadaDAL.SetIdJornada(jornada);
            }

            carreraDAL.InsertCarrera(carrera);

            //datagrid
            dgvCarrera.DataSource = carreraDAL.GetCarrera();
        }

        private void dgvCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

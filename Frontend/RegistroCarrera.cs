﻿using Backend;
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
            cicloDAL.InsertCiclo(ciclo);
            periodoDAL.InsertPeriodo(periodo);
            jornadaDAL.InsertJornada(jornada);
            carreraDAL.InsertCarrera(carrera);

            //datagrid
            dgvCarrera.DataSource = carreraDAL.GetCarrera();
        }
    }
}

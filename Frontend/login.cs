using DataAccesUITI;
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
    public partial class login : Form
    {
        UsuarioDAL usuarioDAL;
        UsuarioDocenteDAL usuarioDocenteDAL;
        public login()
        {
            InitializeComponent();
            usuarioDAL = new UsuarioDAL();
            usuarioDocenteDAL = new UsuarioDocenteDAL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text;
            string contrasena = txtContrasenaLogin.Text; 

            if (cmbTipoUsuario.SelectedItem.ToString() == "Estudiante")
            {
                if (usuarioDAL.ValidarLogin(usuario, contrasena)) 
                {
                    EstudianteMenu estudianteMenu = new EstudianteMenu();
                    MessageBox.Show("Inicio de sesión exitoso.");
                    estudianteMenu.Show();
                    MessageBox.Show("Bienvenido " + usuario);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            else if (cmbTipoUsuario.SelectedItem.ToString() == "Docente")
            {
                if (usuarioDocenteDAL.ValidarLoginDocente(usuario, contrasena))
                {
                    DocenteMenu docenteMenu = new DocenteMenu();
                    MessageBox.Show("Inicio de sesión exitoso.");
                    docenteMenu.Show();
                    MessageBox.Show("Bienvenido " + usuario);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }

        private void buttonRegDocente_Click(object sender, EventArgs e)
        {
            RegistroDocente login = new RegistroDocente();
            login.Show();
        }

        private void buttonRegEstudiante_Click(object sender, EventArgs e)
        {
            registroEstudiante login = new registroEstudiante();
            login.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Administrador administrador = new Administrador();
            administrador.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
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

namespace Frontend
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegDocente = new System.Windows.Forms.Button();
            this.buttonRegEstudiante = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtContrasenaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegDocente
            // 
            this.buttonRegDocente.BackColor = System.Drawing.Color.SlateGray;
            this.buttonRegDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.buttonRegDocente.FlatAppearance.BorderSize = 0;
            this.buttonRegDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonRegDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegDocente.ForeColor = System.Drawing.Color.White;
            this.buttonRegDocente.Location = new System.Drawing.Point(33, 60);
            this.buttonRegDocente.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegDocente.Name = "buttonRegDocente";
            this.buttonRegDocente.Size = new System.Drawing.Size(235, 84);
            this.buttonRegDocente.TabIndex = 0;
            this.buttonRegDocente.Text = "Registro \r\nDocente";
            this.buttonRegDocente.UseVisualStyleBackColor = false;
            this.buttonRegDocente.Click += new System.EventHandler(this.buttonRegDocente_Click);
            // 
            // buttonRegEstudiante
            // 
            this.buttonRegEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.buttonRegEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.buttonRegEstudiante.FlatAppearance.BorderSize = 0;
            this.buttonRegEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonRegEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegEstudiante.ForeColor = System.Drawing.Color.White;
            this.buttonRegEstudiante.Location = new System.Drawing.Point(33, 204);
            this.buttonRegEstudiante.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegEstudiante.Name = "buttonRegEstudiante";
            this.buttonRegEstudiante.Size = new System.Drawing.Size(235, 84);
            this.buttonRegEstudiante.TabIndex = 1;
            this.buttonRegEstudiante.Text = "Registro \r\nEstudiante";
            this.buttonRegEstudiante.UseVisualStyleBackColor = false;
            this.buttonRegEstudiante.Click += new System.EventHandler(this.buttonRegEstudiante_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.SlateGray;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdmin.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Location = new System.Drawing.Point(33, 338);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(235, 84);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Administración";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(544, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuarioLogin.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogin.Location = new System.Drawing.Point(336, 233);
            this.txtUsuarioLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(549, 29);
            this.txtUsuarioLogin.TabIndex = 4;
            // 
            // txtContrasenaLogin
            // 
            this.txtContrasenaLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContrasenaLogin.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaLogin.Location = new System.Drawing.Point(336, 311);
            this.txtContrasenaLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasenaLogin.Name = "txtContrasenaLogin";
            this.txtContrasenaLogin.Size = new System.Drawing.Size(549, 29);
            this.txtContrasenaLogin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(336, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contrasena";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.SlateGray;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(897, 480);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(127, 38);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Docente",
            "Estudiante"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(336, 381);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoUsuario.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(336, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Seleccione (Estudiante/Docente)";
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.Color.SlateGray;
            this.btnSalirLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalirLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalirLogin.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSalirLogin.FlatAppearance.BorderSize = 0;
            this.btnSalirLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSalirLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirLogin.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLogin.ForeColor = System.Drawing.Color.White;
            this.btnSalirLogin.Location = new System.Drawing.Point(85, 476);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(122, 42);
            this.btnSalirLogin.TabIndex = 41;
            this.btnSalirLogin.Text = "Salir";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasenaLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonRegEstudiante);
            this.Controls.Add(this.buttonRegDocente);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegDocente;
        private System.Windows.Forms.Button buttonRegEstudiante;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtContrasenaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalirLogin;
    }
}
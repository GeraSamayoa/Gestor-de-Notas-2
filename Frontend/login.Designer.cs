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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
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
            this.buttonRegDocente.Location = new System.Drawing.Point(25, 49);
            this.buttonRegDocente.Name = "buttonRegDocente";
            this.buttonRegDocente.Size = new System.Drawing.Size(176, 68);
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
            this.buttonRegEstudiante.Location = new System.Drawing.Point(25, 166);
            this.buttonRegEstudiante.Name = "buttonRegEstudiante";
            this.buttonRegEstudiante.Size = new System.Drawing.Size(176, 68);
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
            this.buttonAdmin.Location = new System.Drawing.Point(25, 275);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(176, 68);
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
            this.label1.Location = new System.Drawing.Point(408, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(252, 189);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(413, 25);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContraseña.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(252, 253);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(413, 25);
            this.txtContraseña.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(252, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.SlateGray;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguiente.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(673, 390);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(95, 31);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = "Ingresar";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.button4_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonRegEstudiante);
            this.Controls.Add(this.buttonRegDocente);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
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
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
    }
}
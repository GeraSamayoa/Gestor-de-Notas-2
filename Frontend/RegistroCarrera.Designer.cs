namespace Frontend
{
    partial class RegistroCarrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCarrera));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Jornada = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxUniversidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCiclo = new System.Windows.Forms.TextBox();
            this.textBoxJornada = new System.Windows.Forms.TextBox();
            this.textBoxPeriodo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(266, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 40);
            this.label1.TabIndex = 43;
            this.label1.Text = "Registro Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre de la Carrera:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreCarrera.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCarrera.Location = new System.Drawing.Point(35, 121);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(368, 25);
            this.txtNombreCarrera.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ciclo:";
            // 
            // Jornada
            // 
            this.Jornada.AutoSize = true;
            this.Jornada.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jornada.ForeColor = System.Drawing.Color.Black;
            this.Jornada.Location = new System.Drawing.Point(234, 164);
            this.Jornada.Name = "Jornada";
            this.Jornada.Size = new System.Drawing.Size(58, 18);
            this.Jornada.TabIndex = 51;
            this.Jornada.Text = "Jornada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(422, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Status:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxEstatus.FormattingEnabled = true;
            this.comboBoxEstatus.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBoxEstatus.Location = new System.Drawing.Point(425, 124);
            this.comboBoxEstatus.Name = "comboBoxEstatus";
            this.comboBoxEstatus.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEstatus.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(606, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Sede:";
            // 
            // comboBoxUniversidad
            // 
            this.comboBoxUniversidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxUniversidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxUniversidad.FormattingEnabled = true;
            this.comboBoxUniversidad.Items.AddRange(new object[] {
            "Central"});
            this.comboBoxUniversidad.Location = new System.Drawing.Point(609, 124);
            this.comboBoxUniversidad.Name = "comboBoxUniversidad";
            this.comboBoxUniversidad.Size = new System.Drawing.Size(166, 21);
            this.comboBoxUniversidad.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(422, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Periodo:";
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.Location = new System.Drawing.Point(48, 239);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.Size = new System.Drawing.Size(707, 171);
            this.dgvCarrera.TabIndex = 59;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(501, 432);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 31);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SlateGray;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(374, 432);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(121, 31);
            this.btnActualizar.TabIndex = 62;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarCarrera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarCarrera.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarCarrera.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAgregarCarrera.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarrera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarCarrera.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCarrera.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrera.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrera.Location = new System.Drawing.Point(669, 416);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(119, 47);
            this.btnAgregarCarrera.TabIndex = 61;
            this.btnAgregarCarrera.Text = "Agregar";
            this.btnAgregarCarrera.UseVisualStyleBackColor = false;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.btnAgregarCarrera_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 60;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SlateGray;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(247, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 31);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Siguiente";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCiclo
            // 
            this.textBoxCiclo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxCiclo.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiclo.Location = new System.Drawing.Point(38, 184);
            this.textBoxCiclo.Name = "textBoxCiclo";
            this.textBoxCiclo.Size = new System.Drawing.Size(166, 25);
            this.textBoxCiclo.TabIndex = 66;
            // 
            // textBoxJornada
            // 
            this.textBoxJornada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxJornada.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJornada.Location = new System.Drawing.Point(237, 184);
            this.textBoxJornada.Name = "textBoxJornada";
            this.textBoxJornada.Size = new System.Drawing.Size(166, 25);
            this.textBoxJornada.TabIndex = 67;
            // 
            // textBoxPeriodo
            // 
            this.textBoxPeriodo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPeriodo.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeriodo.Location = new System.Drawing.Point(425, 184);
            this.textBoxPeriodo.Name = "textBoxPeriodo";
            this.textBoxPeriodo.Size = new System.Drawing.Size(166, 25);
            this.textBoxPeriodo.TabIndex = 68;
            // 
            // RegistroCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.textBoxPeriodo);
            this.Controls.Add(this.textBoxJornada);
            this.Controls.Add(this.textBoxCiclo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvCarrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxUniversidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEstatus);
            this.Controls.Add(this.Jornada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.label1);
            this.Name = "RegistroCarrera";
            this.Text = "RegistroCarrera";
            this.Load += new System.EventHandler(this.RegistroCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Jornada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxUniversidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCiclo;
        private System.Windows.Forms.TextBox textBoxJornada;
        private System.Windows.Forms.TextBox textBoxPeriodo;
    }
}
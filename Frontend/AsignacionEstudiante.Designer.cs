namespace Frontend
{
    partial class AsignacionEstudiante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionEstudiante));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizarAsigEst = new System.Windows.Forms.Button();
            this.btnAgregarAsigEstudiante = new System.Windows.Forms.Button();
            this.dgvAsigEstudiante = new System.Windows.Forms.DataGridView();
            this.uITIDataSet = new Frontend.UITIDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCursoEstudiante = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxJornadaEstudiante = new System.Windows.Forms.ComboBox();
            this.jornadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCarreraEstudiante = new System.Windows.Forms.ComboBox();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSeccionEstudiante = new System.Windows.Forms.ComboBox();
            this.seccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalirAsigEstudiante = new System.Windows.Forms.Button();
            this.btnEliminarAsigEstudiante = new System.Windows.Forms.Button();
            this.comboBoxNCarneEst = new System.Windows.Forms.ComboBox();
            this.estudianteTableAdapter = new Frontend.UITIDataSetTableAdapters.EstudianteTableAdapter();
            this.cursoTableAdapter = new Frontend.UITIDataSetTableAdapters.CursoTableAdapter();
            this.carreraTableAdapter = new Frontend.UITIDataSetTableAdapters.CarreraTableAdapter();
            this.jornadaTableAdapter = new Frontend.UITIDataSetTableAdapters.JornadaTableAdapter();
            this.seccionTableAdapter = new Frontend.UITIDataSetTableAdapters.SeccionTableAdapter();
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"Asignación de Clases\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(798, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnActualizarAsigEst
            // 
            this.btnActualizarAsigEst.BackColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizarAsigEst.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarAsigEst.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigEst.FlatAppearance.BorderSize = 0;
            this.btnActualizarAsigEst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigEst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarAsigEst.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAsigEst.ForeColor = System.Drawing.Color.White;
            this.btnActualizarAsigEst.Location = new System.Drawing.Point(713, 407);
            this.btnActualizarAsigEst.Name = "btnActualizarAsigEst";
            this.btnActualizarAsigEst.Size = new System.Drawing.Size(137, 55);
            this.btnActualizarAsigEst.TabIndex = 39;
            this.btnActualizarAsigEst.Text = "Actualizar";
            this.btnActualizarAsigEst.UseVisualStyleBackColor = false;
            this.btnActualizarAsigEst.Click += new System.EventHandler(this.btnActualizarAsigEst_Click);
            // 
            // btnAgregarAsigEstudiante
            // 
            this.btnAgregarAsigEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarAsigEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarAsigEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigEstudiante.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsigEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAsigEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsigEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsigEstudiante.Location = new System.Drawing.Point(520, 407);
            this.btnAgregarAsigEstudiante.Name = "btnAgregarAsigEstudiante";
            this.btnAgregarAsigEstudiante.Size = new System.Drawing.Size(137, 55);
            this.btnAgregarAsigEstudiante.TabIndex = 38;
            this.btnAgregarAsigEstudiante.Text = "Agregar";
            this.btnAgregarAsigEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarAsigEstudiante.Click += new System.EventHandler(this.btnAgregarAsigEstudiante_Click);
            // 
            // dgvAsigEstudiante
            // 
            this.dgvAsigEstudiante.AutoGenerateColumns = false;
            this.dgvAsigEstudiante.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsigEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigEstudiante.DataSource = this.uITIDataSet;
            this.dgvAsigEstudiante.Location = new System.Drawing.Point(104, 510);
            this.dgvAsigEstudiante.Name = "dgvAsigEstudiante";
            this.dgvAsigEstudiante.RowHeadersWidth = 51;
            this.dgvAsigEstudiante.Size = new System.Drawing.Size(746, 182);
            this.dgvAsigEstudiante.TabIndex = 30;
            // 
            // uITIDataSet
            // 
            this.uITIDataSet.DataSetName = "UITIDataSet";
            this.uITIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 426);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Sección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 273);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cursos Disponibles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jornada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "N. de Carné";
            // 
            // comboBoxCursoEstudiante
            // 
            this.comboBoxCursoEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCursoEstudiante.DataSource = this.cursoBindingSource;
            this.comboBoxCursoEstudiante.DisplayMember = "NombreCurso";
            this.comboBoxCursoEstudiante.FormattingEnabled = true;
            this.comboBoxCursoEstudiante.Location = new System.Drawing.Point(138, 310);
            this.comboBoxCursoEstudiante.Name = "comboBoxCursoEstudiante";
            this.comboBoxCursoEstudiante.Size = new System.Drawing.Size(304, 26);
            this.comboBoxCursoEstudiante.TabIndex = 40;
            this.comboBoxCursoEstudiante.ValueMember = "IdCurso";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.uITIDataSet;
            // 
            // comboBoxJornadaEstudiante
            // 
            this.comboBoxJornadaEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxJornadaEstudiante.DataSource = this.jornadaBindingSource;
            this.comboBoxJornadaEstudiante.DisplayMember = "Tipo";
            this.comboBoxJornadaEstudiante.FormattingEnabled = true;
            this.comboBoxJornadaEstudiante.Location = new System.Drawing.Point(138, 455);
            this.comboBoxJornadaEstudiante.Name = "comboBoxJornadaEstudiante";
            this.comboBoxJornadaEstudiante.Size = new System.Drawing.Size(304, 26);
            this.comboBoxJornadaEstudiante.TabIndex = 41;
            this.comboBoxJornadaEstudiante.ValueMember = "IdJornada";
            // 
            // jornadaBindingSource
            // 
            this.jornadaBindingSource.DataMember = "Jornada";
            this.jornadaBindingSource.DataSource = this.uITIDataSet;
            // 
            // comboBoxCarreraEstudiante
            // 
            this.comboBoxCarreraEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCarreraEstudiante.DataSource = this.carreraBindingSource;
            this.comboBoxCarreraEstudiante.DisplayMember = "NombreCarrera";
            this.comboBoxCarreraEstudiante.FormattingEnabled = true;
            this.comboBoxCarreraEstudiante.Location = new System.Drawing.Point(138, 386);
            this.comboBoxCarreraEstudiante.Name = "comboBoxCarreraEstudiante";
            this.comboBoxCarreraEstudiante.Size = new System.Drawing.Size(304, 26);
            this.comboBoxCarreraEstudiante.TabIndex = 42;
            this.comboBoxCarreraEstudiante.ValueMember = "IdCarrera";
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "Carrera";
            this.carreraBindingSource.DataSource = this.uITIDataSet;
            // 
            // comboBoxSeccionEstudiante
            // 
            this.comboBoxSeccionEstudiante.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxSeccionEstudiante.DataSource = this.seccionBindingSource;
            this.comboBoxSeccionEstudiante.DisplayMember = "Tipo";
            this.comboBoxSeccionEstudiante.FormattingEnabled = true;
            this.comboBoxSeccionEstudiante.Location = new System.Drawing.Point(520, 232);
            this.comboBoxSeccionEstudiante.Name = "comboBoxSeccionEstudiante";
            this.comboBoxSeccionEstudiante.Size = new System.Drawing.Size(215, 26);
            this.comboBoxSeccionEstudiante.TabIndex = 43;
            this.comboBoxSeccionEstudiante.ValueMember = "IdSeccion";
            // 
            // seccionBindingSource
            // 
            this.seccionBindingSource.DataMember = "Seccion";
            this.seccionBindingSource.DataSource = this.uITIDataSet;
            // 
            // btnSalirAsigEstudiante
            // 
            this.btnSalirAsigEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalirAsigEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalirAsigEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigEstudiante.FlatAppearance.BorderSize = 0;
            this.btnSalirAsigEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirAsigEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAsigEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnSalirAsigEstudiante.Location = new System.Drawing.Point(884, 541);
            this.btnSalirAsigEstudiante.Name = "btnSalirAsigEstudiante";
            this.btnSalirAsigEstudiante.Size = new System.Drawing.Size(137, 55);
            this.btnSalirAsigEstudiante.TabIndex = 45;
            this.btnSalirAsigEstudiante.Text = "Salir";
            this.btnSalirAsigEstudiante.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAsigEstudiante
            // 
            this.btnEliminarAsigEstudiante.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarAsigEstudiante.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminarAsigEstudiante.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEliminarAsigEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAsigEstudiante.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAsigEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAsigEstudiante.Location = new System.Drawing.Point(884, 407);
            this.btnEliminarAsigEstudiante.Name = "btnEliminarAsigEstudiante";
            this.btnEliminarAsigEstudiante.Size = new System.Drawing.Size(137, 55);
            this.btnEliminarAsigEstudiante.TabIndex = 44;
            this.btnEliminarAsigEstudiante.Text = "Eliminar";
            this.btnEliminarAsigEstudiante.UseVisualStyleBackColor = false;
            this.btnEliminarAsigEstudiante.Click += new System.EventHandler(this.btnEliminarAsigEstudiante_Click);
            // 
            // comboBoxNCarneEst
            // 
            this.comboBoxNCarneEst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxNCarneEst.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estudianteBindingSource1, "Carne", true));
            this.comboBoxNCarneEst.FormattingEnabled = true;
            this.comboBoxNCarneEst.Location = new System.Drawing.Point(138, 232);
            this.comboBoxNCarneEst.Name = "comboBoxNCarneEst";
            this.comboBoxNCarneEst.Size = new System.Drawing.Size(304, 26);
            this.comboBoxNCarneEst.TabIndex = 46;
            this.comboBoxNCarneEst.SelectedIndexChanged += new System.EventHandler(this.comboBoxNCarneEst_SelectedIndexChanged);
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // cursoTableAdapter
            // 
            this.cursoTableAdapter.ClearBeforeFill = true;
            // 
            // carreraTableAdapter
            // 
            this.carreraTableAdapter.ClearBeforeFill = true;
            // 
            // jornadaTableAdapter
            // 
            this.jornadaTableAdapter.ClearBeforeFill = true;
            // 
            // seccionTableAdapter
            // 
            this.seccionTableAdapter.ClearBeforeFill = true;
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataMember = "Estudiante";
            this.estudianteBindingSource1.DataSource = this.uITIDataSet;
            // 
            // AsignacionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1043, 735);
            this.Controls.Add(this.comboBoxNCarneEst);
            this.Controls.Add(this.btnSalirAsigEstudiante);
            this.Controls.Add(this.btnEliminarAsigEstudiante);
            this.Controls.Add(this.comboBoxSeccionEstudiante);
            this.Controls.Add(this.comboBoxCarreraEstudiante);
            this.Controls.Add(this.comboBoxJornadaEstudiante);
            this.Controls.Add(this.comboBoxCursoEstudiante);
            this.Controls.Add(this.btnActualizarAsigEst);
            this.Controls.Add(this.btnAgregarAsigEstudiante);
            this.Controls.Add(this.dgvAsigEstudiante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AsignacionEstudiante";
            this.Text = "Asignacion";
            this.Load += new System.EventHandler(this.AsignacionEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizarAsigEst;
        private System.Windows.Forms.Button btnAgregarAsigEstudiante;
        private System.Windows.Forms.DataGridView dgvAsigEstudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCursoEstudiante;
        private System.Windows.Forms.ComboBox comboBoxJornadaEstudiante;
        private System.Windows.Forms.ComboBox comboBoxCarreraEstudiante;
        private System.Windows.Forms.ComboBox comboBoxSeccionEstudiante;
        private System.Windows.Forms.Button btnSalirAsigEstudiante;
        private System.Windows.Forms.Button btnEliminarAsigEstudiante;
        private System.Windows.Forms.ComboBox comboBoxNCarneEst;
        private UITIDataSet uITIDataSet;
        private UITIDataSetTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private UITIDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private UITIDataSetTableAdapters.CarreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.BindingSource jornadaBindingSource;
        private UITIDataSetTableAdapters.JornadaTableAdapter jornadaTableAdapter;
        private System.Windows.Forms.BindingSource seccionBindingSource;
        private UITIDataSetTableAdapters.SeccionTableAdapter seccionTableAdapter;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
    }
}
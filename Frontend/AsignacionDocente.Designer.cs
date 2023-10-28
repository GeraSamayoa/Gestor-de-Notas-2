namespace Frontend
{
    partial class AsignacionDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionDocente));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSeccionDocente = new System.Windows.Forms.ComboBox();
            this.seccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uITIDataSet = new Frontend.UITIDataSet();
            this.comboBoxCarreraDocente = new System.Windows.Forms.ComboBox();
            this.carreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxJornadaDocente = new System.Windows.Forms.ComboBox();
            this.jornadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCursoDocente = new System.Windows.Forms.ComboBox();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizarAsigDocente = new System.Windows.Forms.Button();
            this.btnAgregarAsigDocente = new System.Windows.Forms.Button();
            this.dgvAsigEstudiante = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalirAsigDocente = new System.Windows.Forms.Button();
            this.btnEliminarAsigDocente = new System.Windows.Forms.Button();
            this.comboBoxIDdocente = new System.Windows.Forms.ComboBox();
            this.docenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docenteTableAdapter = new Frontend.UITIDataSetTableAdapters.DocenteTableAdapter();
            this.cursoTableAdapter = new Frontend.UITIDataSetTableAdapters.CursoTableAdapter();
            this.carreraTableAdapter = new Frontend.UITIDataSetTableAdapters.CarreraTableAdapter();
            this.jornadaTableAdapter = new Frontend.UITIDataSetTableAdapters.JornadaTableAdapter();
            this.seccionTableAdapter = new Frontend.UITIDataSetTableAdapters.SeccionTableAdapter();
            this.uITIDataSet1 = new Frontend.UITIDataSet1();
            this.usuarioDocenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDocenteTableAdapter = new Frontend.UITIDataSet1TableAdapters.UsuarioDocenteTableAdapter();
            this.docenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.docenteTableAdapter1 = new Frontend.UITIDataSet1TableAdapters.DocenteTableAdapter();
            this.idDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDocenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-51, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Carrera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-51, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Jornada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(144, -39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 50);
            this.label1.TabIndex = 44;
            this.label1.Text = "\"Asignación de Clases\"";
            // 
            // comboBoxSeccionDocente
            // 
            this.comboBoxSeccionDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxSeccionDocente.DataSource = this.seccionBindingSource;
            this.comboBoxSeccionDocente.DisplayMember = "Tipo";
            this.comboBoxSeccionDocente.FormattingEnabled = true;
            this.comboBoxSeccionDocente.Location = new System.Drawing.Point(480, 186);
            this.comboBoxSeccionDocente.Name = "comboBoxSeccionDocente";
            this.comboBoxSeccionDocente.Size = new System.Drawing.Size(215, 29);
            this.comboBoxSeccionDocente.TabIndex = 64;
            this.comboBoxSeccionDocente.ValueMember = "IdSeccion";
            // 
            // seccionBindingSource
            // 
            this.seccionBindingSource.DataMember = "Seccion";
            this.seccionBindingSource.DataSource = this.uITIDataSet;
            // 
            // uITIDataSet
            // 
            this.uITIDataSet.DataSetName = "UITIDataSet";
            this.uITIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxCarreraDocente
            // 
            this.comboBoxCarreraDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCarreraDocente.DataSource = this.carreraBindingSource;
            this.comboBoxCarreraDocente.DisplayMember = "NombreCarrera";
            this.comboBoxCarreraDocente.FormattingEnabled = true;
            this.comboBoxCarreraDocente.Location = new System.Drawing.Point(98, 340);
            this.comboBoxCarreraDocente.Name = "comboBoxCarreraDocente";
            this.comboBoxCarreraDocente.Size = new System.Drawing.Size(304, 29);
            this.comboBoxCarreraDocente.TabIndex = 63;
            this.comboBoxCarreraDocente.ValueMember = "IdCarrera";
            // 
            // carreraBindingSource
            // 
            this.carreraBindingSource.DataMember = "Carrera";
            this.carreraBindingSource.DataSource = this.uITIDataSet;
            // 
            // comboBoxJornadaDocente
            // 
            this.comboBoxJornadaDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxJornadaDocente.DataSource = this.jornadaBindingSource;
            this.comboBoxJornadaDocente.DisplayMember = "Tipo";
            this.comboBoxJornadaDocente.FormattingEnabled = true;
            this.comboBoxJornadaDocente.Location = new System.Drawing.Point(98, 409);
            this.comboBoxJornadaDocente.Name = "comboBoxJornadaDocente";
            this.comboBoxJornadaDocente.Size = new System.Drawing.Size(304, 29);
            this.comboBoxJornadaDocente.TabIndex = 62;
            this.comboBoxJornadaDocente.ValueMember = "IdJornada";
            // 
            // jornadaBindingSource
            // 
            this.jornadaBindingSource.DataMember = "Jornada";
            this.jornadaBindingSource.DataSource = this.uITIDataSet;
            // 
            // comboBoxCursoDocente
            // 
            this.comboBoxCursoDocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxCursoDocente.DataSource = this.cursoBindingSource;
            this.comboBoxCursoDocente.DisplayMember = "NombreCurso";
            this.comboBoxCursoDocente.FormattingEnabled = true;
            this.comboBoxCursoDocente.Location = new System.Drawing.Point(98, 264);
            this.comboBoxCursoDocente.Name = "comboBoxCursoDocente";
            this.comboBoxCursoDocente.Size = new System.Drawing.Size(304, 29);
            this.comboBoxCursoDocente.TabIndex = 61;
            this.comboBoxCursoDocente.ValueMember = "IdCurso";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataMember = "Curso";
            this.cursoBindingSource.DataSource = this.uITIDataSet;
            // 
            // btnActualizarAsigDocente
            // 
            this.btnActualizarAsigDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizarAsigDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnActualizarAsigDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigDocente.FlatAppearance.BorderSize = 0;
            this.btnActualizarAsigDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnActualizarAsigDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarAsigDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAsigDocente.ForeColor = System.Drawing.Color.White;
            this.btnActualizarAsigDocente.Location = new System.Drawing.Point(673, 361);
            this.btnActualizarAsigDocente.Name = "btnActualizarAsigDocente";
            this.btnActualizarAsigDocente.Size = new System.Drawing.Size(137, 55);
            this.btnActualizarAsigDocente.TabIndex = 60;
            this.btnActualizarAsigDocente.Text = "Actualizar";
            this.btnActualizarAsigDocente.UseVisualStyleBackColor = false;
            this.btnActualizarAsigDocente.Click += new System.EventHandler(this.btnActualizarAsigDocente_Click);
            // 
            // btnAgregarAsigDocente
            // 
            this.btnAgregarAsigDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarAsigDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarAsigDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigDocente.FlatAppearance.BorderSize = 0;
            this.btnAgregarAsigDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnAgregarAsigDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarAsigDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAsigDocente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAsigDocente.Location = new System.Drawing.Point(480, 361);
            this.btnAgregarAsigDocente.Name = "btnAgregarAsigDocente";
            this.btnAgregarAsigDocente.Size = new System.Drawing.Size(137, 55);
            this.btnAgregarAsigDocente.TabIndex = 59;
            this.btnAgregarAsigDocente.Text = "Agregar";
            this.btnAgregarAsigDocente.UseVisualStyleBackColor = false;
            this.btnAgregarAsigDocente.Click += new System.EventHandler(this.btnAgregarAsigDocente_Click);
            // 
            // dgvAsigEstudiante
            // 
            this.dgvAsigEstudiante.AutoGenerateColumns = false;
            this.dgvAsigEstudiante.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsigEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocenteDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.dPIDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn});
            this.dgvAsigEstudiante.DataSource = this.docenteBindingSource1;
            this.dgvAsigEstudiante.Location = new System.Drawing.Point(64, 464);
            this.dgvAsigEstudiante.Name = "dgvAsigEstudiante";
            this.dgvAsigEstudiante.RowHeadersWidth = 51;
            this.dgvAsigEstudiante.Size = new System.Drawing.Size(746, 182);
            this.dgvAsigEstudiante.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 23);
            this.label9.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 55;
            this.label8.Text = "Sección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cursos Disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Carrera:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Jornada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Código Docente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, -24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(241, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(489, 50);
            this.label10.TabIndex = 49;
            this.label10.Text = "\"Asignación de Clases\"";
            // 
            // btnSalirAsigDocente
            // 
            this.btnSalirAsigDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalirAsigDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalirAsigDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigDocente.FlatAppearance.BorderSize = 0;
            this.btnSalirAsigDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSalirAsigDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirAsigDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAsigDocente.ForeColor = System.Drawing.Color.White;
            this.btnSalirAsigDocente.Location = new System.Drawing.Point(879, 495);
            this.btnSalirAsigDocente.Name = "btnSalirAsigDocente";
            this.btnSalirAsigDocente.Size = new System.Drawing.Size(137, 55);
            this.btnSalirAsigDocente.TabIndex = 66;
            this.btnSalirAsigDocente.Text = "Salir";
            this.btnSalirAsigDocente.UseVisualStyleBackColor = false;
            this.btnSalirAsigDocente.Click += new System.EventHandler(this.btnSalirAsigDocente_Click);
            // 
            // btnEliminarAsigDocente
            // 
            this.btnEliminarAsigDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarAsigDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminarAsigDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigDocente.FlatAppearance.BorderSize = 0;
            this.btnEliminarAsigDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnEliminarAsigDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarAsigDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAsigDocente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAsigDocente.Location = new System.Drawing.Point(879, 361);
            this.btnEliminarAsigDocente.Name = "btnEliminarAsigDocente";
            this.btnEliminarAsigDocente.Size = new System.Drawing.Size(137, 55);
            this.btnEliminarAsigDocente.TabIndex = 65;
            this.btnEliminarAsigDocente.Text = "Eliminar";
            this.btnEliminarAsigDocente.UseVisualStyleBackColor = false;
            // 
            // comboBoxIDdocente
            // 
            this.comboBoxIDdocente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBoxIDdocente.DataSource = this.docenteBindingSource;
            this.comboBoxIDdocente.DisplayMember = "IdDocente";
            this.comboBoxIDdocente.FormattingEnabled = true;
            this.comboBoxIDdocente.Location = new System.Drawing.Point(98, 186);
            this.comboBoxIDdocente.Name = "comboBoxIDdocente";
            this.comboBoxIDdocente.Size = new System.Drawing.Size(304, 29);
            this.comboBoxIDdocente.TabIndex = 67;
            this.comboBoxIDdocente.ValueMember = "IdDocente";
            // 
            // docenteBindingSource
            // 
            this.docenteBindingSource.DataMember = "Docente";
            this.docenteBindingSource.DataSource = this.uITIDataSet;
            // 
            // docenteTableAdapter
            // 
            this.docenteTableAdapter.ClearBeforeFill = true;
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
            // uITIDataSet1
            // 
            this.uITIDataSet1.DataSetName = "UITIDataSet1";
            this.uITIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioDocenteBindingSource
            // 
            this.usuarioDocenteBindingSource.DataMember = "UsuarioDocente";
            this.usuarioDocenteBindingSource.DataSource = this.uITIDataSet1;
            // 
            // usuarioDocenteTableAdapter
            // 
            this.usuarioDocenteTableAdapter.ClearBeforeFill = true;
            // 
            // docenteBindingSource1
            // 
            this.docenteBindingSource1.DataMember = "Docente";
            this.docenteBindingSource1.DataSource = this.uITIDataSet1;
            // 
            // docenteTableAdapter1
            // 
            this.docenteTableAdapter1.ClearBeforeFill = true;
            // 
            // idDocenteDataGridViewTextBoxColumn
            // 
            this.idDocenteDataGridViewTextBoxColumn.DataPropertyName = "IdDocente";
            this.idDocenteDataGridViewTextBoxColumn.HeaderText = "IdDocente";
            this.idDocenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDocenteDataGridViewTextBoxColumn.Name = "idDocenteDataGridViewTextBoxColumn";
            this.idDocenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocenteDataGridViewTextBoxColumn.Width = 125;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dPIDataGridViewTextBoxColumn
            // 
            this.dPIDataGridViewTextBoxColumn.DataPropertyName = "DPI";
            this.dPIDataGridViewTextBoxColumn.HeaderText = "DPI";
            this.dPIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dPIDataGridViewTextBoxColumn.Name = "dPIDataGridViewTextBoxColumn";
            this.dPIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 125;
            // 
            // AsignacionDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.comboBoxIDdocente);
            this.Controls.Add(this.btnSalirAsigDocente);
            this.Controls.Add(this.btnEliminarAsigDocente);
            this.Controls.Add(this.comboBoxSeccionDocente);
            this.Controls.Add(this.comboBoxCarreraDocente);
            this.Controls.Add(this.comboBoxJornadaDocente);
            this.Controls.Add(this.comboBoxCursoDocente);
            this.Controls.Add(this.btnActualizarAsigDocente);
            this.Controls.Add(this.btnAgregarAsigDocente);
            this.Controls.Add(this.dgvAsigEstudiante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AsignacionDocente";
            this.Text = "AsignacionDocente";
            this.Load += new System.EventHandler(this.AsignacionDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDocenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docenteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSeccionDocente;
        private System.Windows.Forms.ComboBox comboBoxCarreraDocente;
        private System.Windows.Forms.ComboBox comboBoxJornadaDocente;
        private System.Windows.Forms.ComboBox comboBoxCursoDocente;
        private System.Windows.Forms.Button btnActualizarAsigDocente;
        private System.Windows.Forms.Button btnAgregarAsigDocente;
        private System.Windows.Forms.DataGridView dgvAsigEstudiante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSalirAsigDocente;
        private System.Windows.Forms.Button btnEliminarAsigDocente;
        private System.Windows.Forms.ComboBox comboBoxIDdocente;
        private UITIDataSet uITIDataSet;
        private System.Windows.Forms.BindingSource docenteBindingSource;
        private UITIDataSetTableAdapters.DocenteTableAdapter docenteTableAdapter;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private UITIDataSetTableAdapters.CursoTableAdapter cursoTableAdapter;
        private System.Windows.Forms.BindingSource carreraBindingSource;
        private UITIDataSetTableAdapters.CarreraTableAdapter carreraTableAdapter;
        private System.Windows.Forms.BindingSource jornadaBindingSource;
        private UITIDataSetTableAdapters.JornadaTableAdapter jornadaTableAdapter;
        private System.Windows.Forms.BindingSource seccionBindingSource;
        private UITIDataSetTableAdapters.SeccionTableAdapter seccionTableAdapter;
        private UITIDataSet1 uITIDataSet1;
        private System.Windows.Forms.BindingSource usuarioDocenteBindingSource;
        private UITIDataSet1TableAdapters.UsuarioDocenteTableAdapter usuarioDocenteTableAdapter;
        private System.Windows.Forms.BindingSource docenteBindingSource1;
        private UITIDataSet1TableAdapters.DocenteTableAdapter docenteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
    }
}
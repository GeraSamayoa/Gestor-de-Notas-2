namespace Frontend
{
    partial class BoletaCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoletaCalificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSiguienteDocente = new System.Windows.Forms.Button();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uITIDataSet1 = new Frontend.UITIDataSet1();
            this.dvgCalificaciones = new System.Windows.Forms.DataGridView();
            this.idRegistroNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstudianteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerParcialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoParcialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actividadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusAprobadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uITIDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uITIDataSet = new Frontend.UITIDataSet();
            this.registroNotasTableAdapter = new Frontend.UITIDataSetTableAdapters.RegistroNotasTableAdapter();
            this.fKIdRegistroNotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteBoletaTableAdapter = new Frontend.UITIDataSetTableAdapters.ReporteBoletaTableAdapter();
            this.reporteBoletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new Frontend.UITIDataSet1TableAdapters.EstudianteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroNotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIdRegistroNotaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(103, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "\"Reporte General de Notas\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(915, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnActualizar.Location = new System.Drawing.Point(854, 362);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(137, 55);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSiguienteDocente
            // 
            this.btnSiguienteDocente.BackColor = System.Drawing.Color.SlateGray;
            this.btnSiguienteDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiguienteDocente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguienteDocente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSiguienteDocente.FlatAppearance.BorderSize = 0;
            this.btnSiguienteDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnSiguienteDocente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiguienteDocente.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocente.ForeColor = System.Drawing.Color.White;
            this.btnSiguienteDocente.Location = new System.Drawing.Point(12, 13);
            this.btnSiguienteDocente.Name = "btnSiguienteDocente";
            this.btnSiguienteDocente.Size = new System.Drawing.Size(137, 55);
            this.btnSiguienteDocente.TabIndex = 23;
            this.btnSiguienteDocente.Text = "Salir";
            this.btnSiguienteDocente.UseVisualStyleBackColor = false;
            this.btnSiguienteDocente.Click += new System.EventHandler(this.btnSiguienteDocente_Click);
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.uITIDataSet1;
            // 
            // uITIDataSet1
            // 
            this.uITIDataSet1.DataSetName = "UITIDataSet1";
            this.uITIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvgCalificaciones
            // 
            this.dvgCalificaciones.AutoGenerateColumns = false;
            this.dvgCalificaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvgCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRegistroNotaDataGridViewTextBoxColumn,
            this.idDocenteDataGridViewTextBoxColumn,
            this.idEstudianteDataGridViewTextBoxColumn,
            this.primerParcialDataGridViewTextBoxColumn,
            this.segundoParcialDataGridViewTextBoxColumn,
            this.actividadesDataGridViewTextBoxColumn,
            this.examenFinalDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.notaFinalDataGridViewTextBoxColumn,
            this.estatusAprobadoDataGridViewTextBoxColumn});
            this.dvgCalificaciones.DataSource = this.registroNotasBindingSource;
            this.dvgCalificaciones.Location = new System.Drawing.Point(12, 268);
            this.dvgCalificaciones.Name = "dvgCalificaciones";
            this.dvgCalificaciones.RowHeadersWidth = 51;
            this.dvgCalificaciones.Size = new System.Drawing.Size(1148, 369);
            this.dvgCalificaciones.TabIndex = 42;
            // 
            // idRegistroNotaDataGridViewTextBoxColumn
            // 
            this.idRegistroNotaDataGridViewTextBoxColumn.DataPropertyName = "IdRegistroNota";
            this.idRegistroNotaDataGridViewTextBoxColumn.HeaderText = "IdRegistroNota";
            this.idRegistroNotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idRegistroNotaDataGridViewTextBoxColumn.Name = "idRegistroNotaDataGridViewTextBoxColumn";
            this.idRegistroNotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRegistroNotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDocenteDataGridViewTextBoxColumn
            // 
            this.idDocenteDataGridViewTextBoxColumn.DataPropertyName = "IdDocente";
            this.idDocenteDataGridViewTextBoxColumn.HeaderText = "IdDocente";
            this.idDocenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDocenteDataGridViewTextBoxColumn.Name = "idDocenteDataGridViewTextBoxColumn";
            this.idDocenteDataGridViewTextBoxColumn.Width = 125;
            // 
            // idEstudianteDataGridViewTextBoxColumn
            // 
            this.idEstudianteDataGridViewTextBoxColumn.DataPropertyName = "IdEstudiante";
            this.idEstudianteDataGridViewTextBoxColumn.HeaderText = "IdEstudiante";
            this.idEstudianteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEstudianteDataGridViewTextBoxColumn.Name = "idEstudianteDataGridViewTextBoxColumn";
            this.idEstudianteDataGridViewTextBoxColumn.Width = 125;
            // 
            // primerParcialDataGridViewTextBoxColumn
            // 
            this.primerParcialDataGridViewTextBoxColumn.DataPropertyName = "PrimerParcial";
            this.primerParcialDataGridViewTextBoxColumn.HeaderText = "PrimerParcial";
            this.primerParcialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primerParcialDataGridViewTextBoxColumn.Name = "primerParcialDataGridViewTextBoxColumn";
            this.primerParcialDataGridViewTextBoxColumn.Width = 125;
            // 
            // segundoParcialDataGridViewTextBoxColumn
            // 
            this.segundoParcialDataGridViewTextBoxColumn.DataPropertyName = "SegundoParcial";
            this.segundoParcialDataGridViewTextBoxColumn.HeaderText = "SegundoParcial";
            this.segundoParcialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.segundoParcialDataGridViewTextBoxColumn.Name = "segundoParcialDataGridViewTextBoxColumn";
            this.segundoParcialDataGridViewTextBoxColumn.Width = 125;
            // 
            // actividadesDataGridViewTextBoxColumn
            // 
            this.actividadesDataGridViewTextBoxColumn.DataPropertyName = "Actividades";
            this.actividadesDataGridViewTextBoxColumn.HeaderText = "Actividades";
            this.actividadesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actividadesDataGridViewTextBoxColumn.Name = "actividadesDataGridViewTextBoxColumn";
            this.actividadesDataGridViewTextBoxColumn.Width = 125;
            // 
            // examenFinalDataGridViewTextBoxColumn
            // 
            this.examenFinalDataGridViewTextBoxColumn.DataPropertyName = "ExamenFinal";
            this.examenFinalDataGridViewTextBoxColumn.HeaderText = "ExamenFinal";
            this.examenFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examenFinalDataGridViewTextBoxColumn.Name = "examenFinalDataGridViewTextBoxColumn";
            this.examenFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.Width = 125;
            // 
            // notaFinalDataGridViewTextBoxColumn
            // 
            this.notaFinalDataGridViewTextBoxColumn.DataPropertyName = "NotaFinal";
            this.notaFinalDataGridViewTextBoxColumn.HeaderText = "NotaFinal";
            this.notaFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notaFinalDataGridViewTextBoxColumn.Name = "notaFinalDataGridViewTextBoxColumn";
            this.notaFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // estatusAprobadoDataGridViewTextBoxColumn
            // 
            this.estatusAprobadoDataGridViewTextBoxColumn.DataPropertyName = "EstatusAprobado";
            this.estatusAprobadoDataGridViewTextBoxColumn.HeaderText = "EstatusAprobado";
            this.estatusAprobadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estatusAprobadoDataGridViewTextBoxColumn.Name = "estatusAprobadoDataGridViewTextBoxColumn";
            this.estatusAprobadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // registroNotasBindingSource
            // 
            this.registroNotasBindingSource.DataMember = "RegistroNotas";
            this.registroNotasBindingSource.DataSource = this.uITIDataSetBindingSource;
            // 
            // uITIDataSetBindingSource
            // 
            this.uITIDataSetBindingSource.DataSource = this.uITIDataSet;
            this.uITIDataSetBindingSource.Position = 0;
            // 
            // uITIDataSet
            // 
            this.uITIDataSet.DataSetName = "UITIDataSet";
            this.uITIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroNotasTableAdapter
            // 
            this.registroNotasTableAdapter.ClearBeforeFill = true;
            // 
            // fKIdRegistroNotaBindingSource
            // 
            this.fKIdRegistroNotaBindingSource.DataMember = "FK_IdRegistroNota";
            this.fKIdRegistroNotaBindingSource.DataSource = this.registroNotasBindingSource;
            // 
            // reporteBoletaTableAdapter
            // 
            this.reporteBoletaTableAdapter.ClearBeforeFill = true;
            // 
            // reporteBoletaBindingSource
            // 
            this.reporteBoletaBindingSource.DataMember = "ReporteBoleta";
            this.reporteBoletaBindingSource.DataSource = this.uITIDataSet;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // BoletaCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1172, 623);
            this.Controls.Add(this.dvgCalificaciones);
            this.Controls.Add(this.btnSiguienteDocente);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoletaCalificaciones";
            this.Text = "BoletaCalificaciones";
            this.Load += new System.EventHandler(this.BoletaCalificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCalificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroNotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uITIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIdRegistroNotaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBoletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSiguienteDocente;
        private System.Windows.Forms.DataGridView dvgCalificaciones;
        private System.Windows.Forms.BindingSource uITIDataSetBindingSource;
        private UITIDataSet uITIDataSet;
        private System.Windows.Forms.BindingSource registroNotasBindingSource;
        private UITIDataSetTableAdapters.RegistroNotasTableAdapter registroNotasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegistroNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstudianteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerParcialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoParcialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actividadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusAprobadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKIdRegistroNotaBindingSource;
        private UITIDataSetTableAdapters.ReporteBoletaTableAdapter reporteBoletaTableAdapter;
        private System.Windows.Forms.BindingSource reporteBoletaBindingSource;
        private UITIDataSet1 uITIDataSet1;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private UITIDataSet1TableAdapters.EstudianteTableAdapter estudianteTableAdapter;
    }
}
namespace pryRodriguezSP1Clinica
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarMedico = new System.Windows.Forms.Button();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNumeroEspecialidad = new System.Windows.Forms.TextBox();
            this.mcrEspecialidades = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.mcrEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidades.Location = new System.Drawing.Point(6, 54);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(144, 25);
            this.lblEspecialidades.TabIndex = 0;
            this.lblEspecialidades.Text = "Especialidades";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(169, 54);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(184, 24);
            this.cboEspecialidad.TabIndex = 1;
            this.cboEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cboEspecialidad_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(380, 43);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 43);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombre});
            this.dgvConsulta.Location = new System.Drawing.Point(21, 155);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(365, 284);
            this.dgvConsulta.TabIndex = 3;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 6;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // btnAgregarMedico
            // 
            this.btnAgregarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedico.Location = new System.Drawing.Point(401, 281);
            this.btnAgregarMedico.Name = "btnAgregarMedico";
            this.btnAgregarMedico.Size = new System.Drawing.Size(157, 56);
            this.btnAgregarMedico.TabIndex = 4;
            this.btnAgregarMedico.Text = "Agregar nuevo medico";
            this.btnAgregarMedico.UseVisualStyleBackColor = true;
            this.btnAgregarMedico.Click += new System.EventHandler(this.btnAgregarMedico_Click);
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(401, 155);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(157, 59);
            this.btnAgregarEspecialidad.TabIndex = 5;
            this.btnAgregarEspecialidad.Text = "Agregar nueva especialidad";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(414, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtNumeroEspecialidad
            // 
            this.txtNumeroEspecialidad.Location = new System.Drawing.Point(21, 464);
            this.txtNumeroEspecialidad.Name = "txtNumeroEspecialidad";
            this.txtNumeroEspecialidad.ReadOnly = true;
            this.txtNumeroEspecialidad.Size = new System.Drawing.Size(148, 22);
            this.txtNumeroEspecialidad.TabIndex = 7;
            // 
            // mcrEspecialidades
            // 
            this.mcrEspecialidades.Controls.Add(this.lblEspecialidades);
            this.mcrEspecialidades.Controls.Add(this.cboEspecialidad);
            this.mcrEspecialidades.Controls.Add(this.btnConsultar);
            this.mcrEspecialidades.Location = new System.Drawing.Point(21, 12);
            this.mcrEspecialidades.Name = "mcrEspecialidades";
            this.mcrEspecialidades.Size = new System.Drawing.Size(505, 111);
            this.mcrEspecialidades.TabIndex = 8;
            this.mcrEspecialidades.TabStop = false;
            this.mcrEspecialidades.Text = "Buscar especialidades";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 520);
            this.Controls.Add(this.mcrEspecialidades);
            this.Controls.Add(this.txtNumeroEspecialidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarEspecialidad);
            this.Controls.Add(this.btnAgregarMedico);
            this.Controls.Add(this.dgvConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.Text = "Consulta Especialidades y Médicos";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.mcrEspecialidades.ResumeLayout(false);
            this.mcrEspecialidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnAgregarMedico;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNumeroEspecialidad;
        private System.Windows.Forms.GroupBox mcrEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}


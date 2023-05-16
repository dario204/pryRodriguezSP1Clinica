namespace pryRodriguezSP1Clinica
{
    partial class frmMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedico));
            this.lblNuevosMedicos = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarMedico = new System.Windows.Forms.Button();
            this.btnBorrarMedico = new System.Windows.Forms.Button();
            this.btnSalirMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevosMedicos
            // 
            this.lblNuevosMedicos.AutoSize = true;
            this.lblNuevosMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevosMedicos.Location = new System.Drawing.Point(169, 32);
            this.lblNuevosMedicos.Name = "lblNuevosMedicos";
            this.lblNuevosMedicos.Size = new System.Drawing.Size(310, 42);
            this.lblNuevosMedicos.TabIndex = 0;
            this.lblNuevosMedicos.Text = "Nuevos Medicos";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(28, 117);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(82, 22);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(31, 184);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(31, 247);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(207, 22);
            this.lblIdentificacion.TabIndex = 3;
            this.lblIdentificacion.Text = "Numero de Identificacion";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(258, 117);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(148, 22);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatricula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(258, 173);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(258, 247);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(148, 22);
            this.txtNumeroIdentificacion.TabIndex = 6;
            this.txtNumeroIdentificacion.TextChanged += new System.EventHandler(this.txtNumeroIdentificacion_TextChanged);
            this.txtNumeroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroIdentificacion_KeyPress);
            // 
            // btnRegistrarMedico
            // 
            this.btnRegistrarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMedico.Location = new System.Drawing.Point(500, 106);
            this.btnRegistrarMedico.Name = "btnRegistrarMedico";
            this.btnRegistrarMedico.Size = new System.Drawing.Size(117, 33);
            this.btnRegistrarMedico.TabIndex = 7;
            this.btnRegistrarMedico.Text = "Registrar";
            this.btnRegistrarMedico.UseVisualStyleBackColor = true;
            this.btnRegistrarMedico.Click += new System.EventHandler(this.btnRegistrarMedico_Click);
            // 
            // btnBorrarMedico
            // 
            this.btnBorrarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMedico.Location = new System.Drawing.Point(500, 168);
            this.btnBorrarMedico.Name = "btnBorrarMedico";
            this.btnBorrarMedico.Size = new System.Drawing.Size(117, 33);
            this.btnBorrarMedico.TabIndex = 8;
            this.btnBorrarMedico.Text = "Borrar";
            this.btnBorrarMedico.UseVisualStyleBackColor = true;
            this.btnBorrarMedico.Click += new System.EventHandler(this.btnBorrarMedico_Click);
            // 
            // btnSalirMedico
            // 
            this.btnSalirMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMedico.Location = new System.Drawing.Point(500, 236);
            this.btnSalirMedico.Name = "btnSalirMedico";
            this.btnSalirMedico.Size = new System.Drawing.Size(117, 33);
            this.btnSalirMedico.TabIndex = 9;
            this.btnSalirMedico.Text = "Salir";
            this.btnSalirMedico.UseVisualStyleBackColor = true;
            this.btnSalirMedico.Click += new System.EventHandler(this.btnSalirMedico_Click);
            // 
            // frmMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 335);
            this.Controls.Add(this.btnSalirMedico);
            this.Controls.Add(this.btnBorrarMedico);
            this.Controls.Add(this.btnRegistrarMedico);
            this.Controls.Add(this.txtNumeroIdentificacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblNuevosMedicos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMedico";
            this.Text = "Agregar nuego médico";
            this.Load += new System.EventHandler(this.frmMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevosMedicos;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.Button btnRegistrarMedico;
        private System.Windows.Forms.Button btnBorrarMedico;
        private System.Windows.Forms.Button btnSalirMedico;
    }
}
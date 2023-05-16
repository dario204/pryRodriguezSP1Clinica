namespace pryRodriguezSP1Clinica
{
    partial class frmEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidad));
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidadNumero = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.btnRegistrarEspecialidad = new System.Windows.Forms.Button();
            this.btnBorrarEspecialidad = new System.Windows.Forms.Button();
            this.btnSalirEspecialidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidades.Location = new System.Drawing.Point(128, 41);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(426, 42);
            this.lblEspecialidades.TabIndex = 0;
            this.lblEspecialidades.Text = "Nuevas especialidades";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(12, 121);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(207, 22);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Numero de Identificacion";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(49, 190);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(112, 22);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // txtEspecialidadNumero
            // 
            this.txtEspecialidadNumero.Location = new System.Drawing.Point(241, 123);
            this.txtEspecialidadNumero.Name = "txtEspecialidadNumero";
            this.txtEspecialidadNumero.Size = new System.Drawing.Size(170, 22);
            this.txtEspecialidadNumero.TabIndex = 3;
            this.txtEspecialidadNumero.TextChanged += new System.EventHandler(this.txtEspecialidadNumero_TextChanged);
            this.txtEspecialidadNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEspecialidadNumero_KeyPress);
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(241, 190);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(170, 22);
            this.txtEspecialidad.TabIndex = 4;
            // 
            // btnRegistrarEspecialidad
            // 
            this.btnRegistrarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEspecialidad.Location = new System.Drawing.Point(520, 106);
            this.btnRegistrarEspecialidad.Name = "btnRegistrarEspecialidad";
            this.btnRegistrarEspecialidad.Size = new System.Drawing.Size(114, 37);
            this.btnRegistrarEspecialidad.TabIndex = 5;
            this.btnRegistrarEspecialidad.Text = "Registrar";
            this.btnRegistrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnRegistrarEspecialidad.Click += new System.EventHandler(this.btnRegistrarEspecialidad_Click);
            // 
            // btnBorrarEspecialidad
            // 
            this.btnBorrarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarEspecialidad.Location = new System.Drawing.Point(520, 175);
            this.btnBorrarEspecialidad.Name = "btnBorrarEspecialidad";
            this.btnBorrarEspecialidad.Size = new System.Drawing.Size(114, 37);
            this.btnBorrarEspecialidad.TabIndex = 6;
            this.btnBorrarEspecialidad.Text = "Borrar";
            this.btnBorrarEspecialidad.UseVisualStyleBackColor = true;
            this.btnBorrarEspecialidad.Click += new System.EventHandler(this.btnBorrarEspecialidad_Click);
            // 
            // btnSalirEspecialidad
            // 
            this.btnSalirEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEspecialidad.Location = new System.Drawing.Point(520, 241);
            this.btnSalirEspecialidad.Name = "btnSalirEspecialidad";
            this.btnSalirEspecialidad.Size = new System.Drawing.Size(114, 37);
            this.btnSalirEspecialidad.TabIndex = 7;
            this.btnSalirEspecialidad.Text = "Salir";
            this.btnSalirEspecialidad.UseVisualStyleBackColor = true;
            this.btnSalirEspecialidad.Click += new System.EventHandler(this.btnSalirEspecialidad_Click);
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 331);
            this.Controls.Add(this.btnSalirEspecialidad);
            this.Controls.Add(this.btnBorrarEspecialidad);
            this.Controls.Add(this.btnRegistrarEspecialidad);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtEspecialidadNumero);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblEspecialidades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEspecialidad";
            this.Text = "Agregar nueva especialidad";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidadNumero;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Button btnRegistrarEspecialidad;
        private System.Windows.Forms.Button btnBorrarEspecialidad;
        private System.Windows.Forms.Button btnSalirEspecialidad;
    }
}
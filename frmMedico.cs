using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP1Clinica
{
    public partial class frmMedico : Form
    {
        public frmMedico()
        {
            InitializeComponent();
        }
        private const string PATH_ARCHIVO_MEDICO = "Medico.txt";

        private void Inicializar()
        {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            txtNumeroIdentificacion.Text = "";
            btnBorrarMedico.Enabled = false;
            
        }
        //Registar nuevo medico
        private void btnRegistrarMedico_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                clsIdentificacion mediconuevo = MedicoNuevo();
                clsPropiedades medicos = new clsPropiedades();
                medicos.NombreArchivo = PATH_ARCHIVO_MEDICO;
                medicos.GrabarMedico(mediconuevo);
                Inicializar();
                MessageBox.Show("Registro existoso", "",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos", "Ingrese nuevamente los datos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtMatricula.Text != "") // controla la matricula
            {
                if (txtNombre.Text != "") // controla el nombre
                {
                    if (txtNumeroIdentificacion.Text != "") // controla el numero de identificacion
                    {
                        clsPropiedades medico = new clsPropiedades();
                        medico.NombreArchivo = PATH_ARCHIVO_MEDICO;
                        // controla que no se repita la matricula
                        if (medico.BuscarRepetidos(txtMatricula.Text) == false)
                        {
                            resultado = true; // devuelve verdadero sólo si todas
                                              // las condiciones se cumplieron
                        }
                    }
                }
            }
            return resultado;
        }
        private clsIdentificacion MedicoNuevo()
        {
            clsIdentificacion MedicoNuevo = new clsIdentificacion();
            MedicoNuevo.matricula = int.Parse(txtMatricula.Text);
            MedicoNuevo.nombre= txtNombre.Text;
            MedicoNuevo.identificacion = int.Parse(txtNumeroIdentificacion.Text);
            return MedicoNuevo;
        }

        private void txtNumeroIdentificacion_TextChanged(object sender, EventArgs e)
        {

            if (txtMatricula.Text != null && txtNombre.Text != null && txtNumeroIdentificacion.Text != null)
            {
                btnRegistrarMedico.Enabled = true;
            }
        }

        private void btnBorrarMedico_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalirMedico_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

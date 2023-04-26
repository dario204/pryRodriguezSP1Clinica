using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP1Clinica
{
    public partial class frmEspecialidad : Form
    {
        public frmEspecialidad()
        {
            InitializeComponent();
        }
        private const string PATH_ARCHIVO_ESPECIALIDAD = "Especialidad.txt";

        private void Inicializar()
        {
            txtEspecialidad.Text = "";
            txtEspecialidadNumero.Text = "";
            btnRegistrarEspecialidad.Enabled = false;
        }
        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private bool ValidarDatos()
        {
            bool resultado = false;
            if (txtEspecialidad.Text != "") // controla la Especialidad
            {
                if (txtEspecialidadNumero.Text != "") // controla el numero de la especialidad
                {
                    clsArchivo especialidad = new clsArchivo();
                    especialidad.NombreArchivo = PATH_ARCHIVO_ESPECIALIDAD;
                    // controla que no se repita la matricula
                    if (especialidad.BuscarRepetidos(txtEspecialidadNumero.Text) == false)
                    {
                        resultado = true; // devuelve verdadero sólo si todas las condiciones se cumplieron
                    }

                }
            }
            return resultado;
        }
        private clsMedico EspecialidadNueva()
        {
            clsMedico especialidad = new clsMedico();
            especialidad.identificacion= int.Parse(txtEspecialidadNumero.Text);
            especialidad.nombre = txtEspecialidad.Text;
            return especialidad;
        }

        private void btnRegistrarEspecialidad_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                clsMedico especialidad = EspecialidadNueva();
                clsArchivo especialidades = new clsArchivo();
                especialidades.NombreArchivo = PATH_ARCHIVO_ESPECIALIDAD;
                especialidades.GrabarEspecialidad(especialidad);
                Inicializar();
            }
            else
            {
                MessageBox.Show("Los datos son incorrectos", "Ingrese nuevamente los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarEspecialidad_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void txtEspecialidadNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtEspecialidad.Text != null && txtEspecialidadNumero.Text != null)
            {
                btnRegistrarEspecialidad.Enabled = true;
            }
        }

        private void txtEspecialidadNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnSalirEspecialidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

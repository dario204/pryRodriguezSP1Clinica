using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSP1Clinica
{
    public partial class frmInicio : Form
    {
        //declaro nombre archivo Medicos
        private const string PATH_ARCHIVO_MEDICO = "Medico.txt";

        //declaro nombre archivo Especialidades
        private const string PATH_ARCHIVO_ESPECIALIDAD = "Especialidad.txt";
        int[] NumeroEspecialidad = new int[8];
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            AgregarEspecialidad();
        }
        private void AgregarEspecialidad()
        {
            // controlar si el archivo existe
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO_ESPECIALIDAD))
            {
                MessageBox.Show("No se ha registrado ninguna especialidad","" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // leer el contenido del archivo
            clsPropiedades especialidad = new clsPropiedades();
            especialidad.NombreArchivo = PATH_ARCHIVO_ESPECIALIDAD;
            List<clsIdentificacion> especialidades = especialidad.ObtenerEspecialidades();
            //limpia el combobox
            cboEspecialidad.Items.Clear();
            //recorre la lista
            foreach (clsIdentificacion especialidadess in especialidades)
            {
                cboEspecialidad.Items.Add(especialidadess.nombre);
                for (int i = 0; i < especialidades.Count; i++)
                {
                    NumeroEspecialidad[i] = especialidadess.identificacion;
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\" + PATH_ARCHIVO_MEDICO))
            {
                MessageBox.Show("No se ha registrado ninguna especialidad", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsPropiedades medico = new clsPropiedades();
            medico.NombreArchivo = PATH_ARCHIVO_MEDICO;
            List<clsIdentificacion> medicos = medico.ObtenerMedicos();

            dgvConsulta.Rows.Clear();
            foreach (clsIdentificacion medicoss in medicos)
            {
                if (medicoss.identificacion == int.Parse(lblEspecialidades.Text))
                {
                    dgvConsulta.Rows.Add(medicoss.matricula, medicoss.nombre);
                }
            }

            cboEspecialidad.SelectedIndex = -1;
            txtNumeroEspecialidad.Text = "";
        }

        private void cboEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEspecialidad.SelectedIndex == 0)
            {
                txtNumeroEspecialidad.Text = NumeroEspecialidad[0].ToString();
            }
            else
            {
                if (cboEspecialidad.SelectedIndex == 1)
                {
                    txtNumeroEspecialidad.Text = NumeroEspecialidad[1].ToString();
                }
                else
                {
                    if (cboEspecialidad.SelectedIndex == 2)
                    {
                        txtNumeroEspecialidad.Text = NumeroEspecialidad[2].ToString();
                    }
                    else
                    {
                        if (cboEspecialidad.SelectedIndex == 3)
                        {
                            txtNumeroEspecialidad.Text = NumeroEspecialidad[3].ToString();
                        }
                        else
                        {
                            if (cboEspecialidad.SelectedIndex == 4)
                            {
                                txtNumeroEspecialidad.Text = NumeroEspecialidad[4].ToString();
                            }
                            else
                            {
                                if (cboEspecialidad.SelectedIndex == 5)
                                {
                                    txtNumeroEspecialidad.Text = NumeroEspecialidad[5].ToString();
                                }
                                else
                                {
                                    if (cboEspecialidad.SelectedIndex == 6)
                                    {
                                        txtNumeroEspecialidad.Text = NumeroEspecialidad[6].ToString();
                                    }
                                    else
                                    {
                                        if (cboEspecialidad.SelectedIndex == 7)
                                        {
                                            txtNumeroEspecialidad.Text = NumeroEspecialidad[7].ToString();
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidad frm = new frmEspecialidad();
            frm.ShowDialog();
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            frmMedico frm = new frmMedico();
            frm.ShowDialog();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

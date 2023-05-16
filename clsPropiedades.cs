using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRodriguezSP1Clinica
{
    internal class clsPropiedades
    {
        public string NombreArchivo { get; set; }
        public bool GrabarMedico(clsIdentificacion registro)
        {
            bool resultado = false;

            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(registro.matricula + "," + registro.nombre + " " + registro.identificacion);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool GrabarEspecialidad(clsIdentificacion registro)
        {
            bool resultado = false;
            if (NombreArchivo != "")
            {
                StreamWriter sw = new StreamWriter(NombreArchivo, true);
                sw.WriteLine(registro.identificacion + "," + registro.nombre);
                sw.Close();
                sw.Dispose();
                resultado = true;
            }
            return resultado;
        }

        public bool BuscarRepetidos(string repetido)
        {
            bool resultado = false;
            string Linea;
            string Matricula;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    Matricula = Linea.Split(',')[0];
                    if (repetido == Matricula)
                    {
                        resultado = true;
                        break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }
            return resultado;
        }

        public List<clsIdentificacion> ObtenerMedicos()
        {
            List<clsIdentificacion> Lista = new List<clsIdentificacion>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    clsIdentificacion Medico = new clsIdentificacion();
                    Medico.matricula = int.Parse(Linea.Split(',')[0]);
                    Medico.nombre = Linea.Split(',')[1];
                    Medico.identificacion= int.Parse(Linea.Split(',')[2]);
                    Lista.Add(Medico);

                }
                sr.Close();
                sr.Dispose();
            }
            return Lista;
        }

        public List<clsIdentificacion> ObtenerEspecialidades()
        {

            List<clsIdentificacion> Lista = new List<clsIdentificacion>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    clsIdentificacion especialidad = new clsIdentificacion();
                    especialidad.identificacion = int.Parse(Linea.Split(',')[0]);
                    especialidad.nombre = Linea.Split(',')[1];
                    Lista.Add(especialidad);
                }
                sr.Close();
                sr.Dispose();
            }
            return Lista;
        }
    }
}

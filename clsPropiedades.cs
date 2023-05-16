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
        public bool GrabarMedico(clsMedico registro)
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

        public bool GrabarEspecialidad(clsMedico registro)
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
            if (NombreArchivo != "" && File.Exists(NombreArchivo)) //verifica que el archivo existe
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
                    sr.Close();
                    sr.Dispose();
                }
            }
            return resultado;
        }

        public List<clsMedico> ObtenerMedicos()
        {
            List<clsMedico> Lista = new List<clsMedico>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    clsMedico medico = new clsMedico();
                    medico.matricula = int.Parse(Linea.Split(',')[0]);
                    medico.nombre = Linea.Split(',')[1];
                   
                    Lista.Add(medico);
                }
                sr.Close();
                sr.Dispose();
            }
            return Lista;
        }

        public List<clsMedico> ObtenerEspecialidades()
        {

            List<clsMedico> Lista = new List<clsMedico>();
            string Linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();
                    clsMedico especialidad = new clsMedico();
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

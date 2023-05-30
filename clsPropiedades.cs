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
                sw.WriteLine(registro.matricula + "," + registro.nombre + "," + registro.identificacion);
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
            // devuelve falso si el código no existe en el archivo
            // devuelve verdadero si el código ya está grabado
            bool resultado = false;
            string Linea;
            string Matricula;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                //crea el stream en modo lectura
                StreamReader sr = new StreamReader(NombreArchivo);
                //lee hasta el final
                while (sr.EndOfStream == false)
                {
                    Linea = sr.ReadLine();// lee una linea completa
                                          // el código está en el primer valor de cada línea
                    Matricula = Linea.Split(',')[0];
                    // comparar el código buscado con el del archivo
                    if (repetido == Matricula)
                    {
                        //si son iguales devuelve verdadero
                        resultado = true;
                        break; //sale del ciclo de lectura
                    }
                }
                sr.Close();//cierra el stream
                sr.Dispose();//libera los recursos
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
                    // el valor decimal se formatea sin formatos regionales
                    // para mantener el punto como separador decimal
                    Medico.matricula = int.Parse(Linea.Split(',')[0]);
                    Medico.nombre = Linea.Split(',')[1];
                    Medico.identificacion = int.Parse(Linea.Split(',')[2]);
                    //se agrega el repuesto a la lista
                    Lista.Add(Medico);

                }
                sr.Close();
                sr.Dispose();
            }
            //devuelve la lista de medicos completa
            return Lista;
        }

        public List<clsIdentificacion> ObtenerEspecialidades()
        {
            List<clsIdentificacion> lista = new List<clsIdentificacion>();
            string linea;
            if (NombreArchivo != "" && File.Exists(NombreArchivo))
            {
                StreamReader sr = new StreamReader(NombreArchivo);
                while (sr.EndOfStream == false)
                {
                    linea = sr.ReadLine();
                    clsIdentificacion identificacion = new clsIdentificacion();
                    identificacion.identificacion = int.Parse(linea.Split(',')[0]);
                    identificacion.nombre = linea.Split(',')[1];
                    lista.Add(identificacion);
                }
                sr.Close();
                sr.Dispose();
            }
            return lista;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.MiniProcess
{
    public class ManejadorString
    {

        public string primerElemento(string cadena)
        {

            return this.modelarCadena(cadena).First();
        }

        public string[] segundoElemento(string  cadena)
        {
            string[] cadenaModelada=this.modelarCadena(cadena);
            string palabrasConcatenadas = cadenaModelada[1];
            string[] palabras = palabrasConcatenadas.Split(new Char[] { ' ' });
            return palabras;
        }

        private string[] modelarCadena(string palabra)
        {
            return palabra.Split(new Char[] { ';' });
        }
    }
}

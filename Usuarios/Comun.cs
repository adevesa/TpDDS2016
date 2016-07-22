using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Consola;

namespace Usuarios
{
    public class Comun:Usuario
    {
        public List<Poi> buscar(string palabraClave)
        {
            List<Poi> resultado;
            resultado = getTerminal().buscar(palabraClave);
            base.almacenarBusqueda(palabraClave, resultado);
            return resultado;
        }
    }
}

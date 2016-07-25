using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenadorBusquedas
{

    public struct busqueda
    {
        public string nombreDeUsuario;
        public string palabraBuscada;
        public int resultadoDeLaBusqueda;
        public DateTime fecha;
        
        public busqueda(string nombreUsuario, string palabraBuscadaa, int cantidadResutados, DateTime fechaDeBusqueda)
        {
            this.nombreDeUsuario = nombreUsuario;
            this.palabraBuscada = palabraBuscadaa;
            this.resultadoDeLaBusqueda = cantidadResutados;
            this.fecha = fechaDeBusqueda;
        }
    }

    public struct busquedaPorFecha
    {
        public DateTime fecha;
        public int cantidadDeResultados;

        public busquedaPorFecha(DateTime fechaDeBusqueda, int resultadosObtenidos)
        {
            this.fecha = fechaDeBusqueda;
            this.cantidadDeResultados = resultadosObtenidos;
        }
    }

    public struct busquedaPorUsuario
    {
        public string nombreDelUsuario;
        public int cantidadDeResultados;
        
        public busquedaPorUsuario(string nombreUsuario, int resultadosObtenidos)
        {
            this.nombreDelUsuario = nombreUsuario;
            this.cantidadDeResultados = resultadosObtenidos;
        }
    }

}

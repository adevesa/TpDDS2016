using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.ManejoDeErrores
{
    public class Reintentar : ErrorGestion
    {
        private int cantidadMaximaDeIntentos;
        private int cantidadDeIntentosRealizados;

        public void setCantidadMaximaDeIntentos(int cantidadMaxima) { this.cantidadMaximaDeIntentos = cantidadMaxima; }

        //Constructor

        public Reintentar(int cantidad)
        {
            setCantidadMaximaDeIntentos(cantidad);
            cantidadDeIntentosRealizados = 0;
        }

        public override void lanzar(Proceso proceso)
        {
            incrementarCantidad();
            proceso.ejecutar(proceso.getMailDelUsserQueEjecuta());
        }

        private void incrementarCantidad()
        {
            cantidadDeIntentosRealizados++;
        }
    }
}

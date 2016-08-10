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
            init();
        }

        public override void manipularResultado(Proceso proceso)
        {
            if (proceso.hayError)
            {
                if (cantidadDeIntentosRealizados <= cantidadMaximaDeIntentos)
                    { realizarSiguienteIteracion(proceso); }
                almacenarResultadoNegativo(proceso.getNombreDelProceso());
            }
            almacenarResultadoPositivo(proceso.getNombreDelProceso());
        }

        private void realizarSiguienteIteracion(Proceso proceso)
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

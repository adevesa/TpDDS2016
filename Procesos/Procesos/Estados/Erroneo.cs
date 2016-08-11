using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.Procesos.Estados
{
    public class Erroneo: Estado
    {
        private Proceso proceso;

        public Erroneo(Proceso proceso)
        {
            this.proceso = proceso;
        }

        //Metodos
        public bool esCorrecto() { return false; }

        public void cambiarEstado()
        {
            proceso.setEstado(new Correcto(proceso));
        }

        public void manipularResultado()
        {
            proceso.getTipoManejoDeError().lanzar(proceso);
        }
    }
}

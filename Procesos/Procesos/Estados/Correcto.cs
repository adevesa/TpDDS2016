using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Procesos;

namespace Procesos.Procesos.Estados
{
    public class Correcto: Estado
    {
        private Proceso proceso;

        public Correcto(Proceso proceso)
        {
            this.proceso = proceso;
        }

        //Metodos
        

        public void cambiarEstado()
        {
            proceso.setEstado(new Erroneo(proceso));
        }

        public void manipularResultado()
        {
            proceso.getTipoManejoDeError().noHacerNada();
        }

    }
}

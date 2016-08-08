using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos
{
    public class ProcesoMultiple : Proceso
    {
        //Atributos 
        private List<Proceso> procesosAsociados;

        //Setters y getters
        public void setProcesosAsociados(List<Proceso> listProcesos) { this.procesosAsociados = listProcesos; }

        //Constructor
        public ProcesoMultiple()
        {
            this.procesosAsociados = new List<Proceso>(); 
        }


        //Método polimórfico
        public override int ejecutar()
        {
            foreach (Proceso unProceso in procesosAsociados)
            {
                unProceso.ejecutar();
            }
            return 0;
        }

        public void agregarProceso(Proceso proceso)
        {
            this.procesosAsociados.Add(proceso);
        }
    }
}

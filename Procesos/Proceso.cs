using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Procesos
{
    public abstract class Proceso
    {
        //Atributos
        private string nombreDelProceso;
        

        //Setters y getters
        protected void setNombreDelProceso(string nombre) { this.nombreDelProceso = nombre; }
        public string getNombreDelProceso() { return this.nombreDelProceso; }

        //Metodos

        public virtual int ejecutar() { return 0; }
    }
}

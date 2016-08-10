using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Procesos.ManejoDeErrores;
using Procesos.Procesos.Estados;


namespace Procesos
{
    public abstract class Proceso
    {
        //Atributos
        private string nombreDelProceso;
        private string mailDelUsserQueEjecuta;
        private Estado estado;
        private ErrorGestion tipoDeError;
        

        //Setters y getters
        protected void setNombreDelProceso(string nombre) { this.nombreDelProceso = nombre; }
        public string getNombreDelProceso() { return this.nombreDelProceso; }

        public void setMailDelUsserQueEjecuta(string mail) { this.mailDelUsserQueEjecuta = mail; }
        public string getMailDelUsserQueEjecuta() { return this.mailDelUsserQueEjecuta; }

        public void setTipoDeManejoDeError(ErrorGestion tipoDeManejador) { this.tipoDeError = tipoDeManejador; }
        public ErrorGestion getTipoManejoDeError() { return this.tipoDeError; }

        public void setEstado(Estado estadoNuevo) { this.estado = estadoNuevo; }
        public Estado getEstado() { return this.estado; }

        //Metodos

        protected void init()
        {
            this.estado = new Correcto(this);
        }

        public virtual void ejecutar(string mailDelUsuario) {  }

       
    }
}

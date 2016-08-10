using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Procesos.ManejoDeErrores;


namespace Procesos
{
    public abstract class Proceso
    {
        //Atributos
        private string nombreDelProceso;
        private string mailDelUsserQueEjecuta;
        public bool hayError;
        private ErrorGestion tipoDeError;
        

        //Setters y getters
        protected void setNombreDelProceso(string nombre) { this.nombreDelProceso = nombre; }
        public string getNombreDelProceso() { return this.nombreDelProceso; }

        public void setMailDelUsserQueEjecuta(string mail) { this.mailDelUsserQueEjecuta = mail; }
        public string getMailDelUsserQueEjecuta() { return this.mailDelUsserQueEjecuta; }

        public void setTipoDeManejoDeError(ErrorGestion tipoDeManejador) { this.tipoDeError = tipoDeManejador; }

        //Metodos
        protected void init() { this.hayError = false; }

        public virtual void ejecutar(string mailDelUsuario) {  }

        protected void cambiarEstado(bool valor)
        {
            hayError = valor;
            tratarErrorSiEsNecesario();
        }

        private void tratarErrorSiEsNecesario()
        {
            this.tipoDeError.manipularResultado(this);
        }
       
    }
}

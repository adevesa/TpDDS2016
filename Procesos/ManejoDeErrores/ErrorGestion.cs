using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.ManejoDeErrores
{
    
    public abstract class ErrorGestion
    {
        //Atributos
        private string mailDelUsuario;
        

        //Setters y getters
        protected void setMailDelUsuario(string mail) { this.mailDelUsuario = mail; }
        protected string getMailDelUsser() { return this.mailDelUsuario; }

        //Metodos

        public virtual void lanzar(Proceso proceso) { }

        public void noHacerNada() { }
    }
}

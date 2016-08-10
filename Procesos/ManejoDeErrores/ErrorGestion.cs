using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.ManejoDeErrores
{
    public struct Resultado
    {
        string mailDelUsuario;
        string nombreDelProceso;
        string resultado;

        public Resultado(string mail, string nombreDelProceso, string resultado)
        {
            this.mailDelUsuario = mail;
            this.nombreDelProceso = nombreDelProceso;
            this.resultado = resultado;
        }
    }

    public abstract class ErrorGestion
    {
        //Atributos
        private string mailDelUsuario;
        private List<Resultado> resultados;

        //Setters y getters
        protected void setMailDelUsuario(string mail) { this.mailDelUsuario = mail; }
        protected string getMailDelUsser() { return this.mailDelUsuario; }

        //Metodos
        protected void init()
        {
            this.resultados = new List<Resultado>();
        }

        protected void almacenarResultadoPositivo(string nombreDelProceso)
        {
                resultados.Add(new Resultado(getMailDelUsser(),nombreDelProceso, "ok"));
            
        }
        protected void almacenarResultadoNegativo(string nombreDelProceso)
        {
            resultados.Add(new Resultado(getMailDelUsser(), nombreDelProceso, "error"));
        }

        public virtual void manipularResultado(Proceso proceso) { }
    }
}

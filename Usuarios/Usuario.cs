using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Consola;
 

namespace Usuarios
{
    public abstract class Usuario
    {

        //Atributos
        private string nombreCompleto;
        private string direccion;
        private string mail;
        private int numeroDecontacto;
        private int idUsuario;
        private TerminalConsola terminalUtilizada;
         

        //Setters y getters
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public string getNombreCompleto() { return this.nombreCompleto; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public string getDireccion() { return this.direccion; }

        public void setMail(string eMail) { this.mail = eMail; }
        public string getMail() { return this.mail; }

        public void setNumeroDeContacto(int numero) { this.numeroDecontacto = numero; }
        public int getNumeroDeContacto() { return this.numeroDecontacto; }

        public void setIdUsuario(int numero) { this.idUsuario = numero; }
        public int getIdUsuario() { return this.idUsuario; }

        public void setTerminalUtilizada(TerminalConsola terminal) { this.terminalUtilizada = terminal; }
        public TerminalConsola getTerminalUtilizada() { return this.terminalUtilizada; }

        //Metodos
        public virtual bool esAdministrador() { return false; }

        public List<POI> buscar(string criterio)
        {
            return getTerminalUtilizada().buscar(criterio);
        }

    }
}

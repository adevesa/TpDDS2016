using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Consola;
using AccionesPorUsuarios;
 

namespace Usuarios
{
    public abstract class Usuario
    {

        //Atributos
        private string nombreCompleto;
        private string contraseña;
        private string nombreDeUsuario;
        private string direccion;
        private string mail;
        private int numeroDecontacto;
        private int idUsuario;
        private TerminalConsola terminalUtilizada;
        private List<Accion> acciones;

        //Setters y getters
        public void setNombreCompleto(string nombreCompleto) { this.nombreCompleto = nombreCompleto; }
        public string getNombreCompleto() { return this.nombreCompleto; }

        public void setNombreDeUsuario(string nombreDeUsuario) { this.nombreDeUsuario = nombreDeUsuario; }
        public string getNombreDeUsuario() { return this.nombreDeUsuario; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public string getDireccion() { return this.direccion; }

        public void setMail(string eMail) { this.mail = eMail; }
        public string getMail() { return this.mail; }

        public void setNumeroDeContacto(int numero) { this.numeroDecontacto = numero; }
        public int getNumeroDeContacto() { return this.numeroDecontacto; }

        public void setIdUsuario(int numero) { this.idUsuario = numero; }
        public int getIdUsuario() { return this.idUsuario; }

        public void setContraseña(string contraseña) { this.contraseña = contraseña; }
        public string getContraseña() { return this.contraseña; }

        public void setTerminalUtilizada(TerminalConsola terminal) { this.terminalUtilizada = terminal; }
        public TerminalConsola getTerminalUtilizada() { return this.terminalUtilizada; }

        public List<Accion> getAcciones() { return this.acciones; }

        //Initializer
        protected void init()
        {
            this.acciones = new List<Accion>();
        }
        
        //Metodos

        //* @name: esAdministrador()
        //* @decryp: por defecto retornará false. Cada clase hija redefinirá a true en caso de que cumpla
        //* con el criterio.
        public virtual bool esAdministrador() { return false; }


        public List<POI> buscar(string criterio)
        {
            return getTerminalUtilizada().buscar(criterio);
        }

 
        //* @name: ejecutarAccion(nombreDeLaAccion)
        //* @decryp: recibe el nombre de la acción y realiza la ejecución de la misma.
        public void ejecutarAccion(string accion)
        {
            Accion accionAEjecutar = buscarAccion(accion);
            accionAEjecutar.ejecutar();
        }

        //* Métodos de manipulación de acciones
        public Accion buscarAccion(string nombre)
        {
            return this.acciones.Find(accion => accion.getNombre() == nombre);
        }

        public void agregarAccion(Accion accion)
        {
            this.acciones.Add(accion);
        }

        public void borrarAccion(Accion accion)
        {
            this.acciones.Remove(accion);
        }

        public bool coincideContraseña(string supuestaContraseña)
        {
            return getContraseña() == supuestaContraseña;
        }
    }
}

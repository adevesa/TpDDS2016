using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;
using Consola;
using AccionesPorUsuarios;

namespace UssersGestion
{
    public class GestorDeUsuarios
    {
        //Atributos
        private UsuarioDao usserDao;
        private bool esAdministradorUsuarioActivo;
        
        //Constructor
        public GestorDeUsuarios()
        {
            this.usserDao = UsuarioDao.getInstance();

        }

        //Setters y getters
        public List<Usuario> getUssers() { return this.usserDao.getUssers(); }

                //Metodos

        //* @name: crearUsuario(tipo, nombre, numero, direccion)
        //* @decryp: delega al factory la creación del usuario.
        public void crearUsuario(string tipoUsuario, string nombreDeUsuario,string contraseña, string nombreCompleto, string mail)
        {
            this.usserDao.crearUsuario(tipoUsuario, nombreDeUsuario,contraseña, nombreCompleto, mail, this.esAdministradorUsuarioActivo);
            
        }

        //* @name: loggearUsuarioEn(nombreDeUsuario, terminal)
        //* @decryp: recibe un nombre de usuario (NO NOMBRE COMPLETO; recibe por ejemplo:"fede_capo2007"),
        //*  y una terminal. Establece la conexión entre ambos setteandole a la terminal que el usserActivo
        //* es el que realiza la petición. Además se settea en el usuario que la terminal utilizada es la recibida.
        public void loggearUsuarioEn(string nombreDeUsuario,string contraseña, TerminalConsola terminal)
        {
            Usuario usserBuscado = buscarUsuario(nombreDeUsuario);
            if (usserBuscado != null && usserBuscado.coincideContraseña(contraseña))
            { loggerUsuario(usserBuscado, terminal); }
            else { throw new System.InvalidOperationException("No se encuentra usuario en la base de datos"); }
        }
        private void loggerUsuario(Usuario usser, TerminalConsola terminal)
        {
            terminal.loggearUsuario(usser.getNombreDeUsuario());
            usser.setTerminalUtilizada(terminal);
            terminal.setUsuarioCuentaConPrivilegiosEspeciales(usser.esAdministrador());
            this.esAdministradorUsuarioActivo=usser.esAdministrador();
        }
        
        //* @name: cerrarSesionDe(nombreDeUsuario, terminal)
        //* @decryp: recibe el nombre del usuario que desea cerrar sension en la terminal solicitada.
        //* Se settea que la terminal utilizada por el usuario es "null", y se ejecuta el método
        //* cerrarSesion de la terminal.
        public void cerrarSesionDe(string nombreDeUsuario, TerminalConsola terminal)
        {
            buscarUsuario(nombreDeUsuario).setTerminalUtilizada(null);
            terminal.cerrarSesion();
        }

        //* @name: buscarUsuario(nombreDeUsuario)
        //* @decryp: recibe un nombre de usuario y retorna el usuario (tipo usuario) buscado
        public Usuario buscarUsuario(string nombreDeUsuario)
        {
            return this.usserDao.buscarUsser(nombreDeUsuario);
        }

        public List<String> mapearNombresDeUsuarios()
        {
            return this.usserDao.filtrarNombresDeUsuarios();
        }


        


    }
}

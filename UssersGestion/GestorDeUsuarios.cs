using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;
using Consola;

namespace UssersGestion
{
    public class GestorDeUsuarios
    {
        //Atributos
        private UsuarioDao usserDao;
        private bool esAdministradorUsuarioActivo;

        //Setters y getters
        public List<Usuario> getUssers() { return this.usserDao.getUssers(); }

                //Metodos

        //* @name: crearUsuario(tipo, nombre, numero, direccion)
        //* @decryp: delega al factory la creación del usuario.
        public void crearUsuario(string tipoUsuario, string nombreDeUsuario, string nombreCompleto, string mail)
        {
            this.usserDao.crearUsuario(tipoUsuario, nombreDeUsuario, nombreCompleto, mail, this.esAdministradorUsuarioActivo);
            
        }

        //* @name: loggearUsuarioEn(nombreDeUsuario, terminal)
        //* @decryp: recibe un nombre de usuario (NO NOMBRE COMPLETO; recibe por ejemplo:"fede_capo2007"),
        //*  y una terminal. Establece la conexión entre ambos setteandole a la terminal que el usserActivo
        //* es el que realiza la petición. Además se settea en el usuario que la terminal utilizada es la recibida.
        public void loggearUsuarioEn(string nombreDeUsuario, TerminalConsola terminal)
        {
            Usuario usserBuscado = usserDao.buscarUsser(nombreDeUsuario);
            if (usserBuscado != null) { loggerUsuario(usserBuscado, terminal); }
            else { throw new System.InvalidOperationException("No se encuentra usuario en la base de datos"); }
        }
        private void loggerUsuario(Usuario usser, TerminalConsola terminal)
        {
            terminal.loggearUsuario(usser.getNombreDeUsuario());
            usser.setTerminalUtilizada(terminal);
            terminal.setUsuarioCuentaConPrivilegiosEspeciales(usser.esAdministrador());
            this.esAdministradorUsuarioActivo=usser.esAdministrador();
        }
        
        public List<String> mapearNombresDeUsuarios()
        {
            return this.usserDao.filtrarNombresDeUsuarios();
        }

        //Constructor
        public GestorDeUsuarios()
        {
            this.usserDao = new UsuarioDao();
            
        }


    }
}

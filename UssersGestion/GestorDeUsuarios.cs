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
        private List<Usuario> ussers = new List<Usuario>();
        public List<Usuario> getUssers() { return ussers; }

        public int crearUsuario(Usuario tipoUsuario, string nombreCompleto, int numeroDeContacto, string direccion)
        {
            int codigoDeIdentificacion = GeneradorDeUsuario.crearUsuario(tipoUsuario, nombreCompleto, numeroDeContacto, direccion);
            agregarUsuario(tipoUsuario);
            return (codigoDeIdentificacion);
            
        }

        public void agregarUsuario(Usuario usuario)
        {
            getUssers().Add(usuario);

        }

        public void loggearUsuarioEn(int idUsuario, TerminalConsola terminal)
        {
            Usuario usserBuscado = mapearUsser(idUsuario);
            if(usserBuscado != null)
            { terminal.loggearUsuario(usserBuscado); }
            else { throw new System.InvalidOperationException("No se encuentra usuario en la base de datos"); }
                
        }
        public void loggearUsuarioEn(string nombreDeUsuario, TerminalConsola terminal)
        {
            Usuario usserBuscado = mapearUsser(nombreDeUsuario);
            if (usserBuscado != null)
            {
                terminal.loggearUsuario(usserBuscado);
            }
            else { throw new System.InvalidOperationException("No se encuentra usuario en la base de datos"); }
        }
        public Usuario mapearUsser(int idUsser)
        {
            Usuario usserPedido = getUssers().Find(usuario => usuario.getIdUsuario() == idUsser);
            return usserPedido;
        }
        public Usuario mapearUsser(string nombreDeUsuario)
        {
            Usuario usserPedido = getUssers().Find(usuario => usuario.getNombreCompleto() == nombreDeUsuario);
            return usserPedido;
        }


        public List<String> mapearNombresDeUsuarios()
        {
            List<String> lista = new List<String>();
            foreach(Usuario usser in getUssers())
            {
                lista.Add(usser.getNombreCompleto());
            }
            return lista;
        }

        //Constructor
        public GestorDeUsuarios()
        {
            this.init();
        }

        private void init()
        {
            //Administradores default
            crearUsuario(new Administrador(), "ezequiel oscar escobar", 1156339537, "corrientes 440");
            crearUsuario(new Administrador(), "santiago candia", 1141758947, "cordoba 1100");
            crearUsuario(new Administrador(), "profe paula", 1159339596, "avenida de mayo 550");

            //Usuarios default
            crearUsuario(new Comun(), "agustin greco", 1137032497, "lavalle 1080");
            crearUsuario(new Comun(), "agustin devesa", 1167964584, "venezuela 100");
        }

    }
}

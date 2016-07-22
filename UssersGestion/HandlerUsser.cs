using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;
using Consola;

namespace UssersGestion
{
    public class HandlerUsser
    {
        private List<Usuario> ussers;
        public List<Usuario> getUssers() { return ussers; }
       

        public int crearUsuario(Usuario tipoUsuario, string nombreCompleto, int numeroDeContacto, string direccion)
        {
            int code = GeneradorDeUsuario.crearUsuario(tipoUsuario, nombreCompleto, numeroDeContacto, direccion);
            agregarUsuario(tipoUsuario);
            return (code);
            
        }

        public void agregarUsuario(Usuario usuario)
        {
            getUssers().Add(usuario);

        }

        public void loggearUsuarioEn(int idUsuario, TerminalConsola terminal)
        {
            mapearUsser(idUsuario).loggearEn(terminal);

        }

        private Usuario mapearUsser(int idUsser)
        {
            Usuario usserPedido = getUssers().Find(usuario => usuario.getIdUsuario() == idUsser);
            return usserPedido;
        }

    }
}

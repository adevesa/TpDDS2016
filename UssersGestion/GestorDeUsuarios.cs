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
        private List<Usuario> ussers;
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
            { usserBuscado.loggearEn(terminal); }
            else { throw new System.InvalidOperationException("No se encuentra usuario en la base de datos."); }
                
        }

        private Usuario mapearUsser(int idUsser)
        {
            Usuario usserPedido = getUssers().Find(usuario => usuario.getIdUsuario() == idUsser);
            return usserPedido;
        }

    }
}

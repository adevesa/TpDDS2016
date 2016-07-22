using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios;

namespace UssersGestion
{
    public class HandlerUsser
    {
        private List<Usuario> ussers;
        public List<Usuario> getUssers() { return ussers; }
       

        public int crearUsuarioComun(string nombreCompleto, double numeroDeContacto, string direccion)
        {
            Comun nuevoUsuarioComun = GeneradorUsuarioComun.crearUsuarioComun(nombreCompleto, numeroDeContacto, direccion);
            agregarUsuario(nuevoUsuarioComun);
            return nuevoUsuarioComun.getIdUsuario();
        }

        public int crearAdministrador(string nombreCompleto, double numeroDeContacto, string direccion, int numeroDeComuna)
        {
            Administrador nuevoAdministrador = GeneradorAdministrador.crearAdministrador(nombreCompleto, numeroDeContacto, direccion, numeroDeComuna);
            agregarUsuario(nuevoAdministrador);
            return nuevoAdministrador.getIdUsuario();
        }

        public void agregarUsuario(Usuario usuario)
        {
            getUssers().Add(usuario);

        }

    }
}

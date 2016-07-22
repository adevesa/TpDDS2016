using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public  class GeneradorUsuarioComun:GeneradorDeUsuario
    {
        static public Comun crearUsuarioComun(string nombreCompleto, double numeroDeContacto, string direccion)
        {
            Comun nuevoUsuarioComun = new Comun(nombreCompleto,numeroDeContacto,direccion);
            nuevoUsuarioComun.setIdUsuario(generarId());
            return nuevoUsuarioComun;
        }

        
    }
}

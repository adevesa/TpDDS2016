using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public  class GeneradorAdministrador : GeneradorDeUsuario
    {
        static public Administrador crearAdministrador(string nombreCompleto, double numeroDeContacto, string direccion, int numeroDeComuna)
        {
            Administrador nuevoAdministrador = new Administrador(nombreCompleto, numeroDeContacto, direccion, numeroDeComuna);
            nuevoAdministrador.setIdUsuario(generarId());
            return nuevoAdministrador;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public  class GeneradorDeUsuario
    {
        static private Random aleatorio = new Random();

        static public int generarId()
        {
            return aleatorio.Next(0, 800);
            
        }

        static public int crearUsuario(Usuario tipoUsuario, string nombreCompleto, int numeroDeContacto, string direccion)
        {
            tipoUsuario.setNombreCompleto(nombreCompleto);
            tipoUsuario.setNumeroDeContacto(numeroDeContacto);
            tipoUsuario.setDireccion(direccion);
            tipoUsuario.setIdUsuario(generarId());
            return tipoUsuario.getIdUsuario();
        }
       
    }
}

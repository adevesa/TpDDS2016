using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public abstract class GeneradorDeUsuario
    {
        static private Random aleatorio = new Random();

        static public int generarId()
        {
            return aleatorio.Next(0, 800);
            
        }
       
    }
}

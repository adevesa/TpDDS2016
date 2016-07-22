using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consola;
using LibreriaClasesPoi;

namespace Usuarios
{
    public interface Usuario
    {
        List<Poi> buscar(string palabraClave);
      

    }
}

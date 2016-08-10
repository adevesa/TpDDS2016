using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos.Procesos.Estados
{
    public interface Estado
    {
        void manipularResultado();
        void cambiarEstado();
    }
}

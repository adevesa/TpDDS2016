using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenadorBusquedas
{
    public class BusquedasPorUsuario
    {
        private List<busquedaPorUsuario> busquedas = new List<busquedaPorUsuario>();
        public List<busquedaPorUsuario> getBusquedas() { return this.busquedas; }
    }
}

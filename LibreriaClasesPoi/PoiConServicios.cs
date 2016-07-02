using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:Poi
    {
        public List<string> Servicios { get; set; }

        public void initService()
        {
            Servicios = new List<string>();
        }
        public void agregarServicios(string service)
        {
            Servicios.Add(service);
        }

    }
}

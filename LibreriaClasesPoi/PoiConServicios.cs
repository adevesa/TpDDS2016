using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:Poi
    {
        private List<string> Servicios;

        public void initService()
        {
            Servicios = new List<string>();
        }

        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.getService().Contains(palabraBuscada) || this.PalabrasClaves.Contains(palabraBuscada));
        }

        public List<string> getService() { return Servicios; }

        public void agregarServicios(string service)
        {
            Servicios.Add(service);
        }

    }
}

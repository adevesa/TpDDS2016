using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:Poi
    {
        public List<servicio> Servicios;

        public void initService()
        {
            Servicios = new List<servicio>();
        }

        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.getService().Any(servicio => servicio.nombreServicio == palabraBuscada) || this.PalabrasClaves.Contains(palabraBuscada));
        }

        public List<servicio> getService() { return Servicios; }

        public void agregarServicios(servicio service)
        {
            Servicios.Add(service);
        }
        public void agregarServicioSinLimiteHorario(string servicio)
        {
            servicio nuevoServicio = new servicio();
            nuevoServicio.nombreServicio = servicio;
            this.Servicios.Add(nuevoServicio);
        }

 
    }
}

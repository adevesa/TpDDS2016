using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:Poi
    {
        private List<servicio> servicios;
        public List<servicio> getServicios() { return this.servicios; }

        public void initService()
        {
            servicios = new List<servicio>();
        }

        public override bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.getServicios().Any(servicio => servicio.nombreServicio == palabraBuscada) || base.buscarCoincidencia(palabraBuscada));
        }


        public void agregarServicios(servicio service)
        {
            this.getServicios().Add(service);
        }
        public void agregarServicioSinLimiteHorario(string servicio)
        {
            servicio nuevoServicio = new servicio();
            nuevoServicio.nombreServicio = servicio;
            getServicios().Add(nuevoServicio);
        }

 
    }
}

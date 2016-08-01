using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poi.Servicios;

namespace LibreriaClasesPoi
{
    public abstract class PoiConServicios:POI
    {
        private List<Servicio> servicios;
        public List<Servicio> getServicios() { return this.servicios; }

        public void initService()
        {
            servicios = new List<Servicio>();
        }

        public override bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.getServicios().Any(servicio => servicio.servicioCoincide(palabraBuscada) || base.buscarCoincidencia(palabraBuscada)));
        }


        public void agregarServicios(string nombreDelServicio)
        {
            Servicio nuevoServicio = new Servicio();
            nuevoServicio.setNombreDelServicio(nombreDelServicio);
            this.getServicios().Add(nuevoServicio);
        }
        
        public void agregarServicios(Servicio servicio)
        {
            this.servicios.Add(servicio);
        }

        public void agregarHorarioDeAtencionAServicio(string nombreDelServicio, string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            Servicio serviceBuscado = this.getServicios().Find(servicio => servicio.servicioCoincide(nombreDelServicio));
            serviceBuscado.agregarDiaYHorario(dia, turno, horarioDeApertura, horarioDeCierre);
        }
        public void agregarServicioSinLimiteHorario(string servicio)
        {
            Servicio nuevoServicio = new Servicio();
            nuevoServicio.setNombreDelServicio(servicio);
            getServicios().Add(nuevoServicio);
        }

        private List<string> mappearNombresServicios(List<Servicio> listaDeServicios)
        {
            List<string> lista = new List<string>();
            foreach (Servicio unServicio in listaDeServicios)
            {
                lista.Add(unServicio.getNombreDelServicio());
            }
            return lista;
        }


    }
}

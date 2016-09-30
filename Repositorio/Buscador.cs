using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using OrigenesDeDatos;

namespace Repositorio
{
    public class Buscador
    {
        public RepositorioDePois repositorio;
        //Constructor//
        public Buscador()
        {
            this.repositorio = RepositorioDePois.getInstance();
        }

        public List<POI> find(string criterio)
        {
            List<POI> poisBuscados = repositorio.localOrigin.find(criterio);
            return poisBuscados;
        }

        public void cerrar()
        {
            repositorio.localOrigin.dao.cerrar();
        }
        public List<string> mappearNombresPois(List<POI> pois)
        {

            List<string> nombres = new List<string>();
            foreach (POI poi in pois)
            {
                nombres.Add(poi.getNombre());
            }
            return nombres;
        }
    }
}

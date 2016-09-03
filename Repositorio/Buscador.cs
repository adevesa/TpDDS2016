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

        //Constructor//
        public Buscador()
        {
        }
        public List<POI> find(string criterio)
        {
            RepositorioDePois repositorio = RepositorioDePois.getInstance();
            List<POI> poisBuscados = repositorio.localOrigin.find(criterio);

            return poisBuscados;
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

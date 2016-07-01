using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class Buscador
    {
        public List<Poi> find(String criteri0)
        {
            10         PoiCollection repositorio = PoiCollection.getInstance();
            11         List<PointOfInterest> lista = repositorio.getOrigenLocal().find(criteria);
            12         lista.addAll(repositorio.getOrigenes().stream()
            13.map(origin->origin.find(criteria))
            14.flatMap(List::stream)
            15.collect(Collectors.toList()));
            16         return lista;

        }
        public List<string> BuscarPOIs(string criterio)
        {
            List<Poi> poisBuscados = administracionPois.Pois.FindAll(poi => poi.BuscarCoincidencia(criterio));
            List<string> nombresPoi = AgarrarLosNombres(poisBuscados);
            return nombresPoi;
        }

    }

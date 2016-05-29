using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class Consola
    {
        //ATRIBUTOS//
        public Coordenada coordenada;
        public int Comuna { get; set; }
        public List<Poi> misPois = new List<Poi>();

        //METODOS PRINCIPALES//

        //Consultar CERCANIA//
        public bool consultarCercania(Poi puntoDeInteres)
        {
            return puntoDeInteres.CercanoDe(coordenada, Comuna);
        }

        //Consultar DISPONIBILIDAD ACTUAL//
        public bool estaDisponible(Poi puntoDeInteres)
        {
            DateTime fechaYhoraActual = DateTime.Now;
            return puntoDeInteres.EstaDisponible(fechaYhoraActual);
        }

        //BUSCAR POIs//
        public List<string> BuscarPOIs(string pois)
        {
            List<Poi> poisBuscados = misPois.FindAll(poi => poi.BuscarCoincidencia(pois));
            List<string> nombresPoi = AgarrarLosNombres(poisBuscados);
            return nombresPoi;
        }

        public List<string> AgarrarLosNombres(List<Poi> pois)
        {

            List<string> nombres = new List<string>();
            foreach (Poi poi in pois)
            {
                nombres.Add(poi.Nombre);
            }
            return nombres;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Repositorio;


namespace Consola
{
    public class TerminalConsola
    {

        //ATRIBUTOS//
        public string nombre;
        public Coordenada coordenada;
        public int comuna;
        public Buscador buscador;

        //CONSTRUCTOR//
        public TerminalConsola(string nombreTerminal, int miComuna, Buscador unBuscador)
        {
            this.nombre = nombreTerminal;
            this.comuna = miComuna;
            this.buscador = unBuscador;

        }



        //METODOS PRINCIPALES//

      
        //Consultar DISPONIBILIDAD ACTUAL//
        public bool estaDisponible(Poi puntoDeInteres)
        {
            DateTime fechaYhoraActual = DateTime.Now;
            return puntoDeInteres.EstaDisponible(fechaYhoraActual);
        }

        //BUSCAR POIs//
        public List<Poi> buscar(string criterio)
        {
            List<Poi> lista = buscador.find(criterio);
            return lista;
        }

        public List<string> mappearNombresPois(List<Poi> pois)
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

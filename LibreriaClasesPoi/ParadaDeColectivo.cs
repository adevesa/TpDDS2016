using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class ParadaDeColectivo:Poi
    {
        //METODOS PRINCIPALES//
        //CONSTRUCTOR//
        public ParadaDeColectivo(int id, string nombre, Coordenada coordenadaa)
        {
            base.init(id, nombre, coordenadaa);
       
        }
        
        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Poi poi)
        {
            return (DistanciaMenorA(poi.getCoordenada(), 100));
        }

        //Disponibilidad ACTUAL//
        public override bool EstaDisponible(DateTime fechaYhoraActual)
        {
            return true;
        }

        
    }
}

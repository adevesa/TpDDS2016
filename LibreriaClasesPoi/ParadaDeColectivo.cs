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
            base.init(id, nombre, coordenada);
       
        }
        
        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        {
            return (DistanciaMenorA(coordenadaDelOtroPunto, 100));
        }

        //Disponibilidad ACTUAL//
        public override bool EstaDisponible(DateTime fechaYhoraActual)
        {
            return true;
        }

        
    }
}

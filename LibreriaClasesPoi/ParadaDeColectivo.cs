using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class ParadaDeColectivo:POI
    {
        
        //CONSTRUCTOR//
        public ParadaDeColectivo()
        {

        }
        public ParadaDeColectivo(string nombre)
        {
            base.init(nombre);
       
        }
        
        //Cercanía
        public override bool cercanoDe(POI poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(), 100));
        }

        //Disponibilidad ACTUAL//
        public override bool estaDisponible(DateTime fechaYhoraActual)
        {
            return true;
        }

        
    }
}

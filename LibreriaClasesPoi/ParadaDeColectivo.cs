using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class ParadaDeColectivo:Poi
    {
        //ATRIBUTOS//

        //METODOS PRINCIPALES//
        //ARMO EL CONSTRUCTOR//
        public ParadaDeColectivo( string nombre, Coordenada suCoordenada, Direccion suDireccion, List<string> palabrasClaves, Dictionary<string, rango> suHorarioDeAtencion)
        {
            Nombre = nombre;
            coordenada = suCoordenada;
            direccion = suDireccion;
            PalabrasClaves = palabrasClaves;
            HorarioDeAtencion = suHorarioDeAtencion;
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

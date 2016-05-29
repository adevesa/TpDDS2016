using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class LocalComercial:Poi 
    {
        //ATRIBUTOS//
        public double CriterioDeCercania { get; set; }
        public List<string> Rubros { get; set; }

        //CONSTRUCTOR//
        public  LocalComercial(string nombre, Coordenada suCoordenada, Direccion suDireccion, List<string> palabrasClaves, List<string> susRubros, Dictionary<string, rango> suHorarioDeAtencion)
        {
            Nombre = nombre;
            coordenada = suCoordenada;
            direccion = suDireccion;
            PalabrasClaves = palabrasClaves;
            Rubros = susRubros;
            HorarioDeAtencion = suHorarioDeAtencion;
        }
        //METODOS PRINCIPALES//
        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        {
            return (DistanciaMenorA(coordenadaDelOtroPunto, CriterioDeCercania));
        }

        // Responde al metodo "BuscarPoi" de Consolita
        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.Rubros.Contains(palabraBuscada) || this.PalabrasClaves.Contains(palabraBuscada));
        }

    }
}

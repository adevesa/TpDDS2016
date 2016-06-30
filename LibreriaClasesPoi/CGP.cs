using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class CGP:Poi
    {
        //ATRIBUTOS//
        public List<string> Servicios = new List<string>();

        //CONSTRUCTOR//
        public CGP(string nombre, Direccion suDireccion, List<string> palabrasClaves, List<string> susServicios, Dictionary<string, rango> suHorarioDeAtencion)
        {
            Nombre = nombre;
            direccion = suDireccion;
            PalabrasClaves = palabrasClaves;
            Servicios = susServicios;
            HorarioDeAtencion = suHorarioDeAtencion;
            if (!Esvalido()) { throw new System.ArgumentException("El POI no es válido"); }
        }
        
        //METODOS PRINCIPALES//
        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        { return (ZonaDeComuna == comunaDelOtroPunto); }

        // Responde al metodo "BuscarPoi" de Consolita
        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.Servicios.Contains(palabraBuscada) || this.PalabrasClaves.Contains(palabraBuscada));
        }

    }
}

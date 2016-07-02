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
        public  LocalComercial(int id,string nombre, string suDireccion, Coordenada coordenadaa)
        {
            base.init(id, nombre, coordenadaa);
            base.agregarDireccion(suDireccion);
            this.Rubros = new List<string>();
 
        }
        
        //METODOS PRINCIPALES//

        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        {
            return (DistanciaMenorA(coordenadaDelOtroPunto, CriterioDeCercania));
        }

        
        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.Rubros.Contains(palabraBuscada) || this.PalabrasClaves.Contains(palabraBuscada));
        }

        //Agregar rubros//
        public void agregarRubro(string rubro)
        {
            agregarElemA(Rubros, rubro);
        }


    }
}

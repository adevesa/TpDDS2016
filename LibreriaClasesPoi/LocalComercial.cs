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
        private List<string> Rubros;
        public  List<string> getRubros() { return Rubros; }

        //CONSTRUCTOR//
        public  LocalComercial(int id,string nombre, string suDireccion, Coordenada coordenadaa)
        {
            base.init(id, nombre, coordenadaa);
            base.agregarDireccion(suDireccion);
            this.Rubros = new List<string>();
 
        }
        
        //METODOS PRINCIPALES//

        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public override bool CercanoDe(Poi poi)
        {
            return (DistanciaMenorA(poi.getCoordenada(), this.CriterioDeCercania));
        }

        
        public override bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.getRubros().Contains(palabraBuscada) || base.getPalabrasClaves().Contains(palabraBuscada));
        }

        //Agregar rubros//
        public void agregarRubro(params string[] rubro)
        {
            foreach(string unRubro in rubro)
            agregarElemA(this.getRubros(), unRubro);
        }


    }
}

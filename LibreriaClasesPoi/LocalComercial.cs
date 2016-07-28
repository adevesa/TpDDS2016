using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class LocalComercial:Poi 
    {
        //Atributos
        private double criterioDeCercania;
        private List<string> rubros;
        
        //Setters y getters
        public void setCriterioDeCercania(double criterio) { this.criterioDeCercania = criterio; }
        public double getCriterioDeCercania() { return this.criterioDeCercania; }

        public List<string> getRubros() { return this.rubros; }

        //Constructor
        public  LocalComercial(int id,string nombre, string direccion)
        {
            base.init(id, nombre);
            base.setDireccion(direccion);
            this.rubros = new List<string>();
 
        }
        
        //METODOS PRINCIPALES//

        //Cercania
        public override bool cercanoDe(Poi poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(), this.criterioDeCercania));
        }

        
        public override bool buscarCoincidencia(string palabraBuscada)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class LocalComercial:POI 
    {
        //Atributos
        public virtual double CriterioDeCercania { get; set; }
        private List<string> rubros;
        
        //Setters y getters
        public virtual void setCriterioDeCercania(double criterio) { this.CriterioDeCercania = criterio; }
        public virtual double getCriterioDeCercania() { return this.CriterioDeCercania; }

        public virtual List<string> getRubros() { return this.rubros; }

        //Constructores
        public LocalComercial()
        {

        }
        public  LocalComercial(string nombre, string direccion)
        {
            base.init(nombre);
            base.setDireccion(direccion);
            this.rubros = new List<string>();
 
        }
        public LocalComercial(string nombre)
        {
            base.init(nombre);
            this.rubros = new List<string>();
        }
        
        //METODOS PRINCIPALES//

        //Cercania
        public override bool cercanoDe(POI poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(), this.CriterioDeCercania));
        }

        
        public override bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.getRubros().Contains(palabraBuscada) || base.getPalabrasClaves().Contains(palabraBuscada));
        }

        //Agregar rubros//
        public virtual void agregarRubro(params string[] rubro)
        {
            foreach(string unRubro in rubro)
            agregarElemA(this.getRubros(), unRubro);
        }


    }
}

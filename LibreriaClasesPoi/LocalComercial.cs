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


        //* @name: agregarDiaYHorario(string dia, string turno, int apertura, int cierre) 
        //* @decryp: recibe por parámetro un string día, un string turno (mañana, tarde o noche),
        //* un int que representa el horario de apertura del turno y un int que representa
        //* el hoarrio de cierre del turno. Agrega dicha informacion a la lista de hoariosDeAtencion.
        public override void agregarDiaYHorario(string turno, int horarioDeApertura, int horarioDeCierre, params string[] dias)
        {
            foreach (string dia in dias)
            {
                HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
                nuevoHorarioDeAtencion.localComercial = this;
                nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
                this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
            }

        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;
using HorariosDeAtencion;
using Poi.GeneraciónDeIDs;
using System.Globalization;
using System.Threading;

namespace LibreriaClasesPoi
{
    public abstract class POI
    {
        //Atributos 
        public virtual string Nombre { get; set; }
        public virtual int Id { get; set; }
        private Coordenada coordenada;
        public virtual string Direccion { get; set; }
        public virtual int Comuna { get; set; }
        private List<HorarioDeAtencion> horarioDeAtencion;
        private List<string> palabrasClaves;
        private  DateTime fechaDeBaja;

        //INIT
        public virtual void init(string nombre)
        {
            palabrasClaves = new List<string>();
            horarioDeAtencion = new List<HorarioDeAtencion>();
            //this.setId(IDGenerator.getRandomValue(1800));
            this.Nombre = nombre;
            this.coordenada = new Coordenada();
            this.getCoordenada().localizar(this.Direccion);
        }

        //Setters y getters

        public virtual string getNombre() { return this.Nombre; }

        public virtual void setDireccion(string direccion) { this.Direccion = direccion; }
        public virtual string getDireccion() { return this.Direccion; }

        public virtual void setComuna(int comuna) { this.Comuna = comuna; }
        public virtual int getComuna() { return this.Comuna; }

        public virtual void setId(int id) { this.Id = id; }
        public virtual int getId() { return this.Id; }

        public virtual Coordenada getCoordenada() { return coordenada; }

        public virtual List<string> getPalabrasClaves() { return palabrasClaves; }

        public virtual void setFechaDeBaja(DateTime fechaDeBaja) { this.fechaDeBaja = fechaDeBaja; }
        public virtual DateTime getFechaBaja() { return this.fechaDeBaja; }
        public virtual List<HorarioDeAtencion> getHorarioDeAtencion() { return this.horarioDeAtencion; }

        //Metodos 

        //* @name: esValido()
        //* @decryp: verifica si el poi tiene nombre y si es ubicable. Para cumplir con ser ubicable
        //* la googleApi debe poder rellenar los campos de coordenadas.
        public virtual bool esvalido()
        {
            return (tieneNombre() && esUbicable());
        }

        public virtual bool tieneNombre()
        {
            return (this.Nombre != null);
        }

        public virtual bool esUbicable()
        {
            return this.getCoordenada().tieneCoordenadas();
        }

        //* @name: cercanoDe(POI poi)
        //* @decryp: verifica si el poi se encuentra cercano a otro poi. Por defecto,
        //* decimos que un poi está cerca de otro si estan a menos de 500 metros.
        public virtual bool cercanoDe(POI poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(),500));
        }

        //* @name: estaDisponible(DateTime horarioYfechaActual)
        //* @decryp: recibe un objeto de la clase DateTime y verifica si el poi se encuentra
        //* disponible en dicho horario y fecha.
        public virtual bool estaDisponible(DateTime horarioYfecha)
        {
            return (horarioDeAtencion.Any(unHorarioDeAtencion => unHorarioDeAtencion.estaDisponible(horarioYfecha)));
        
        }

        //* @name: buscarConcidencia(string palabraBuscada)
        //* @decryp: rebibe un string y verifica si se encuentra en las palabras claves
        public virtual bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.getPalabrasClaves().Contains(palabraBuscada));
        }


        //* @name: agregarDiaYHorario(string dia, string turno, int apertura, int cierre) 
        //* @decryp: recibe por parámetro un string día, un string turno (mañana, tarde o noche),
        //* un int que representa el horario de apertura del turno y un int que representa
        //* el hoarrio de cierre del turno. Agrega dicha informacion a la lista de hoariosDeAtencion.
        public virtual void agregarDiaYHorario(string turno, int horarioDeApertura, int horarioDeCierre, params string[] dias)
        {
            foreach(string dia in dias)
            {
                HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
                nuevoHorarioDeAtencion.setPoiId(this.Id);
                nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
                this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
            }
            
        }

        public virtual void agregarHorarioDeAtencion(HorarioDeAtencion horarioDeAtencion)
        {
            this.horarioDeAtencion.Add(horarioDeAtencion);
        }

        //* @name: agregarPalabraClave(strings palabras) 
        //* @decryp: rebibe una o varios string que representan palabras claves y los agrega
        //* a la lista de palabrasClaves
        public virtual void agregarPalabraClave(params string[] palabras)
        {
            foreach(string palabra in palabras)
            {
                if (this.getPalabrasClaves().Contains(palabra)) { }
                else agregarElemA(this.palabrasClaves, palabra);
            }
        }
        public virtual void agregarElemA(List<string> lista, string palabra)
        {
            lista.Add(palabra);
        }

        //* @name: bool estaActivo()
        //* @decryp: compara la fecha de baja con la fecha ACTUAL (la que posee el sistema)
        //* y devuelve TRUE en caso de que aun no se haya "vencido", caso omiso falso.
        public virtual bool estaActivo()
        {
            //*Compare: Compara dos instancias de DateTime y devuelve un entero que indica
            //* si la primera instancia es anterior que, el mismo que, o posterior a la segunda instancia.
            DateTime fechaActual = DateTime.Today;
            return this.fechaDeBaja.CompareTo(fechaActual) > 0;              
            //return (DateTime.Compare(this.fechaDeBaja, fechaActual) > 0);
        }
       
    }
}

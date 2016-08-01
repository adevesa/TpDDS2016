using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;
using HorariosDeAtencion;
using Poi;

namespace LibreriaClasesPoi
{
    public abstract class POI
    {
        //Atributos 
        private string nombre;
        private int id;
        private Coordenada coordenada;
        private string direccion;
        private int comuna;
        private List<HorarioDeAtencion> horarioDeAtencion;
        private List<string> palabrasClaves;
        

        public void init(int id, string nombre)
        {
            palabrasClaves = new List<string>();
            horarioDeAtencion = new List<HorarioDeAtencion>();
            this.setId(id);
            this.nombre = nombre;
            this.coordenada = new Coordenada();
            this.getCoordenada().localizar(this.direccion);

        }

        //Setters y getters

        public string getNombre() { return this.nombre; }

        public void setDireccion(string direccion) { this.direccion = direccion; }
        public string getDireccion() { return this.direccion; }

        public void setComuna(int comuna) { this.comuna = comuna; }
        public int getComuna() { return this.comuna; }

        public void setId(int id) { this.id = id; }
        public int getId() { return this.id; }

        public Coordenada getCoordenada() { return coordenada; }

        public List<string> getPalabrasClaves() { return palabrasClaves; }

                    //Metodos 

        //* @name: esValido()
        //* @decryp: verifica si el poi tiene nombre y si es ubicable. Para cumplir con ser ubicable
        //* la googleApi debe poder rellenar los campos de coordenadas.
        public bool esvalido()
        {
            return (tieneNombre() && esUbicable());
        }

        public bool tieneNombre()
        {
            return (this.nombre != null);
        }

        public bool esUbicable()
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
            return (this.palabrasClaves.Contains(palabraBuscada));
        }


        //* @name: agregarDiaYHorario(string dia, string turno, int apertura, int cierre) 
        //* @decryp: recibe por parámetro un string día, un string turno (mañana, tarde o noche),
        //* un int que representa el horario de apertura del turno y un int que representa
        //* el hoarrio de cierre del turno. Agrega dicha informacion a la lista de hoariosDeAtencion.
        public void agregarDiaYHorario(string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
            nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
            this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
        }


        //* @name: agregarPalabraClave(strings palabras) 
        //* @decryp: rebibe una o varios string que representan palabras claves y los agrega
        //* a la lista de palabrasClaves
        public void agregarPalabraClave(params string[] palabras)
        {
            foreach(string palabra in palabras)
            {
                agregarElemA(this.palabrasClaves, palabra);
            }
        }
        public void agregarElemA(List<string> lista, string palabra)
        {
            lista.Add(palabra);
        }



    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;
using HorariosDeAtencion;
using Poi;

using System.Globalization;
using System.Threading;

namespace LibreriaClasesPoi
{
    public abstract class POI
    {
        //Atributos 
        static private Random aleatorio = new Random();
        public string Nombre { get; set; }
        public int Id { get; set; }
        private Coordenada coordenada;
        public string Direccion { get; set; }
        public int Comuna { get; set; }
        private List<HorarioDeAtencion> horarioDeAtencion;
        private List<string> palabrasClaves;
        

        public void init(string nombre)
        {
            palabrasClaves = new List<string>();
            horarioDeAtencion = new List<HorarioDeAtencion>();
            this.setId(generarId());
            this.Nombre = nombre;
            this.coordenada = new Coordenada();
            this.getCoordenada().localizar(this.Direccion);

        }

        //Setters y getters

        public string getNombre() { return this.Nombre; }

        public void setDireccion(string direccion) { this.Direccion = direccion; }
        public string getDireccion() { return this.Direccion; }

        public void setComuna(int comuna) { this.Comuna = comuna; }
        public int getComuna() { return this.Comuna; }

        public void setId(int id) { this.Id = id; }
        public int getId() { return this.Id; }

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
            return (this.Nombre != null);
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
            return (this.getPalabrasClaves().Contains(palabraBuscada));
        }


        //* @name: agregarDiaYHorario(string dia, string turno, int apertura, int cierre) 
        //* @decryp: recibe por parámetro un string día, un string turno (mañana, tarde o noche),
        //* un int que representa el horario de apertura del turno y un int que representa
        //* el hoarrio de cierre del turno. Agrega dicha informacion a la lista de hoariosDeAtencion.
        public void agregarDiaYHorario(string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
            nuevoHorarioDeAtencion.setPoiId(this.Id);
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

        static private int generarId()
        {
            return aleatorio.Next(0, 888);

        }

        //*Compare: Compara dos instancias de DateTime y devuelve un entero que indica si la primera instancia es anterior que, el mismo que, o posterior a la segunda instancia.
        public bool estaActivo()
        {
         DateTime fechaDeBaja = serviceRest.ejecutarService(this); //Supuestamente tendria que devolver una fecha de baja, pero no especifica en que formato, asi que lo interpreto como un tipo DateTime
         DateTime fechaActual = DateTime.Today;                     //Despues le pregunto a la profe o a algún ayudante como es la movida con esto. 
         return (DateTime.Compare(fechaDeBaja, fechaActual) > 0); 
        }
       
    }
}

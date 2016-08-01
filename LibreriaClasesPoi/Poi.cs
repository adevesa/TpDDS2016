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

        //Metodos PRINCIPALES//
        
            //VALIDAR poi//
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

        //Cercania con con otro POI por defecto //
        public virtual bool cercanoDe(POI poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(),500));
        }

        //Calculo de disponibilidad//
        public virtual bool estaDisponible(DateTime horarioYfechaActual)
        {
            return (horarioDeAtencion.Any(unHorarioDeAtencion => unHorarioDeAtencion.estaDisponible(horarioYfechaActual)));
        
        }

        //Buscar Coincidencia//
        public virtual bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.palabrasClaves.Contains(palabraBuscada));
        }


        //Agregar Horario de atención//
        public void agregarDiaYHorario(string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
            nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
            this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
        }

        //Agregar Elementos a lista//
        public void agregarElemA(List<string> lista, string palabra)
        {
            lista.Add(palabra);
        }

        //Agregar palabras claves//
        public void agregarPalabraClave(params string[] palabras)
        {
            foreach(string palabra in palabras)
            {
                agregarElemA(this.palabrasClaves, palabra);
            }
            
        }

        
       
 
    }
}

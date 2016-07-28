using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public abstract class Poi
    {
        //Atributos 
        private string nombre;
        private int id;
        private Coordenada coordenada;
        private string direccion;
        private int comuna;
        private Dictionary<string, rango> horarioDeAtencion;
        private List<string> palabrasClaves;
        

        public void init(int id, string nombre)
        {
            palabrasClaves = new List<string>();
            horarioDeAtencion = new Dictionary<string, rango>();
            this.id = id;
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
        public virtual bool cercanoDe(Poi poi)
        {
            return (this.getCoordenada().distanciaMenorA(poi.getCoordenada(),500));
        }

        //Calculo de disponibilidad//
        public virtual bool estaDisponible(DateTime horarioYfechaActual)
        {
            string diaActual;
            int hora;
            diaActual = horarioYfechaActual.ToString("dddd");
            hora = horarioYfechaActual.Hour;
            return ((horarioDeAtencion.ContainsKey(diaActual)) && (EstaEnRangoHorario(diaActual, hora)));
        }

        //Buscar Coincidencia//
        public virtual bool buscarCoincidencia(string palabraBuscada)
        {
            return (this.palabrasClaves.Contains(palabraBuscada));
        }


                         //DELEGACIONES//
        
        //BETWEEN//
        public bool Between(int x, int minimo, int maximo)
        {
            return ((minimo <= x) && (x < maximo));
        }

        //VERFICA SI VALOR X ESTA EN RANGO HORARIO//
        public bool EstaEnRangoHorario(string dia, int hora)
        {
            rango rangoDeldia = horarioDeAtencion[dia];
            turno turno1 = rangoDeldia.turno1;
            turno turno2 = rangoDeldia.turno2;
            turno turno3 = rangoDeldia.turno3;
            return (EstaEnRango(hora, turno1) || EstaEnRango(hora, turno2) || EstaEnRango(hora, turno3));
        }
        public bool EstaEnRango(int hora, turno turno)
        {
            return Between(hora, turno.horarioInicio, turno.horarioFin);
        }

        
        //Agregar Horarios de atención//
        public void agregarDiaYHorario(string dia, rango horariosDeAtencionDelDia)
        {
            this.horarioDeAtencion[dia] = horariosDeAtencionDelDia;
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

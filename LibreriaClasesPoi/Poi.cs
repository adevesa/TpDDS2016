using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 



namespace LibreriaClasesPoi
{
    public  class Poi
    {
        //Atributos 
        private string nombre;
        private int id;
        private  coordenada;
        public Coordenada getCoordenada() { return coordenada; }
        private string direccion;
        private int comuna;
        private Dictionary<string, rango> horarioDeAtencion;
        private List<string> palabrasClaves;
        public List<string> getPalabrasClaves() { return palabrasClaves; }

        public void init(int id, string nombre, Coordenada coordenadaa)
        {
            palabrasClaves = new List<string>();
            horarioDeAtencion = new Dictionary<string, rango>();
            this.id = id;
            this.nombre = nombre;
            this.coordenada = coordenadaa;
        }
        
                            //Metodos PRINCIPALES//
         //VALIDAR poi//
        public bool Esvalido()
        {
            return (TieneNombre() && EsUbicable());
        }

        public bool TieneNombre()
        {
            return (this.nombre != null);
        }

        public bool EsUbicable()
        {
            //Llamada a Google maps//

            var _request = new GeocodingRequest{ Address = this.ConvertirDireccion() };
            var _result = GoogleMaps.Geocode.Query(_request);
            AgregarCoordenadas(_result.Results.First().Geometry.Location.Latitude, _result.Results.First().Geometry.Location.Longitude);
            return (_result.Status == Status.OK);

            //Status.OK, _result.Status//
            // Assert.AreEqual("40.7140415,-73.9613119", _result.Results.First().Geometry.Location.LocationString);//
        }

        //Agregar coordenadas//
        public void AgregarCoordenadas(double latitude, double longitude)
        {
            this.coordenada.latitud = latitude;
            this.coordenada.longitud = longitude;
        }

        //Cercania con otra Coordenada//
        public virtual bool CercanoDe(Poi poi)
        {
            return (DistanciaMenorA(poi.getCoordenada(), 500));
        }

        //Calculo de disponibilidad//
        public virtual bool EstaDisponible(DateTime horarioYfechaActual)
        {
            string diaActual;
            int hora;
            diaActual = horarioYfechaActual.ToString("dddd");
            hora = horarioYfechaActual.Hour;
            return ((horarioDeAtencion.ContainsKey(diaActual)) && (EstaEnRangoHorario(diaActual, hora)));
        }

        //Buscar Coincidencia//
        public virtual bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.palabrasClaves.Contains(palabraBuscada));
        }


                         //DELEGACIONES//
        //Distancia entre dos puntos dados por COORDENADA//
        public double GetDistance(Coordenada point1, Coordenada point2)
        {
            double distance = 0;
            double Lat = (point2.latitud - point1.latitud) * (Math.PI / 180);
            double Lon = (point2.longitud - point1.longitud) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(point1.latitud * (Math.PI / 180)) * Math.Cos(point2.latitud * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = 6371 * c;
            return distance;
        }

        //Distancia del POI menor a otra coordenada//
        public bool DistanciaMenorA(Coordenada coordenadaDelOtroPoi, double metros)
        {
            if (GetDistance(coordenada, coordenadaDelOtroPoi) < metros)
            { return true; }
            else return false;
        }

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

        //CONVERTIR ESTRUCTURA DIRECCION EN STRING DIRECCION CON FORMA "CALLE ALTURA, CABA, BUENOS AIRES, ARGENTINA"//
        public string ConvertirDireccion()
        {
            string direcc;
            direcc = this.direccion + "," + "CABA Buenos Aires Argentina";
            return direcc;
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

        //Agregar direccion//
        public void agregarDireccion(string dir)
        {
            this.direccion = dir;
        }
       
 
    }
}

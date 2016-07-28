using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleApi;
using GoogleApi.Entities.Common;
using GoogleApi.Entities.Maps.Directions.Request;
using GoogleApi.Entities.Maps.DistanceMatrix.Request;
using GoogleApi.Entities.Maps.Elevation.Request;
using GoogleApi.Entities.Maps.Geocode.Request;

namespace CoordenadaGeografica
{
    public class Coordenada
    {
        //Atributos
        private double latitud;
        private double longitud;

        //Setters y getters
        public void setLatitud(double latitud) { this.latitud = latitud; }
        public double getLatitud() { return this.latitud; }

        public void setLongitud(double longitud) { this.longitud = longitud; }
        public double getLongitud() { return this.longitud; }

        //Metodos

        //Calculo de distancia
        public double getDistance(Coordenada point)
        {
            double distance = 0;
            double Lat = (point.getLatitud() - this.getLatitud()) * (Math.PI / 180);
            double Lon = (point.getLongitud() - this.getLongitud()) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(this.getLatitud() * (Math.PI / 180)) * Math.Cos(point.getLatitud() * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = 6371 * c;
            return distance;
        }

        //Distancia menor a X metros de otra coordenada
        public bool distanciaMenorA(Coordenada coordenadaDelOtroPoi, double metros)
        {
            if (getDistance(coordenadaDelOtroPoi) < metros)
            { return true; }
            else return false;
        }

        public bool localizar(string direccion)
        {
            //Llamada a Google maps//

            var _request = new GeocodingRequest { Address = this.convertirDireccion(direccion) };
            var _result = GoogleMaps.Geocode.Query(_request);
            setLatitud(_result.Results.First().Geometry.Location.Latitude);
            setLongitud(_result.Results.First().Geometry.Location.Longitude);
            return (_result.Status == Status.OK);

            //Status.OK, _result.Status//
            // ("40.7140415,-73.9613119", _result.Results.First().Geometry.Location.LocationString);//
        }
        
        //Convierte direccion a la forma "CALLE ALTURA, CABA, BUENOS AIRES, ARGENTINA"//
        private string convertirDireccion(string direccion)
        {
            string direcc;
            direcc = direccion + "," + "CABA Buenos Aires Argentina";
            return direcc;
        }

        //Verifica que los atributos no estén vacios
        public bool tieneCoordenadas()
        {
            bool tieneLatitud = this.getLatitud() != null;
            bool tieneLongitud = this.getLongitud() != null;
            return (tieneLatitud && tieneLatitud);
        }
    }
}

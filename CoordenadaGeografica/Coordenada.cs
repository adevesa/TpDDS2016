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
    class Coordenada
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


    }
}

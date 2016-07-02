using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
        public struct Coordenada
        {
            public double latitud;
            public double longitud;
            public Coordenada(double lat, double longi)
            {
                latitud = lat;
                longitud = longi;
            }
        }
    
        public struct turno
        {
            public int horarioInicio;
            public int horarioFin;
            public turno(int inicio, int fin)
            {
                horarioInicio = inicio;
                horarioFin = fin;
            }
        }

        public struct rango
        {
            public turno turno1;
            public turno turno2;
            public turno turno3;
            public rango(turno uno, turno dos, turno tres)
            {
                turno1 = uno;
                turno2 = dos;
                turno3 = tres;
            }
        }

        public struct servicio
    {
        public string nombreServicio;
        public rango rangoDeAtencion;

    }
}


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
        public rango(int horaInicioTurnoMañana, int horaFinTurnoMañana, int horaInicioTurnoTarde, int horaFinTurnoTarde, int horaInicioTurnoNoche, int horaFinTurnoNoche)
        {

            turno1 = new turno(horaFinTurnoMañana, horaFinTurnoMañana);
            turno2 = new turno(horaInicioTurnoTarde, horaFinTurnoTarde);
            turno3 = new turno(horaInicioTurnoNoche, horaFinTurnoNoche);
        }
    }

    public struct servicio
    {
        public string nombreServicio;
        public rango rangoDeAtencion;
        public servicio(string nombreDelService, rango horariosDeAtencion)
        {
            nombreServicio = nombreDelService;
            rangoDeAtencion = horariosDeAtencion;
        }

    }

    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public partial class Poi
    {
        //Atributos de la clase//
        public string Nombre { get; set; }
        public Coordenada coordenada;
        public Direccion direccion;
        public int ZonaDeComuna { get; set; }
        public Dictionary<string, rango> HorarioDeAtencion { get; set; }
        public List<string> PalabrasClaves { get; set; }


        //Metodos PRINCIPALES//


        //Cercania con otra Coordenada//
        public virtual bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        {
            return (DistanciaMenorA(coordenadaDelOtroPunto, 500));
        }

        //Calculo de disponibilidad//
        public virtual bool EstaDisponible(DateTime horarioYfechaActual)
        {
            string diaActual;
            int hora;
            diaActual = horarioYfechaActual.ToString("dddd");
            hora = horarioYfechaActual.Hour;
            return ((HorarioDeAtencion.ContainsKey(diaActual)) && (EstaEnRangoHorario(diaActual, hora)));
        }

        // Responde al metodo "BuscarPoi" de Consolita
        public virtual bool BuscarCoincidencia(string palabraBuscada)
        {
            return (this.PalabrasClaves.Contains(palabraBuscada));
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

        //CREAMOS BETWEEN//
        public bool Between(int x, int minimo, int maximo)
        {
            return ((minimo <= x) && (x < maximo));
        }

        //VERFICA SI VALOR X ESTA EN RANGO HORARIO//
        public bool EstaEnRangoHorario(string dia, int hora)
        {
            rango rangoDeldia = HorarioDeAtencion[dia];
            turno turno1 = rangoDeldia.turno1;
            turno turno2 = rangoDeldia.turno2;
            turno turno3 = rangoDeldia.turno3;
            return (EstaEnRango(hora, turno1) || EstaEnRango(hora, turno2) || EstaEnRango(hora, turno3));
        }
        public bool EstaEnRango(int hora, turno turno)
        {
            return Between(hora, turno.horarioInicio, turno.horarioFin);
        }

        //METODO A MODO DE PRUEBA//
        public int primerComponent(rango reinchHours)
        {
            return (reinchHours.turno1.horarioInicio);
        }

   

    }
}

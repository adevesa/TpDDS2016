using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosDeAtencion
{
    public struct turno
    {
        //Campos
        private string nombreDelTurno;
        private int horarioInicio;
        private int horarioFin;

        //Setters y getters
        public void setNombreDelTurno(string nombreDelTurno) { this.nombreDelTurno = nombreDelTurno; }
        public string getNombreDelTurno() { return this.nombreDelTurno; }

        public void setHorarioDeInicio(int horaInicio) { this.horarioInicio = horaInicio; }
        public int getHoraDeInicio() { return this.horarioInicio; }

        public void setHorarioDeFin(int horaFin) { this.horarioInicio = horaFin; }
        public int getHoraDeFin() { return this.horarioFin; }

    }

    public class HorarioDeAtencion
    {
        //Atributos
        private string dia;
        private List<turno> turnosDeAtencion;

        //Setters y getters
        public void setDia(string dia) { this.dia = dia; }
        public string getDia(){ return this.dia; }

        //Constructor
        public HorarioDeAtencion(string dia)
        {
            this.dia = dia;
            this.turnosDeAtencion = new List<turno>();
        }

        //Metodos

        //* @name: agregarHorarioPorTurno
        //* @decryp: recibe un string ("mañana", "tarde", "noche") y dos int(hora inicio, hora fin)

        public void agregarHorarioPorTurno(string turno, int horarioDeApertura, int horarioDeCierre)
        {
            turno nuevoTurno = new turno();
            nuevoTurno.setNombreDelTurno(turno);
            nuevoTurno.setHorarioDeInicio(horarioDeApertura);
            nuevoTurno.setHorarioDeFin(horarioDeCierre);
            this.turnosDeAtencion.Add(nuevoTurno);
                
        }

        //* @name: estaDisponile
        //* @decryp: recibe hora y fecha actual y retorna un booleano para informar si la clase está disponible

        public  bool estaDisponible(DateTime horarioYfechaActual)
        {
            string dia = horarioYfechaActual.ToString("dddd");
            if (this.getDia() !=dia)
            { return false; }
          else
            {
                int hora = horarioYfechaActual.Hour;
                return (this.turnosDeAtencion.Any(unTurno => between(hora, unTurno.getHoraDeInicio(), unTurno.getHoraDeFin())));
             }
        }

        
        //* @name:BETWEEN
        //* @decryp: recibe tres parametros y verifica que el primer parámetro se encuentre entre los otros dos;
        //* es decir: min<x<max

        public bool between(int x, int minimo, int maximo)
        {
            return ((minimo <= x) && (x < maximo));
        }
    }
}

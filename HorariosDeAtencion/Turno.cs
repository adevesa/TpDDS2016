using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosDeAtencion
{
    public class Turno
    {
        //Atributos
        public int Id { get; set; }
        public int Horario_ID { get; set; }
        public string NombreDelTurno { get; set; }
        public int HorarioInicio { get; set; }
        public int HorarioFin { get; set; }

        //Setters y getters
        public void setNombreDelTurno(string nombreDelTurno) { this.NombreDelTurno = nombreDelTurno; }
        public string getNombreDelTurno() { return this.NombreDelTurno; }

        public void setHorarioDeInicio(int horaInicio) { this.HorarioInicio = horaInicio; }
        public int getHoraDeInicio() { return this.HorarioInicio; }

        public void setHorarioDeFin(int horaFin) { this.HorarioFin = horaFin; }
        public int getHoraDeFin() { return this.HorarioFin; }
        
        //Constructor
        public Turno(int horarioId)
        {
            this.Horario_ID = horarioId;
        }

        //Metodos

        //* @name:BETWEEN
        //* @decryp: recibe tres parametros y verifica que el primer parámetro se encuentre entre los otros dos;
        //* es decir: min<x<max
        public bool between(int x, int minimo, int maximo)
        {
            return ((minimo <= x) && (x < maximo));
        }

        //* @name: estaEnHorario
        //* @decryp: verifica si cumple el método between enviandole como parámetros: la hora recibida, 
        //* la hora de inicio, y la hora de fin.
        public bool estaEnHorario(int hora)
        {
            return between(hora, this.getHoraDeInicio(), this.getHoraDeFin());
        }
    }
}

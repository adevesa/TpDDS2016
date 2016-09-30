using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class Turno
    {
        //Atributos
        public virtual int Id { get; set; }
        public virtual int Horario_ID { get; set; }
        public virtual HorarioDeAtencion horarioDeAtencion { get; set; }
        public virtual string NombreDelTurno { get; set; }
        public virtual int HorarioInicio { get; set; }
        public virtual int HorarioFin { get; set; }

        //Setters y getters
        public virtual void setNombreDelTurno(string nombreDelTurno) { this.NombreDelTurno = nombreDelTurno; }
        public virtual string getNombreDelTurno() { return this.NombreDelTurno; }

        public virtual void setHorarioDeInicio(int horaInicio) { this.HorarioInicio = horaInicio; }
        public virtual int getHoraDeInicio() { return this.HorarioInicio; }

        public virtual void setHorarioDeFin(int horaFin) { this.HorarioFin = horaFin; }
        public virtual int getHoraDeFin() { return this.HorarioFin; }
        
        //Constructor
        public Turno(int horarioId)
        {
            this.Horario_ID = horarioId;
        }

        public Turno()
        {

        }

        //Metodos

        //* @name:BETWEEN
        //* @decryp: recibe tres parametros y verifica que el primer parámetro se encuentre entre los otros dos;
        //* es decir: min<x<max
        public virtual bool between(int x, int minimo, int maximo)
        {
            return ((minimo <= x) && (x < maximo));
        }

        //* @name: estaEnHorario
        //* @decryp: verifica si cumple el método between enviandole como parámetros: la hora recibida, 
        //* la hora de inicio, y la hora de fin.
        public virtual bool estaEnHorario(int hora)
        {
            return between(hora, this.getHoraDeInicio(), this.getHoraDeFin());
        }
    }
}

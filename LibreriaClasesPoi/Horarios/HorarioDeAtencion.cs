using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poi.Servicios;


namespace LibreriaClasesPoi
{

    public class HorarioDeAtencion
    {
        //Atributos
        public virtual int Id { get; set; }
        public virtual Banco banco { get; set; }
        public virtual CGP cgp { get; set; }
        public virtual LocalComercial localComercial { get; set; }
        public virtual Servicio servicio { get; set; }

        public virtual string Dia { get; set; }
        public virtual IList<Turno> turnosDeAtencion { get; set; }

        //Setters y getters
        public virtual void setDia(string dia) { this.Dia = dia; }
        public virtual string getDia(){ return this.Dia; }

        //Constructor
        public HorarioDeAtencion(string dia)
        {
            this.Dia = dia;
            this.turnosDeAtencion = new List<Turno>();
        }

        public HorarioDeAtencion()
        {

        }
        //Metodos

        //* @name: agregarHorarioPorTurno
        //* @decryp: recibe un string ("mañana", "tarde", "noche") y dos int(hora inicio, hora fin)
        public virtual void agregarHorarioPorTurno(string turno, int horarioDeApertura, int horarioDeCierre)
        {
            Turno nuevoTurno = new Turno(this.Id);
            nuevoTurno.horarioDeAtencion = this;
            nuevoTurno.setNombreDelTurno(turno);
            nuevoTurno.setHorarioDeInicio(horarioDeApertura);
            nuevoTurno.setHorarioDeFin(horarioDeCierre);
            this.turnosDeAtencion.Add(nuevoTurno);
                
        }

        //* @name: estaDisponile
        //* @decryp: recibe hora y fecha actual y retorna un booleano para informar si la clase está disponible
        public virtual bool estaDisponible(DateTime horarioYfechaActual)
        {
            string dia = horarioYfechaActual.ToString("dddd");
            if (this.getDia() !=dia)
            { return false; }
          else
            {
                int hora = horarioYfechaActual.Hour;
                return (this.turnosDeAtencion.Any(unTurno => unTurno.estaEnHorario(hora)));
             }
        }

        
    }
}

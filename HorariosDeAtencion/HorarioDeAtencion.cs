using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HorariosDeAtencion
{
    
    public class HorarioDeAtencion
    {
        //Atributos
        public int Id { get; set; }
        public int PoiId { get; set; }
        public int ServicioId { get; set; }
        public string Dia { get; set; }
        private List<Turno> turnosDeAtencion;

        //Setters y getters
        public void setDia(string dia) { this.Dia = dia; }
        public string getDia(){ return this.Dia; }

        public void setPoiId(int idPoi) { this.PoiId = idPoi; }
        public void setServicioId(int idServicio) { this.ServicioId = idServicio; }

        //Constructor
        public HorarioDeAtencion(string dia)
        {
            this.Dia = dia;
            this.turnosDeAtencion = new List<Turno>();
        }

        //Metodos

        //* @name: agregarHorarioPorTurno
        //* @decryp: recibe un string ("mañana", "tarde", "noche") y dos int(hora inicio, hora fin)
        public void agregarHorarioPorTurno(string turno, int horarioDeApertura, int horarioDeCierre)
        {
            Turno nuevoTurno = new Turno(this.Id);
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
                return (this.turnosDeAtencion.Any(unTurno => unTurno.estaEnHorario(hora)));
             }
        }

        
    }
}

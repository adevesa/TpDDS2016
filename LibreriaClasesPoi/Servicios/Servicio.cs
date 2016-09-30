using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;

namespace Poi.Servicios
{
    public class Servicio
    {
        //Atributos
        public virtual int Id { get; set; }
        public virtual string NombreServicio { get; set; }
        public virtual Banco banco { get; set; }
        public virtual CGP cgp { get; set; }
        public virtual IList<HorarioDeAtencion> horariosDeAtencion { get; set; }
        public virtual bool NoTieneLimiteHorario { get; set; }

        //Setters y getters
        public virtual void setNombreDelServicio(string nombre) { this.NombreServicio = nombre; }
        public virtual string getNombreDelServicio() { return this.NombreServicio; }

        public virtual void setNoTieneLimiteHorario(bool valorDeVerdad) { this.NoTieneLimiteHorario = valorDeVerdad; }
        public virtual bool getNoTieneLimiteHorario() { return this.NoTieneLimiteHorario; }

        //Constructor
        public Servicio()
        {
            this.horariosDeAtencion = new List<HorarioDeAtencion>();
        }

        //Metodos

        //* @name: servicioCoincide(string)
        //* @decryp: recibe un string  y verifica si el nombre del servicio es igual al string recibido.
        public virtual bool servicioCoincide(string palabraBuscada)
        {
            return this.getNombreDelServicio() == palabraBuscada;
        }

        //* @name: agregarDiaYHorario(string dia, string turno, int inico, int fin)
        //* @decryp: crea un nueo objeto "horario de atencion" con sus atributos correspondientes y los agrega
        //* a la lista de horariosDeAtencion
        public virtual void agregarDiaYHorario(string turno, int horarioDeApertura, int horarioDeCierre, params string[] dias)
        {
            foreach (string dia in dias)
            {
                HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
                nuevoHorarioDeAtencion.servicio = this;
                nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
                this.horariosDeAtencion.Add(nuevoHorarioDeAtencion);
            }
        }
        //* @name: estaDisponible(DateTime horarioYfechaActual)
        //* @decryp: recibe un objeto de la clase DateTime y verifica si el poi se encuentra
        //* disponible en dicho horario y fecha.
        public virtual bool estaDisponible(DateTime horarioYfecha)
        {
            if (NoTieneLimiteHorario)
            {
                return (horariosDeAtencion.Any(unHorarioDeAtencion => unHorarioDeAtencion.estaDisponible(horarioYfecha)));
            }
            else return false;
        }
    }
}

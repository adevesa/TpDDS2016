using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorariosDeAtencion;

namespace Poi.Servicios
{
    public class Servicio
    {
        //Atributos
        public int Id { get; set; }
        public int PoiId { get; set; }
        public string NombreServicio { get; set; }
        private List<HorarioDeAtencion> horariosDeAtencion;
        public bool NoTieneLimiteHorario { get; set; }

        //Setters y getters
        public void setNombreDelServicio(string nombre) { this.NombreServicio = nombre; }
        public string getNombreDelServicio() { return this.NombreServicio; }

        public void setNoTieneLimiteHorario(bool valorDeVerdad) { this.NoTieneLimiteHorario = valorDeVerdad; }
        public bool getNoTieneLimiteHorario() { return this.NoTieneLimiteHorario; }

        public void setPoiId(int idPoi) { this.PoiId = idPoi; }
        //Constructor
        public Servicio()
        {
            this.horariosDeAtencion = new List<HorarioDeAtencion>();
        }

        //Metodos

        //* @name: servicioCoincide(string)
        //* @decryp: recibe un string  y verifica si el nombre del servicio es igual al string recibido.
        public bool servicioCoincide(string palabraBuscada)
        {
            return this.getNombreDelServicio() == palabraBuscada;
        }

        //* @name: agregarDiaYHorario(string dia, string turno, int inico, int fin)
        //* @decryp: crea un nueo objeto "horario de atencion" con sus atributos correspondientes y los agrega
        //* a la lista de horariosDeAtencion
        public void agregarDiaYHorario(string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
            nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
            this.horariosDeAtencion.Add(nuevoHorarioDeAtencion);
        }

        //* @name: estaDisponible(DateTime horarioYfechaActual)
        //* @decryp: recibe un objeto de la clase DateTime y verifica si el poi se encuentra
        //* disponible en dicho horario y fecha.
        public bool estaDisponible(DateTime horarioYfecha)
        {
            if (NoTieneLimiteHorario)
            {
                return (horariosDeAtencion.Any(unHorarioDeAtencion => unHorarioDeAtencion.estaDisponible(horarioYfecha)));
            }
            else return false;
        }
    }
}

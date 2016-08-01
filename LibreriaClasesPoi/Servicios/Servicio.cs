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
        private string nombreServicio;
        private List<HorarioDeAtencion> horariosDeAtencion;

        //Setters y getters
        public void setNombreDelServicio(string nombre) { this.nombreServicio = nombre; }
        public string getNombreDelServicio() { return this.nombreServicio; }

        //Constructor
        public Servicio()
        {
            this.horariosDeAtencion = new List<HorarioDeAtencion>();
        }

        //Metodos
        public bool servicioCoincide(string palabraBuscada)
        {
            return this.getNombreDelServicio() == palabraBuscada;
        }

        public void agregarDiaYHorario(string dia, string turno, int horarioDeApertura, int horarioDeCierre)
        {
            HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
            nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
            this.horariosDeAtencion.Add(nuevoHorarioDeAtencion);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;
using Poi.Servicios;

namespace LibreriaClasesPoi
{
    public class Banco:PoiConServicios
    {
        //Constructor
        public Banco()
        {

        }

        public Banco(string nombre) 
        {
            initService(nombre);
            agregarHorariosFijos();
        }

        private void agregarHorariosFijos()
        {
            agregarDiaYHorario("horario bancario", 10, 15, "lunes", "martes", "miercoles", "jueves", "viernes");

        }


        //* @name: agregarDiaYHorario(string dia, string turno, int apertura, int cierre) 
        //* @decryp: recibe por parámetro un string día, un string turno (mañana, tarde o noche),
        //* un int que representa el horario de apertura del turno y un int que representa
        //* el hoarrio de cierre del turno. Agrega dicha informacion a la lista de hoariosDeAtencion.
        public override void agregarDiaYHorario(string turno, int horarioDeApertura, int horarioDeCierre, params string[] dias)
        {
            foreach (string dia in dias)
            {
                HorarioDeAtencion nuevoHorarioDeAtencion = new HorarioDeAtencion(dia);
                nuevoHorarioDeAtencion.banco = this;
                nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
                this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
            }
        }

        public override void agregarServicio(Servicio servicio)
        {
            servicio.banco = this;
            servicios.Add(servicio);
        }

        public override void crearServicio(string nombreDelServicio)
        {
            base.crearServicio(nombreDelServicio);
            Servicio service = buscarServicio(nombreDelServicio);
            service.banco = this;
        }

        public override void agregarServicioSinLimiteHorario(string servicio)
        {
            Servicio nuevoServicio = new Servicio();
            nuevoServicio.setNombreDelServicio(servicio);
            nuevoServicio.setNoTieneLimiteHorario(false);
            nuevoServicio.banco = this;
            agregarServicio(nuevoServicio);
        }
    }
}

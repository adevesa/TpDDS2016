using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;
using Poi.Servicios;

namespace LibreriaClasesPoi
{
    public class CGP:PoiConServicios
    {
        //Atributos
        public virtual string ZonasAledañas { get; set; }
        public virtual string NombreDirector { get; set; }
        public virtual string Telefono { get; set; }

        //Constructores
        public CGP()
        {

        }

        public CGP(string nombre,string direccion, int comuna)
        {
            setDireccion(direccion);
            setComuna(comuna);
            initService(nombre);    
        }

        public CGP(int numeroComuna, string domicilio)
        {
            
            setDireccion(domicilio);
            initService("sin nombre");
            setComuna(numeroComuna);
        }

        //Métodos
        public override void agregarServicio(Servicio servicio)
        {
            servicio.cgp = this;
            servicios.Add(servicio);
        }

        public override void crearServicio(string nombreDelServicio)
        {
            base.crearServicio(nombreDelServicio);
            Servicio service = buscarServicio(nombreDelServicio);
            service.cgp = this;
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
                nuevoHorarioDeAtencion.cgp = this;
                nuevoHorarioDeAtencion.agregarHorarioPorTurno(turno, horarioDeApertura, horarioDeCierre);
                this.horarioDeAtencion.Add(nuevoHorarioDeAtencion);
            }

        }
        //Cercanía
        public override bool cercanoDe(POI poi)
        { return (this.getComuna() == poi.getComuna()); }

        
        

    }
}

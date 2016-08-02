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
        public Banco(string nombre) 
        {
            base.init(nombre);
            base.initService();
            agregarHorariosFijos();
        }

        private void agregarHorariosFijos()
        {
            agregarDiaYHorario("lunes", "mañana", 10, 15);
            agregarDiaYHorario("martes", "mañana", 10, 15);
            agregarDiaYHorario("miercoles", "mañana", 10, 15);
            agregarDiaYHorario("jueves", "mañana", 10, 15);
            agregarDiaYHorario("viernes", "mañana", 10, 15);

        }

       
    }
}

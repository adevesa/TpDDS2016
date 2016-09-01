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
            initService(nombre);
            agregarHorariosFijos();
        }

        private void agregarHorariosFijos()
        {
            agregarDiaYHorario("horario bancario", 10, 15, "lunes", "martes", "miercoles", "jueves", "viernes");

        }

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class Banco:PoiConServicios
    {
        public Banco(int id, string nombre, Coordenada coordenadaa) 
        {
            base.init(id, nombre, coordenadaa);
            base.initService();
            agregarHorariosFijos();
        }
        public void agregarHorariosFijos()
        {
            Dictionary<string, rango> horariosDeBancos = new Dictionary<string, rango>();
            agregarDiaYHorario( "lunes",new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("martes", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("miercoles", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("jueves", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("viernes", new rango(10, 12, 12, 15, 0, 0));

        }
    }
}

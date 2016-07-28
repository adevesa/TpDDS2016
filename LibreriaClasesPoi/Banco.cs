﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class Banco:PoiConServicios
    {
        //Constructor
        public Banco(int id, string nombre) 
        {
            base.init(id, nombre);
            base.initService();
            agregarHorariosFijos();
        }

        private void agregarHorariosFijos()
        {
            Dictionary<string, rango> horariosDeBancos = new Dictionary<string, rango>();
            agregarDiaYHorario( "lunes",new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("martes", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("miercoles", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("jueves", new rango(10, 12, 12, 15, 0, 0));
            agregarDiaYHorario("viernes", new rango(10, 12, 12, 15, 0, 0));

        }

     
        private List<string> mappearNombresServicios(List<servicio> listaDeServicios)
        {
            List<string> lista = new List<string>();
            foreach(servicio unServicio in listaDeServicios)
            {
                lista.Add(unServicio.nombreServicio);
            }
            return lista;       
         }
    }
}

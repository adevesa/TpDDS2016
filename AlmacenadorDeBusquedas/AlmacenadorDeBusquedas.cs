﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace AlmacenadorBusquedas
{
    static public class AlmacenadorDeBusquedas
    {
        static private List<busqueda> busquedas = new List<busqueda>();
        
        static List<busqueda> getbusquedas() { return busquedas; }

        static public void almacenarBusqueda(string nombreDeUsuario, string palabraBuscada,List<POI> resultadoDeLaBusqueda, DateTime fecha)
        {
            int cantidadResultadosObtenidos = resultadoDeLaBusqueda.Count;
            busqueda nuevaBusqueda = new busqueda(nombreDeUsuario, palabraBuscada, cantidadResultadosObtenidos, fecha);
            agregarResultado(nuevaBusqueda);

        }

        static private void agregarResultado(busqueda nuevaBusqueda)
        {
            getbusquedas().Add(nuevaBusqueda);
        }

        static public List<busquedaPorFecha> generarReportePorFecha(DateTime inicio, DateTime fin)
        {
            return BusquedasPorFecha.generarReporte(inicio, fin, busquedas);
        }

        static public List<busquedaPorUsuario> generarReportePorUsuario(string nombreDelUsuario)
        {
            return BusquedasPorUsuario.generarReportePorUsuario(nombreDelUsuario, getbusquedas());
        }
    }
}

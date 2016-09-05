using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenadorBusquedas
{
     static public class BusquedasPorFecha
    {
        static public List<busquedaPorFecha> generarReporte(DateTime inicio, DateTime fin, List<busqueda> busquedas)
        {
            List<busqueda> resultadosParciales = busquedas.FindAll(busqueda => cumpleCriterio(busqueda, inicio, fin));
            return generarLista(resultadosParciales);
        }

        static private bool cumpleCriterio(busqueda unaBusqueda, DateTime inicio, DateTime fin)
        {
            int supera = DateTime.Compare(unaBusqueda.fecha, inicio);
            int noSupera = DateTime.Compare(unaBusqueda.fecha, fin);
            if (supera >= 0)
            {
                if(noSupera<= 0) { return true; }
            }

            return false;
        }




        static public List<busquedaPorFecha> generarReportePorFecha(string fecha, List<busqueda> busquedas)
        {
            List<busqueda> resultadosParciales = busquedas.FindAll(busqueda => busqueda.fecha.ToString()==fecha);
            return generarLista(resultadosParciales);
        }

        static private List<busquedaPorFecha> generarLista(List<busqueda> busquedaParcial)
        {
            List<busquedaPorFecha> listaBusquedaPorFecha = new List<busquedaPorFecha>();
            foreach(busqueda unaBusqueda in busquedaParcial)
            {
                listaBusquedaPorFecha.Add(new busquedaPorFecha(unaBusqueda.fecha, unaBusqueda.resultadoDeLaBusqueda));
            }
            return listaBusquedaPorFecha;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenadorBusquedas
{
     static public class BusquedasPorFecha
    {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenadorBusquedas
{
    static public class BusquedasPorUsuario
    {
        
        static public List<busquedaPorUsuario> generarReportePorUsuario(string nombreDelUsuario, List<busqueda> busquedas)
        {
            
            List<busqueda> resultadosParciales = busquedas.FindAll(busqueda => busqueda.nombreDeUsuario == nombreDelUsuario);
            return generarLista(resultadosParciales);

        }

        static private List<busquedaPorUsuario> generarLista(List<busqueda> busquedasParciales)
        {
            List<busquedaPorUsuario> listaBusquedaPorUsuario = new List<busquedaPorUsuario>();
            foreach(busqueda unaBusqueda in busquedasParciales)
            {
                listaBusquedaPorUsuario.Add(new busquedaPorUsuario(unaBusqueda.nombreDeUsuario, unaBusqueda.resultadoDeLaBusqueda));

            }
            return listaBusquedaPorUsuario;
        }
    }
}

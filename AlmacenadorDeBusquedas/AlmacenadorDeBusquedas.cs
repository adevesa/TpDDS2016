using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Usuarios;

namespace AlmacenadorBusquedas
{
    static public class AlmacenadorDeBusquedas
    {
        static private List<busqueda> busquedas = new List<busqueda>();
        
        static List<busqueda> getbusquedas() { return busquedas; }

        static public void almacenarBusqueda(string nombreDeUsuario, string palabraBuscada,List<Poi> resultadoDeLaBusqueda, DateTime fecha)
        {
            int cantidadResultadosObtenidos = resultadoDeLaBusqueda.Count;
            busqueda nuevaBusqueda = new busqueda(nombreDeUsuario, palabraBuscada, cantidadResultadosObtenidos, fecha);
            agregarResultado(nuevaBusqueda);

        }

        static private void agregarResultado(busqueda nuevaBusqueda)
        {
            getbusquedas().Add(nuevaBusqueda);
        }

        static public List<busquedaPorFecha> generarReportePorFecha(string fecha)
        {
            return BusquedasPorFecha.generarReportePorFecha(fecha, getbusquedas());
        }

        static public List<busquedaPorUsuario> generarReportePorUsuario(string nombreDelUsuario)
        {
            return BusquedasPorUsuario.generarReportePorUsuario(nombreDelUsuario, getbusquedas());
        }
    }
}

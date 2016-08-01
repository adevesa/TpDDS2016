using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;
using CoordenadaGeografica;


namespace Adapters
{
    public class BancoAdapter
    {
       static public List<POI> adapt(List<DatosExternosBanco> lista)
        {
            List<POI> listaAdaptada = new List<POI>();

            foreach(DatosExternosBanco modeloDeBanco in lista)
            {
                Banco banco = modelarBanco(modeloDeBanco);
                listaAdaptada.Add(banco);
            }
            return listaAdaptada;
        }

        static public Banco modelarBanco(DatosExternosBanco modeloBanco)
        {
            
            Banco bancoModelado = new Banco(modeloBanco.id, modeloBanco.nombre);
            agregarServicios(bancoModelado, modeloBanco);
            return bancoModelado;
        }
        static public void agregarServicios(Banco bancoModelado, DatosExternosBanco modeloBanco)
        {
            foreach(string servicio in modeloBanco.servicios)
            {
                bancoModelado.agregarServicioSinLimiteHorario(servicio);
            }
        }
    }
}

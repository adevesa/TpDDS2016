using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;


namespace Adapters
{
    public class BancoAdapter
    {
       static public List<Poi> adapt(List<DatosExternosBanco> lista)
        {
            List<Poi> listaAdaptada = new List<Poi>();

            foreach(DatosExternosBanco modeloDeBanco in lista)
            {
                Banco banco = modelarBanco(modeloDeBanco);
                listaAdaptada.Add(banco);
            }
            return listaAdaptada;
        }

        static public Banco modelarBanco(DatosExternosBanco modeloBanco)
        {
            Coordenada coordenadaDelBanco = new Coordenada(modeloBanco.x, modeloBanco.y);
            Banco bancoModelado = new Banco(modeloBanco.id, modeloBanco.nombre, coordenadaDelBanco);
            agregarServicios(bancoModelado, modeloBanco);
            return bancoModelado;
        }
        static public void agregarServicios(Banco bancoModelado, DatosExternosBanco modeloBanco)
        {
            foreach(string servicio in modeloBanco.servicios)
            {
                bancoModelado.agregarServicios(servicio);
            }
        }
    }
}

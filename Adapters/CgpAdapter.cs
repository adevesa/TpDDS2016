using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;

namespace Adapters
{
   public class CgpAdapter
    {
        static public List<Poi> adapt(List<DatosExternosCGP> lista)
        {
            List<Poi> listaAdaptada = new List<Poi>();

            foreach (DatosExternosCGP modeloDeCGP in lista)
            {
                CGP banco = modelarCGP(modeloDeCGP);
                listaAdaptada.Add(banco);
            }
            return listaAdaptada;
        }
        static public CGP modelarCGP(DatosExternosCGP modeloRecibido)
        {
            CGP cgpNuevo = new CGP(modeloRecibido.id, modeloRecibido.numeroComuna, modeloRecibido.domicilio);
            cgpNuevo.zonasAledañas = modeloRecibido.zonasQueIncluye;
            cgpNuevo.telefono = modeloRecibido.telefono;
            cgpNuevo.nombreDirector = modeloRecibido.nombreDelDirector;
            agregarServicios(cgpNuevo, modeloRecibido.servicios);
            return cgpNuevo;
        }
        
        static public void agregarServicios(CGP nuevoCgp, List<servicio> servicios)
        {
            foreach(servicio unServicio in servicios)
            {
                nuevoCgp.agregarServicios(unServicio);
            }
        }

    }
}

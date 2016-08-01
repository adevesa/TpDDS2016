using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;
using Poi.Servicios;

namespace Adapters
{
   public class CgpAdapter
    {
        static public List<POI> adapt(List<DatosExternosCGP> lista)
        {
            List<POI> listaAdaptada = new List<POI>();

            foreach (DatosExternosCGP modeloDeCGP in lista)
            {
                CGP nuevoCGP = modelarCGP(modeloDeCGP);
                listaAdaptada.Add(nuevoCGP);
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
        
        static public void agregarServicios(CGP nuevoCgp, List<Servicio> servicios)
        {
            foreach(Servicio unServicio in servicios)
            {
                nuevoCgp.agregarServicios(unServicio);
            }
        }

    }
}

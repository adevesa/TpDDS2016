using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;
using Adapters;

namespace OrigenesDeDatos
{
    class OrigenCGPS
    {
        private FuenteDeDatosCGPS fuente;

        OrigenCGPS(FuenteDeDatosCGPS fuentee)
        {
            this.fuente = fuentee;
        }

        public List<Poi> find(string criterio)
        {
            List<DatosExternosCGP> result = fuente.buscar(criterio);
            return CgpAdapter.adapt(result);

        }
    }
}

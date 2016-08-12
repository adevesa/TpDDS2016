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
    public class OrigenBancos : Origenes
    {
   
        private FuenteDeDatosBanco fuente;

        OrigenBancos(FuenteDeDatosBanco fuentee)
        {
            this.fuente = fuentee;
        }

        public List<POI> find(string criterio)
        {
            List<DatosExternosBanco> result = fuente.buscar(criterio);
            return BancoAdapter.adapt(result);

        }

        public void agregar(POI poi) { }
        public void borrar(POI poi) { }
        public bool verificarExistencia(string poi) { return true; }
    }
}

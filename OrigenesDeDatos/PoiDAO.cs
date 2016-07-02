using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace OrigenesDeDatos
{
    public class PoiDAO
    {
        public List<Poi> pois;


        public PoiDAO()
        {
            this.pois = new List<Poi>();
        }

        //Crear Poi//
        public void crear(Poi unPoi)
        {
            pois.Add(unPoi);
        }

        //Actualizar Poi//
        public void actualizar(Poi unPoi)
        {
            borrar(unPoi.Id);
            crear(unPoi);
        }

        //Borrar un Poi//
        public void borrar(int index)
        {
            int indexBuscado = pois.FindIndex(poiLocal => poiLocal.Id.Equals(index));
            pois.RemoveAt(indexBuscado);
        }

    }
}

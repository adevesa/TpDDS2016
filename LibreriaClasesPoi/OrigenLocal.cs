using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    class OrigenLocal : Origenes
    {
        public PoiDAO dao;

        //Constructor//
        public OrigenLocal()
        {
            dao = new PoiDAO();
        }

        //Agregar POI//
        public void agregar(Poi unPoi)
        {
            this.dao.crear(unPoi);
        }

        //Editar o actualizar Poi//
        public void editar(Poi unPoi)
        {
            this.dao.actualizar(unPoi);
        }

        //Borrar un Poi//
        public void borrar(int indice)
        {
            this.dao.borrar(indice);
        }

        //Buscar//
        public List<Poi> find(String criteria)
        {
            return dao.pois.FindAll(poi => poi.BuscarCoincidencia(criteria));

        }


    }
}

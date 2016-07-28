using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;


namespace OrigenesDeDatos
{
    public class OrigenLocal : Origenes
    {
        //BASE DE DATOS PROPIA DEL SISTEMA//

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
        public void borrar(Poi poi)
        {
            this.dao.borrar(poi.getId());
        }

        //Buscar//
        public List<Poi> find(String criterio)
        {
            return dao.pois.FindAll(poi => poi.buscarCoincidencia(criterio));

        }

    }
}

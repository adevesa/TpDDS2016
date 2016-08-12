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

        public List<POI> getPois() { return dao.pois; }

        //Constructor//
        public OrigenLocal()
        {
            dao = new PoiDAO();
        }

        //Agregar POI//
        public void agregar(POI unPoi)
        {
            this.dao.crear(unPoi);
        }

        //Editar o actualizar Poi//
        public void editar(POI unPoi)
        {
            this.dao.actualizar(unPoi);
        }

        //Borrar un Poi//
        public void borrar(POI poi)
        {
            this.dao.borrar(poi.getId());
        }

        //Borrar que si funciona en el test//
        public void borrar2(POI poi)
        {
            this.dao.borrar2(poi);
        }

        //Buscar//
        public List<POI> find(String criterio)
        {
            return dao.pois.FindAll(poi => poi.buscarCoincidencia(criterio));

        }

        //Buscar poi x nombre
        public POI buscarPoiLlamado(string nombreDelPoiBuscado)
        {
            POI poiBuscado;
           return poiBuscado = dao.obtenerPoiLlamado(nombreDelPoiBuscado);
        }
        public bool verificarExistencia(string nombreDelPoi)
        {
            return (this.dao.verificarExistencia(nombreDelPoi));
        }
    }
}

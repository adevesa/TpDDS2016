﻿using System;
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

        //Buscar//
        public List<POI> find(String criterio)
        {
            return dao.pois.FindAll(poi => poi.buscarCoincidencia(criterio));

        }

    }
}

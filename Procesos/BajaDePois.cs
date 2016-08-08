using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using Repositorio;
using OrigenesDeDatos;

namespace Procesos
{
    public class BajaDePois: Proceso
    {
        //Atributos
        RepositorioDePois repositorio = RepositorioDePois.getInstance();

        //Metodos
        public void darDeBajaSiEsNecesario(POI unPoi)
        {
            if (!unPoi.estaActivo())
            {
                repositorio.localOrigin.borrar(unPoi);
            }

        }

        //Método polimórfico
        public override int ejecutar()
        {
            List<POI> listPoi = repositorio.localOrigin.dao.pois; //acá tendría que usar el método buscar pero me parece que es al pedo. Además, bajo que criterio de busqueda?
            foreach(POI poi in listPoi)
            {
                darDeBajaSiEsNecesario(poi);
            }
            return 0;
        }


    }
}

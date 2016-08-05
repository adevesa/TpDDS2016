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
        public void darDeBajaPoi(POI unPoi)
        {
            if (!(unPoi.estaActivo()))  //Le pregunta al POI si NO (!) esta activo
            {
                repositorio.localOrigin.dao.borrar2(unPoi); //en el codigo le mandaste en vez de un POI un 
                                       //indice para buscar al POI y despues borrarlo
                                       //yo lo pense de otra forma, fijate como definí 
                                       //el nuevo metodo de borrar en PoiDAO a ver cual te gusta más.
            }



        }
    }
}

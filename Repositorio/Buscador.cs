using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using OrigenesDeDatos;

namespace Repositorio
{
    public class Buscador
    {

        public List<Poi> find(string criterio)
        {
            RepositorioDePois repositorio = RepositorioDePois.getInstance();
            List<Poi> poisBuscados = repositorio.localOrigin.find(criterio);

            return poisBuscados;
        }
    }
}

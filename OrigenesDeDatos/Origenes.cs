using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using FuenteDeDatos;

namespace OrigenesDeDatos
{
    public interface Origenes
    {  List<POI> find(String criterio);
        
    }
}

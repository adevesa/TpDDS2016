using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;

namespace Adapters
{
    public class BancoAdapter
    {
        static public List<Poi> adapt(List<string> lista)
        {
            List<Poi> listaAdaptada = new List<Poi>;

            foreach(string nombre in lista)
            {
                BancoDTO banco =modelarBanco(nombre);
                listaAdaptada.Add(banco);

            }
            return listaAdaptada;


            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class RepositorioDePois
    {
        //CONTENDRÁ TODA LA INFO DE LOS POIS//

        private static RepositorioDePois instance = null; 
        private List<Origenes> origenes;
        private OrigenLocal localOrigin;
        private Buscador buscadorDePOI;


        //Constructor//
        public RepositorioDePois()
        {
            localOrigin = new OrigenLocal();
            origenes = new List<Origenes>();
            buscadorDePOI = new Buscador();

        }

        public static RepositorioDePois getInstance ()
        {
            if (instance == null) { instance = new RepositorioDePois(); }
            return instance;
        }

    }
}

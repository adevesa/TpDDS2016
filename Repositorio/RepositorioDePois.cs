using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrigenesDeDatos;

namespace Repositorio
{
    public class RepositorioDePois
    {
        //CONTENDRÁ TODA LA INFO DE LOS POIS//

        private static RepositorioDePois instance = null;
        private List<Origenes> origenes;
        public OrigenLocal localOrigin { get; set; }
        public Buscador buscadorDePOI { get; set; }


        //Constructor//
        public RepositorioDePois()
        {
            localOrigin = new OrigenLocal();
            origenes = new List<Origenes>();
            buscadorDePOI = new Buscador();

        }

        public static RepositorioDePois getInstance()
        {
                if (instance == null) { instance = new RepositorioDePois(); }
                return instance;      
        }

        public void agregarOrigenes(Origenes algunOrigen)
        {
            this.origenes.Add(algunOrigen);
        }

        public bool verificarExistencia(string nombreDelPoi)
        {
            return (localOrigin.verificarExistencia(nombreDelPoi));
        }
    }
}

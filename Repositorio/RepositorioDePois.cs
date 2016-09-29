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

        //Aplicación del SINGLETON
        private static RepositorioDePois instance = null;

        public RepositorioDePois()
        {
            localOrigin = new OrigenLocal();
            origenes = new List<Origenes>();
        }

        public static RepositorioDePois getInstance()
        {
            if (instance == null) { instance = new RepositorioDePois(); }
            return instance;
        }

        //Atributos
        private List<Origenes> origenes;
        public OrigenLocal localOrigin { get; set; }
        
        //Metodos 
    
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

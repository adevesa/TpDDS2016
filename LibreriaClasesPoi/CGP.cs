using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoordenadaGeografica;

namespace LibreriaClasesPoi
{
    public class CGP:PoiConServicios
    {
        //Atributos
        public virtual string ZonasAledañas { get; set; }
        public virtual string NombreDirector { get; set; }
        public virtual string Telefono { get; set; }

        //Constructores
        public CGP()
        {

        }

        public CGP(string nombre,string direccion, int comuna)
        {
            setDireccion(direccion);
            setComuna(comuna);
            initService(nombre);    
        }

        public CGP(int numeroComuna, string domicilio)
        {
            
            setDireccion(domicilio);
            initService("sin nombre");
            setComuna(numeroComuna);
        }

        //Métodos
        //Cercanía
        public override bool cercanoDe(POI poi)
        { return (this.getComuna() == poi.getComuna()); }

        
        

    }
}

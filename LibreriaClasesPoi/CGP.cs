using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesPoi
{
    public class CGP: PoiConServicios
    {
        public string zonasAledañas { get; set; }
        public string nombreDirector { get; set; }
        public string telefono { get; set; }


        //CONSTRUCTORES//
        public CGP(int id,string nombre,Coordenada coordenadaa, string suDireccion)
        {
            base.init(id, nombre, coordenadaa);
            base.agregarDireccion(suDireccion);
            base.initService();
        }
        
        public CGP(int id,int comuna, string direccion)
        {
            base.agregarDireccion(direccion);
            base.ZonaDeComuna = comuna;
            base.Id = id;
            base.initService();
        }

        //METODOS PRINCIPALES//
        //CERCANIA con otra Coordenada//
        public override bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        { return (ZonaDeComuna == comunaDelOtroPunto); }

        
        

    }
}

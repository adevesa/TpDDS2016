using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace Mapeo
{
    public class PoiMap: ClassMapping<POI>
    {
        public PoiMap()
        {
            //* @define: nombre de la tabla en la base de datos
            //Table("Poi");

            //* @define: genera un id automático
            Id(unPOI => unPOI.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));

            //* @define: Mapeamos las propiedades de la clase generando las columnas
            Property(poi => poi.Nombre, map => map.NotNullable(true));
            Property(poi => poi.Comuna, map => map.NotNullable(false));
            Property(poi => poi.Direccion, map => map.NotNullable(true));

            //Map(unPOI => unPOI.Nombre).Column("NOMBRE");
            //Map(unPOI => unPOI.Comuna).Column("NUMERO_COMUNA");
            //Map(unPOI => unPOI.Direccion).Column("DIRECCION");

        }
    }
}

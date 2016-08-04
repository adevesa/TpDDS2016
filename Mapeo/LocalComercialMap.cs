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
    class LocalComercialMap: ClassMapping<LocalComercial>
    {
        public LocalComercialMap()
        {
            

            //* @define: genera un id automático
            Id(unLocalComercial => unLocalComercial.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));

            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(unLocalComercial => unLocalComercial.Nombre, map => map.NotNullable(true));
            Property(unLocalComercial => unLocalComercial.Comuna, map => map.NotNullable(false));
            Property(unLocalComercial => unLocalComercial.Direccion, map => map.NotNullable(true));
            Property(unLocalComercial => unLocalComercial.CriterioDeCercania, map => map.NotNullable(false) );
         

        }
    }
}

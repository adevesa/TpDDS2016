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
    public class CGPMap : ClassMapping<CGP>
    {
        public CGPMap()
        {
            
            //* @define: genera un id automático
            Id(cgp=> cgp.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));

            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(cgp => cgp.Nombre, map => map.NotNullable(true));
            Property(cgp => cgp.Comuna, map => map.NotNullable(true));
            Property(cgp => cgp.Direccion, map => map.NotNullable(true));
            Property(cgp => cgp.Telefono, map => map.NotNullable(false));
            Property(cgp => cgp.NombreDirector, map => map.NotNullable(false));
            Property(cgp => cgp.ZonasAledañas, map => map.NotNullable(false));

        }

    }
}

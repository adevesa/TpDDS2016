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
    public class ParadaDeColectivoMap : ClassMapping<ParadaDeColectivo>
    {
        public ParadaDeColectivoMap()
        {
            //* @define: genera un id automático
            Id(paradaDeColectivo =>paradaDeColectivo.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));

            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(paradaDeColectivo => paradaDeColectivo.Nombre, map => map.NotNullable(true));
            Property(paradaDeColectivo => paradaDeColectivo.Comuna, map => map.NotNullable(false));
            Property(paradaDeColectivo => paradaDeColectivo.Direccion, map => map.NotNullable(true));
        }

    }
}

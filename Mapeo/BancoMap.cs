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
    public class BancoMap : ClassMapping<Banco>
    {
        public BancoMap()
        {

            //* @define: genera un id automático
            Id(banco => banco.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));

            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(banco => banco.Nombre, map => map.NotNullable(true));
            Property(banco => banco.Comuna, map => map.NotNullable(false));
            Property(banco => banco.Direccion, map => map.NotNullable(true));
            Bag(poi => poi.horarioDeAtencion, map =>
                                                     {
                                                         map.Key(x => x.Column("BancoId"));
                                                         map.Table("BancoHorarios");
                                                         map.Cascade(Cascade.All);
                                                     }, rel => rel.ManyToMany( horario => horario.Column("HorarioDeAtencionId"))
               );
            Bag(banco => banco.servicios, map =>
            {
                map.Key(x => x.Column("BancoId"));
                map.Table("BancoServicios");
                map.Cascade(Cascade.All);
            }, rel => rel.ManyToMany(horario => horario.Column("ServicioId"))
              );
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using LibreriaClasesPoi;
using Poi.Servicios;

namespace Mapeo
{
    class ServicioMap : ClassMapping<Servicio>
    {
        public ServicioMap()
        {
            //* @define: genera un id automático
            Id(h => h.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));
            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(servicio => servicio.NombreServicio, map => map.NotNullable(true));
            Property(servicio => servicio.NoTieneLimiteHorario, map => map.NotNullable(true));
            ManyToOne(servicio => servicio.banco, map => map.Column("BancoId"));
            ManyToOne(servicio => servicio.cgp, map => map.Column("CGPId"));
            Bag(servicio => servicio.horariosDeAtencion, map =>
                                                            {
                                                                   map.Key(key => key.Column("ServicioId"));
                                                                   map.Table("ServicioHorarios");
                                                                   map.Cascade(Cascade.All);
                                                                }, rel => rel.ManyToMany(turno => turno.Column("HorarioDeAtencionId"))
                );
        }

    }
}

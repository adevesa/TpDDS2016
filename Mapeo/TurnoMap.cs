using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaClasesPoi;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Properties;
using FluentNHibernate.Utils;
namespace Mapeo
{
    class TurnoMap : ClassMapping<Turno>
    {
        public TurnoMap()
        {
            //* @define: genera un id automático
            Id(h => h.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));
            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(horario => horario.NombreDelTurno, map => map.NotNullable(false));
            Property(horario => horario.Horario_ID, map => map.NotNullable(true));
            Property(horario => horario.HorarioInicio, map => map.NotNullable(true));
            Property(horario => horario.HorarioFin, map => map.NotNullable(true));
            ManyToOne(turno => turno.horarioDeAtencion, map => map.Column("HorarioDeAtencionId"));
        }
    }
}

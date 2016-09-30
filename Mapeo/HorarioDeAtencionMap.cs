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
    class HorarioDeAtencionMap : ClassMapping<HorarioDeAtencion>
    {
        public HorarioDeAtencionMap()
        {
            //* @define: genera un id automático
            Id(h => h.Id, map => map.Generator(Generators.HighLow, x => x.Params(new { max_low = 1800 })));
            //* @define: Mapeamos las propiedades de la clase generando las columnas en la BDD
            Property(horario => horario.Dia, map => map.NotNullable(true));
            ManyToOne(horario => horario.banco, map => map.Column("BancoId"));
            ManyToOne(horario => horario.localComercial, map => map.Column("LocalComercialId"));
            ManyToOne(horario => horario.cgp, map => map.Column("CGPId"));
            ManyToOne(horario => horario.servicio, map => map.Column("ServicioId"));
            Lazy(false);
            Bag(horario => horario.turnosDeAtencion, map =>
                                                            {
                                                                map.Key(key => key.Column("HorarioDeAtencionId"));
                                                                map.Table("HorarioTurnos");
                                                                map.Cascade(Cascade.All);                                                              
                                                            }, rel => rel.ManyToMany(turno => turno.Column("TurnoId"))
                );
        }


    }
}

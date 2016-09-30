using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using Mapper;
using LibreriaClasesPoi;
using Poi.Servicios;
using NHibernate.Criterion;

namespace Mapeo
{

    public class MapManager
    {
        public NHibernate.ISession session;
        public NHibernate.ITransaction transaction;
        private Configuration configuration;

        public void init()
        {
            this.configuration = CreateAndConfigure.nuevaConfiguracion(); ;
            //var config = CreateAndConfigure.nuevaConfiguracion();

            //* se crea un objeto mapper y cada uno de las clases que se necesitan persistir

            var mapper = new ConventionModelMapper();

            var mappingBanco = new BancoMap();
            var mappingCGP = new CGPMap();
            var mappingLocalComercial = new LocalComercialMap();
            var mappingParadaDeColectivo = new ParadaDeColectivoMap();
            var mappingHorariosDeAtencion = new HorarioDeAtencionMap();
            var mappingTurnos = new TurnoMap();
            var mappingServicios = new ServicioMap();

            //* se agregan las clases al objeto mapper
            agregarMapeos(mapper, mappingBanco, mappingCGP, mappingLocalComercial, mappingParadaDeColectivo, mappingHorariosDeAtencion, mappingTurnos, mappingServicios);

            configuration.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            new SchemaExport(configuration).Execute(false, true, false);
        }

        public void comenzar_transaccion()
        {
            var factory = configuration.BuildSessionFactory();
            session = factory.OpenSession();
            transaction = session.BeginTransaction();
        }

        public void terminar_transaccion()
        {
            session.Close();
        }

        public void actualizar_datos(object objeto_a_actualizar)
        {
            comenzar_transaccion();
            session.Update(objeto_a_actualizar);
            session.Refresh(objeto_a_actualizar);
            impactar_en_bd();
            terminar_transaccion();
        }

        public void guardar_datos(object objeto_a_guardar)
        {
            comenzar_transaccion();
            session.SaveOrUpdate(objeto_a_guardar);
            impactar_en_bd();
            terminar_transaccion();
        }

        public void borrar_datos(object objeto_a_borrar)
        {
            comenzar_transaccion();
            session.Delete(objeto_a_borrar);
            impactar_en_bd();
            terminar_transaccion();
        }

        public void impactar_en_bd()
        {
            transaction.Commit();
            session.Flush();
        }


        /*
         * METODOS PARA LA RECUPERACIÓN DE POIS
         */

        public IList<POI> recuperar_pois(String palabra)
        {
            comenzar_transaccion();
            NHibernate.ICriteria criteria = session.CreateCriteria<POI>();
            criteria.Add(Restrictions.Like("Nombre", "%" + palabra + "%"));
            IList<POI> lista_consulta = criteria.List<POI>();
            asociar_horarios_a_pois(lista_consulta);
            terminar_transaccion();
            return lista_consulta;
        }

        private void asociar_horarios_a_pois(IList<POI> pois)
        {
            foreach (POI poi in pois)
            {
                poi.horarioDeAtencion = recuperar_horarios_de_atencion(poi);
            }
        }

        private IList<HorarioDeAtencion> recuperar_horarios_de_atencion(POI poi)
        {
            NHibernate.ICriteria criteria = session.CreateCriteria<HorarioDeAtencion>();
            LocalComercial local = new LocalComercial();
            if (poi.GetType() == local.GetType())
            {
                SimpleExpression restriccion_local = Restrictions.Eq("localComercial", poi);
                criteria.Add(restriccion_local);
            }
            else
            {
                Banco banco = new Banco();
                if (poi.GetType() == banco.GetType())
                {
                    SimpleExpression restriccion_banco = Restrictions.Eq("banco", poi);
                    criteria.Add(restriccion_banco);
                    recuperar_servicios((PoiConServicios)poi);
                }
                else
                {
                    CGP cgp = new CGP();
                    if (poi.GetType() == cgp.GetType())
                    {
                        SimpleExpression restriccion_cgp = Restrictions.Eq("cgp", poi);
                        criteria.Add(restriccion_cgp);
                        recuperar_servicios((PoiConServicios)poi);
                    }
                }
            }
            IList<HorarioDeAtencion> lista_consulta = criteria.List<HorarioDeAtencion>();
            foreach (HorarioDeAtencion horario in lista_consulta)
            {
                horario.turnosDeAtencion = recuperar_turnos(horario);
            }
            return lista_consulta;
        }

        private IList<Turno> recuperar_turnos(HorarioDeAtencion id_horario_atencion)
        {
            NHibernate.ICriteria criteria = session.CreateCriteria<Turno>();
            criteria.Add(Restrictions.Eq("horarioDeAtencion", id_horario_atencion));
            IList<Turno> lista_consulta = criteria.List<Turno>();
            return lista_consulta;
        }

        private void recuperar_servicios(PoiConServicios poi)
        {
            NHibernate.ICriteria criteria = session.CreateCriteria<Servicio>();
            Banco banco = new Banco();
            if (poi.GetType() == banco.GetType())
            {
                SimpleExpression restriccion_banco = Restrictions.Eq("banco", poi);
                criteria.Add(restriccion_banco);
            }
            else
            {
                CGP cgp = new CGP();
                if (poi.GetType() == cgp.GetType())
                {
                    SimpleExpression restriccion_cgp = Restrictions.Eq("cgp", poi);
                    criteria.Add(restriccion_cgp);
                }
            }
            IList<Servicio> lista_consulta = criteria.List<Servicio>();
            foreach(Servicio servicio in lista_consulta)
            {
                servicio.horariosDeAtencion=recuperar_horarios_servicio(servicio);
            }
            poi.servicios = lista_consulta;
        }

        private IList<HorarioDeAtencion> recuperar_horarios_servicio(Servicio servicio)
        {
            NHibernate.ICriteria criteria = session.CreateCriteria<HorarioDeAtencion>();
            criteria.Add(Restrictions.Eq("servicio", servicio));
            IList<HorarioDeAtencion> lista_consulta = criteria.List<HorarioDeAtencion>();
            foreach (HorarioDeAtencion horario in lista_consulta)
            {
                horario.turnosDeAtencion = recuperar_turnos(horario);
            }
            return lista_consulta;
        }

        public void cerrar_transaccion()
        {
            session.Close();
        }

        private void agregarMapeos(ConventionModelMapper mapper, params IConformistHoldersProvider[] mapeos)
        {
            foreach (IConformistHoldersProvider claseAMapear in mapeos)
            {
                mapper.AddMapping(claseAMapear);
            }
        }

          
    }
}

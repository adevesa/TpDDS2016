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


namespace Mapeo
{
    
    public class MapManager
    {
        public NHibernate.ISession session;
        public NHibernate.ITransaction transaction;
        private Configuration configuration; 
        public void init()
        {
            var config = CreateAndConfigure.nuevaConfiguracion();

            //* se crea un objeto mapper y cada uno de las clases que se necesitan persistir

            var mapper = new ConventionModelMapper();
            
            var mappingBanco = new BancoMap();
            var mappingCGP = new CGPMap();
            var mappingLocalComercial = new LocalComercialMap();
            var mappingParadaDeColectivo = new ParadaDeColectivoMap();

            //* se agregan las clases al objeto mapper
            agregarMapeos(mapper, mappingBanco, mappingCGP, mappingLocalComercial, mappingParadaDeColectivo);

            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            new SchemaExport(config).Execute(false, true, false);

            var factory = config.BuildSessionFactory();
            session =factory.OpenSession();
        }

        public void comenzar_transaccion()
        {
            transaction=session.BeginTransaction();
        }

        public void actualizar_datos(object objeto_a_actualizar)
        {
            session.Update(objeto_a_actualizar);
            session.Refresh(objeto_a_actualizar);
        }

        public void guardar_datos(object objeto_a_guardar)
        {
            session.SaveOrUpdate(objeto_a_guardar);
        }

        public void borrar_datos(object objeto_a_borrar)
        {
            session.Delete(objeto_a_borrar);
        }

        public void impactar_en_bd()
        {
            transaction.Commit();
            session.Flush();
        }

        public void cerrar_transaccion()
        {
            session.Close();
        }

        private void agregarMapeos(ConventionModelMapper mapper, params IConformistHoldersProvider[] mapeos)
        {
            foreach(IConformistHoldersProvider claseAMapear in mapeos)
            {
                mapper.AddMapping(claseAMapear);
            }
        }

        
    }
}

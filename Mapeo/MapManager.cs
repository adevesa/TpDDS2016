using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Tool.hbm2ddl;
using Mapper;


namespace Mapeo
{
    
    public class MapManager
    {
        public void init()
        {
            var config = CreateAndConfigure.nuevaConfiguracion();

            //* se crea un objeto mapper y cada uno de los mappings que se necesitan sincronizar

            var mapper = new ConventionModelMapper();
            var mappingBanco = new BancoMap();
            var mappingCGP = new CGPMap();
            var mappingLocalComercial = new LocalComercialMap();
            var mappingParadaDeColectivo = new ParadaDeColectivoMap();

            //* se agregan los mapeos al objeto mapper
            agregarMapeos(mapper, mappingBanco, mappingCGP, mappingLocalComercial, mappingParadaDeColectivo);

            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());
            new SchemaExport(config).Execute(false, true, false);
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

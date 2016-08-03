using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Mapping;

namespace Mapeo
{
    
    public class MapManager
    {
        public void init()
        {
            var config = new Configuration();
            config.DataBaseIntegration(db =>
            {
                db.ConnectionProvider<DriverConnectionProvider>();
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = @"Server=.\SQLEXPRESS;Database=****;User=sqlUser;Password=****;";
                db.BatchSize = 30;
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.Timeout = 10;
                db.LogFormattedSql = true;
                db.LogSqlInConsole = false;
                db.HqlToSqlSubstitutions = "true 1, false 0, yes 'Y', no 'N'";
            }
            );

            var mapper = new ConventionModelMapper();
            var mappings = new []
            {
                typeof(PoiMap)
            };
            mapper.AddMapping(mappings);
            config.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            new SchemaExport(config).Execute(false, true, false);
        }
        
    }
}

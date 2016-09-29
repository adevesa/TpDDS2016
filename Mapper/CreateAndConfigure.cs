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

namespace Mapper
{
    public class CreateAndConfigure
    {
        static public Configuration nuevaConfiguracion()
        {
            var config = new Configuration();
            configurarParametrosBDD(config);
            return config;
        }
        static private void configurarParametrosBDD(Configuration configuracion)
        {
            configuracion.DataBaseIntegration(db =>
            {
                db.ConnectionProvider<DriverConnectionProvider>();
                db.Dialect<MsSql2012Dialect>();
                db.Driver<SqlClientDriver>();
                db.ConnectionString = @"Data Source=localhost\SQLSERVER2012;Database=TPDDS2016;User=tpdds2016;Password=tpdds2016;";
                db.BatchSize = 30;
                db.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                db.Timeout = 10;
                db.LogFormattedSql = true;
                db.LogSqlInConsole = false;
                db.HqlToSqlSubstitutions = "true 1, false 0, yes 'Y', no 'N'";
            }
            );
        }
    }
}

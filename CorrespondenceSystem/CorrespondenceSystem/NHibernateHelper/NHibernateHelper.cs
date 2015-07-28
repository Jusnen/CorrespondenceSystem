using System.Configuration;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

/*librerias NHibernate*/

namespace MvcGCP.NHibernateHelpers
{
    public class NHibernateHelper
    {
        private readonly string _connectionString;
        private ISessionFactory _sessionFactory;

        public NHibernateHelper()
        {
            // _connectionString = @"Data Source=CODE-PC\DANTESQL;Initial Catalog=GCP;Trusted_Connection=True";

            //  _connectionString = @"Data Source=DES-06-PC\MSSQLSERVER02;Initial Catalog=GCP;Trusted_Connection=True";

            _connectionString = ConfigurationManager.ConnectionStrings["LocalWork"].ToString();

            //@"Data Source=SOL-DS-01;Initial Catalog=GCP;Trusted_Connection=True";
        }

        public ISessionFactory SessionFactory
        {
            get { return _sessionFactory ?? (_sessionFactory = CreateSessionFactory()); }
        }

        public ISessionFactory CreateSessionFactory()
        {
            var configuration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(_connectionString)
                    .ShowSql())
                .ExposeConfiguration(c => new SchemaUpdate(c).Execute(false, true))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildConfiguration();

            _sessionFactory = configuration.BuildSessionFactory();
            return _sessionFactory;
        }
    }
}
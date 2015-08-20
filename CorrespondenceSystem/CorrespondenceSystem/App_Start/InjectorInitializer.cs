using System.Reflection;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Repositories;
using CorrespondenceSystem.Services;
using LightInject;
using MvcGCP.NHibernateHelpers;

namespace CorrespondenceSystem
{
    public static class InjectorInitializer
    {
        public static void Initialize()
        {
            var container = new ServiceContainer();
            InitializeContainer(container);
            container.RegisterControllers(Assembly.GetExecutingAssembly());
            container.EnableMvc();
        }

        private static void InitializeContainer(ServiceContainer container)
        {
            container.Register(factory => NHibernateHelper.CreateSessionFactory().OpenSession());
            container.Register<IServiceDocumento, ServiceDocumento>();
            container.Register(typeof(IRepository<,>), typeof(RepositoryBase<,>));
            container.Register<IServiceDepartamento, ServiceDepartamento>();
            container.Register<IServiceMovimiento, ServiceMovimiento>();
        }
    }
}
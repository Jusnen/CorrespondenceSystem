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
            container.Register(factory => NHibernateHelper.CreateSessionFactory().GetCurrentSession());
            container.Register(typeof(RepositoryBase<,>), typeof(IRepository<,>), new PerScopeLifetime());
            container.Register(typeof(ServiceDocumento), typeof(IServiceDocumento));
            container.Register(typeof(ServiceDepartamento), typeof(IServiceDepartamento));
            container.Register(typeof(ServiceMovimiento), typeof(IServiceMovimiento));
        }
    }
}
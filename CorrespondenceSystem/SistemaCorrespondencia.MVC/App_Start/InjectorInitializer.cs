using System.Reflection;
using SistemaCorrespondencia.MVC.Interfaces;
using SistemaCorrespondencia.MVC.Repositories;
using SistemaCorrespondencia.MVC.Services;
using LightInject;
using MvcGCP.NHibernateHelpers;

namespace SistemaCorrespondencia.MVC
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
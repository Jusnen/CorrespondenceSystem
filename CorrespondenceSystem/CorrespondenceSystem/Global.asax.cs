using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CorrespondenceSystem
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            InjectorInitializer.Initialize();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
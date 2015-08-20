using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jusnen.MVC.Startup))]
namespace Jusnen.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}

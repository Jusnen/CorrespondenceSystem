using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaCorrespondencia.MVC.Startup))]
namespace SistemaCorrespondencia.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}

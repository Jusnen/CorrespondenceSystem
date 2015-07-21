using System.Web.Mvc;
using MvcGCP.NHibernateHelpers;

namespace CorrespondenceSystem.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var nHibernateHelper = new NHibernateHelper();
            var a = nHibernateHelper.CreateSessionFactory();
            
            return View();
        }
	}
}
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
            return View();

        }
	}
}
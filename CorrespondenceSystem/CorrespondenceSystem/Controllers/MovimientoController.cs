using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorrespondenceSystem.Controllers
{
    public class MovimientoController : Controller
    {
        //
        // GET: /Movimiento/
        public ActionResult Index()
        {
            return View("verMovimientosHistorial");
        }

        [HttpGet]
        public ActionResult Ver()
        {
            
            return View("verMovimientosHistorial");
        }
	}
}
﻿using System.Web.Mvc;

namespace SistemaCorrespondencia.MVC.Controllers
{
    public class MovimientoController : Controller
    {
        //
        // GET: /Movimiento/
        public ActionResult Index()
        {
            return View("MovimientoVerHistorialTodos");
        }

        [HttpGet]
        public ActionResult Ver()
        {
            return View("MovimientoVerHistorialTodos");
        }
    }
}
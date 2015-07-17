using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CorrespondenceSystem.Controllers
{
    public class DocumentoController : Controller
    {
        //
        //GET: /Documento/
        [HttpGet]
        public ActionResult Index()
        {
            return View("VerDocumentos");
        }

        //
        [HttpGet]
        public ActionResult VerDocumentos()
        {
            return View("VerDocumentos");
        }

        //GET: /Documento/Nuevo
        [HttpGet]
        public ActionResult Nuevo()
        {

            return View("RegistrarDocumentoNuevo");
        }

        [HttpGet]
        public ActionResult Salida()
        {
            return View("RegistrarDocumentoSalida");
        }

	}
}
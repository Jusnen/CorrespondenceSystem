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
        public ActionResult Index()
        {
            return View("VerDocumentos");
        }

        //
        public ActionResult verDocumentos()
        {
            return View("VerDocumentos");
        }

        //GET: /Documento/Nuevo
        public ActionResult Nuevo()
        {

            return View("RegistrarDocumentoNuevo");
        }

	}
}
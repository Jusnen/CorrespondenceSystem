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

        [HttpGet]
        public ActionResult VerDocumentos()
        {
            return View("VerDocumentos");
        }

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

        [HttpGet]
        public ActionResult Entrada()
        {
            
            return View("RegistrarDocumentoEntrada");
        }

        [HttpGet]
        public ActionResult EntradaUser()
        {
            
            return View("RegistrarDocumentoEntradaUser");
        }
	}
}
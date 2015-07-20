﻿using System.Web.Mvc;

namespace CorrespondenceSystem.Controllers
{
    public class DocumentoController : Controller
    {
        //
        //GET: /Documento/
        [HttpGet]
        public ActionResult Index()
        {
            return View("DocumentoVerTodos");
        }

        [HttpGet]
        public ActionResult VerDocumentos()
        {
            return View("DocumentoVerTodos");
        }

        [HttpGet]
        public ActionResult Nuevo()
        {

            return View("DocumentoRegistrarNuevo");
        }

        [HttpGet]
        public ActionResult Salida()
        {
            return View("DocumentoRegistrarSalida");
        }

        [HttpGet]
        public ActionResult Entrada()
        {

            return View("DocumentoRegistrarEntrada");
        }

        [HttpGet]
        public ActionResult EntradaUser()
        {

            return View("DocumentoRegistrarEntradaUser");
        }
	}
}
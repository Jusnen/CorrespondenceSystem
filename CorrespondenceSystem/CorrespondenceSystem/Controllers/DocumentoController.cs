using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Services;
using CorrespondenceSystem.ViewModel.Documento;


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
        public ActionResult Documentos()
        {
            ServiceDocumento serviceDocumento = new ServiceDocumento();

            var listViewModel = new List<DocumentoViewModel>();
            DocumentoViewModel doc;

            var listaDocumento = serviceDocumento.GetAllDocumentosByTipoDepartamento(2);

            foreach (var documento in listaDocumento)
            {
                doc = new DocumentoViewModel();

                doc.departamento = documento.departamento;
                doc.asunto = documento.asunto;
                doc.codigo = documento.codigo;
                doc.fechaCreacionUsuario = documento.fechaCreacionUsuario;
                listViewModel.Add(doc);

            }


            return View("DocumentoVerTodos", listViewModel);
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            DocumentoCrearViewModel documentoCrearViewModel = new DocumentoCrearViewModel();

            var listaRegional = new ServiceDepartamento().GetAllDepartamentosByTipoDepartamento(2);
            var listaDestinatarios = new ServiceDepartamento().GetAllDepartamentosByTipoDepartamento(1);

            documentoCrearViewModel.ddlRegional = new SelectList(listaRegional, "id", "descripcion");
            documentoCrearViewModel.ddlDestinatarios = new SelectList(listaDestinatarios, "id", "descripcion");

            return View("DocumentoRegistrarNuevo", documentoCrearViewModel);
        }

        [HttpPost]
        public ActionResult Nuevo (DocumentoCrearViewModel vm)
        {
            Documento documento = new Documento();
            documento.departamento.id = vm.idDepartamento;
            documento.asunto = vm.asunto;
            documento.codigo = vm.noOficio;
            documento.fechaCreacionUsuario = DateTime.ParseExact(vm.fechaDocumento,"dd/MM/yyyy",null);
            documento.fechaCreacion = DateTime.Now;
            documento.fechaRegistroUsuario = DateTime.ParseExact(vm.fechaRecibido,"dd/MM/yyyy",null);
            documento.usuarioCreacion = 1;
            new ServiceDocumento().InsertDocumento(documento);
            return View("/");
        }
        [HttpGet]
        public ActionResult Salida()
        {
            ServiceDocumento serviceDocumento = new ServiceDocumento();

            var listViewModel = new List<DocumentoViewModel>();
            DocumentoViewModel doc;

            var listaDocumento = serviceDocumento.GetAllDocumentosByTipoDepartamento(2);

            foreach (var documento in listaDocumento)
            {
                doc = new DocumentoViewModel();

                doc.asunto = documento.asunto;
                doc.codigo = documento.codigo;
                doc.fechaCreacionUsuario = documento.fechaCreacionUsuario;
                doc.departamento = documento.departamento;
                listViewModel.Add(doc);

            }
            return View("DocumentoRegistrarSalida", listViewModel);
        }

        [HttpGet]
        public ActionResult Entrada()
        {
            ServiceDocumento serviceDocumento = new ServiceDocumento();

            var listViewModel = new List<DocumentoViewModel>();
            DocumentoViewModel doc;

            var listaDocumento = serviceDocumento.GetAllDocumentosByTipoDepartamento(2);

            foreach (var documento in listaDocumento)
            {
                doc = new DocumentoViewModel();

                doc.asunto = documento.asunto;
                doc.codigo = documento.codigo;
                doc.fechaCreacionUsuario = documento.fechaCreacionUsuario;
                listViewModel.Add(doc);

            }
            return View("DocumentoRegistrarEntrada", listViewModel);
        }

        [HttpGet]
        public ActionResult EntradaUser()
        {
            ServiceDocumento serviceDocumento = new ServiceDocumento();

            var listViewModel = new List<DocumentoViewModel>();
            DocumentoViewModel doc;
            var listaDocumento = serviceDocumento.GetAllDocumentosByDepartamento(4);

            foreach (var documento in listaDocumento)
            {
                doc = new DocumentoViewModel();

                doc.asunto = documento.asunto;
                doc.codigo = documento.codigo;
                doc.fechaCreacionUsuario = documento.fechaCreacionUsuario;
                listViewModel.Add(doc);

            }

            return View("DocumentoRegistrarEntradaUser",listViewModel);
        }

        [HttpGet]
        public ActionResult Documento()
        {
            return View("DocumentoVerDocumento");
        }
    }
}
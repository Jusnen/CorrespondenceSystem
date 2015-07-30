using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.HtmlControls;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Implementations;
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


        #region Nuevo()

        [HttpGet]
        public ActionResult Nuevo()
        {
            var documentoNuevoViewModel = _documentoNuevoViewModel;
            return View("DocumentoRegistrarNuevo", documentoNuevoViewModel);
        }

        [HttpPost]
        public ActionResult Nuevo(DocumentoNuevoViewModel vm)
        {

            Documento documento = new Documento();
            documento.codigo = vm.noOficio;
            documento.fechaCreacionUsuario = DateTime.ParseExact(vm.fechaDocumento, "dd/MM/yyyy", null);
            documento.departamento.id = vm.regional;
            documento.asunto = vm.asunto;
            documento.fechaRegistroUsuario = DateTime.ParseExact(vm.fechaRecibido, "dd/MM/yyyy", null);
            //documento.destinatarios = vm.destinatarios (CREAR)
            documento.usuarioCreacion = 2;
            documento.fechaCreacion = DateTime.Now;

            Movimiento movimiento = new Movimiento();
            movimiento.documento = documento;
            movimiento.departamento = documento.departamento;
            movimiento.fecha = documento.fechaRegistroUsuario;
            movimiento.tipoMovimiento.id = 1;
            movimiento.usuario.id = 2;
            movimiento.usuarioCreacion = 2;
            movimiento.fechaCreacion = documento.fechaCreacion;

            new ServiceDocumento().InsertDocumento(documento);
            new ServiceMovimiento().InsertMovimiento(movimiento);
            return Json(new
            {
                Success = true,
                Message = "Registro guardado correctamente"
            });
        }

        #endregion

        #region Salida()

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

        #endregion Salida()

        #region Entrada()

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

        #endregion

        #region EntradaUser()

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

            return View("DocumentoRegistrarEntradaUser", listViewModel);
        }

        #endregion

        #region Documento/s

        [HttpGet]
        public ActionResult Documento()
        {
            return View("DocumentoVerDocumento");
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

        #endregion


        private static DocumentoNuevoViewModel _documentoNuevoViewModel
        {
            get
            {
                DocumentoNuevoViewModel documentoNuevoViewModel = new DocumentoNuevoViewModel();

                List<Departamento> listaInternos = new ServiceDepartamento().GetAllDepartamentosByTipoDepartamento(1);
                List<Departamento> listaExternos = new ServiceDepartamento().GetAllDepartamentosByTipoDepartamento(2);
                List<Departamento> listaOperaciones = new ServiceDepartamento().GetAllDepartamentosByTipoDepartamento(3);

                documentoNuevoViewModel.ddlRegional = new SelectList(listaExternos, "id", "descripcion");
                documentoNuevoViewModel.departamentosInternos = listaInternos;
                documentoNuevoViewModel.departamentosOpreaciones = listaOperaciones;
                return documentoNuevoViewModel;
            }
        }

    }
}
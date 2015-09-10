using System;
using System.Linq;
using System.Web.Mvc;
using SistemaCorrespondencia.MVC.DomainClasses;
using SistemaCorrespondencia.MVC.Interfaces;
using SistemaCorrespondencia.MVC.ViewModel.Documento;


namespace SistemaCorrespondencia.MVC.Controllers
{
    public class DocumentoController : Controller
    {
        private readonly IServiceDocumento _serviceDocumento;
        private readonly IServiceDepartamento _serviceDepartamento;
        private readonly IServiceMovimiento _serviceMovimiento;

        public DocumentoController(IServiceDocumento serviceDocumento,
            IServiceDepartamento serviceDepartamento,
            IServiceMovimiento serviceMovimiento)
        {
            _serviceDocumento = serviceDocumento;
            _serviceDepartamento = serviceDepartamento;
            _serviceMovimiento = serviceMovimiento;
        }

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
            var documentoNuevoViewModel = new DocumentoNuevoViewModel();
            var listaExternos = _serviceDepartamento.GetAllDepartamentosByTipoDepartamento(2);

            documentoNuevoViewModel.ddlRegional = new SelectList(listaExternos, "id", "descripcion");
            documentoNuevoViewModel.departamentosInternos = _serviceDepartamento.GetAllDepartamentosByTipoDepartamento(1);
            documentoNuevoViewModel.departamentosOpreaciones =
                _serviceDepartamento.GetAllDepartamentosByTipoDepartamento(3);

            return View("DocumentoRegistrarNuevo", documentoNuevoViewModel);
        }

        [HttpPost]
        public ActionResult Nuevo(DocumentoNuevoViewModel vm)
        {

            var documento = new Documento
            {
                codigo = vm.noOficio,
                fechaCreacionUsuario = DateTime.ParseExact(vm.fechaDocumento, "dd/MM/yyyy", null),
                departamento = {Id = vm.regional},
                asunto = vm.asunto,
                fechaRegistroUsuario = DateTime.ParseExact(vm.fechaRecibido, "dd/MM/yyyy", null),
                usuarioCreacion = 2,
                fechaCreacion = DateTime.Now
            };
            //documento.destinatarios = vm.destinatarios (CREAR)

            var movimiento = new Movimiento
            {
                documento = documento,
                departamento = documento.departamento,
                fecha = documento.fechaRegistroUsuario,
                tipoMovimiento = {Id = 1},
                usuario = {Id = 2},
                usuarioCreacion = 2,
                fechaCreacion = documento.fechaCreacion
            };

            _serviceDocumento.InsertDocumento(documento);
            _serviceMovimiento.InsertMovimiento(movimiento);
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
            var listViewModel = new DocumentoSalidaViewModel();
            var destinatarios = _serviceDepartamento.GetAllDepartamentosByTipoDepartamento(1);

            listViewModel.destinararios = destinatarios;
            listViewModel.documentos = _serviceDocumento.GetAllDocumentosByTipoDepartamento(2);
            listViewModel.ddlDestinatarios = new SelectList(destinatarios, "id", "descripcion");

            return View("DocumentoRegistrarSalida", listViewModel);
        }

        [HttpPost]
        public ActionResult Salida(DocumentoSalidaViewModel vm)
        {

            var movimiento = new Movimiento
            {
                documento = {Id = vm.idDocumento},
                departamento = {Id = vm.idDestinatario},
                fecha = DateTime.Now,
                fechaCreacion = DateTime.Now,
                tipoMovimiento = {Id = 2},
                usuario = {Id = 2},
                usuarioCreacion = 2
            };

            _serviceMovimiento.InsertMovimiento(movimiento);

            return Json(new
            {
                Success = true,
                Message = "Registro guardado correctamente"
            });
        }

        #endregion Salida()

        #region Entrada()

        [HttpGet]
        public ActionResult Entrada()
        {
            var ListaEntrada = _serviceDocumento.GetAllTipoEntrada();

            //foreach (var lista in listaDocumento )
            //{

            //}


            //var listViewModel = listaDocumento.Select(documento => new DocumentoViewModel
            //{
            //    asunto = documento.asunto,
            //    codigo = documento.codigo,
            //    fechaCreacionUsuario = documento.fechaCreacionUsuario
            //}).ToList();


            return View("DocumentoRegistrarEntrada", ListaEntrada);
        }

        #endregion

        #region EntradaUser()

        [HttpGet]
        public ActionResult EntradaUser()
        {
            var listaDocumento = _serviceDocumento.GetAllDocumentosByDepartamento(4);

            var listViewModel = listaDocumento.Select(documento => new DocumentoViewModel
            {
                asunto = documento.asunto,
                codigo = documento.codigo,
                fechaCreacionUsuario = documento.fechaCreacionUsuario
            }).ToList();

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
            var listaDocumento = _serviceDocumento.GetAllDocumentosByTipoDepartamento(2);

            var listViewModel = listaDocumento.Select(documento => new DocumentoViewModel
            {
                departamento = documento.departamento,
                asunto = documento.asunto,
                codigo = documento.codigo,
                fechaCreacionUsuario = documento.fechaCreacionUsuario
            }).ToList();


            return View("DocumentoVerTodos", listViewModel);
        }

        #endregion


    }
}
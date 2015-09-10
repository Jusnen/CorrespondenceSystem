using System;
using System.Collections.Generic;
using System.Linq;
using SistemaCorrespondencia.MVC.DomainClasses;
using SistemaCorrespondencia.MVC.Interfaces;

namespace SistemaCorrespondencia.MVC.Services
{
    public class ServiceDocumento : IServiceDocumento
    {
        private readonly IRepository<Documento, int> _repository;
        private readonly IRepository<TipoEntrada, int> _TipoEntrada;

        public ServiceDocumento(IRepository<Documento, int> documentoRepository,
                                IRepository<TipoEntrada, int> TipoEntradaRepository

            )
        {
            _repository = documentoRepository;
            _TipoEntrada = TipoEntradaRepository;

            //_sessionFactory = nHibernateHelper.CreateSessionFactory();
            //_session = _sessionFactory.OpenSession();
            //_repository = new RepositoryBase<Documento, int>(_session);
        }

        public List<Documento> GetAllDocumentos()
        {
            return _repository.GetAll().ToList();
        }

        public List<Documento> GetAllDocumentosByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentosByTipoDepartamento(int idTipoDepartamento)
        {
            return _repository.GetAll(x => x.departamento.tipoDepartamento.Id == idTipoDepartamento).ToList();
        }

        public List<Documento> GetAllDocumentosByDepartamento(int idDepartamento)
        {
            return _repository.GetAll(x => x.departamento.Id == idDepartamento).ToList();
        }

        public List<Documento> GetAllDocumentosByDepartamento(int idDepartamento, DateTime fechaInicio,
            DateTime fechaFinal)
        {
            return _repository.GetAll(x => x.departamento.Id == idDepartamento &&
                                           x.fechaRegistroUsuario >= fechaInicio &&
                                           x.fechaRegistroUsuario <= fechaFinal)
                .ToList();
        }

        public Documento GetDocumentoByCodigo(string codigo)
        {

            return _repository.Get(x => x.codigo == codigo);
        }

        public Documento GetDocumentoById(int id)
        {
            return _repository.Get(x => x.Id == id);
        }

        public void InsertDocumento(Documento documento)
        {
            _repository.Insert(documento);
        }

        public void UpdateDocumento(Documento documento)
        {
            _repository.Update(documento);
        }

        public void UpdateStatus(Documento documento)
        {
            throw new NotImplementedException();
        }

        public List<TipoEntrada> GetAllTipoEntrada()
        {

            var ListaEntrada = _TipoEntrada.GetAll().ToList();
            return ListaEntrada;
        }
    }
}
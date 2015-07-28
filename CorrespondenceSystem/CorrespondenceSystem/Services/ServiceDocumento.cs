using System;
using System.Collections.Generic;
using System.Linq;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Repositories;
using MvcGCP.NHibernateHelpers;
using NHibernate;

namespace CorrespondenceSystem.Services
{
    public class ServiceDocumento : IServiceDocumento
    {
        private static NHibernateHelper nHibernateHelper;
        private static ISessionFactory _sessionFactory;
        private static ISession _session;
        private readonly IRepository<Documento, int> _repository;

        public ServiceDocumento()
        {
            nHibernateHelper = new NHibernateHelper();
            _sessionFactory = nHibernateHelper.CreateSessionFactory();
            _session = _sessionFactory.OpenSession();
            _repository = new RepositoryBase<Documento, int>(_session);
        }

        public List<Documento> GetAllDocumentos()
        {
            return _repository.GetAll().ToList();
        }


        public List<Documento> GetAllDocumentosByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentosByDepartamento(int idDepartamento)
        {
            return _repository.GetAll(x => x.departamento.id == idDepartamento).ToList();
        }

        public List<Documento> GetAllDocumentosByDepartamento(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal)
        {
            return _repository.GetAll(x => x.departamento.id == idDepartamento && 
                x.fechaRegistroUsuario >= fechaInicio && 
                x.fechaRegistroUsuario <= fechaFinal)
                .ToList();
        }

        public Documento GetDocumentoByCodigo(string codigo)
        {
            return _repository.Get(x => x.codigo.Equals(codigo));
        }

        public Documento GetDocumentoById(int id)
        {
            return _repository.Get(x => x.id == id);
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
    }
}
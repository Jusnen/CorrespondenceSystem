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

        public List<Documento> GetAllDocumento()
        {
           return _repository.GetAll().OrderBy(documento => documento.codigo).ToList();
        }

        public List<Documento> GetAllDocumentoFromRemitente(string remitente)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentoFromFechaRegistrado(DateTime fechaInicio, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentoFromFechaCracion(DateTime fechaInicio, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public Documento GetDocumentoByCodigo(string codigo)
        {
            throw new NotImplementedException();
        }

        public Documento GetDocumentoById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertDocumento(Documento documento)
        {
            _repository.Insert(documento);
        }

        public void UpdateDocumento(Documento documento)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(Documento documento)
        {
            throw new NotImplementedException();
        }
    }
}
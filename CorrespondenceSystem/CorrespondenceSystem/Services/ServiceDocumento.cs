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
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentosByFieldAndDate(string campo, DateTime fechaInicio, DateTime fechaFinal)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentosByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public List<Documento> GetAllDocumentosByDepartamento(Departamento departamento)
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
            throw new NotImplementedException();
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
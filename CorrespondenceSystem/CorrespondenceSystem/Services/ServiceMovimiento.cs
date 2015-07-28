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
    public class ServiceMovimiento : IServiceMovimiento
    {
        private static NHibernateHelper nHibernateHelper;
        private static ISessionFactory _sessionFactory;
        private static ISession _session;
        private readonly IRepository<Movimiento, int> _repository;

        public ServiceMovimiento()
        {
            nHibernateHelper = new NHibernateHelper();
            _sessionFactory = nHibernateHelper.CreateSessionFactory();
            _session = _sessionFactory.OpenSession();
            _repository = new RepositoryBase<Movimiento, int>(_session);
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoId(int idDocumento)
        {
            return _repository.GetAll(x => x.documento.id == idDocumento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromDocumentoCodigo(string codigoDocumento)
        {
            return _repository.GetAll(x => x.documento.codigo == codigoDocumento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromDepartamento(int idDepartamento)
        {
            return _repository.GetAll(x => x.departamento.id == idDepartamento).ToList();
        }

        public List<Movimiento> GetAllMovimientosFromFecha(int idDepartamento, DateTime fechaInicio, DateTime fechaFinal)
        {
            return _repository.GetAll(x => x.departamento.id == idDepartamento &&
                                           x.fecha >= fechaInicio &&
                                           x.fecha <= fechaFinal)
                .ToList();
        }

        public Movimiento GetMovimiento(int idDocumento)
        {
            return _repository.Get(x => x.documento.id == idDocumento);
        }

        public void InsertMovimiento(Movimiento movimiento)
        {
            _repository.Insert(movimiento);
        }
    }
}
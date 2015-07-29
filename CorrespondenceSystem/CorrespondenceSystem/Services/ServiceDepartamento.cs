using System.Collections.Generic;
using System.Linq;
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Repositories;
using MvcGCP.NHibernateHelpers;
using NHibernate;

namespace CorrespondenceSystem.Services
{
    public class ServiceDepartamento : IServiceDepartamento
    {
        private static NHibernateHelper nHibernateHelper;
        private static ISessionFactory _sessionFactory;
        private static ISession _session;
        private readonly IRepository<Departamento, int> _repository;

        public ServiceDepartamento()
        {
            nHibernateHelper = new NHibernateHelper();
            _sessionFactory = nHibernateHelper.CreateSessionFactory();
            _session = _sessionFactory.OpenSession();
            _repository = new RepositoryBase<Departamento, int>(_session);
        }
        public List<Departamento> GetAllDepartamentos()
        {
            return _repository.GetAll().ToList();
        }

        public List<Departamento> GetAllDepartamentosByTipoDepartamento(int idTipoDepartamento)
        {
            return _repository.GetAll(x => x.tipoDepartamento.id == idTipoDepartamento).ToList();
        }
    }
}
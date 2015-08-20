using System.Collections.Generic;
using System.Linq;
using SistemaCorrespondencia.MVC.DomainClasses;
using SistemaCorrespondencia.MVC.Interfaces;

namespace SistemaCorrespondencia.MVC.Services
{
    public class ServiceDepartamento : IServiceDepartamento
    {
        private readonly IRepository<Departamento, int> _departamentoRepository;

        public ServiceDepartamento(IRepository<Departamento, int> departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
        }
        public List<Departamento> GetAllDepartamentos()
        {
            return _departamentoRepository.GetAll().ToList();
        }

        public List<Departamento> GetAllDepartamentosByTipoDepartamento(int idTipoDepartamento)
        {
            return _departamentoRepository.GetAll(x => x.tipoDepartamento.Id == idTipoDepartamento).ToList();
        }
    }
}
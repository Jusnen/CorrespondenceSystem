
using System.Collections.Generic;
using SistemaCorrespondencia.MVC.DomainClasses;

namespace SistemaCorrespondencia.MVC.Interfaces
{
    public interface IServiceDepartamento
    {
        List<Departamento> GetAllDepartamentos();
        List<Departamento> GetAllDepartamentosByTipoDepartamento(int idTipoDepartamento);
    }
}
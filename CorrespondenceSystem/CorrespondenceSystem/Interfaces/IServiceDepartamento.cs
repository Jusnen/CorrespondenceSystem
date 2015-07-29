
using System.Collections.Generic;
using CorrespondenceSystem.DomainClasses;

namespace CorrespondenceSystem.Interfaces
{
    public interface IServiceDepartamento
    {
        List<Departamento> GetAllDepartamentos();
        List<Departamento> GetAllDepartamentosByTipoDepartamento(int idTipoDepartamento);
    }
}
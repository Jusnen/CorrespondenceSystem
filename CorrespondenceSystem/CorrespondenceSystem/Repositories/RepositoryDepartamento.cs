using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryDepartamento : IRepository<Departamento, int>
    {
         
    }

    public class NhRepositoryDepartamento : NhRepositoryBase<Departamento, int>, IRepositoryDepartamento
    {
         
    }
}
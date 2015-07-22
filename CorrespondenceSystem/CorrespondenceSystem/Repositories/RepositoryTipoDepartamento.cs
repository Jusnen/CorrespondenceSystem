using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryTipoDepartamento : IRepository<TipoDepartamento, int>
    {

    }

    public class NhRepositoryTipoDepartamento : NhRepositoryBase<TipoDepartamento, int>, IRepositoryTipoDepartamento
    {
         
    }
}
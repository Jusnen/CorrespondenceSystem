using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryTipoMovimiento : IRepository<TipoMovimiento, int>
    {

    }

    public class NhRepositoryTipoMovimiento : NhRepositoryBase<TipoMovimiento, int>, IRepositoryTipoMovimiento
    {
         
    }
}
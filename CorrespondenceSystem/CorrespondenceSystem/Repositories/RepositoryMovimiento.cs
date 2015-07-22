using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryMovimiento : IRepository<Movimiento, int>
    {

    }

    public class NhRepositoryMovimiento : NhRepositoryBase<Movimiento, int>, IRepositoryMovimiento
    {
         
    }
}
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryMensajero : IRepository<Mensajero, int>
    {

    }

    public class NhRepositoryMensajero : NhRepositoryBase<Mensajero, int>, IRepositoryMensajero
    {
         
    }
}
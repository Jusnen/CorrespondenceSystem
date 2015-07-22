using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryUsuario : IRepository<Usuario, int>
    {

    }

    public class NhRepositoryUsuario : NhRepositoryBase<Usuario, int>, IRepositoryUsuario
    {
         
    }
}
using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryTipoUsuario : IRepository<TipoUsuario, int>
    {

    }

    public class NhRepositoryTipoUsuario : NhRepositoryBase<TipoUsuario, int>, IRepositoryTipoUsuario
    {
         
    }
}
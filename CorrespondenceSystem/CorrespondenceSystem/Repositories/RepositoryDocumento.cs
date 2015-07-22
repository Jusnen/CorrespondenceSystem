using CorrespondenceSystem.DomainClasses;
using CorrespondenceSystem.Interfaces;

namespace CorrespondenceSystem.Repositories
{
    public interface IRepositoryDocumento : IRepository<Documento, int>
    {
         
    }

    public class NhRepositoryDocumento : NhRepositoryBase<Documento, int>, IRepositoryDocumento
    {
        
    }
}
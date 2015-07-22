using System.Linq;
using CorrespondenceSystem.Implementations;
using NHibernate.Persister.Entity;

namespace CorrespondenceSystem.Interfaces
{
    public interface IRepository
    {
         
    }

    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : Entity<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(TPrimaryKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}
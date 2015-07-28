using System;
using System.Linq;
using System.Linq.Expressions;
using CorrespondenceSystem.Implementations;

namespace CorrespondenceSystem.Interfaces
{
    public interface IRepository
    {
         
    }

    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : Entity<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity,bool>> expression);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SistemaCorrespondencia.MVC.Interfaces
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity, TPrimaryKey> : IRepository where TEntity : IEntity<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> expression);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}
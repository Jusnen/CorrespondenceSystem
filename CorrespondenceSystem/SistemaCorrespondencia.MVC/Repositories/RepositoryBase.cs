using NHibernate;
using NHibernate.Linq;
using SistemaCorrespondencia.MVC.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SistemaCorrespondencia.MVC.Repositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
       where TEntity : IEntity<TPrimaryKey>
    {
        private readonly ISession Session;

        /// Used to get a IQueryable that is used to retrive object from entire table.
        /// IQueryable to be used to select entities from database
        public RepositoryBase(ISession session)
        {
            Session = session;
        }

        //Gets an list of entities filtered
        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return Session.Query<TEntity>().Where(expression);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        // Gets an entity filtered
        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return Session.Query<TEntity>().Where(expression).ToList()[0];
        }

        /// Inserts a new entity.
        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        /// Updates an existing entity.
        public void Update(TEntity entity)
        {
            Session.Update(entity);
            Session.Flush();
        }

        /// Deletes an entity.
        public void Delete(TPrimaryKey id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }

        ~RepositoryBase()
        {
            Session.Close();
        }
    }
}

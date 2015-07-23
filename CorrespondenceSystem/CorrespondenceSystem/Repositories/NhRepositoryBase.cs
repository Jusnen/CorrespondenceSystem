using System.Linq;
using CorrespondenceSystem.Implementations;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Services;
using NHibernate;
using NHibernate.Linq;

namespace CorrespondenceSystem.Repositories
{
    public abstract class NhRepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : Entity<TPrimaryKey>
    {
        protected ISession Session { get { return NhUnitOfWork.Current.Session; } }

        /// Used to get a IQueryable that is used to retrive object from entire table.
        /// IQueryable to be used to select entities from database
        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        /// Gets an entity.
        /// <param name="key">Primary key of the entity to get</param>
        /// <returns>Entity</returns>
        public TEntity Get(TPrimaryKey key)
        {
            return Session.Get<TEntity>(key);
        }

        /// Inserts a new entity.
        /// <param name="entity">Entity</param>
        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        /// Updates an existing entity.
        /// <param name="entity">Entity</param>
        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        /// Deletes an entity.
        /// <param name="id">Id of the entity</param>
        public void Delete(TPrimaryKey id)
        {
            Session.Delete(Session.Load<TEntity>(id));
        }
    }
}
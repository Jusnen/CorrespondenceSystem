using System.Linq;
using CorrespondenceSystem.Implementations;
using CorrespondenceSystem.Interfaces;
using CorrespondenceSystem.Services;
using NHibernate;
using NHibernate.Linq;

namespace CorrespondenceSystem.Repositories
{
    public class RepositoryBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {
        protected ISession Session;

        /// Used to get a IQueryable that is used to retrive object from entire table.
        /// IQueryable to be used to select entities from database

        public RepositoryBase(ISession session)
        {
            Session = session;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        /// Gets an entity.
        public TEntity Get(TPrimaryKey key)
        {
            return Session.Get<TEntity>(key);
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
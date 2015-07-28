using System;
using CorrespondenceSystem.Interfaces;
using NHibernate;

namespace CorrespondenceSystem.Services
{
    public class NhUnitOfWork : IUnitOfWork
    {
        [ThreadStatic] private static NhUnitOfWork _current;

        /// Reference to the session factory.
        private readonly ISessionFactory _sessionFactory;

        /// Reference to the currently running transcation.
        private ITransaction _transaction;

        /// Creates a new instance of NhUnitOfWork.
        public NhUnitOfWork(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
        }

        public static NhUnitOfWork Current
        {
            get { return _current; }
            set { _current = value; }
        }

        /// Gets Nhibernate session object to perform queries.
        public ISession Session { get; private set; }

        /// Opens database connection and begins transaction.
        public void BeginTransaction()
        {
            Session = _sessionFactory.OpenSession();
            _transaction = Session.BeginTransaction();
        }

        /// Commits transaction and closes database connection.
        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            finally
            {
                Session.Close();
            }
        }

        /// Rollbacks transaction and closes database connection.
        public void RollBack()
        {
            try
            {
                _transaction.Rollback();
            }
            finally
            {
                Session.Close();
            }
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class UnitOfWorkAttribute : Attribute
    {
    }
}
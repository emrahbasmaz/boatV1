using Boat.Framework.Interface;
using Boat.Framework.GenericRepository;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Boat.Framework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        ///     Reference to the currently connect to db transcation.
        /// </summary>
        private IDbConnection _connection;

        /// <summary>
        ///     Reference to the currently running transcation.
        /// </summary>
        private IDbTransaction _transaction;

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public IRepository<TEntity, long> repository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity, long>(_transaction);
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
            }
        }

        #region IDisposable Members
        // Burada IUnitOfWork arayüzüne implemente ettiğimiz IDisposable arayüzünün Dispose Patternini implemente ediyoruz.
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _transaction.Dispose();
                }
            }

            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}

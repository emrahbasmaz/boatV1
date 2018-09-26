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
        private readonly string _connectionString;

        /// <summary>
        ///     Reference to the currently running transcation.
        /// </summary>
        public IDbTransaction _transaction;

        public UnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
            _connection.Open();

        }

        ///     Get the current connection, or open a new connection
        /// </summary>

        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SqlConnection(_connectionString);

                if (string.IsNullOrWhiteSpace(_connection.ConnectionString))
                    _connection.ConnectionString = _connectionString;

                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                return _connection;
            }
        }

        IDbTransaction IUnitOfWork.Transaction => _transaction;

        public IDbTransaction Transaction;

        public IDbTransaction BeginTransaction()
        {
            if (_transaction == null || _transaction.Connection == null)
                _transaction = Connection.BeginTransaction();

            return _transaction;
        }

        //public IRepository<TEntity, long> repository<TEntity>() where TEntity : class
        //{

        //    return new GenericRepository<TEntity, TPrimaryKey>(BeginTransaction());
        //}

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

        public IRepository<TEntity, long> repository<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}

using System;
using System.Data;

namespace Boat.Framework.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection Connection { get; }
        IDbTransaction Transaction { get; }

        IRepository<TEntity, long> repository<TEntity>() where TEntity : class;

        IDbTransaction BeginTransaction();
        void Commit();
    }
}

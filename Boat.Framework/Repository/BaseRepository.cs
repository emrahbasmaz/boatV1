using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Framework.Repository
{
    public abstract class BaseRepository<TEntity> where TEntity : class
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }

        public BaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }

        public IEnumerable<TEntity> Query(string sql)
        {
            return Connection.Query<TEntity>(sql).AsList();
        }

        public TEntity Get(long key)
        {
            return Connection.Get<TEntity>(key);
        }

        public async Task<TEntity> GetAsync(long key)
        {
            return await Connection.GetAsync<TEntity>(key);
        }

        public long Save(TEntity entity)
        {
            return Connection.Insert(entity);
        }

        public async Task<long> SaveAsync(TEntity entity)
        {
            return await Connection.InsertAsync(entity);
        }

        public bool Update(TEntity entity)
        {
            return Connection.Update(entity);
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            return await Connection.UpdateAsync(entity);
        }

        public bool Delete(TEntity entity)
        {
            return Connection.Delete(entity);
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            return await Connection.DeleteAsync(entity);
        }
    }
}


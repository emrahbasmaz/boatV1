using Boat.Framework.Interface;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Boat.Framework.GenericRepository
{
    public class GenericRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
         where TEntity : class
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }

        public GenericRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
            // Transaction = transaction ?? throw new ArgumentNullException("transaction can not be null.");
        }

        // protected IStringLocalizer<string> Localizer => IocFacility.Container.Resolve<IStringLocalizer<string>>();

        public IEnumerable<TEntity> Query(string sql)
        {
            return Connection.Query<TEntity>(sql).AsList();
            // using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //return SqlMapper.Query<TEntity>(sqlConnection, sql).AsList();
        }

        public TEntity Get(TPrimaryKey key)
        {
            return Connection.Get<TEntity>(key);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //return SqlMapperExtensions.Get<TEntity>(sqlConnection, key);
        }

        public async Task<TEntity> GetAsync(TPrimaryKey key)
        {
            return await Connection.GetAsync<TEntity>(key);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return await SqlMapperExtensions.GetAsync<TEntity>(sqlConnection, key);
        }

        public long Save(TEntity entity)
        {
            return Connection.Insert(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return SqlMapperExtensions.Insert(sqlConnection, entity);
        }

        public async Task<long> SaveAsync(TEntity entity)
        {
            return await Connection.InsertAsync(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return await SqlMapperExtensions.InsertAsync(sqlConnection, entity);
        }

        public bool Update(TEntity entity)
        {
            return Connection.Update(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //return SqlMapperExtensions.Update(sqlConnection, entity);
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            return await Connection.UpdateAsync(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return await SqlMapperExtensions.UpdateAsync(sqlConnection, entity);
        }

        public bool Delete(TEntity entity)
        {
            return Connection.Delete(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return SqlMapperExtensions.Delete(sqlConnection, entity);
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            return await Connection.DeleteAsync(entity);
            //using (var sqlConnection = new SqlConnection(DbConstant.DatabaseConnection))
            //    return await SqlMapperExtensions.DeleteAsync(sqlConnection, entity);
        }

        public bool Commit()
        {
            try
            {
                Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Task CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}

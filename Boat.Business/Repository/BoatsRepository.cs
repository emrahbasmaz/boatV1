using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Boat.Business.Service.Interface;
using Boat.Data.DataModel.BoatModule.Entity;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Boat.Business.Repository
{
    public class BoatsRepository : IBoatsRepository
    {
        protected IDbTransaction Transaction { get; private set; }
        protected IDbConnection Connection { get { return Transaction.Connection; } }

        public BoatsRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }

        public IEnumerable<Boats> GetAll()
        {
            return Connection.GetAll<Boats>().AsList();
        }

        public Boats Get(long key)
        {
            return Connection.Get<Boats>(key);
        }

        public async Task<Boats> GetAsync(long key)
        {
            return await Connection.GetAsync<Boats>(key);
        }

        public long Save(Boats entity)
        {
            return Connection.Insert(entity);
        }

        public async Task<long> SaveAsync(Boats entity)
        {
            return await Connection.InsertAsync(entity);
        }

        public bool Update(Boats entity)
        {
            return Connection.Update(entity);
        }

        public async Task<bool> UpdateAsync(Boats entity)
        {
            return await Connection.UpdateAsync(entity);
        }

        public bool Delete(Boats entity)
        {
            return Connection.Delete(entity);
        }

        public async Task<bool> DeleteAsync(Boats entity)
        {
            return await Connection.DeleteAsync(entity);
        }
    }
}

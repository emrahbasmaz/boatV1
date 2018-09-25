using Boat.Data.DataModel.BoatModule.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boat.Business.Service.Interface
{
    public interface IBoatsService
    {
        IEnumerable<Boats> GetAll();
        Boats Get(long id);
        Task<Boats> GetAsync(long id);
        long Add(Boats entity);
        Task<long> AddAsync(Boats entity);
        void Update(Boats entity);
        Task UpdateAsync(Boats entity);
        void Delete(Boats entity);
        Task DeleteAsync(Boats entity);
    }
}

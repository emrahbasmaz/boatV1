using Boat.Data.DataModel.BoatModule.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boat.Business.Service.Interface
{
    public interface IBoatsRepository
    {
        IEnumerable<Boats> GetAll();
        Boats Get(long id);
        Task<Boats> GetAsync(long id);
        long Save(Boats entity);
        Task<long> SaveAsync(Boats entity);
        bool Update(Boats entity);
        Task<bool> UpdateAsync(Boats entity);
        bool Delete(Boats entity);
        Task<bool> DeleteAsync(Boats entity);
    }
}

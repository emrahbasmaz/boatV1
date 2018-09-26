using System.Data;
using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.GenericRepository;

namespace Boat.Business.Repository
{
    public class BoatsRepository : GenericRepository<Boats, long>, IBoatsRepository
    {

    }
}

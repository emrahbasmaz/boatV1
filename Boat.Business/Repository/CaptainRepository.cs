using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.GenericRepository;

namespace Boat.Business.Repository
{
    public class CaptainRepository : GenericRepository<Captains, long>, ICaptainRepository
    {
    }
}

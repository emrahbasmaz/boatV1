using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.Interface;

namespace Boat.Data.DataModel.BoatModule.Interface
{
    public interface IBoatPhotosRepository : IRepository<BoatPhotos, long>, IRepository
    {
    }
}

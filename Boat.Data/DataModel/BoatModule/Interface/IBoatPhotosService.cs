using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.Interface;

namespace Boat.Data.DataModel.BoatModule.Interface
{
    public interface IBoatPhotosService : IService<BoatPhotos, long, IBoatPhotosRepository>
    {
    }
}

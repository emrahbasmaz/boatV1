using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.Interface;
using System.Collections.Generic;

namespace Boat.Data.DataModel.BoatModule.Interface
{
    public interface IBoatPhotosRepository : IRepository<BoatPhotos, int>, IRepository
    {
    }
}

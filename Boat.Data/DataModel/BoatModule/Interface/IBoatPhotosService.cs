using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boat.Data.DataModel.BoatModule.Interface
{
    public interface IBoatPhotosService : IService<BoatPhotos, long, IBoatPhotosRepository>
    {
    }
}

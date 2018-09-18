﻿using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.Repository;
using Dapper;

namespace Boat.Business.Repository
{
    public class BoatPhotosRepository : Repository<BoatPhotos, long>, IBoatPhotosRepository
    {
    }
}

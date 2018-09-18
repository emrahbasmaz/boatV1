using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boat.Business.Repository
{
    public class BoatsRepository : Repository<Boats, long>, IBoatsRepository
    {
    }
}

using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using Boat.Framework.Service;

namespace Boat.Business.Service
{
    public class CaptainService : Service<Captains, long, ICaptainRepository>, ICaptainService
    {
        public CaptainService(ICaptainRepository repository) : base(repository)
        {
        }
    }
}

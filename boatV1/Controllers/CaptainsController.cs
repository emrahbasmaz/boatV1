using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using boatV1.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace boatV1.Controllers
{
    [Route("api/[controller]")]
    public class CaptainsController : BaseController<Captains, long, ICaptainRepository, ICaptainService>
    {
        public CaptainsController(ICaptainService service) : base(service)
        {
        }
    }
}
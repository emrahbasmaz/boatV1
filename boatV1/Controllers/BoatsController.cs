using Boat.Business.Service.Interface;
using Boat.Data.DataModel.BoatModule.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace boatV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatsController : ControllerBase
    {
        private readonly IBoatsService Service;

        public BoatsController(IBoatsService service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<Boats>> GetAll()
        {
            IEnumerable<Boats> entities = Service.GetAll();
            return Ok(entities);
        }

        [HttpPost]
        public virtual ActionResult<object> Add([FromBody]  Boats entity)
        {
            var id = Service.Add(entity);
            return Ok(id);
        }
    }
}
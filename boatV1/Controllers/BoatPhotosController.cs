using Boat.Data.DataModel.BoatModule.Entity;
using Boat.Data.DataModel.BoatModule.Interface;
using boatV1.Base;
using Microsoft.AspNetCore.Mvc;

namespace boatV1.Controllers
{
    [Route("api/[controller]")]
    public class BoatPhotosController : BaseController<BoatPhotos, long, IBoatPhotosRepository, IBoatPhotosService>
    {
        public BoatPhotosController(IBoatPhotosService service) : base(service)
        {
        }
        //private readonly IBoatPhotosService service;
        //public BoatPhotosController(IBoatPhotosService _service)
        //{
        //    service = _service;
        //}

        //[HttpGet]
        //public virtual ActionResult<IEnumerable<BoatPhotos>> Get()
        //{
        //    IEnumerable<BoatPhotos> entities = service.Get();
        //    return Ok(entities);
        //}

        //[HttpGet("{id}")]
        //public virtual ActionResult<BoatPhotos> Get(long id)
        //{
        //    try
        //    {
        //        BoatPhotos entity = service.Get(id);
        //        return Ok(entity);
        //    }
        //    catch
        //    {
        //        return StatusCode(500, "Computer really says no !...");
        //    }

        //}

        //[HttpGet("GetAsync/{id}")]
        //public async virtual Task<ActionResult<BoatPhotos>> GetAsync(long id)
        //{
        //    BoatPhotos entity = await service.GetAsync(id);
        //    return Ok(entity);
        //}

        //[HttpPost]
        //public virtual ActionResult<object> Add([FromBody]  BoatPhotos entity)
        //{
        //    var id = service.Add(entity);
        //    return Ok(id);
        //}

        //[HttpPost("AddAsync")]
        //public async virtual Task<ActionResult<object>> AddAsync([FromBody]  BoatPhotos entity)
        //{
        //    var id = await service.AddAsync(entity);
        //    return Ok(id);
        //}

        //[HttpPut]
        //public virtual ActionResult Update([FromBody] BoatPhotos entity)
        //{
        //    service.Update(entity);
        //    return Ok();
        //}

        //[HttpPut("UpdateAsync")]
        //public async virtual Task<ActionResult> UpdateAsync([FromBody]  BoatPhotos entity)
        //{
        //    await service.UpdateAsync(entity);
        //    return Ok();
        //}

        //[HttpDelete("{id}")]
        //public virtual ActionResult Delete(BoatPhotos entity)
        //{
        //    service.Delete(entity);
        //    return Ok();
        //}

        //[HttpDelete("DeleteAsync/{id}")]
        //public async virtual Task<ActionResult> DeleteAsync(BoatPhotos entity)
        //{
        //    await service.DeleteAsync(entity);
        //    return Ok();
        //}
    }
}
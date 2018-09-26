using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Data.DataModel.CustomerModule.Interface;
using boatV1.Base;
using Microsoft.AspNetCore.Mvc;

namespace boatV1.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : BaseController<Customer, long, ICustomerRepository, ICustomerService>
    {
        public RegisterController(ICustomerService service) : base(service)
        {
        }
    }
}
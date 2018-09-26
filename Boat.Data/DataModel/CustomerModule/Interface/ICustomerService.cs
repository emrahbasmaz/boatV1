using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Framework.Interface;

namespace Boat.Data.DataModel.CustomerModule.Interface
{
   public interface ICustomerService : IService<Customer, long, ICustomerRepository>
    {
    }
}

using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Framework.Interface;

namespace Boat.Data.DataModel.CustomerModule.Interface
{
    public interface ICustomerAddressService : IService<CustomerAddress, long, ICustomerAddressRepository>
    {
    }
}

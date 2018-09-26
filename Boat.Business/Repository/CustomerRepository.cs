using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Data.DataModel.CustomerModule.Interface;
using Boat.Framework.GenericRepository;

namespace Boat.Business.Repository
{
   public class CustomerRepository : GenericRepository<Customer, long>, ICustomerRepository
    {
    }
}

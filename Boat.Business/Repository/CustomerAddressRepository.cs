using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Data.DataModel.CustomerModule.Interface;
using Boat.Framework.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boat.Business.Repository
{
   public class CustomerAddressRepository : GenericRepository<CustomerAddress, long>, ICustomerAddressRepository
    {
    }
}

using Boat.Data.DataModel.CustomerModule.Entity;
using Boat.Data.DataModel.CustomerModule.Interface;
using Boat.Framework.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boat.Business.Service
{
    public class CustomerService : Service<Customer, long, ICustomerRepository>, ICustomerService
    {
        public CustomerService(ICustomerRepository repository) : base(repository)
        {
        }
    }
}

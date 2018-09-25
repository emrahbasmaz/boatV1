using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Boat.Framework.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; set; }
    }
}

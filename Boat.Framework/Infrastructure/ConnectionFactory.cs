using Boat.Framework.Interface;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Boat.Framework.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        static string conString = "Data Source=94.73.170.20;database=boatDB;User ID=deem;Password=CRwn61Z9;";
        private readonly string connectionString = conString;
        //ConfigurationManager.ConnectionStrings["DTAppCon"].ConnectionString;

        //public static string DatabaseConnection = conString;
        public IDbConnection GetConnection
        {
            get
            {
                var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
                return conn;
            }
        }

        IDbConnection IConnectionFactory.GetConnection { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

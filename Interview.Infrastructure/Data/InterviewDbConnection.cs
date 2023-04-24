using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using Dapper;


namespace Interview.Infrastructure.Data
{
	public class InterviewDbConnection
	{
        private readonly string _connectionString;
        //private readonly IConfiguration _config;
        public InterviewDbConnection(string connectionString)
        {
            _connectionString = connectionString;
            //_config = configuration;
            //var connectionString = Environment.GetEnvironmentVariable("InterviewDB");
            //if (connectionString!= null)
            //{
            //    _connectionString = connectionString;
            //}
            //else
            //{
            //    _connectionString = _config.GetConnectionString("InterviewDB");
            //}

        }

        public IDbConnection GetConnection()
        {
            //return new SqlConnection("Server=10.84.82.43,1433; Database=InterviewDB; User Id=sa; Password=#Wmafs6119107; TrustServerCertificate=true");
            return new SqlConnection(_connectionString);
        }
    }
}


using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace LegacyApplicationRefactoring.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("DatabaseConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string is not configured.");
            }

            return new SqlConnection(connectionString);
        }
    }
}
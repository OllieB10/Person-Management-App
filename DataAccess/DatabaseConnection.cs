using System.Configuration;

namespace DataAccess
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}

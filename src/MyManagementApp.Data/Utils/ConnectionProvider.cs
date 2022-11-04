using System.Data.SqlClient;
namespace MyManagementApp.Data
{
    public static class ConnectionProvider
    {
        public static SqlConnection GetConnection()
        {
            var config = DataConfig.Factory.GetConnectionConfig();
            var connectionString = config.ConnectionString;
            var dbConnection = new System.Data.SqlClient.SqlConnection(connectionString);
            return dbConnection;
        }
    }
}

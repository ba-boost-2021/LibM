using System.Data.SqlClient;

namespace BilgeAdam.Tekrar.Data.Managers
{
    public static class ConnectionManager
    {
        private static SqlConnection instance;

        public static SqlConnection GetConnection()
        {
            if (instance != null)
            {
                return instance;
            }

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            instance = new SqlConnection(connectionString);
            return instance;
        }
    }
}
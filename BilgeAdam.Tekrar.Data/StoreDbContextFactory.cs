using BilgeAdam.Tekrar.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BilgeAdam.Tekrar.Data
{
    public class StoreDbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSetting.json", false, true).Build()
                .GetSection("Database:Rdb:StoreConnectionString").Value;

            var optionBuilder = new DbContextOptionsBuilder<StoreDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            var options = optionBuilder.Options;
            return new StoreDbContext(options);
        }
    }
}
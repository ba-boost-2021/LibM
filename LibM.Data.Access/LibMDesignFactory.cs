using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LibM.Data.Access
{
    public class LibMDesignFactory : IDesignTimeDbContextFactory<LibMDbContext>
    {
        public LibMDbContext CreateDbContext(string[] args)
        {
            var connectionString = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsetting.json", false, true).Build().GetSection("Local").Value;

            var optionsBuilder = new DbContextOptionsBuilder<LibMDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            return new LibMDbContext(options);
        }
    }
}

using LibM.Data.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Test
{
    public class IntegrationTestBase
    {
        protected LibMDbContext dbContext;
        [OneTimeSetUp]
        public void Setup()
        {
            var connectionString = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsetting.json", false, true).Build()
                                    .GetSection("Database:LibMConnectionString").Value;

            var optionsBuilder = new DbContextOptionsBuilder<LibMDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var options = optionsBuilder.Options;
            dbContext = new LibMDbContext(options);
            dbContext.Database.Migrate();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }
    }
}

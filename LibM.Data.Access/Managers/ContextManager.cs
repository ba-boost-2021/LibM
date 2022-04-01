using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibM.Data.Access.Managers
{
    public static class ContextManager
    {
        private static object @lock = new object();
        private static LibMDbContext context;
        public static LibMDbContext GetDbContext()
        {
            if (context is not null)
            {
                return context;
            }
            lock (@lock)
            {
                if (context is not null)
                {
                    return context;
                }
                var connectionString = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                                .AddJsonFile($"appsetting.Development.json", false, true)
                                                                .Build().GetSection("Database:LibMConnectionString").Value;
                var optionBuilder = new DbContextOptionsBuilder<LibMDbContext>();
                var options = optionBuilder.UseSqlServer(connectionString).Options;
                context = new LibMDbContext(options);
            }
            return context;
        }
    }
}

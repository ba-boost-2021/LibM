using BilgeAdam.Tekrar.Data.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Tekrar.Data.DataAccess
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appSetting.json").Build()
                                .GetSection("Database:Rdb:NorthwindConnectionString").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

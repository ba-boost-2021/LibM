using LibM.Data.Entities.Management;
using Microsoft.EntityFrameworkCore;

namespace LibM.Data.Access
{
    public class LibMDbContext : DbContext
    {
        public LibMDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
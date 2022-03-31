using LibM.Data.Entities.Customer;
using LibM.Data.Entities.Definition;
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
        public DbSet<Entities.Definition.Type> Types { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
using BilgeAdam.Tekrar.Data.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.Tekrar.Data.DataAccess
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
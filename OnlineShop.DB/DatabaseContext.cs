using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DB
{
    public class DatabaseContext:DbContext
    {
        public DbSet<ProductDB> Products { get; set; }

        public DatabaseContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
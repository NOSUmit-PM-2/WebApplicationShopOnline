using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OnlineShop.DB
{
    public class DatabaseContext:DbContext
    {
        public DbSet<ProductDB> products { get; set; }

        public DatabaseContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DB.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OnlineShop.DB
{
    public class DatabaseContext:IdentityDbContext<UserDB>
    {
        public DbSet<ProductDB> ProductDBs { get; set; }

        public DatabaseContext(DbContextOptions options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
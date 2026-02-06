using AngularCafeServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AngularCafeServer.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}

using be_dotnet_core_first.Database.Entity;
using Microsoft.EntityFrameworkCore;

namespace be_dotnet_core_first.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> ActUsers { get; set; }

        public DbSet<Activity> Activity { get; set; }

        public DbSet<Category> Category { get; set; }
    }

}

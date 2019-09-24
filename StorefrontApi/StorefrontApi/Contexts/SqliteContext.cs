using Microsoft.EntityFrameworkCore;
using StorefrontApi.PersistanceModels;

namespace StorefrontApi.Contexts
{
    public class SqliteContext : DbContext
    {
        public DbSet<PersistantCompany> Companies { get; set; }
        public DbSet<PersistantDeveloper> Developers { get; set; }
        public DbSet<PersistantUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersistantCompany>().HasKey(pc => pc.Id);
            modelBuilder.Entity<PersistantDeveloper>().HasKey(pd => pd.Id);
            modelBuilder.Entity<PersistantUser>().HasKey(pu => pu.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            options.UseSqlite("Data Source=Store.db");
        }
    }
}

using ApisDB.Models;
using Microsoft.EntityFrameworkCore;
using ApisDB.Data.Configurations;

namespace ApisDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public virtual DbSet<ViiMovitoX01> ViiMovitoX01s { get; set; }
        public virtual DbSet<Txusuario> Txusuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new ViiMovitoX01Configuration());
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}

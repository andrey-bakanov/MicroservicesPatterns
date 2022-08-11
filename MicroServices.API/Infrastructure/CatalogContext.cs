using MicroServices.API.Infrastructure.EntityConfigurations;
using MicroServices.API.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroServices.API.Infrastructure
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options):base(options)
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }
    }
}

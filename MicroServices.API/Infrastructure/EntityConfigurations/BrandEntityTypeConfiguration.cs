using MicroServices.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroServices.API.Infrastructure.EntityConfigurations
{
    public class BrandEntityTypeConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("CatalogBrand");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.BrandName).IsRequired().HasMaxLength(100);
        }
    }
}

using Inclass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inclass.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired(false);
            builder.Property(p=>p.Price).IsRequired().HasPrecision(10,3);

            builder.HasOne(c => c.Catagory)
               .WithMany(p => p.ProductList)
               .HasForeignKey(c => c.CatagoryId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

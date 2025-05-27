using Inclass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inclass.Configuration
{
    public class ShippingAddressConfiguration : IEntityTypeConfiguration<ShippingAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
            builder.ToTable("ShippingAddress");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.StreetAddress).IsRequired();
            builder.Property(p => p.City).IsRequired();
            builder.Property(p => p.State).IsRequired(false);
            builder.Property(p => p.Country).IsRequired();
            builder.Property(p => p.PostalCode).IsRequired(false);

            

            builder.HasOne(c => c.Customer)
               .WithMany(s => s.ShippingAddressList)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

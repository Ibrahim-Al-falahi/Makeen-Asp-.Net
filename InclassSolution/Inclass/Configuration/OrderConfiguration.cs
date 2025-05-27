using Inclass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inclass.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.ToTable("Order");
            builder.HasKey(p => p.Id);
            builder.Property(o => o.OrderDate)
               .IsRequired()
               .HasColumnType("datetime");
            builder.Property(p => p.TotalPrice).IsRequired().HasPrecision(10, 3);

            builder.HasOne(c => c.Customer)
               .WithMany(o => o.OrderList)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

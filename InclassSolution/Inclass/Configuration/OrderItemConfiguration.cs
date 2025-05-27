using Inclass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inclass.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.ItemPrice).IsRequired().HasPrecision(10, 3);

            builder.HasOne(p => p.Product)
               .WithMany(oi => oi.OrderItemList)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(o => o.Order)
               .WithMany(oi => oi.OrderItemList)
               .HasForeignKey(o => o.OrderId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

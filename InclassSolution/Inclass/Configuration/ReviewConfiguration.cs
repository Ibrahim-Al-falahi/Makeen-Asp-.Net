using Inclass.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inclass.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Review");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Comment).IsRequired(false);
            builder.Property(p => p.Rating).IsRequired();
            builder.HasCheckConstraint("range rating", "`Rating` BETWEEN `1` AND `5`");

            builder.HasOne(p => p.Product)
               .WithMany(r => r.ReviewList)
               .HasForeignKey(p => p.ProductId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Customer)
               .WithMany(r => r.ReviewList)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

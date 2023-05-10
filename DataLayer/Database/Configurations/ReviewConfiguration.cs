using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataLayer.Database.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");

            builder.HasKey(r => r.ReviewId);

            builder.Property(r => r.ReviewId)
                .IsRequired()
                .HasColumnName("ReviewId")
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Comment)
                .HasColumnName("Comment")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(r => r.Rating)
                .HasColumnName("Rating")
                .IsRequired();

            builder.Property(r => r.WebsiteId)
                .HasColumnName("WebsiteId")
                .IsRequired();

            builder.HasOne(r => r.Website)
                .WithMany()
                .HasForeignKey(r => r.WebsiteId);

            builder.Property(r => r.UserId)
                .HasColumnName("UserId")
                .IsRequired();

            builder.HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);

            builder.Property(r => r.CreatedAt)
                .HasColumnName("CreatedAt")
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(r => r.Website)
                .WithMany(w => w.Reviews)
                .HasForeignKey(r => r.WebsiteId);

            builder.HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);
        }

    }
}

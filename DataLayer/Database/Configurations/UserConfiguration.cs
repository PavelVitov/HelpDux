using DataLayer.Models;
using DataLayer.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataLayer.Database.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.UserId);

            builder.Property(u => u.UserId)
                .IsRequired()
                .HasColumnName("UserId")
                .ValueGeneratedOnAdd();

            builder.Property(u => u.Username)
                .IsRequired()
                .HasColumnName("Username")
                .HasMaxLength(50);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("Email")
                .HasMaxLength(100);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasMaxLength(100);

            builder.Property(u => u.PictureUrl)
                .HasColumnName("PictureUrl");

            builder.HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(u => u.Roles)
                .IsRequired()
                .HasColumnName("Roles")
                .HasConversion(
                    v => v.ToString(),
                    v => (Roles)Enum.Parse(typeof(Roles), v));

            builder.HasIndex(u => u.Username).IsUnique();
            builder.HasIndex(u => u.Email).IsUnique();
        }

    }
}

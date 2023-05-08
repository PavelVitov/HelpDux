using DataLayer.Models;
using DataLayer.Models.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database.Configurations
{
    public class WebsiteConfiguration : IEntityTypeConfiguration<Website>
    {
        public void Configure(EntityTypeBuilder<Website> builder)
        {
            builder.ToTable("Websites");

            builder.HasKey(w => w.WebsiteId);

            builder.Property(w => w.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(w => w.Url)
                .IsRequired()
                .HasMaxLength(700)
                .HasAnnotation("RegularExpression", @"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w.-]*)*/?$");

            builder.Property(w => w.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(w => w.CreatedAt)
                .IsRequired();

            builder.Property(w => w.UpdatedAt)
                .IsRequired();

            builder.Property(w => w.IsActive)
                .IsRequired();

            builder.Property(w => w.ImageUrl)
                .HasMaxLength(1000);

            builder.Property(w => w.Tag)
                .IsRequired()
                .HasConversion(
                t => t.ToString(),
                t => (Tag)Enum.Parse(typeof(Tag), t));

            builder.HasMany(w => w.Reviews)
                .WithOne(r => r.Website)
                .HasForeignKey(r => r.WebsiteId);
        }

    }

}

using DataLayer.Models;
using DataLayer.Models.Enum;
using System;
using System.Collections.Generic;

namespace DataLayer.Database.Seeders
{
    public class WebsiteSeeder
    {
        public static void SeedWebsites(HelpDuxDbContext dbContext)
        {
            var websites = new List<Website>
        {
            new Website
            {
                WebsiteId = 1,
                Name = "Google",
                Url = "https://www.google.com",
                Description = "Search engine",
                Tag = Tag.Search_Engine,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/google.jpg"
            },
            new Website
            {
                WebsiteId = 2,
                Name = "Twitter",
                Url = "https://www.twitter.com",
                Description = "Social media platform",
                Tag = Tag.Social_Media,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/twitter.jpg"
            },
            new Website
            {
                WebsiteId = 3,
                Name = "GitHub",
                Url = "https://www.github.com",
                Description = "Code hosting platform",
                Tag = Tag.Code_Hosting,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/github.jpg"
            }
        };

            dbContext.Websites.AddRange(websites);
            dbContext.SaveChanges();
        }
    }
}

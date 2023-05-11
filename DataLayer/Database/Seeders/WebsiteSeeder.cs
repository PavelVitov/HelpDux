using DataLayer.Models;
using DataLayer.Models.Enum;
using System;
using System.Collections.Generic;

namespace DataLayer.Database.Seeders
{
    public class WebsiteSeeder
    {
        internal static Website[] WebsiteSeeding => new Website[]
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
            },
            new Website
            {
                WebsiteId = 4,
                Name = "YouTube",
                Url = "https://www.youtube.com",
                Description = "Video sharing platform",
                Tag = Tag.Entertainment,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/youtube.jpg"
            },
            new Website
            {
                WebsiteId = 5,
                Name = "Facebook",
                Url = "https://www.facebook.com",
                Description = "Social media platform",
                Tag = Tag.Social_Media,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/facebook.jpg"
            },
            new Website
            {
                WebsiteId = 6,
                Name = "Netflix",
                Url = "https://www.netflix.com",
                Description = "Streaming platform",
                Tag = Tag.Entertainment,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/netflix.jpg"
            },
            new Website
            {
                WebsiteId = 7,
                Name = "Spotify",
                Url = "https://www.spotify.com",
                Description = "Music streaming platform",
                Tag = Tag.Music,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/spotify.jpg"
            },
            new Website
            {
                WebsiteId = 8,
                Name = "Instagram",
                Url = "https://www.instagram.com",
                Description = "Social media platform",
                Tag = Tag.Social_Media,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/instagram.jpg"
            },
            new Website
            {
                WebsiteId = 9,
                Name = "TikTok",
                Url = "https://www.tiktok.com",
                Description = "Social media platform",
                Tag = Tag.Social_Media,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsActive = true,
                ImageUrl = "https://example.com/tiktok.jpg"
            }
        };      
    }
}

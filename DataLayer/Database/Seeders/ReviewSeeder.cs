using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace DataLayer.Database.Seeders
{
    public static class ReviewSeeder
    {
        internal static Review[] ReviewSeeding => new Review[]
        {
            new Review
{
                ReviewId = 1,
                Comment = "Great search engine!",
                Rating = 5,
                WebsiteId = 1,
                UserId = 2,
                CreatedAt = DateTime.UtcNow
},
            new Review
            {
                ReviewId = 2,
                Comment = "Love using Twitter!",
                Rating = 4,
                WebsiteId = 2,
                UserId = 3,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 3,
                Comment = "GitHub is amazing for open-source projects!",
                Rating = 5,
                WebsiteId = 3,
                UserId = 1,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 4,
                Comment = "I find YouTube very entertaining!",
                Rating = 5,
                WebsiteId = 4,
                UserId = 4,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 5,
                Comment = "Facebook helps me stay connected with friends and family!",
                Rating = 4,
                WebsiteId = 5,
                UserId = 2,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 6,
                Comment = "Netflix has the best shows and movies!",
                Rating = 5,
                WebsiteId = 6,
                UserId = 1,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 7,
                Comment = "I love listening to music on Spotify!",
                Rating = 4,
                WebsiteId = 7,
                UserId = 3,
                CreatedAt = DateTime.UtcNow
            },
            new Review
            {
                ReviewId = 8,
                Comment = "Instagram is my favorite social media app!",
                Rating = 4,
                WebsiteId = 8,
                UserId = 4,
                CreatedAt = DateTime.UtcNow
            }

        };
    }
}

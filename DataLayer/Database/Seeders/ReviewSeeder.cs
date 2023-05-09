using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database.Seeders
{
    public static class ReviewSeeder
    {
        public static void SeedReviews(HelpDuxDbContext dbContext)
        {
            var reviews = new List<Review>
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
            }
        };

            dbContext.Reviews.AddRange(reviews);
            dbContext.SaveChanges();
        }
    }
}

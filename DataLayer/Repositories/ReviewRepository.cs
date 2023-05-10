using DataLayer.Models;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly HelpDuxDbContext _reviews;

        public ReviewRepository(HelpDuxDbContext reviews)
        {
            this._reviews = reviews;
        }

        public async Task<List<Review>> GetAllReviewsAsync()
        {
            return await _reviews.Reviews.ToListAsync();
        }

        public async Task<Review> GetReviewByIdAsync(int reviewId)
        {
            return await _reviews.Reviews.FirstOrDefaultAsync(r =>  r.ReviewId == reviewId);
        }

        public async Task<List<Review>> GetReviewsByWebsiteIdAsync(int websiteId)
        {
            return await _reviews.Reviews.Where(r => r.WebsiteId == websiteId).ToListAsync();
        }

        public async Task CreateReviewAsync(Review review)
        {
            _reviews.Reviews.Add(review);
            await _reviews.SaveChangesAsync();
        }

        public async Task UpdateReviewAsync(Review review)
        {
            review.UpdatedAt = DateTime.Now;
            _reviews.Reviews.Update(review);
            await _reviews.SaveChangesAsync();
        }

        public async Task DeleteReviewAsync(int id)
        {
            var review = await _reviews.Reviews.FindAsync(id);
            if (review != null)
            {
                _reviews.Reviews.Remove(review);
                await _reviews.SaveChangesAsync();
            }
        }
    }
}

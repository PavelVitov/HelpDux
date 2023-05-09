using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewService _reviewService;
        public ReviewService(IReviewService reviewService)
        {
            this._reviewService = reviewService;
        }
        public Task CreateReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }

        public Task DeleteReviewAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetAllReviewsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetReviewByIdAsync(int reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetReviewsByWebsiteIdAsync(int websiteId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }
    }
}

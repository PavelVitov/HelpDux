using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IReviewService
    {
        Task<List<Review>> GetAllReviewsAsync();
        Task<Review> GetReviewByIdAsync(int reviewId);
        Task<List<Review>> GetReviewsByWebsiteIdAsync(int websiteId);
        Task CreateReviewAsync(Review review);
        Task UpdateReviewAsync(Review review);
        Task DeleteReviewAsync(int id);
    }
}

using BusinessLayer.DTOs;
using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IReviewService
    {
        Task<List<ReviewDTO>> GetAllReviewsAsync();
        Task<ReviewDTO> GetReviewByIdAsync(int reviewId);
        Task<List<ReviewDTO>> GetReviewsByWebsiteIdAsync(int websiteId);
        Task CreateReviewAsync(ReviewDTO review);
        Task UpdateReviewAsync(ReviewDTO review);
        Task DeleteReviewAsync(int id);
    }
}

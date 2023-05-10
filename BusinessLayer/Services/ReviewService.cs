using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using DataLayer.Models.Exceptions;
using DataLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        public ReviewService(IReviewRepository reviewRepository)
        {
            this._reviewRepository = reviewRepository;
        }    

        public async Task<List<Review>> GetAllReviewsAsync()
        {
            return await _reviewRepository.GetAllReviewsAsync();
        }

        public async Task<Review> GetReviewByIdAsync(int reviewId)
        {
            var review = await _reviewRepository.GetReviewByIdAsync(reviewId);
            if (review == null)
            {
                throw new EntityNotFoundException($"Review with id {reviewId} was not found.");
            }

            return review;
        }

        public async Task<List<Review>> GetReviewsByWebsiteIdAsync(int websiteId)
        {
            var review = await _reviewRepository.GetReviewsByWebsiteIdAsync(websiteId);
            if (review == null)
            {
                throw new EntityNotFoundException($"Review related to website with id {websiteId} was not found.");
            }

            return review;
        }

        public async Task CreateReviewAsync(Review review)
        {
            if (string.IsNullOrEmpty(review.Comment))
            {
                throw new EntityNotFoundException("Review comment cannot be null or empty.");
            }
            if (review.Rating < 1 || review.Rating > 5)
            {
                throw new EntityNotFoundException("Review rating must be between 1 and 5.");
            }
            await _reviewRepository.CreateReviewAsync(review);
        }

        public async Task UpdateReviewAsync(Review review)
        {
            if (review == null)
            {
                throw new EntityNotFoundException("Review cannot be empty");
            }

            await _reviewRepository.UpdateReviewAsync(review);
        }

        public async Task DeleteReviewAsync(int id)
        {
            // Retrieve the review by id
            var reviewToDelete = await _reviewRepository.GetReviewByIdAsync(id);

            if (reviewToDelete == null)
            {
                throw new EntityNotFoundException($"Review with id {id} not found");
            }

            // Delete the review from the repository
            await _reviewRepository.DeleteReviewAsync(id);
        }
    }
}

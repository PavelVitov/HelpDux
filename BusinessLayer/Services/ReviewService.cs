using AutoMapper;
using BusinessLayer.DTOs;
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
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
        {
            this._reviewRepository = reviewRepository;
            this._mapper = mapper;
        }

        public async Task<List<ReviewDTO>> GetAllReviewsAsync()
        {
            var reviews = await _reviewRepository.GetAllReviewsAsync();
            return _mapper.Map<List<ReviewDTO>>(reviews);
        }

        public async Task<ReviewDTO> GetReviewByIdAsync(int reviewId)
        {
            var review = await _reviewRepository.GetReviewByIdAsync(reviewId);
            if (review == null)
            {
                throw new EntityNotFoundException($"Review with id {reviewId} was not found.");
            }

            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task<List<ReviewDTO>> GetReviewsByWebsiteIdAsync(int websiteId)
        {
            var review = await _reviewRepository.GetReviewsByWebsiteIdAsync(websiteId);
            if (review == null)
            {
                throw new EntityNotFoundException($"Reviews related to website with id {websiteId} were not found.");
            }

            return _mapper.Map<List<ReviewDTO>>(review);
        }

        public async Task CreateReviewAsync(ReviewDTO reviewDTO)
        {
            var review = _mapper.Map<Review>(reviewDTO);

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

        public async Task UpdateReviewAsync(ReviewDTO reviewDTO)
        {
            var review = _mapper.Map<Review>(reviewDTO);

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

using System;

namespace WebLayer_HelpDux.Models.Review
{
    public class ReviewMVC
    {
        public int ReviewId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int WebsiteId { get; set; }
        public string WebsiteName { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ReviewMVC()
        {
            // Default constructor
        }

        public ReviewMVC(int reviewId, string comment, int rating, int websiteId, string websiteName, int userId, string username, DateTime createdAt, DateTime updatedAt)
        {
            ReviewId = reviewId;
            Comment = comment;
            Rating = rating;
            WebsiteId = websiteId;
            WebsiteName = websiteName;
            UserId = userId;
            Username = username;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}

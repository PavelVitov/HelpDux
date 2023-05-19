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

    }
}

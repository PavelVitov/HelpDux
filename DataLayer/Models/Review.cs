using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        public int Rating { get; set; }
        public int WebsiteId { get; set; }
        public Website Website { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Review()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }

}

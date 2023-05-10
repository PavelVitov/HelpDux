using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Review
    {
        public Review()
        {
            CreatedAt = DateTime.UtcNow;
        }

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
    }

}

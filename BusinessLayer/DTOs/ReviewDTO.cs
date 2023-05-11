using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class ReviewDTO
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

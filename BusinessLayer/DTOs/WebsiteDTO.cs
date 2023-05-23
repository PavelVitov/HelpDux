using DataLayer.Models.Enum;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class WebsiteDTO
    {
        public int WebsiteId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Tag Tag { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public List<ReviewDTO> Reviews { get; set; }

        public WebsiteDTO(int websiteId, string name, string url, string description, Tag tag, DateTime createdAt, DateTime updatedAt, bool isActive, string imageUrl, List<ReviewDTO> reviews)
        {
            WebsiteId = websiteId;
            Name = name;
            Url = url;
            Description = description;
            Tag = tag;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            IsActive = isActive;
            ImageUrl = imageUrl;
            Reviews = reviews;
        }

    }
}

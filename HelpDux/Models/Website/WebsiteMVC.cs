using BusinessLayer.DTOs;
using DataLayer.Models.Enum;
using System.Collections.Generic;
using System;
using WebLayer_HelpDux.Models.Review;

namespace WebLayer_HelpDux.Models.Website
{
    public class WebsiteMVC
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
        public List<ReviewMVC> Reviews { get; set; }

        public WebsiteMVC()
        {
        }

        public WebsiteMVC(int websiteId, string name, string url, string description, Tag tag, DateTime createdAt, DateTime updatedAt, bool isActive, string imageUrl, List<ReviewMVC> reviews)
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

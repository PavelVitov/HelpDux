using DataLayer.Models.Enum;
using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Website
    {       
        [Key]
        public int WebsiteId { get; set; }
        public string Name { get; set; }     
        public string Url { get; set; }
        public string Description { get; set; }
        public Tag Tag { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public List<Review> Reviews { get; set; }
        public Website()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }

}

using DataLayer.Models.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Website
    {
        [Key]
        public int WebsiteId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Website Name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^(https?://)?([\da-z.-]+)\.([a-z.]{2,6})([/\w.-]*)*/?$")]
        public string Url { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public Tag Tag { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
    }

}

using BusinessLayer.DTOs;
using DataLayer.Models.Enum;
using System.Collections.Generic;
using WebLayer_HelpDux.Models.Review;

namespace WebLayer_HelpDux.Models.User
{
    public class UserMVC
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PictureUrl { get; set; }
        public Roles Roles { get; set; }
        public List<ReviewMVC> Reviews { get; set; }
        public UserMVC()
        {
            // Default constructor
        }

        public UserMVC(int userId, string username, string email, string password, string pictureUrl, Roles roles, List<ReviewMVC> reviews)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Password = password;
            PictureUrl = pictureUrl;
            Roles = roles;
            Reviews = reviews;
        }
    }
}

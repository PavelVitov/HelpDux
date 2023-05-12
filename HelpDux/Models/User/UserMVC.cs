﻿using BusinessLayer.DTOs;
using DataLayer.Models.Enum;
using System.Collections.Generic;

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
        public List<ReviewDTO> Reviews { get; set; }
    }
}
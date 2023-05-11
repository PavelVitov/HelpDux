using DataLayer.Models;
using DataLayer.Models.Enum;
using System.Collections.Generic;
using BCrypt.Net;

namespace DataLayer.Database.Seeders
{
    public static class UserSeeder
    {
        internal static User[] UserSeeding => new User[]
        {
            new User
            {
                UserId = 1,
                Username = "Lucifer23",
                Email = "pavelvitov02@gmail.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.Admin,
                PictureUrl = "https://example.com/johndoe.jpg"
            },
            new User
            {
                UserId = 2,
                Username = "JaneDoe",
                Email = "janedoe@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/janedoe.jpg"
            },
            new User
            {
                UserId = 3,
                Username = "BobSmith",
                Email = "bobsmith@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/bobsmith.jpg"
            },
            new User
            {
                UserId = 4,
                Username = "AliceJohnson",
                Email = "alicejohnson@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/alicejohnson.jpg"
            },
            new User
            {
                UserId = 5,
                Username = "DavidLee",
                Email = "davidlee@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/davidlee.jpg"
            },
            new User
            {
                UserId = 6,
                Username = "LisaWang",
                Email = "lisawang@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/lisawang.jpg"
            },
            new User
            {
                UserId = 7,
                Username = "MikeWilliams",
                Email = "mikewilliams@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/mikewilliams.jpg"
            },
            new User
            {
                UserId = 8,
                Username = "SamanthaBrown",
                Email = "samanthabrown@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/samanthabrown.jpg"
            },
            new User
            {
                UserId = 9,
                Username = "AdamSmith",
                Email = "adamsmith@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/adamsmith.jpg"
            },
            new User
            {
                UserId = 10,
                Username = "OliviaJones",
                Email = "oliviajones@example.com",
                Password = BCrypt.Net.BCrypt.HashPassword("Password123!"),
                Roles = Roles.User,
                PictureUrl = "https://example.com/oliviajones.jpg"
            }
        };
      
    }
}

using DataLayer.Models;
using DataLayer.Models.Enum;
using System.Collections.Generic;

namespace DataLayer.Database.Seeders
{
    public static class UserSeeder
    {
        public static void SeedUsers(HelpDuxDbContext dbContext)
        {
            var users = new List<User>
        {
            new User
            {
                UserId = 1,
                Username = "Lucifer23",
                Email = "pavelvitov02@gmail.com",
                Password = "Password123!",
                Roles = Roles.Admin,
                PictureUrl = "https://example.com/johndoe.jpg"
            },
            new User
            {
                UserId = 2,
                Username = "JaneDoe",
                Email = "janedoe@example.com",
                Password = "Password123!",
                Roles = Roles.User,
                PictureUrl = "https://example.com/janedoe.jpg"
            },
            new User
            {
                UserId = 3,
                Username = "BobSmith",
                Email = "bobsmith@example.com",
                Password = "Password123!",
                Roles = Roles.User,
                PictureUrl = "https://example.com/bobsmith.jpg"
            }
        };

            dbContext.Users.AddRange(users);
            dbContext.SaveChanges();
        }
    }
}

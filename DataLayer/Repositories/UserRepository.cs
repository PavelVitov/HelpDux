using DataLayer.Models;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HelpDuxDbContext _users;

        public UserRepository(HelpDuxDbContext users)
        {
            this._users = users;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _users.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _users.Users.FirstOrDefaultAsync(i => i.UserId == id);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _users.Users.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _users.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task CreateUserAsync(User user)
        {
            await _users.Users.AddAsync(user);
            await _users.SaveChangesAsync();
        }

        public async Task UpdateUserUsernameAsync(int userId, string newUsername)
        {
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.Username = newUsername;
            await _users.SaveChangesAsync();
        }

        public async Task UpdateUserPasswordAsync(int userId, string newPassword)
        {
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.Password = newPassword;
            await _users.SaveChangesAsync();
        }

        public async Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture)
        {
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.PictureUrl = newUrlPicture;
            await _users.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _users.Users.FindAsync(id);
            if (user != null)
            {
                _users.Users.Remove(user);
                await _users.SaveChangesAsync();
            }         
        }
    }
}

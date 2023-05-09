using DataLayer.Models;
using DataLayer.Models.Exceptions;
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
            var user = await _users.Users.FirstOrDefaultAsync(i => i.UserId == id);
            if (user == null)
            {
                throw new EntityNotFoundException($"User not found.");
            }
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _users.Users.FirstOrDefaultAsync(e => e.Email == email);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with email: {email} not found.");
            }
            return user;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            var user = await _users.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with username: {username} not found.");
            }
            return user;
        }

        public async Task CreateUserAsync(User user)
        {
            bool emailExists = await _users.Users.AnyAsync(u => u.Email == user.Email);
            if (emailExists)
            {
                throw new DuplicateEntityFoundException("Email already taken, please check your email inbox.");
            }

            bool usernameExists = await _users.Users.AnyAsync(u => u.Username == user.Username);
            if (usernameExists)
            {
                throw new DuplicateEntityFoundException("Username already taken");
            }
            await _users.Users.AddAsync(user);
        }

        public async Task UpdateUserUsernameAsync(int userId, string newUsername)
        {
            bool usernameExists = await _users.Users.AnyAsync(u => u.Username == newUsername);
            if (usernameExists)
            {
                throw new DuplicateEntityFoundException($"Username already taken.");
            }
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.Username = newUsername;
        }

        public async Task UpdateUserPasswordAsync(int userId, string newPassword)
        {
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.Password = newPassword;
        }

        public async Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture)
        {
            User userToUpdate = await _users.Users.FindAsync(userId);
            userToUpdate.PictureUrl = newUrlPicture;
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _users.Users.FindAsync(id);
            if (user != null)
            {
                _users.Users.Remove(user);
            }
            else
            {
                throw new EntityNotFoundException($"User not found.");
            }
        }
    }
}

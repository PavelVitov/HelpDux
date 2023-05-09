using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using DataLayer.Repositories.Exceptions;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await this._userRepository.GetAllUsersAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await this._userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                throw new EntityNotFoundException($"User not found.");
            }
            return user;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with email: {email} not found.");
            }
            return user;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with username: {username} not found.");
            }
            return user;
        }

        public async Task CreateUserAsync(User user)
        {
            var userWithEmail = await _userRepository.GetUserByEmailAsync(user.Email);
            if (userWithEmail != null)
            {
                throw new DuplicateEntityFoundException("A user with the same email already exists.");
            }

            var userWithUsername = await _userRepository.GetUserByUsernameAsync(user.Username);
            if (userWithUsername != null)
            {
                throw new DuplicateEntityFoundException("A user with the same username already exists.");
            }

            await _userRepository.CreateUserAsync(user);
        }

        public async Task UpdateUserUsernameAsync(int userId, string newUsername)
        {
            var usernameExists = await _userRepository.GetUserByIdAsync(userId)
            if (usernameExists)
            {
                throw new DuplicateEntityFoundException($"Username already taken.");
            }
            User userToUpdate = await _userRepository.Users.FindAsync(userId);
        }

        public async Task UpdateUserPasswordAsync(int userId, string oldPassword, string newPassword)
        {
            var user = await this.GetUserByIdAsync(userId);

            if (user.Password == oldPassword)
            {
                throw new OldPasswordMatchedException("New password cannot match old password.");
            }

            await _userRepository.UpdateUserPasswordAsync(userId, newPassword);
        }

        public Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using DataLayer.Models.Exceptions;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this._userRepository = userRepository;
            this._mapper = mapper;
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await this._userRepository.GetAllUsersAsync();
            return _mapper.Map<List<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                throw new EntityNotFoundException($"User not found.");
            }
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByEmailAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with email: {email} not found.");
            }
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<UserDTO> GetUserByUsernameAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with username: {username} not found.");
            }
            return _mapper.Map<UserDTO>(user);
        }

        public async Task CreateUserAsync(UserDTO userDTO)
        {
            await this.GetUserByEmailAsync(userDTO.Email);
            await this.GetUserByUsernameAsync(userDTO.Username);

            // Hash the user's password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);

            // Set the user's password to the hashed password
            userDTO.Password = hashedPassword;

            var user = _mapper.Map<User>(userDTO);
            await _userRepository.CreateUserAsync(user);
        }

        public async Task UpdateUserUsernameAsync(int userId, string newUsername)
        {
            bool usernameExists = await this.GetUserByUsernameAsync(newUsername) != null;
            if (usernameExists)
            {
                throw new DuplicateEntityFoundException($"Username '{newUsername}' already exists.");
            }

            await _userRepository.UpdateUserUsernameAsync(userId, newUsername);
        }

        public async Task UpdateUserPasswordAsync(int userId, string oldPassword, string newPassword)
        {
            var user = await this.GetUserByIdAsync(userId);

            // Hash the old password and compare it to the user's current password hash
            bool oldPasswordMatches = BCrypt.Net.BCrypt.Verify(oldPassword, user.Password);
            if (!oldPasswordMatches)
            {
                throw new OldPasswordMatchedException("The old password matches the current password, try again.");
            }

            // Hash the new password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

            // Set the user's password to the hashed password
            user.Password = hashedPassword;

            await _userRepository.UpdateUserPasswordAsync(userId, hashedPassword);
        }

        public async Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture)
        {
            //Check the Uri/Url stuff tomorrow, too late today - Check in GP tommorow
            if (!Uri.TryCreate(newUrlPicture, UriKind.Absolute, out Uri uriResult) || !(uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                throw new EntityNotValidException("Invalid URL format");
            }
            await _userRepository.UpdateUserUrlPictureAsync(userId, newUrlPicture);
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await this.GetUserByIdAsync(id);
            if (user != null)
            {
                await _userRepository.DeleteUserAsync(id);
            }
            else
            {
                throw new EntityNotFoundException($"User not found.");
            }
        }

    }
}

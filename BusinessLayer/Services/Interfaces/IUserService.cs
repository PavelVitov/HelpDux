using BusinessLayer.DTOs;
using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UserDTO> GetUserByUsernameAsync(string username);
        Task<UserDTO> GetUserByEmailAsync(string email);
        Task CreateUserAsync(UserDTO userDTO);
        Task UpdateUserUsernameAsync(int userId, string newUsername);
        Task UpdateUserPasswordAsync(int userId, string oldPassword, string newPassword);
        Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture);
        Task DeleteUserAsync(int id);
    }
}

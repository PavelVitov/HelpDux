using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByUsernameAsync(string name);
        Task<User> GetUserByEmailAsync(string email);
        Task CreateUserAsync(User user);
        Task UpdateUserUsernameAsync(int userId, string newUsername);
        Task UpdateUserPasswordAsync(int userId, string oldPassword, string newPassword);
        Task UpdateUserUrlPictureAsync(int userId, string newUrlPicture);
        Task DeleteUserAsync(int id);
    }
}

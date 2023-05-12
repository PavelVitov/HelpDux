using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using BusinessLayer.DTOs;

namespace BusinessLayer.Services.Interfaces
{
    public interface IWebsiteService
    {
        Task<IEnumerable<WebsiteDTO>> GetAllWebsitesAsync();
        Task<WebsiteDTO> GetWebsiteByIdAsync(int id);
        Task<WebsiteDTO> GetWebsiteByNameAsync(string name);
        Task<WebsiteDTO> GetWebsiteByUrlAsync(string url);
        Task CreateWebsiteAsync(WebsiteDTO website);
        Task UpdateWebsiteDescriptionAsync(int websiteId, string newDescription);
        Task DeleteWebsiteAsync(int id);
    }
}

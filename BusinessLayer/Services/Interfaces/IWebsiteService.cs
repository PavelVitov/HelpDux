using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interfaces
{
    public interface IWebsiteService
    {
        Task<IEnumerable<Website>> GetAllWebsitesAsync();
        Task<Website> GetWebsiteByIdAsync(int id);
        Task<Website> GetWebsiteByNameAsync(string name);
        Task<Website> GetWebsiteByUrlAsync(string url);
        Task CreateWebsiteAsync(Website website);
        Task UpdateWebsiteDescriptionAsync(int websiteId, string newDescription);
        Task DeleteWebsiteAsync(int id);
    }
}

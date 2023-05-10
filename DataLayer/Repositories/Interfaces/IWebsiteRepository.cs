using DataLayer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interfaces
{
    public interface IWebsiteRepository
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

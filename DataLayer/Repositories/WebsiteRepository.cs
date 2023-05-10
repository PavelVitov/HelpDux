using DataLayer.Models;
using DataLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class WebsiteRepository : IWebsiteRepository
    {
        private readonly HelpDuxDbContext _websites;

        public WebsiteRepository(HelpDuxDbContext websites)
        {
            this._websites = websites;
        }

        public async Task<IEnumerable<Website>> GetAllWebsitesAsync()
        {
            return await _websites.Websites.ToListAsync();
        }

        public async Task<Website> GetWebsiteByIdAsync(int id)
        {
            return await _websites.Websites.FirstOrDefaultAsync(w => w.WebsiteId == id);
        }

        public async Task<Website> GetWebsiteByNameAsync(string name)
        {
            return await _websites.Websites.FirstOrDefaultAsync(w => w.Name == name);
        }

        public async Task<Website> GetWebsiteByUrlAsync(string url)
        {
            return await _websites.Websites.FirstOrDefaultAsync(w => w.Url == url);
        }

        public async Task CreateWebsiteAsync(Website website)
        {
            await _websites.Websites.AddAsync(website);
            await _websites.SaveChangesAsync();
        }

        public async Task UpdateWebsiteDescriptionAsync(int websiteId, string newDescription)
        {
            Website websiteToUpdate = await _websites.Websites.FindAsync(websiteId);
            websiteToUpdate.Description = newDescription;
            websiteToUpdate.UpdatedAt = DateTime.UtcNow;
            await _websites.SaveChangesAsync();
        }

        public async Task DeleteWebsiteAsync(int id)
        {
            Website websiteToDelete = await _websites.Websites.FindAsync(id);
            if (websiteToDelete != null)
            {
                _websites.Websites.Remove(websiteToDelete);
                await _websites.SaveChangesAsync();
            }         
        }

    }
}

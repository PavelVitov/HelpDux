using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
using DataLayer.Models.Exceptions;
using DataLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class WebsiteService : IWebsiteService
    {
        private readonly IWebsiteRepository _websiteRepository;
        public WebsiteService(IWebsiteRepository websiteRepository)
        {
            this._websiteRepository = websiteRepository;
        }   

        public async Task<IEnumerable<Website>> GetAllWebsitesAsync()
        {
            return await _websiteRepository.GetAllWebsitesAsync();
        }

        public async Task<Website> GetWebsiteByIdAsync(int id)
        {
            Website website = await _websiteRepository.GetWebsiteByIdAsync(id);
            if (website == null)
            {
                throw new EntityNotFoundException("Website not found.");
            }
            return website;
        }

        public async Task<Website> GetWebsiteByNameAsync(string name)
        {
            Website website = await _websiteRepository.GetWebsiteByNameAsync(name);
            if (website == null)
            {
                throw new EntityNotFoundException("Website not found.");
            }
            return website;
        }

        public async Task<Website> GetWebsiteByUrlAsync(string url)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
            {
                throw new EntityNotValidException("Invalid URL");
            }

            return await _websiteRepository.GetWebsiteByUrlAsync(url);
        }

        public async Task CreateWebsiteAsync(Website website)
        {
            if (website == null)
            {
                throw new EntityNotFoundException("Website cannot be null");
            }

            if (!Uri.IsWellFormedUriString(website.Url, UriKind.Absolute))
            {
                throw new EntityNotValidException("Invalid URL format.");
            }

            await _websiteRepository.CreateWebsiteAsync(website);
        }

        public async Task UpdateWebsiteDescriptionAsync(int websiteId, string newDescription)
        {
            if (string.IsNullOrEmpty(newDescription))
            {
                throw new EntityNotFoundException("The new description cannot be null or empty.");
            }

            await _websiteRepository.UpdateWebsiteDescriptionAsync(websiteId, newDescription);
        }
       
        public async Task DeleteWebsiteAsync(int id)
        {
            await _websiteRepository.GetWebsiteByIdAsync(id);
            await _websiteRepository.DeleteWebsiteAsync(id);
        }
    }
}

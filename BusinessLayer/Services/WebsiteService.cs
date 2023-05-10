﻿using BusinessLayer.Services.Interfaces;
using DataLayer.Models;
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

        public Task CreateWebsiteAsync(Website website)
        {
            throw new NotImplementedException();
        }

        public Task DeleteWebsiteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Website>> GetAllWebsitesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Website> GetWebsiteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Website> GetWebsiteByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Website> GetWebsiteByUrlAsync(string url)
        {
            throw new NotImplementedException();
        }

        public Task UpdateWebsiteDescriptionAsync(int websiteId, string newDescription)
        {
            throw new NotImplementedException();
        }
    }
}

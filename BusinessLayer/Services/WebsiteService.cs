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
    public class WebsiteService : IWebsiteService
    {
        private readonly IWebsiteRepository _websiteRepository;
        private readonly IMapper _mapper;

        public WebsiteService(IWebsiteRepository websiteRepository, IMapper mapper)
        {
            this._websiteRepository = websiteRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<WebsiteDTO>> GetAllWebsitesAsync()
        {
            var websites = await _websiteRepository.GetAllWebsitesAsync();
            return _mapper.Map<IEnumerable<WebsiteDTO>>(websites);
        }

        public async Task<WebsiteDTO> GetWebsiteByIdAsync(int id)
        {
            var website = await _websiteRepository.GetWebsiteByIdAsync(id);
            if (website == null)
            {
                throw new EntityNotFoundException("Website not found.");
            }
            return _mapper.Map<WebsiteDTO>(website);
        }

        public async Task<WebsiteDTO> GetWebsiteByNameAsync(string name)
        {
            Website website = await _websiteRepository.GetWebsiteByNameAsync(name);
            if (website == null)
            {
                throw new EntityNotFoundException("Website not found.");
            }
            return _mapper.Map<WebsiteDTO>(website);
        }

        public async Task<WebsiteDTO> GetWebsiteByUrlAsync(string url)
        {
            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
            {
                throw new EntityNotValidException("Invalid URL");
            }

            var website = await _websiteRepository.GetWebsiteByUrlAsync(url);
            return _mapper.Map<WebsiteDTO>(website);
        }

        public async Task CreateWebsiteAsync(WebsiteDTO websiteDto)
        {
            if (websiteDto == null)
            {
                throw new EntityNotFoundException("Website cannot be null");
            }

            if (!Uri.IsWellFormedUriString(websiteDto.Url, UriKind.Absolute))
            {
                throw new EntityNotValidException("Invalid URL format.");
            }

            var website = _mapper.Map<Website>(websiteDto);
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

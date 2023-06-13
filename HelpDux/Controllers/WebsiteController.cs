using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebLayer_HelpDux.Models.Website;

namespace WebLayer_HelpDux.Controllers
{
    public class WebsiteController : Controller
    {
        public readonly IWebsiteService _websiteService;
        private readonly IMapper _mapper;

        public WebsiteController(IWebsiteService websiteService, IMapper mapper)
        {
            this._websiteService = websiteService;
            this._mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var websites = await _websiteService.GetAllWebsitesAsync();
            var websiteModels = _mapper.Map<IEnumerable<WebsiteMVC>>(websites);
            return View(websiteModels);

        }
    }
}

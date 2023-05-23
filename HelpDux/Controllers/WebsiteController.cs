using BusinessLayer.DTOs;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebLayer_HelpDux.Controllers
{
    public class WebsiteController : Controller
    {
        public readonly IWebsiteService _websiteService;

        public WebsiteController(IWebsiteService websiteService)
        {
            this._websiteService = websiteService;
        }
        public async Task<IActionResult> Index()
        {
            var websites = await _websiteService.GetAllWebsitesAsync();
            return View(websites);
        }
    }
}

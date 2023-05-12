using BusinessLayer.DTOs;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebLayer_HelpDux.Controllers
{
    public class WebsiteController : Controller
    {
        public readonly IWebsiteService _websiteService;

        public WebsiteController(IWebsiteService websiteService)
        {
            this._websiteService = websiteService;
        }


        public async IActionResult Index()
        {
            IEnumerable<WebsiteDTO> websites = await this._websiteService.GetAllWebsitesAsync();

            return this.View();
        }
    }
}

using BusinessLayer.Services.Interfaces;
using DataLayer.Models.Exceptions;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BusinessLayer.DTOs;

namespace WebLayer_HelpDux.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            return this.View();
        }

        public async Task<IActionResult> Profile()
        {
            return this.View();
        }

        
    }
}


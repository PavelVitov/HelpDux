using BusinessLayer.Services.Interfaces;
using DataLayer.Models.Exceptions;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BusinessLayer.DTOs;
using System.Collections.Generic;
using WebLayer_HelpDux.Models.User;
using AutoMapper;

namespace WebLayer_HelpDux.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            List<UserDTO> userDtos = await _userService.GetAllUsersAsync();
            List<UserMVC> users = _mapper.Map<List<UserMVC>>(userDtos);

            return View(users);
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int id)
        {
            UserDTO userDto = await _userService.GetUserByIdAsync(id);
            UserMVC user = _mapper.Map<UserMVC>(userDto);

            return View(user);
        }

    }
}


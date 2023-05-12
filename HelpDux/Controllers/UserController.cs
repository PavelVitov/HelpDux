using BusinessLayer.Services.Interfaces;
using DataLayer.Models.Exceptions;
using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            var users = await _userService.GetAllUsersAsync();
            return View(users);
        }

        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                return View(user);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _userService.CreateUserAsync(user);
                    return RedirectToAction(nameof(Index));
                }
                catch (EntityNotValidException)
                {
                    ModelState.AddModelError("User.Email", "The email address is not valid.");
                }
                catch (DuplicateEntityFoundException)
                {
                    ModelState.AddModelError("User.Username", "The username is already taken.");
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                return View(user);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _userService.UpdateUserUsernameAsync(id, user.Username);
                    await _userService.UpdateUserUrlPictureAsync(id, user.PictureUrl);
                    return RedirectToAction(nameof(Index));
                }
                catch (DuplicateEntityFoundException)
                {
                    ModelState.AddModelError("User.Username", "The username is already taken.");
                }
                catch (EntityNotValidException)
                {
                    ModelState.AddModelError("User.UrlPicture", "The URL is not valid.");
                }
                catch (EntityNotFoundException)
                {
                    return NotFound();
                }
            }

            return View(user);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var user = await _userService.GetUserByIdAsync(id);
                return View(user);
            }
            catch (EntityNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _userService.DeleteUserAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}


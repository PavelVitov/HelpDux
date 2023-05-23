using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebLayer_HelpDux.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult AboutUs()
        {
            return this.View();
        }

        public IActionResult ContactUs()
        {
            return this.View();
        }
    }
}

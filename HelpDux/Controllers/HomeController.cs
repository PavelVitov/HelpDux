using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebLayer_HelpDux.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult AboutUs()
        {
            return this.View();
        }

        public ActionResult ContactUs()
        {
            return this.View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Part1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Return the home view
            return View();
        }

        public IActionResult About()
        {
            // Return the about view
            return View();
        }
    }
}

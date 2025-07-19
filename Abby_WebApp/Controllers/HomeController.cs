using Microsoft.AspNetCore.Mvc;

namespace Abby_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

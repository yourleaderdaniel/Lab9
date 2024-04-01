using Microsoft.AspNetCore.Mvc;

namespace Lab92.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }
    }
}

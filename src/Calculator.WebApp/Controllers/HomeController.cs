using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebApp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

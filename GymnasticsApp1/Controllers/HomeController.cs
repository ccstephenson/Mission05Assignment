using Microsoft.AspNetCore.Mvc;

namespace GymnasticsApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
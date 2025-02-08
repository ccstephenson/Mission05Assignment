using Microsoft.AspNetCore.Mvc;

namespace GymnasticsApp1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
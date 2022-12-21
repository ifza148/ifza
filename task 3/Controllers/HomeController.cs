using Microsoft.AspNetCore.Mvc;

namespace task_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

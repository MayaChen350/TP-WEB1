using Microsoft.AspNetCore.Mvc;

namespace TP_WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TP_WEB.Controllers
{
    public class EnfantController : Controller
    {
        public IActionResult Recherche()
        {
            return View();
        }  
        
        public IActionResult Detail()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TP_WEB.Models;

namespace TP_WEB.Controllers
{
    public class HomeController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public HomeController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
            return View(_baseDeDonnees.Rosters.ToList());
        }
    }
}

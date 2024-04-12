using Microsoft.AspNetCore.Mvc;
using TP_WEB.Models;

namespace TP_WEB.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public EnfantController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Recherche()
        {
            return View(_baseDeDonnees.Personnages.ToList());
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}

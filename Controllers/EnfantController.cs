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

        public IActionResult Detail(int id)
        {
            var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Id == id).SingleOrDefault();
            if (personnageRecherché == null)
            {
                return View("NonTrouvé", "Il n'y a malheureusement que 12 personnages sur ce site, réessayez avec 5 par exemple, mais pas en haut de 12.");
            }
            else
            {
                return View(personnageRecherché);
            }

            return View();
        }
    }
}

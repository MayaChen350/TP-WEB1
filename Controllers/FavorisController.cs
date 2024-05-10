using Microsoft.AspNetCore.Mvc;
using TP_WEB.Extensions;
using TP_WEB.Models;

namespace TP_WEB.Controllers
{
    public class FavorisController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public FavorisController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        public IActionResult Index()
        {
            List<int> list = HttpContext.Session.Get<List<int>>("enfantIds");
            return View(_baseDeDonnees.Personnages.Take(3).ToList());
        }

        // public IActionResult AjouterUnEnfant(int id) { }

        //public IActionResult SupprimerUnEnfant(int id) { }

    }
}

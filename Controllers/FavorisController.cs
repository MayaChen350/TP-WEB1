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
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIds");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            var enfantsDeLaBD = _baseDeDonnees.Personnages.Where(e => enfantIDs.Contains(e.Id)).ToList();

            return View(enfantsDeLaBD);
        }

        public IActionResult AjouterUnEnfant(int id)
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIds");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            if (!enfantIDs.Contains(id))
                enfantIDs.Add(id);

            HttpContext.Session.Set("enfantIds", enfantIDs);

            return Redirect("index");

        }

        public IActionResult SupprimerUnEnfant(int id)
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIds");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            if (enfantIDs.Contains(id))
            enfantIDs.Remove(id);

            HttpContext.Session.Set("enfantIds", enfantIDs);

            return Redirect("index");

        }

    }
}

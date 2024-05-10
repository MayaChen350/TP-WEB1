using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_WEB.Extensions;
using TP_WEB.Models;

namespace TP_WEB.Controllers
{
    public class GestionEnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public GestionEnfantController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Id == id).SingleOrDefault();

            if (personnageRecherché != null)
                return View(personnageRecherché);
            else
                return View("NonTrouvé", "Ce personnage n'est pas présent.");
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Id == id).Single();
                personnageRecherché.Roster.Personnages.Remove(personnageRecherché);
                _baseDeDonnees.Personnages.Remove(personnageRecherché);
                return RedirectToAction("Index", "Home");

            }
            catch
            {
                return View();
            }
        }
    }
}

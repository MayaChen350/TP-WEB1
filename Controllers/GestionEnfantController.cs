using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [Route("/GestionEnfant/Delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Id == id).SingleOrDefault();

            if (personnageRecherché != null)
                return View(personnageRecherché);
            else
                return View("NonTrouvé", "Il n'y a malheureusement que 12 personnages sur ce site, ce personnage n'est probablement pas là.");
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using TP_WEB.Models;
using TP_WEB.ViewModels;

namespace TP_WEB.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public EnfantController(BaseDeDonnees baseDeDonnees)
        {
            _baseDeDonnees = baseDeDonnees;
        }

        [Route("enfant/recherche")]
        public IActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.AvecLyn = true;
            model.Criteres.AvecEliwood = true;
            model.Criteres.AvecHector = true;
            model.Resultat = _baseDeDonnees.Personnages.ToList();
            return View(model);
        }

        [Route("enfant/detail/{id:int}")]
        [Route("enfant/{id:int}")]
        [Route("{id:int}")]
        public IActionResult DetailParID(int? id)
        {
            if (id == null)
            {
                return View("NonTrouvé", "Cette adresse de page n'est pas correct. S'il vous plaît revenez en arrière et réessayer quelque chose d'autre.");
            }

            var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Id == id).SingleOrDefault();

            if (personnageRecherché == null)
            {
                return View("NonTrouvé", "Il n'y a malheureusement que 12 personnages sur ce site, ce personnage n'est probablement pas là.");
            }
            else
            {
                return View("Detail", personnageRecherché);
            }
        }

        [Route("enfant/detail/{nom?}")]
        [Route("enfant/{nom?}")]
        [Route("{nom}")]
        public IActionResult DetailParNom(string? nom)
        {
            if (nom == null)
            {
                return View("NonTrouvé", "Cette adresse de page n'est pas correct. S'il vous plaît revenez en arrière et réessayer quelque chose d'autre.");
            }

            var personnageRecherché = _baseDeDonnees.Personnages.Where(p => p.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();

            if (personnageRecherché == null)
            {
                return View("NonTrouvé", "Il n'y a malheureusement que 12 personnages sur ce site, ce personnage n'est probablement pas là.");
            }
            else
            {
                return View("Detail", personnageRecherché);
            }
        }
    }
}

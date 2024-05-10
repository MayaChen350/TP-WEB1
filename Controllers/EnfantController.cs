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

        [Route("enfant/filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            if (criteres == null || criteres.MotCles == null)
                return RedirectToAction("Recherche");

            IEnumerable<Personnage> donnees = _baseDeDonnees.Personnages;
            
            if (criteres.MotCles[0] != null)
                foreach (string motCle in criteres.MotCles)
                        donnees = donnees.Where(p => p.Nom.ToLower().Contains(motCle.ToLower()) || p.Roster.Nom.ToLower().Contains(motCle.ToLower()) || p.LigneArmes.ToLower().Contains(motCle.ToLower()) || p.LigneClasses.ToLower().Contains(motCle.ToLower()) || p.Citation.ToLower().Contains(motCle.ToLower()) || p.SourceImagePrincipal.ToLower().Contains(motCle.ToLower()));

            if (criteres.StatsMax != null)
                donnees = donnees.Where(p => p.StatsDeBaseTotaux < criteres.StatsMax);
            if (criteres.StatsMin != null)
                donnees = donnees.Where(p => p.StatsDeBaseTotaux > criteres.StatsMin);


            switch (criteres.PersonnageVedette)
            {
                case enumPersonnageVedette.Non:
                    donnees = donnees.Where(p => !p.PersonnageVedette);
                    break;
                case enumPersonnageVedette.Oui:
                    donnees = donnees.Where(p => p.PersonnageVedette);
                    break;
                default: // case enumPersonnageVedette.PeuImporte:
                    break;
            }

            donnees = donnees.Where(p => (criteres.AvecLyn && p.Roster.Id == 1) || (criteres.AvecEliwood && p.Roster.Id == 2) || (criteres.AvecHector && p.Roster.Id == 3));

            PageRechercheViewModel filtre = new PageRechercheViewModel() { Criteres = criteres, Resultat = donnees.ToList() };

            return View(filtre);

        }
    }
}

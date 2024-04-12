using TP_WEB.Models;

namespace TP_WEB.ViewModels
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }

        public List<Personnage> Resultat { get; set; }
    }
}

namespace TP_WEB.ViewModels
{
    public class CritereRechercheViewModel
    {
        public List<string>? MotCles { get; set; }

        public string LigneMotCles
        {
            get
            {
                if (MotCles == null)
                    return null;

                string ligneMots = "";
                foreach (string mot in MotCles)
                    if (mot != null)
                        ligneMots += mot + " ";
                return ligneMots.Trim();
            }
        }

        public int? StatsMax { get; set; }

        public int? StatsMin { get; set; }

        public enumPersonnageVedette PersonnageVedette { get; set; }

        public bool AvecLyn { get; set; }

        public bool AvecEliwood { get; set; }

        public bool AvecHector { get; set; }

        public string CheckedOuNon(bool avecQui) => avecQui ? "checked" : "";

        public string SelectedOuNon(enumPersonnageVedette etatPersonnageVedette) => etatPersonnageVedette == PersonnageVedette ? "selected" : "";
    }
}

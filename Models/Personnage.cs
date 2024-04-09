namespace TP_WEB.Models
{
    public class Personnage
    {
        public int Id { get; set; }

        public int IdParent { get; set; }

        public Roster Roster { get; set; }

        public string Nom { get; set; }

        public bool PersonnageVedette { get; set; }

        public string ChaineClasses { get; set; }

        public string[] Classes
        {
            get => ChaineClasses.Split(',');
        }

        public string ChaineArmesUtilisees { get; set; }

        public string[] ArmesUtilisees
        {
            get => ChaineArmesUtilisees.Split(',');
        }

        public string Citation { get; set; }

        public string LienImage
        {
            get => $"/images/{Nom}.jpg";
        }

        public string LienGif
        {
            get => $"/images/{Nom}_Action.gif";
        }

        public string SourceImagePrincipal { get; set; }

        public string LienSourceImage { get; set; }
    }
}

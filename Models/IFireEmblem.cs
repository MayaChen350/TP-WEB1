namespace TP_WEB.Models
{
    /// <summary>
    /// Utilisé pour _CreditsPartial. Contient des propriétés communs aux rosters et aux personnages.
    /// </summary>
    public interface IFireEmblem
    {
        public string Nom { get; set; }
        public int Id { get; set; }
        public string SourceImagePrincipal { get; set; }
        public string LienSourceImage { get; set; }
    }
}

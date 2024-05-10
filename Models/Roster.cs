namespace TP_WEB.Models
{
    /// <summary>
    /// Roster d'un personnage principal.
    /// </summary>
    public class Roster : IFireEmblem
    {
        /// <summary>
        /// Id du roster.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Liste de personnages du roster.
        /// </summary>
        public List<Personnage> Personnages { get; set; }

        /// <summary>
        /// Nom du principal personnage associé au roster.
        /// </summary>
        public string Nom { get; set; }

        public string Description { get; set; }

        /// <summary>
        /// Lien vers l'image utilisée pour le roster.
        /// </summary>
        public string LienImage
        {
            get => $"/images/Cutscenes/{Nom}_Cutscene.png";
        }

        /// <summary>
        /// La source de l'image utilisée pour le roster.
        /// </summary>
        public string SourceImagePrincipal { get; set; }

        /// <summary>
        /// Le lien vers la source de l'image utilisée pour le roster.
        /// </summary>
        public string LienSourceImage { get; set; }
    }
}
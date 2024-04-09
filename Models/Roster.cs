namespace TP_WEB.Models
{
    /// <summary>
    /// Roster d'un personnage principal.
    /// </summary>
    public class Roster
    {
        public int Id { get; set; }

        public List<Personnage> Personnages { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }
    }
}
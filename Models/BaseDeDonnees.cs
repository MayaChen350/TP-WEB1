using System.Numerics;

namespace TP_WEB.Models
{
    public class BaseDeDonnees
    {
        public List<Personnage> Personnages { get; set; }

        public List<Roster> Rosters { get; set; }

        public BaseDeDonnees()
        {


            Rosters = new List<Roster>
            {
                new Roster() {Id = 1, Nom = "Lyn", Description = "Lyn, aussi connue sous le nom de Lyndis, est une épeiste solitaire qui a vécu avec sa tribu jusqu'à ce que celle-ci se fasse décimé par des bandits.\r\n\r\nElle apprend par la suite qu'elle est la petite fille du Seigneur Hausen de Caelin. Durant la quête de Lyn pour secourir son grand pêre elle rencontre plusieurs personnages pour l'aider tel que Sain et Kent." },
                new Roster() {Id = 2, Nom = "Eliwood", Description = "Eliwood est un enfant de nobles de la maison de Pharae. Eliwood est ami avec Hector depuis qu'il est tout petit, ceux-ci se combattant depuis l'âge de douze ans à tout les deux mois, comme les traditions l'exigent. Eliwood rejoint Lyn dans sa quête pour reprendre Caelin.\r\n\r\n1 an après les évènements de Caelin, des rumeurs circule sur la disparation et la mort de son père, ce qui l'incite à vérifier ces rumeurs. Lui et sa troupe de soldat font face aux Black Fangs, un groupe d'assassins et de mercenaires apparemment responsable de tout ça." },
                new Roster() {Id = 3, Nom = "Lyn", Description = "Hector est le prince d'Ostia. Il devient marquis à un jeune âge, du fait de ses parents mourant de maladies. Hector fait un pacte avec Eliwood l'obligeant à se combattre contre lui à chaque 2 mois, forgeant leur amitié.\r\n\r\nHector aide Lyn et Eliwood dans leur quêtes. Durant leur périple, Hector accepte l'épreuve pour obtenir la hache légendaire Armads. Après de lourds efforts, Hector se retrouve digne de la hache légendaire, mais cette hache a un point négatif, elle le maudit à \"mourrir non paisiblement, mais en combat\". Hector, sachant cela, acquiert quand même Armads car il veut tout faire pour aider Eliwood." }
            };

            Personnages = new List<Personnage>
            {
                new Personnage() { Id = 1, IdParent = 1, Nom = "Lyn", PersonnageVedette = true, ChaineClasses = "Lord,Blade Lord", ChaineArmesUtilisees = "Épées,Arc", Citation = "As if I'd lose!", SourceImagePrincipal = "Fanart par kaejunni.",  LienSourceImage = "https://danbooru.donmai.us/posts/3292291" },
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage(),
                new Personnage()
            };

            foreach (var r in Rosters)
            {
                r.Personnages = new List<Personnage>();
                r.Personnages.AddRange(Personnages.Where(p => p.IdParent == r.Id));
            }

            foreach (var p in Personnages)
            {
                p.Roster = Rosters.Where(r => r.Id == p.IdParent).Single();
            }
        }
    }
}

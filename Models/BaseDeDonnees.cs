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
                new Roster() {Id = 1, Nom = "Lyn", Description = "Lyn, aussi connue sous le nom de Lyndis, est une épeiste solitaire qui a vécu avec sa tribu jusqu'à ce que celle-ci se fasse décimé par des bandits.\r\n\r\nElle apprend par la suite qu'elle est la petite fille du Seigneur Hausen de Caelin. Durant la quête de Lyn pour secourir son grand pêre elle rencontre plusieurs personnages pour l'aider tel que Sain et Kent.", SourceImagePrincipal = "Artwork #4 officiel de Fire Emblem 7 venant du jeu.",  LienSourceImage = "https://serenesforest.net/blazing-sword/miscellaneous/cgs/"  },

                new Roster() {Id = 2, Nom = "Eliwood", Description = "Eliwood est un enfant de nobles de la maison de Pharae. Eliwood est ami avec Hector depuis qu'il est tout petit, ceux-ci se combattant depuis l'âge de douze ans à tout les deux mois, comme les traditions l'exigent. Eliwood rejoint Lyn dans sa quête pour reprendre Caelin.\r\n\r\n1 an après les évènements de Caelin, des rumeurs circule sur la disparation et la mort de son père, ce qui l'incite à vérifier ces rumeurs. Lui et sa troupe de soldat font face aux Black Fangs, un groupe d'assassins et de mercenaires apparemment responsable de tout ça.", SourceImagePrincipal = "Artwork #12 officiel de Fire Emblem 7 venant du jeu.",  LienSourceImage = "https://serenesforest.net/blazing-sword/miscellaneous/cgs/"   },

                new Roster() {Id = 3, Nom = "Hector", Description = "Hector est le prince d'Ostia. Il devient marquis à un jeune âge, du fait de ses parents mourant de maladies. Hector fait un pacte avec Eliwood l'obligeant à se combattre contre lui à chaque 2 mois, forgeant leur amitié.\r\n\r\nHector aide Lyn et Eliwood dans leur quêtes. Durant leur périple, Hector accepte l'épreuve pour obtenir la hache légendaire Armads. Après de lourds efforts, Hector se retrouve digne de la hache légendaire, mais cette hache a un point négatif, elle le maudit à \"mourrir non paisiblement, mais en combat\". Hector, sachant cela, acquiert quand même Armads car il veut tout faire pour aider Eliwood.", SourceImagePrincipal = "Artwork #14 officiel de Fire Emblem 7 venant du jeu.",  LienSourceImage = "https://serenesforest.net/blazing-sword/miscellaneous/cgs/"   }
            };

            Personnages = new List<Personnage>
            {
                new Personnage() { Id = 1, IdParent = 1, Nom = "Lyn", PersonnageVedette = true, ChaineClasses = "Lord,Blade Lord", ChaineArmesUtilisees = "Épée,Arc", Citation = "As if I'd lose!", SourceImagePrincipal = "Fanart par kaejunni.",  LienSourceImage = "https://danbooru.donmai.us/posts/3292291" },

                new Personnage() { Id = 2, IdParent = 1, Nom = "Sain", PersonnageVedette = false, ChaineClasses = "Cavalier,Paladin", ChaineArmesUtilisees = "Lance,Épée,Hache", Citation = "I won't hold back! This is for all the lovely ladies I've yet to meet!!", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Nekobayash.",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Sain/Gallery?file=B07-014N_artwork.png" },

                new Personnage() { Id = 3, IdParent = 1, Nom = "Kent", PersonnageVedette = false, ChaineClasses = "Cavalier,Paladin", ChaineArmesUtilisees = "Épée,Lance,Hache", Citation = "I will gladly volunteer to protect Lycia with my life.", SourceImagePrincipal = "Artwork #4 officiel de Fire Emblem 7 venant du jeu, découpé sur Kent.",  LienSourceImage = "https://serenesforest.net/blazing-sword/miscellaneous/cgs/" },

                new Personnage() { Id = 4, IdParent = 1, Nom = "Wallace", PersonnageVedette = false, ChaineClasses = "Knight,General", ChaineArmesUtilisees = "Lance,Hache", Citation = "I'm trembling with anticipation!", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Mineri.",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Wallace/Gallery?file=B21-060HN_artwork.png" },

                new Personnage() { Id = 5, IdParent = 2, Nom = "Eliwood", PersonnageVedette = true, ChaineClasses = "Lord,Knight Lord", ChaineArmesUtilisees = "Épée,Lance", Citation = "I know that I've caused much pain for my friends. But that is why... I will not lose here today!!", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Sachiko Wada.",  LienSourceImage = "https://serenesforest.net/2016/11/11/cipher-s7-weekly-recap-new-reveals-and-text-free-artwork/" },

                new Personnage() { Id = 6, IdParent = 2, Nom = "Marcus", PersonnageVedette = false, ChaineClasses = "Paladin", ChaineArmesUtilisees = "Épée,Lance,Hache", Citation = "I'll show you the strength of a knight of Pherae.", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Sachie.",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Marcus/Gallery?file=S10-005ST_artwork.png" },

                new Personnage() { Id = 7, IdParent = 2, Nom = "Lowen", PersonnageVedette = false, ChaineClasses = "Cavalier,Paladin", ChaineArmesUtilisees = "Épée,Lance,Hache", Citation = "Knights should fight, not speak! ...Was that right?", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Matsun (まっつん).",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Lowen?file=B13-018N_artwork.png#Fire_Emblem_0_(Cipher)" },

                new Personnage() { Id = 8, IdParent = 2, Nom = "Isadora", PersonnageVedette = false, ChaineClasses = "Paladin", ChaineArmesUtilisees = "Épée,Lance,Hache", Citation = "My pride shall not be broken! My strength holds true!", SourceImagePrincipal = "Image créee par intelligence artificiel, généré par la demande de l'utilisateur LordOtako sur Civitai.",  LienSourceImage = "https://civitai.com/images/2730039" },

                new Personnage() { Id = 9, IdParent = 3, Nom = "Hector", PersonnageVedette = true, ChaineClasses = "Lord,Great Lord", ChaineArmesUtilisees = "Hache,Épée", Citation = "Me? Don't worry about me. I'm fine. I'm built tough, you know. A little too much is just enough for me.", SourceImagePrincipal = "Image créee par intelligence artificiel sur PixAI.",  LienSourceImage = "https://pixai.art/model/1678066113063153096?lang=fr" },

                new Personnage() { Id = 10, IdParent = 3, Nom = "Matthew", PersonnageVedette = false, ChaineClasses = "Thief,Assassin", ChaineArmesUtilisees = "Épée", Citation = "Let me handle this! There is much I can do.", SourceImagePrincipal = "Fanart sur Deviantart.com par Fishenode.",  LienSourceImage = "https://www.deviantart.com/fishenod/art/Ositia-s-Best-392523031" },

                new Personnage() { Id = 11, IdParent = 3, Nom = "Serra", PersonnageVedette = false, ChaineClasses = "Cleric,Bishop", ChaineArmesUtilisees = "Bâton de guérison", Citation = "Blessed Saint Elimine, grant us the strength to win this with ease.", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par 40hara.",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Serra/Gallery?file=B07-018N_artwork.png" },

                new Personnage() { Id = 12, IdParent = 3, Nom = "Oswin", PersonnageVedette = false, ChaineClasses = "Knight,General", ChaineArmesUtilisees = "Lance,Hache", Citation = "For the honor of the knights of Ostia.", SourceImagePrincipal = "Artwork pour le jeu Fire Emblem Cipher par Yoneko.",  LienSourceImage = "https://fireemblem.fandom.com/wiki/Oswin?file=B07-027N_artwork.png" }
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

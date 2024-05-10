using System.Reflection;

namespace TP_WEB.Models
{
    /// <summary>
    /// Personnage de Fire Emblem 7 d'un roster.
    /// </summary>
    public class Personnage : IFireEmblem
    {
        private string chaineArmesUtilisees;

        private string chaineClasses;

        /// <summary>
        /// Id du personnage.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id du parent du personnage.
        /// </summary>
        public int IdParent { get; set; }

        /// <summary>
        /// Le roster à laquel ce personnage appartient.
        /// </summary>
        public Roster Roster { get; set; }

        /// <summary>
        /// Le nom du personnage.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Stats de bases totaux du personnage.
        /// </summary>
        public int StatsDeBaseTotaux { get; set; }

        /// <summary>
        /// Si le personnage est un personnage vedette ou non.
        /// </summary>
        public bool PersonnageVedette { get; set; }

        /// <summary>
        /// Ligne de toutes les classes possibles séparés par une virgule.
        /// </summary>
        public string ChaineClasses
        {
            set
            {
                chaineClasses = value;
            }
        }

        /// <summary>
        /// Liste des classes possibles du personnage.
        /// </summary>
        public string[] Classes
        {
            get => chaineClasses.Split(',');
        }

        /// <summary>
        /// Retourne une ligne avec toutes les classes.
        /// </summary>
        public string LigneClasses
        {
            get
            {
                string ligne = "";
                for (int i = 0; i < Classes.Length; i++)
                {
                    ligne += Classes[i];
                    if (i != Classes.Length - 1)
                        ligne += ", ";
                }
                return ligne;
            }
        }

        /// <summary>
        /// Ligne de toutes les armes utilisés séparés par une virgule.
        /// </summary>
        public string ChaineArmesUtilisees
        {
            set
            {
                chaineArmesUtilisees = value;
            }
        }


        /// <summary>
        /// Liste des armes utilisées par le personnage.
        /// </summary>
        public string[] ArmesUtilisees
        {
            get => chaineArmesUtilisees.Split(',');
        }


        /// <summary>
        /// Retourne une ligne avec toutes les armes utilisées.
        /// </summary>
        public string LigneArmes
        {
            get
            {
                string ligne = "";
                for (int i = 0; i < ArmesUtilisees.Length; i++)
                {
                    ligne += ArmesUtilisees[i];
                    if (i != ArmesUtilisees.Length - 1)
                        ligne += ", ";
                }
                return ligne;
            }
        }

        /// <summary>
        /// Une citation du personnage.
        /// </summary>
        public string Citation { get; set; }

        /// <summary>
        /// Le lien vers l'image de son portrait.
        /// </summary>
        public string LienImage
        {
            get => $"/images/Portraits/{Nom}.jpg";
        }

        /// <summary>
        /// Le lien vers le gif animé du personnage.
        /// </summary>
        public string LienGif
        {
            get => $"/images/EnAction/{Nom}_Action.gif";
        }

        /// <summary>
        /// Le texte de source de l'image de portrait du personnage.
        /// </summary>
        public string SourceImagePrincipal { get; set; }

        /// <summary>
        /// Le lien vers la source de l'image de portrait du personnage.
        /// </summary>
        public string LienSourceImage { get; set; }
    }
}

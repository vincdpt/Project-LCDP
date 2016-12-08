using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PpeGSBTeam27
{
    class Visiteur
    {
         public String id_visiteur;
         public int id_secteur;
         public String nom;
         public String prenom;
         public String login;
         public String mdp;
         public String adresse;
         public String cp;
         public String ville;
         public DateTime dateEmbauche;
         public int Privileges;


        public Visiteur(String unId_visiteur, int unId_secteur, String unNom, String unPrenom, String unLogin, String unMdp, String uneAdresse, String unCp, String unVille, DateTime uneDateEmbauche, int unPrivileges)
        {
            this.id_visiteur = unId_visiteur;
            this.id_secteur = id_secteur;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.mdp = mdp;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            this.dateEmbauche = dateEmbauche;
        }

        


        #region Methode BDD
        //Méthode permettant de charger la liste d'objet visiteur
        public static List<Visiteur> chargerVis()
        {
            return DAOVisiteur.chargerVisiteur();
        }
        //envoie d'objet
        public static Boolean creerVisiteur(Visiteur vis)
        {
            return DAOVisiteur.CreerVisiteur(vis);
        }

        public static Boolean SupprimerVisiteur(Visiteur vis)
        {
            return DAOVisiteur.SupprimerVisiteur(vis);
        }

        public static Boolean ModifierVisiteur(Visiteur vis)
        {
            return DAOVisiteur.ModifierVisiteur(vis);
        }
    }
    #endregion
}

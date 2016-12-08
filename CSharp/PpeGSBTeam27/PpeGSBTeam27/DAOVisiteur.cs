using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PpeGSBTeam27
{
    class DAOVisiteur
    {
        private static DAOFactory connexion = new DAOFactory();

        public DAOVisiteur() { }

        //Méthode permettant de créer une liste d'objet Visiteur contenant les données de la base de données
        public static List<Visiteur> chargerVisiteur()
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();

            try
            {
                SqlDataReader reader;
                reader = connexion.sqlSELECT("SELECT * FROM visiteur");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Visiteur v = new Visiteur(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetDateTime(9), reader.GetInt32(10));
                        lesVisiteurs.Add(v);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesVisiteurs;

        }


        public static Boolean CreerVisiteur(Visiteur vis)
        {
            Boolean test = false;
            try
            {
                connexion.sqlCmd("INSERT INTO visiteur (id_visiteur, id_secteur, nom, prenom, login, mdp, adresse, cp, ville, dateEmbauche, Privileges) VALUES ('" + vis.id_visiteur + "', '" + vis.id_secteur + "', '" + vis.nom
                    + "', '" + vis.prenom + "', '" + vis.login + "', '" + vis.mdp + "', '" + vis.adresse + "', '" + vis.cp + "', '" + vis.ville + "', '" + vis.dateEmbauche + "', '" + vis.Privileges + "',);");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }

        public static Boolean SupprimerVisiteur(Visiteur vis)
        {
            Boolean test = false;
            try
            {
                connexion.sqlCmd("DELETE FROM visiteur WHERE id_visiteur = " + vis.id_visiteur + "");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return false;
        }

        public static Boolean ModifierVisiteur(Visiteur vis)
        {
            Boolean test = false;
            try
            {
                connexion.sqlCmd("UPDATE visiteur SET id_visiteur = '" + vis.id_visiteur + "', id_secteur = '" + vis.id_secteur + "', nom = '" +
                    vis.nom + "', prenom = '" + vis.prenom + "', login = '" + vis.login + "', mdp = '" + vis.mdp + "', adresse = '" + vis.adresse + "', cp = '" + vis.cp + "', ville = '" + vis.ville + "', dateEmbauche = '" + vis.dateEmbauche + "', Privileges = '" + vis.Privileges + "' WHERE id_visiteur = '" + vis.id_visiteur + "';");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return false;
        }



    }
}

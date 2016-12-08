using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PpeGSBTeam27
{
    class DAOProduit {

        // Récupération de touts les données dans la BDD puis création d'objets Produits, 
        // puis d'une liste contenant tous les produits crées précédemment.
        public static List<Produit> listeProduit()
        {
            DAOFactory df = new DAOFactory();
            df.connexion();
            string req = "SELECT * FROM produit;";
            List<Produit> resultat = new List<Produit>();
            // récupération des données de la requête
            try
            {
                SqlDataReader dr = df.execSql(req);

                while (dr.Read())
                {
                    Produit r = new Produit(dr.GetInt32(0), dr.GetString(1),
                        dr.GetString(2), dr.GetString(3), dr.GetString(4), dr.GetString(5),
                        dr.GetInt32(6), dr.GetDouble(7), dr.GetDouble(8), dr.GetString(9));
                    resultat.Add(r);
                }
                df.deconnexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return resultat;
        }

        // Récupére l'intégralité des familles dans la BDD, crée les objets et les stocke dans une liste.
        public static ArrayList listeFamille()
        {
            DAOFactory dfp = new DAOFactory();
            dfp.connexion();
            string req = "SELECT * FROM famille;"; // + ";"
            ArrayList lesFamilles = new ArrayList();
            // Récupération des données de la requête
            try
            {
                SqlDataReader dr = dfp.execSql(req);

                while (dr.Read())
                {
                    lesFamilles.Add(dr.GetString(1));
                }
                dfp.deconnexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return lesFamilles;
        }

        // Création d'un nouveau produit dans la BDD.
        public static string creerProduit(Produit leProduit)
        {
            string prixHT = leProduit.getPrixHT().ToString();
            string prixEch = leProduit.getPrixEch().ToString();

            DAOFactory dfp = new DAOFactory();
            Produit produit;
            //MySqlDataReader leSelect = select();
            produit = leProduit;
            string req = "set identity_insert produit ON; insert into produit(num, nom, effet, contre_indic, presentation, dosage, idFamille, prixHT, prixEchant, interactions) values(" + leProduit.getNum() + ", "
                + "'" + leProduit.getNom() + "', '" + leProduit.getEffet() + "', '" + leProduit.getCI() + "', '"
                + leProduit.getPresentation() + "', '" + leProduit.getDosage() + "', " + getIDFamille(leProduit.getFamille())
                + ", " + prixHT.Replace(',', '.') + ", " + prixEch.Replace(',', '.') + ", '" + leProduit.getInteraction() + "');";
            try
            {
                dfp.connexion();
                dfp.execSql(req);
                dfp.deconnexion();
                return "Produit crée";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "Erreur dans la création du produit";
            }
        }

        //Permet la récupération d'un nom de famille de produit avec son id en passant par la BDD.
        public static string getNomFamille(int idFamille)
        {
            string resultat = null;
            DAOFactory dfp = new DAOFactory();
            idFamille = idFamille + 1;
            dfp.connexion();
            string req = "SELECT famille_produit FROM famille WHERE id_famille = " + idFamille + ";";
            try
            {
                SqlDataReader dre = dfp.execSql(req);
                dre.Read(); 
                resultat = dre.GetString(0);
                dfp.deconnexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return resultat;
        }

        // Permet la récupération d'un ID de famille d'un produit avec son nom en passant par la BDD
        public static int getIDFamille(string nomFamille)
        {
            int resultat = 0;
            DAOFactory p = new DAOFactory();
            p.connexion();
            string req = "SELECT id_famille FROM Famille WHERE famille_produit = '" + nomFamille + "';";
            try
            {
                SqlDataReader dr = p.execSql(req);
                dr.Read();
                resultat = dr.GetInt32(0);
                p.deconnexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return resultat;
        }

        // Requête de modification d'un produit dans la BDD.
        public static string modifierProduit(Produit leProduit)
        {
            string prixHT = leProduit.getPrixHT().ToString();
            string prixEch = leProduit.getPrixEch().ToString();

            DAOFactory p = new DAOFactory();
            string requeteLigne = "UPDATE produit "
                + "idFamille = " + (getIDFamille(leProduit.getFamille()) - 1)
                + ", SET nom = '" + leProduit.getNom() + "'"
                + ", effet = '" + leProduit.getEffet().Replace("'", "`") + "'" // Sécurité
                + ", contre_indication = '" + leProduit.getCI().Replace("'", "`") + "'"
                + ", interactions_autres_produits = '" + leProduit.getInteraction().Replace("'", "`") + "'"
                + ", presentation = '" + leProduit.getPresentation().Replace("'", "`") + "'"
                + ", dosage = '" + leProduit.getDosage() + "'"
                + ", prix_HT = " + prixHT.Replace(',', '.')
                + ", prix_Echantillon = " + prixEch.Replace(',', '.')
                
                + " WHERE num = " + leProduit.getNum() + ";";
            try
            {
                p.connexion();
                p.execSql(requeteLigne);
                p.deconnexion();
                return "Produit modifié";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "Erreur dans la modification du produit";
            }
        }

        //Reqûête de suppression d'un produit dans la BDD
        public static string supprimerProduit(int num)
        {
            DAOFactory dfp = new DAOFactory();
            try
            {
                dfp.connexion();
                string requeteLigne = "DELETE FROM produit WHERE num=" + num + ";";
                dfp.execSql(requeteLigne);
                dfp.deconnexion();
                return "Produit Supprimé";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "Erreur dans la suppression du produit";
            }
        }

    }
}

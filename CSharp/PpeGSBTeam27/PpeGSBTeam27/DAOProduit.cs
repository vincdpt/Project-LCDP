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
            string req = "SELECT produit.* FROM produit;";
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


    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpeGSBTeam27
{
    class DAOProduit
    {
        public static List<Produit> listeProduit()
        {
            DAOFactory df = new DAOFactory();
            df.connection();
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
    }
}

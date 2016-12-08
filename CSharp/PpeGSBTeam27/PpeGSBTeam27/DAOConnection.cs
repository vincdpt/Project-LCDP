using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PpeGSBTeam27
{
    class DAOConnection
    {
        // Vérifie les identifiants entrées sur le formulaire de connexion. Return true si ils sont existants sur la BDD.
        public static Boolean verifLoginMdp()
        {
            DAOFactory dfco = new DAOFactory();
            dfco.connexion();
            string resultatRequete = "0";
           
            string req = "SELECT COUNT(*) AS existe FROM dbo.gestionnaire WHERE login = '" + FormConnection.login + "' AND mdp = '" + FormConnection.mdp + "';";

            try
            {
                SqlDataReader dr = dfco.execSql(req);
                while (dr.Read())
                {
                    resultatRequete = dr.GetInt32(0).ToString();
                }
                dfco.deconnexion();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            if (resultatRequete == "0")
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}

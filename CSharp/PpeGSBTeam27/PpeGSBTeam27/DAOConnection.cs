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
        public static Boolean verifLoginMdp()
        {
            DAOFactory df = new DAOFactory();
            df.connection();
            string resultatRequete = "0";
           
            string rqt = "SELECT COUNT(*) AS existe FROM dbo.gestionnaire WHERE login = '" + FormConnection.login + "' AND mdp = '" + FormConnection.mdp + "';";

            try
            {
                SqlDataReader dr = df.execSql(rqt);
                while (dr.Read())
                {
                    resultatRequete = dr.GetInt32(0).ToString();
                }
                df.deconnexion();
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

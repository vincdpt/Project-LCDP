using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PpeGSBTeam27
{
    class DAOFactory
    {
        public static SqlConnection cnx = new SqlConnection("Data Source='172.17.21.34';Initial Catalog=BackOffice_GSB;User ID=gsb;Password=gsb-2016");

        public void connection()
        {
            try
            {
                cnx.Open();           
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n Erreur de connection : " + ex.Message);
            }
            
        }

        public void deconnexion()
        {
            cnx.Close();
        }

        /* Exécution des commandes SQL */

        public SqlDataReader execSql(string requete)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cmd.CommandText = requete;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnx;

            dr = cmd.ExecuteReader();
            return dr;
        }

    }
}

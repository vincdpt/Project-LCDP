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
        public static SqlConnection cnx = new SqlConnection("Data Source='172.17.21.34';Initial Catalog=BackOffice_GSB;User ID=administrateur;Password=btssio-slam-2015");
       
        public static void connexion()
        {
            try
            {
                cnx.Open();
                MessageBox.Show("\n Connection réussi ;) avoue t'est refait hein !!\n j'avoue moi aussi j'y croyais pas mais bon\n LOURD !!!!!\n On essaye depuis le 29/11/2016 vers 16h t'imagine le temps perdu o_O !!!!! \n ATOZ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n Marche toujours pas :'( ...\n" + ex.Message);
                Console.WriteLine(ex);
            }
            
        }
    }
}

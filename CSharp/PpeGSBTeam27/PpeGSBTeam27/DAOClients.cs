using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpeGSBTeam27
{
    class DAOClients
    {
        private static DAOFactory connexion = new DAOFactory();
        
        public DAOClients() {  }

        //Méthode qui charge une liste de client à partir de la base de donnée
        public static List<Clients> chargerClients()
        {
            List<Clients> lesClients = new List<Clients>();

            try
            {
                SqlDataReader reader;
                reader = connexion.execSql("SELECT * FROM praticien");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Clients c = new Clients(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), 
                            reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8), reader.GetInt32(9));
                        lesClients.Add(c);
                    }
                }
                reader.Close();
            }
            catch(SqlException e)
            {
                MessageBox.Show("erreur");
            }
            return lesClients;
        }

        public static Boolean CreerClients(Clients cli)
        {
            Boolean reussiteCreation = false;
            try
            {
                connexion.execSql("INSERT INTO praticien (id_praticien, id_specialite, raison_sociale, adresse, telephone, nom, mail, coeff_notoriete, coeff_confiance, type) "
                    + "VALUES ('" + cli.Id + "', '" + cli.IdSpecialite + "', '" + cli.RaisonSociale + "', '" + cli.Adresse + "', '" + cli.Telephone + "', '" + cli.Nom +
                    "', '" + cli.AdresseMail + "', '" + cli.CoefficientNotoriete + "', '" + cli.CoefficientConfiance + "', '" + cli.TypeDeProfession + "');");
                reussiteCreation = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erreur");
            }
            return reussiteCreation;
        }

        public static Boolean SupprimerClients(Clients cli)
        {
            Boolean reussiteSuppression = false;
            try
            {
                connexion.execSql("DELETE FROM praticien WHERE id = " + cli.Id + "");
                reussiteSuppression = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erreur");
                reussiteSuppression = false;
            }
            return reussiteSuppression;
        }

        public static Boolean ModifierClients(Clients cli)
        {
            Boolean reussiteModification = false;
            try
            {
                connexion.execSql("UPDATE praticien SET id_praticien ='" + cli.Id + "', raison_sociale ='" + cli.RaisonSociale + "', adresse ='" + cli.Adresse +
                    "', telephone ='" + cli.Telephone + "', nom ='" + cli.Nom + "', mail ='" + cli.AdresseMail + "', coeff_notoriete ='" + cli.CoefficientNotoriete +
                    "', coeff_confiance ='" + cli.CoefficientConfiance + "', type ='" + cli.TypeDeProfession + "';");
                reussiteModification = true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erreur");
                reussiteModification = false;
            }
            return false;
        }
    }
}

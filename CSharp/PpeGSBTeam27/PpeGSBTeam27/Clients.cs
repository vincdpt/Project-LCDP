using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpeGSBTeam27
{
    class Clients
    {
        #region Attributs

            private int id;
            private int idSpecialite;
            private String nom;
            private String raisonSociale;
            private String adresse;
            private String adresseMail;
            private String telephone;
            private String typeDeProfession;
            private int coefficientNotoriete;
            private int coefficientConfiance;       

        #endregion

        #region Constructeur

        // Constructeur de Produit.
        public Clients(int unId, int unIdSpecialite, string unNom, string uneRaisonSociale, string uneAdresse, string uneAdresseMail, string unTelephone,
                string unTypeDeProfession, int unCoefficientNotoriete, int unCoefficientConfiance)
            {
                Id = unId;
                Nom = unNom;
                RaisonSociale = uneRaisonSociale;
                Adresse = uneAdresse;
                AdresseMail = uneAdresseMail;
                Telephone = unTelephone;
                TypeDeProfession = unTypeDeProfession;
                CoefficientNotoriete = unCoefficientNotoriete;
                CoefficientConfiance = unCoefficientConfiance;              
            }

        #endregion

        #region getter/setter

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int IdSpecialite
        {
            get
            {
                return idSpecialite;
            }

            set
            {
                idSpecialite = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }

            set
            {
                raisonSociale = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string AdresseMail
        {
            get
            {
                return adresseMail;
            }

            set
            {
                adresseMail = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string TypeDeProfession
        {
            get
            {
                return typeDeProfession;
            }

            set
            {
                typeDeProfession = value;
            }
        }

        public int CoefficientNotoriete
        {
            get
            {
                return coefficientNotoriete;
            }

            set
            {
                coefficientNotoriete = value;
            }
        }

        public int CoefficientConfiance
        {
            get
            {
                return coefficientConfiance;
            }

            set
            {
                coefficientConfiance = value;
            }
        }

        #endregion

        #region Procédures/Fonctions
        // Méthode permettant de charger les objets clients
        public static List<Clients> chargerCli()
        {
            return DAOClients.chargerClients();
        }
        // envoi de l'objet
        public static Boolean creerClients(Clients cli)
        {
            return DAOClients.CreerClients(cli);
        }

        public static Boolean SupprimerClients(Clients cli)
        {
            return DAOClients.CreerClients(cli);
        }

        public static Boolean ModifierClients(Clients cli)
        {
            return DAOClients.ModifierClients(cli);
        }
        #endregion
    }
 }
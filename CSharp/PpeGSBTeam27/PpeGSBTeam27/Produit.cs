using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpeGSBTeam27
{
    class Produit
    {
            #region Attributs

            int num;
            String nom;
            String effet;
            String CI;
            String presentation;
            String dosage;
            String famille;
            String interaction;
            double prixHT;
            double prixEch;

            #endregion

            #region Constructeur

            // Constructeur de Produit.
            public Produit(int unNum, string unNom, string unEffet, string desCI, string unePresentation, string unDosage, int unIDFamille, double unPrixHT, double unPrixEch, string uneInteraction)
            {
                num = unNum;
                nom = unNom;
                effet = unEffet;
                CI = desCI;
                presentation = unePresentation;
                dosage = unDosage;
                // Penser a une famille
                prixHT = unPrixHT;
                prixEch = unPrixEch;
                interaction = uneInteraction;
            }

            #endregion

            #region Getters / Setters
            public int getNum()
            {
                return num;
            }

            public void setNom(string value)
            {
                this.nom = value;
            }

            public string getNom()
            {
                return nom;
            }

            public void setEffet(string value)
            {
                this.effet = value;
            }

            public string getEffet()
            {
                return effet;
            }

            public void setCI(string value)
            {
                this.CI = value;
            }

            public string getCI()
            {
                return CI;
            }

            public void setPresentation(string value)
            {
                this.presentation = value;
            }

            public string getPresentation()
            {
                return presentation;
            }

            public void setDosage(string value)
            {
                this.dosage = value;
            }

            public string getDosage()
            {
                return dosage;
            }

            public void setFamille(string value)
            {
                this.famille = value;
            }

            public string getFamille()
            {
                return famille;
            }

            public void setPrixHT(double value)
            {
                this.prixHT = value;
            }

            public double getPrixHT()
            {
                return this.prixHT;
            }

            public void setPrixEch(double value)
            {
                this.prixEch = value;
            }

            public double getPrixEch()
            {
                return prixEch;
            }

            public string getInteraction()
            {
                return interaction;
            }

        #endregion

        #region Procédures/Fonctions

        // Création de la liste Produit en passant par DAOProduit où ils ont été récupérés.
        public static List<Produit> listeProduit()
        {
            List<Produit> laListe = DAOProduit.listeProduit();
            return laListe;
        }


        #endregion
    }
 }
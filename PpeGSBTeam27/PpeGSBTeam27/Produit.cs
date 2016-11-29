using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpeGSBTeam27
{
    class Produit
    {
        int num;
        String nom;
        String effet;
        String contreIndication;
        String presentation;
        String dosage;
        String famille;
        String interaction;
        double prixHT;
        double prixEchantillon;

        public Produit(int unNum, string unNom, string unEffet, string desCI, string unePresentation, string unDosage, int unIDFamille, double unPrixHT, double unPrixEch, string uneInteraction)
        {
            num = unNum;
            nom = unNom;
            effet = unEffet;
            contreIndication = desCI;
            presentation = unePresentation;
            dosage = unDosage;
            famille = ;
            prixHT = unPrixHT;
            prixEchantillon = unPrixEch;
            interaction = uneInteraction;
        }

        #region Getters et Setters

        public int getNum()
        {
            return num;
        }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string value)
        {
            this.nom = value;
        }


        public void setEffet(string value)
        {
            this.effet = value;
        }

        public string getEffet()
        {
            return effet;
        }

        public void setContreIndication(string value)
        {
            this.contreIndication = value;
        }

        public string getContreIndication()
        {
            return contreIndication;
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

        public void setPrixEchantillon(double value)
        {
            this.prixEchantillon = value;
        }

        public double getPrixEchantillon()
        {
            return prixEchantillon;
        }

        public string getInteraction()
        {
            return interaction;
        }
        #endregion

    }
}

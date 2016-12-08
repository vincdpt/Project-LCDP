using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GSB_Desk
{
    class Medicament
    {
        private int medId;
        private String codeMed;
        private String nomCommMed;
        private String familleMed;
        private String compositionMed;
        private String effetIndeMed;
        private String contreIndicMed;
        private String prixMed;
        

        public Medicament(int medId, String codeMed, String nomCommMed, String familleMed, String compositionMed, String effetIndeMed,
            String contreIndicMed, String prixMed)
        {
            this.medId = medId;
            this.codeMed = codeMed;
            this.nomCommMed = nomCommMed;
            this.familleMed = familleMed;
            this.compositionMed = compositionMed;
            this.effetIndeMed = effetIndeMed;
            this.contreIndicMed = contreIndicMed;
            this.prixMed = prixMed;
        }

        #region Getter/Setter
        public int MedId
        {
            get { return medId; }
            set { medId = value; }
        }
        public String CodeMed
        {
            get { return codeMed; }
            set { codeMed = value; }
        }

        public String NomCommMed
        {
            get { return nomCommMed; }
            set { nomCommMed = value; }
        }

        public String FamilleMed
        {
            get { return familleMed; }
            set { familleMed = value; }
        }

        public String CompositionMed
        {
            get { return compositionMed; }
            set { compositionMed = value; }
        }

        public String EffetIndeMed
        {
            get { return effetIndeMed; }
            set { effetIndeMed = value; }
        }

        public String ContreIndicMed
        {
            get { return contreIndicMed; }
            set { contreIndicMed = value; }
        }

        public String PrixMed
        {
            get { return prixMed; }
            set { prixMed = value; }
        }
        #endregion


        #region Methode BDD
        //Méthode permettant de charger la liste d'objet médicament
        public static List<Medicament> chargerMed()
        {
            return DAOMedicament.chargerMedicament();
        }
        //envoie d'objet
        public static Boolean creerMedicament(Medicament med)
        {
            return DAOMedicament.CreerMedicament(med);
        }

        public static Boolean SupprimerMedicament(Medicament med)
        {
            return DAOMedicament.SupprimerMedicament(med);
        }

        public static Boolean ModifierMedicament(Medicament med)
        {
            return DAOMedicament.ModifierMedicament(med);
        }
    }
        #endregion
}

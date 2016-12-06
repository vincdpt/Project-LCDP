using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpeGSBTeam27
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        #region Variables globales
        public static string login;
        public static string mdp;
        #endregion


        private void btnSeConnecterValider_Click(object sender, EventArgs e)
        {
            login = txbSeConnecterLogin.Text.ToString();
            mdp = txbSeConnecterMdp.Text.ToString();

            if (DAOConnection.verifLoginMdp())
            {
                BackOfficeGSB frm = new BackOfficeGSB();
                this.Visible = false;
                frm.Show();
            }

            else
            {
                MessageBox.Show("Erreur - Login ou mot de passe incorrect");
            }
            
        }
    }
}

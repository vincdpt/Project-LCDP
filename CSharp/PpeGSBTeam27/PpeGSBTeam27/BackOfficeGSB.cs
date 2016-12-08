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
    public partial class BackOfficeGSB : Form
    {
        public BackOfficeGSB()
        {
            InitializeComponent();
        }

        private void labProduitsCreerEffets_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            DAOFactory.cnx.Close();
            FormConnection frm = new FormConnection();
            this.Visible = false;
            frm.Show();
        }

        private void tabProduits_Click(object sender, EventArgs e)
        {

        }

        private void cbxVisiteursCreerSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        private void btnSeConnecterValider_Click(object sender, EventArgs e)
        {
            BackOfficeGSB frm = new BackOfficeGSB();
            this.Visible = false;
            frm.Show();
        }
    }
}

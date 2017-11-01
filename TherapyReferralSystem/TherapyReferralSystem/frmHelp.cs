using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmHelp : Form
    {
        private string type;
        private string username;

        public frmHelp()
        {
          
        }

        public frmHelp(string username, string type)
        {
            this.username = username;
            this.type = type;
            InitializeComponent();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile pr = new frmProfile();
            pr.Show();
            this.Dispose();

        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }
    }
}

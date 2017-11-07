using System;
using System.Drawing;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmHelp : Form
    {
        private string v;

        public frmHelp()
        {
           
        }

        public frmHelp(string v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            
            
            if(v.Equals("Login"))
            {
                tbpPRec.Dispose();
                tbpProfile.Dispose();
                tbpRegChild.Dispose();
                tbpRegUser.Dispose();
                tbpTheRef.Dispose();
            }
            if (v.Equals("TheRef"))
            {
                tbpLogin.Dispose();
                tbpPRec.Dispose();
                tbpProfile.Dispose();
                tbpRegChild.Dispose();
                tbpRegUser.Dispose();
               
            }
            if (v.Equals("User"))
            {
                tbpLogin.Dispose();
                tbpPRec.Dispose();
                tbpProfile.Dispose();
                tbpRegChild.Dispose();
                tbpTheRef.Dispose();
            }
            if (v.Equals("Child"))
            {
                tbpLogin.Dispose();
                tbpPRec.Dispose();
                tbpProfile.Dispose();
                tbpRegUser.Dispose();
                tbpTheRef.Dispose();
            }
            if (v.Equals("Profile"))
            {
                tbpLogin.Dispose();
                tbpPRec.Dispose();
                tbpRegUser.Dispose();
                tbpRegChild.Dispose();
                tbpTheRef.Dispose();
            }


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

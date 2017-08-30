using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TherapyReferralSystem;

namespace Register_Form
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
                   }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegUserReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Close();
        }

        private void mnuRegUserReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports();
            rep.Show();
            this.Close();
        }

        private void mnuRegUserHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Close();
        }

        private void mnuRegUserTherapyRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tr = new frmTherapyReferral();
            tr.Show();
            this.Close();
        }

        private void mnuRegUserRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild();
            rc.Show();
            this.Close();
        }

        private void mnuRegUserRegTherapist_Click(object sender, EventArgs e)
        {
            frmRegisterTherapist rc = new frmRegisterTherapist();
            rc.Show();
            this.Close();
        }
    }
}

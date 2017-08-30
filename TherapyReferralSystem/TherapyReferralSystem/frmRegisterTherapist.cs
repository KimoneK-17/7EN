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
    public partial class frmRegisterTherapist : Form
    {
        public frmRegisterTherapist()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltype_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegisterTherapist_Load(object sender, EventArgs e)
        {

        }

        private void frmRegisterTherapist_Load_1(object sender, EventArgs e)
        {

        }

        private void mnuRegTherapistTherapyRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tr = new frmTherapyReferral();
            tr.Show();
            this.Close();
        }

        private void mnuRegTherapistReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Close();
        }

        private void mnuRegTherapistReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports();
            rep.Show();
            this.Close();
        }

        private void mnuRegTherapistHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Close();
        }

        private void mnuRegTherapistRegUser_Click(object sender, EventArgs e)
        {
            //frmRegisterUser ru = new frmRegisterUser();
            //ru.Show();
            //this.Close(); 
        }

        private void mnuRegTherapistRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild();
            rc.Show();
            this.Close(); 
        }
    }
}

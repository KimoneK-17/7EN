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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        //**********************************************************************************
        private void txtTherapistID_TextChanged(object sender, EventArgs e)
        {
            //check validations for only numbers
            try
            {
                int temp = Convert.ToInt32(txtTherapistID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide number only");
            }
        }

        //**********************************************************************************
        private void txtChildID_TextChanged(object sender, EventArgs e)
        {
            //check validations for only numbers
            try
            {
                int temp = Convert.ToInt32(txtChildID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide number only");
            }
        }

        private void ezitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //**********************************************************************************

    }
}

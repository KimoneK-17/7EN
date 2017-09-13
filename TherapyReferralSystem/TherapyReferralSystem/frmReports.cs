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
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }


        private void mnuReportsHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }

        private void cboxRefine_CheckedChanged(object sender, EventArgs e)
        {
            //set visibility of options to be shown or hidden
            if(cboxRefine.Checked)
            {
                lblCluster.Visible = true;
                cboxCluster.Visible = true;

                lblYear.Visible = true;
                cboxYear.Visible = true;

                lblTherID.Visible = true;
                txtTherapistID.Visible = true;

                lblChildID.Visible = true;
                txtChildID.Visible = true;

                lblTherapyType.Visible = true;
                cboxTherapyType.Visible = true;
            }
            else
            {
                lblCluster.Visible = false;
                cboxCluster.Visible = false;

                lblYear.Visible = false;
                cboxYear.Visible = false;

                lblTherID.Visible = false;
                txtTherapistID.Visible = false;

                lblChildID.Visible = false;
                txtChildID.Visible = false;

                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;

                lblHouse.Visible = false;
                cboxHouse.Visible = false;

                lblMonth.Visible = false;
                cboxMonth.Visible = false;

                lblDay.Visible = false;
                cboxDay.Visible = false;


            }
        }

        private void cboxCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHouse.Visible = true;
            cboxHouse.Visible = true;
        }

        private void cboxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMonth.Visible = true;
            cboxMonth.Visible = true;
        }

        private void cboxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDay.Visible = true;
            cboxDay.Visible = true;
        }


        //**********************************************************************************

    }
}

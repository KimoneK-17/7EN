using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmReports : Form
    {
<<<<<<< HEAD
        private string type;

=======
        DBConnect objDBConnect = new DBConnect();
>>>>>>> fdd3965c8767aab833f7aef0f0c861616e44ff15
        public frmReports()
        {
        }

        public frmReports(string type)
        {
            InitializeComponent();
            this.type = type;
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

        private void mnuReportsTherRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tf = new frmTherapyReferral();
            tf.Show();
            this.Dispose();
        }

        private void mnuReportsRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild();
            rc.Show();
            this.Dispose();

        }

        private void mnuReportsRegUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser();
            ru.Show();
            this.Dispose();
        }

        private void mnuReportsPrintRep_Click(object sender, EventArgs e)
        {

        }

        //*********************************************************************************
        //report selection , which report is being selected, and what information should be called from db
        private void cboxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVReport.DataSource = getReportList();
        }

        //**********************************************************************************
        private DataTable getReportList()
        {

            DataTable report = new DataTable();
            objDBConnect.OpenConnection();
            if (cboxReport.SelectedIndex.ToString() == "Child Information")
                objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM CHILD", objDBConnect.sqlConn);

            else if (cboxReport.SelectedIndex.ToString() == "Theraphies")
                objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM THERAPY_REF", objDBConnect.sqlConn);

            else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy")
                objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM ADD_ADHD", objDBConnect.sqlConn);

            else if (cboxReport.SelectedIndex.ToString() == "Therapist Information")
                objDBConnect.sqlCmd = new SqlCommand("SELECT U_ID,U_FNAME,U_SNAME,U_CONTACT,U_EMAIL,T_ID,T_TYPE,T_IE   FROM TBL_USER   WHERE T_ID != null", objDBConnect.sqlConn);

            else if (cboxReport.SelectedIndex.ToString() == "Waiting on outside resource")
                objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM THERAPY_REF   WHERE R_WAITING_LIST < CURRENT_DATE()", objDBConnect.sqlConn);


            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

            MessageBox.Show("Successfully Loaded");
            objDBConnect.sqlDR.Close();
            objDBConnect.sqlConn.Close();

            return report;
        }
        //**********************************************************************************
    }
}

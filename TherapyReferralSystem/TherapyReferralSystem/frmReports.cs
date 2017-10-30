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
        //declarations
        private string type;
        DBConnect objDBConnect = new DBConnect();

        public frmReports()
        {
        }

        public frmReports(string type)
        {
            InitializeComponent();
            this.type = type;
            // find out about theraphy type????? then add if statements for them as well
            // 
            //based on position, add items to report drop down on what is accessible for the person
            //reports availible Theraphy, ADD & ADHD Theraphy, Child Information, Therapist Information, Referals, Interventions, Waiting on outside resource
        }
        //******************************************************************
        //menu navigations
        private void mnuReportsTherRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tf = new frmTherapyReferral(type);
            tf.Show();
            this.Dispose();
        }
        private void mnuReportsRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild(type);
            rc.Show();
            this.Dispose();
        }
        private void mnuReportsRegUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser(type);
            ru.Show();
            this.Dispose();
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
        //******************************************************************
        //print of report
        private void mnuReportsPrintRep_Click(object sender, EventArgs e)
        {

        }

        //*********************************************************************************
        //report selection , which report is being selected, and what information should be called from db
        private void cboxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                //make all values null and hidden then visible when one is selected in below if statements
                lblCluster.Visible = false;
                txtCluster.Visible = false;
                txtCluster = null;

                lblYear.Visible = false;
                DTPYear.Visible = false;
                DTPYear = null;

                lblTherID.Visible = false;
                txtTherapistID.Visible = false;
                txtTherapistID = null;


                lblChildID.Visible = false;
                txtChildID.Visible = false;
                txtChildID = null;

                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;
                cboxTherapyType = null;

                lblHouse.Visible = false;
                txtHouse.Visible = false;
                txtHouse = null;

                lblMonth.Visible = false;
                DTPMonth.Visible = false;
                DTPMonth = null;

                lblDay.Visible = false;
                DTPDay.Visible = false;
                DTPDay = null;

                DGVReport.DataSource = getReportList();
            }
            catch(Exception error)
            {
                Console.WriteLine("An error occurred: '{0}'", error);
            }
        }

        //**********************************************************************************
        private DataTable getReportList()
        {

            DataTable report = new DataTable();
            objDBConnect.OpenConnection();

        


            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "Child Information")
            {
                lblCluster.Visible = true;
                txtCluster.Visible = true;

                lblChildID.Visible = true;
                txtChildID.Visible = true;

                if (cboxReport.SelectedIndex.ToString() == "Child Information" && txtCluster != null && txtHouse != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM CHILD 
                        WHERE C_CLUSTER = " + txtCluster.Text + " && C_HOUSE = " + txtHouse.Text + " && C_NUMBER = " + txtChildID.Text ,objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Child Information" && txtCluster != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM CHILD 
                        WHERE C_CLUSTER = " + txtCluster.Text + " && C_NUMBER = " + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Child Information" && txtCluster != null && txtHouse != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM CHILD 
                        WHERE C_CLUSTER = " + txtCluster.Text + " && C_HOUSE = " + txtHouse.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Child Information" && txtCluster != null )
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM CHILD 
                        WHERE C_CLUSTER = " + txtCluster.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Child Information" && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM CHILD 
                        WHERE C_NUMBER = " + txtChildID.Text, objDBConnect.sqlConn);
                }

                else
                    objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM CHILD", objDBConnect.sqlConn);
            }






            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy")
            {
                lblYear.Visible = true;
                DTPYear.Visible = true;

                lblTherID.Visible = true;
                txtTherapistID.Visible = true;

                if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null && DTPMonth != null && DTPDay != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE cast(A_DATE_REF as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' && A_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null && DTPMonth != null && DTPDay != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE cast(A_DATE_REF as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "'", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null && DTPMonth != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE year(A_DATE_REF) = year(" + DTPYear.Text + ") && month(A_DATE_REF) = month(" + DTPMonth.Text + ") && A_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null && DTPMonth != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE year(A_DATE_REF) = year(" + DTPYear.Text + ") && month(A_DATE_REF) = month(" + DTPMonth.Text + ")", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE year(A_DATE_REF) = year(" + DTPYear.Text + ") && A_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && DTPYear != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE year(A_DATE_REF) = year(" + DTPYear.Text + ")", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy" && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT * FROM ADD_ADHD
                    WHERE A_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else
                    objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM ADD_ADHD", objDBConnect.sqlConn);
            }





            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "Waiting on outside resource")
                objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM THERAPY_REF   WHERE R_WAITING_LIST < CURRENT_DATE()", objDBConnect.sqlConn);






            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "Therapist Information")
            {
                lblTherID.Visible = true;
                txtTherapistID.Visible = true;

                if (cboxReport.SelectedIndex.ToString() == "Therapist Information" && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand("SELECT U_ID,U_FNAME,U_SNAME,U_CONTACT,U_EMAIL,T_ID,T_TYPE,T_IE   FROM TBL_USER   WHERE T_ID =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }
                else
                    objDBConnect.sqlCmd = new SqlCommand("SELECT U_ID,U_FNAME,U_SNAME,U_CONTACT,U_EMAIL,T_ID,T_TYPE,T_IE   FROM TBL_USER   WHERE T_ID != null", objDBConnect.sqlConn);
            }







            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "Referals")
            {
                lblChildID.Visible = true;
                txtChildID.Visible = true;

                lblYear.Visible = true;
                DTPYear.Visible = true;

                if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null && DTPMonth != null && DTPDay != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' && R_C_NUMBER =" + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null && DTPMonth != null && DTPDay != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "'", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null && DTPMonth != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ") && R_C_NUMBER = " + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null && DTPMonth != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ")", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && R_C_NUMBER = " + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && DTPYear != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ")", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Referals" && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF
                    WHERE R_C_NUMBER = " + txtChildID.Text, objDBConnect.sqlConn);
                }
                else
                    objDBConnect.sqlCmd = new SqlCommand("SELECT R_ID, R_C_NUMBER, R_CHILD_NAME, R_REASON, R_STATUS, R_REFFERED_BY, R_DATE_REFFERED, R_DATE_START, R_DATE_ENDED, R_DETAILS FROM THERAPY_REF", objDBConnect.sqlConn);
            }








            /////////////////////////////////////////////////////////////////
            if (cboxReport.SelectedIndex.ToString() == "Theraphies")
            {
                lblChildID.Visible = true;
                txtChildID.Visible = true;

                lblYear.Visible = true;
                DTPYear.Visible = true;

                lblTherID.Visible = true;
                txtTherapistID.Visible = true;

                if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && DTPDay != null && txtChildID != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' && R_C_NUMBER =" + txtChildID.Text + " && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && DTPDay != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' && R_C_NUMBER =" + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && DTPDay != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && txtChildID != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ") && R_C_NUMBER =" + txtChildID.Text + " && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ") && R_C_NUMBER =" + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && DTPMonth != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ") && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && txtChildID != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && R_C_NUMBER =" + txtChildID.Text + " && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && R_C_NUMBER =" + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && DTPYear != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE year(R_DATE_REFFERED) = year(" + DTPYear.Text + ")", objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && txtChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE R_C_NUMBER =" + txtChildID.Text, objDBConnect.sqlConn);
                }

                else if (cboxReport.SelectedIndex.ToString() == "Theraphies" && txtTherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"SELECT *   FROM THERAPY_REF
                    WHERE R_THERAPIST =" + txtTherapistID.Text, objDBConnect.sqlConn);
                }

                else
                    objDBConnect.sqlCmd = new SqlCommand("SELECT *   FROM THERAPY_REF", objDBConnect.sqlConn);
            }
            /////////////////////////////////////////////////////////////////


            objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

            MessageBox.Show("Successfully Loaded");
            objDBConnect.sqlDR.Close();
            objDBConnect.sqlConn.Close();

            return report;
        }

        //********************************************************************************
        //checks text entry of cluster and hide/show house fields if valid
        private void txtCluster_TextChanged(object sender, EventArgs e)
        {
            //check validations for only numbers
            try
            {
                int temp = Convert.ToInt32(txtCluster.Text);
                if (txtCluster != null)
                {
                    lblHouse.Visible = true;
                    txtHouse.Visible = true;
                }
                else
                {
                    lblHouse.Visible = false;
                    txtHouse.Visible = false;
                    txtHouse = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide number only");
            }
        }

        //***********************************************************************
        //error check house entry
        private void txtHouse_TextChanged(object sender, EventArgs e)
        {
            //check validations for only numbers
            try
            {
                int temp = Convert.ToInt32(txtHouse.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide number only");
            }
        }

        //***********************************************************************
        //enable/disable month values if a year value is entered
        private void DTPYear_ValueChanged(object sender, EventArgs e)
        {
            if (DTPYear != null)
            {
                lblMonth.Visible = true;
                DTPMonth.Visible = true;
            }
            else
            {
                lblMonth.Visible = false;
                DTPMonth.Visible = false;
                DTPMonth = null;
            }
        }

        //**********************************************************************************
        //enable/disable day values if a month value is entered
        private void DTPMonth_ValueChanged(object sender, EventArgs e)
        {
            if (DTPYear != null)
            {
                lblDay.Visible = true;
                DTPDay.Visible = true;
            }
            else
            {
                lblDay.Visible = false;
                DTPDay.Visible = false;
                DTPDay = null;
            }
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

        private void frmReports_Load(object sender, EventArgs e)
        {
            if (type.Equals("Therapist")|| type.Equals("Teacher")|| type.Equals("Clinic"))
            {
                mnuReportsRegChild.Enabled = false;
                mnuReportsRegUser.Enabled = false;

            }
           
        }
        //**********************************************************************************
    }
}

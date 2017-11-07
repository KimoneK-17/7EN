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
        private string type;    //position availible - Teacher Clinic Therapist   Admin   Social worker
        DBConnect objDBConnect = new DBConnect();
        string Query;
        private string type1;

        public frmReports()
        {
        }

        public frmReports(string type)
        {
            InitializeComponent();
            this.type = type;
            //based on position, add items to report drop down on what is accessible for the person
            if (type == "Admin" || type == "Social worker")
            {
                cboxReport.Items.Add("Child Information");
                cboxReport.Items.Add("Therapist Information");
            }

            btnShowReport.Visible=true;
            //reports availible Theraphy, ADD & ADHD Theraphy, Child Information, Therapist Information, Referals, Waiting on outside resource
        }

        public frmReports(string type, string type1) : this(type)
        {
            this.type1 = type1;
        }

        //******************************************************************
        //menu navigations
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
        //report selection , which report is being selected
        private void cboxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        //**********************************************************************************
        //display information in datagrid view based on selections on what to search, and what information should be called from db
        private void btnShowReport_Click(object sender, EventArgs e)
        {

          
            //declarations
            string Report = cboxReport.SelectedItem.ToString();
            string Cluster = txtCluster.Text;
            string House = txtHouse.Text;
            //string TheraphyType = cboxTherapyType.SelectedItem.ToString();
            string Year = DTPYear.Text;
            string Month = DTPMonth.Text;
            string Day = DTPDay.Text;
            string TherapistID = txtTherapistID.Text;
            string ChildID = txtChildID.Text;

            ////////////////////////////////////////////////////////////////////////////////////
            if (Report == "Child Information")
            {
                Query = @"SELECT C_NUMBER,C_STATUS,C_CLUSTER,C_HOUSE,C_BSF,C_FNAME,C_MNAME,C_SNAME,C_ID,C_GENDER,C_ADM_DATE,C_CONSIDER
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER";


                if (!txtCluster.Text.Equals("") || !txtChildID.Text.Equals(""))
                {
                    Query = Query + " where";
                }
                if (!txtCluster.Text.Equals(""))
                {
                    Query = Query + " c_cluster = " + txtCluster.Text + " and";
                }

                if (txtCluster.Text.Equals("") && !txtHouse.Text.Equals(""))
                {
                    Query = Query + " c_house = " + txtHouse.Text + " and";
                }
                if (!txtChildID.Text.Equals(""))
                {
                    Query = Query + " c_id like " + txtChildID.Text + " and";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////
            else if (Report == "ADD & ADHD Theraphy")
            {
                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_SESSION, R_DATE_START, R_DATE_ENDED, R_DETAILS, R_THERAPIST, R_REPORT, R_RESULT
                                    FROM THERAPY_REF
                                    Where R_REASON like 'ADD' and ";

                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " R_THERAPIST = " + txtTherapistID.Text + " and";
                }
                if (DTPYear.Text.Equals("") && DTPMonth.Text.Equals("") && !DTPDay.Text.Equals(""))
                {
                    Query = Query + " cast(R_DATE_START as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' and";
                }
                if (DTPYear.Text.Equals("") && !DTPMonth.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_START) = year(" + DTPYear.Text + ") && month(R_DATE_START) = month(" + DTPMonth.Text + ") and";
                }
                if (!DTPYear.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_START) = year(" + DTPYear.Text + ")  and";
                }
            }

            //////////////////////////////////////////////////////////////////////////////////////
            else if (Report == "Therapist Information")
            {
                Query = "Select * from tbl_user where u_type like 'Therapist'";

                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " and u_id = " + txtTherapistID.Text;
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////
            else if (Report == "Referals")
            {
                Query = @"SELECT R_ID, R_C_NUMBER, R_REASON, R_REFFERED_BY, R_DATE_REFFERED DATE 
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER
                                    INNER JOIN TBL_USER on R_THERAPIST = U_ID";

                if (!txtChildID.Text.Equals("") || !DTPYear.Text.Equals(""))
                {
                    Query = Query + " where";
                }
                if (!txtChildID.Text.Equals(""))
                {
                    Query = Query + " c_id like " + txtChildID.Text + " and";
                }
                if (DTPYear.Text.Equals("") && DTPMonth.Text.Equals("") && !DTPDay.Text.Equals(""))
                {
                    Query = Query + " cast(R_DATE_REFFERED as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' and";
                }
                if (DTPYear.Text.Equals("") && !DTPMonth.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_REFFERED) = year(" + DTPYear.Text + ") && month(R_DATE_REFFERED) = month(" + DTPMonth.Text + ") and";
                }
                if (!DTPYear.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_REFFERED) = year(" + DTPYear.Text + ")  and";
                }
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////
            else if (Report == "Theraphy")
            {
                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_SESSION, R_DATE_START, R_DATE_ENDED, R_DETAILS, R_THERAPIST, R_REPORT, R_RESULT 
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER
                                    INNER JOIN TBL_USER on R_THERAPIST = U_ID";
                /*if (!txtCluster.Text.Equals("") || !txtChildID.Text.Equals("") || !DTPYear.Text.Equals("") || !txtTherapistID.Text.Equals("") || !cboxTherapyType.SelectedItem.ToString().Equals(""))
                {
                    Query = Query + " where";
                }
                if (!txtCluster.Text.Equals(""))
                {
                    Query = Query + " c_cluster = " + txtCluster.Text + " and";
                }

                if (txtCluster.Text.Equals("") && !txtHouse.Text.Equals(""))
                {
                    Query = Query + " c_house = " + txtHouse.Text + " and";
                }
                if (!cboxTherapyType.SelectedItem.ToString().Equals(""))
                {
                    Query = Query + " R_REASON = " + txtTherapistID.Text + " and";
                }
                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " u_id = " + txtTherapistID.Text + " and";
                }
                if (!txtChildID.Text.Equals(""))
                {
                    Query = Query + " c_id like " + txtChildID.Text + " and";
                }
                if (DTPYear.Text.Equals("") && DTPMonth.Text.Equals("") && !DTPDay.Text.Equals(""))
                {
                    Query = Query + " cast(R_DATE_START as date) = '" + DTPYear.Text + "-" + DTPMonth.Text + "-" + DTPDay.Text + "' and";
                }
                if (DTPYear.Text.Equals("") && !DTPMonth.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_START) = year(" + DTPYear.Text + ") && month(R_DATE_START) = month(" + DTPMonth.Text + ") and";
                }
                if (!DTPYear.Text.Equals(""))
                {
                    Query = Query + " year(R_DATE_START) = year(" + DTPYear.Text + ")  and";
                }*/
            }


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            else if (Report == "Waiting on outside resource")
            {
                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_WAITING_LIST 
                                    FROM THERAPY_REF
                                    WHERE R_WAITING_LIST > NOW()";
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            DGVReport.DataSource = getReportList(Report, Query);

        }
        //**********************************************************************************
        private DataTable getReportList(String Report, String Query)
        {
            DataTable report = new DataTable();
            objDBConnect.OpenConnection();

            /////////////////////////////////////////////////////////////////
            if (Report != null)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (Query.Contains("and"))
                {
                    Query = Query.Substring(0, Query.LastIndexOf("and")).Trim();
                }
                
                    objDBConnect.sqlCmd = new SqlCommand(Query, objDBConnect.sqlConn);
                

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("Successfully Loaded");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();
            }
            

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
                MessageBox.Show("Please provide number only for cluster");
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
                MessageBox.Show("Please provide number only for house");
            }
        }

        //***********************************************************************
        //enable/disable month values if a year value is entered
        private void DTPYear_ValueChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Please insure year is selected");
            }
        }

        //**********************************************************************************
        //enable/disable day values if a month value is entered
        private void DTPMonth_ValueChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Please insure month is selected");
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
                MessageBox.Show("Please provide number only for therapist ID");
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
                MessageBox.Show("Please provide number only for child ID");
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //**********************************************************************************
    }
}

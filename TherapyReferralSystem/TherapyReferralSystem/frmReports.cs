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
            //reports availible Theraphy, ADD & ADHD Theraphy, Child Information, Therapist Information, Referals, Waiting on outside resource
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
            try
            {
                //make all values null and hidden then visible when selection made in report to view
                lblCluster.Visible = false;
                txtCluster.Visible = false;
                txtCluster.Text = null;

                lblYear.Visible = false;
                DTPYear.Visible = false;
                DTPYear = null;

                lblTherID.Visible = false;
                txtTherapistID.Visible = false;
                txtTherapistID.Text = null;


                lblChildID.Visible = false;
                txtChildID.Visible = false;
                txtChildID.Text = null;

                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;
                cboxTherapyType = null;

                lblHouse.Visible = false;
                txtHouse.Visible = false;
                txtHouse.Text = null;

                lblMonth.Visible = false;
                DTPMonth.Visible = false;
                DTPMonth = null;

                lblDay.Visible = false;
                DTPDay.Visible = false;
                DTPDay = null;

                //depends on report, only certain fields will become visible
                if (cboxReport.SelectedIndex.ToString() == "Child Information")
                {
                    lblCluster.Visible = true;
                    txtCluster.Visible = true;

                    lblChildID.Visible = true;
                    txtChildID.Visible = true;
                }
                else if (cboxReport.SelectedIndex.ToString() == "ADD & ADHD Theraphy")
                {
                    lblYear.Visible = true;
                    DTPYear.Visible = true;

                    lblTherID.Visible = true;
                    txtTherapistID.Visible = true;
                }
                else if (cboxReport.SelectedIndex.ToString() == "Therapist Information")
                {
                    lblTherID.Visible = true;
                    txtTherapistID.Visible = true;

                    lblTherapyType.Visible = true;
                    cboxTherapyType.Visible = true;
                }
                else if (cboxReport.SelectedIndex.ToString() == "Referals")
                {
                    lblChildID.Visible = true;
                    txtChildID.Visible = true;

                    lblYear.Visible = true;
                    DTPYear.Visible = true;
                }
                else if (cboxReport.SelectedIndex.ToString() == "Theraphies")
                {
                    lblCluster.Visible = true;
                    txtCluster.Visible = true;

                    lblChildID.Visible = true;
                    txtChildID.Visible = true;

                    lblYear.Visible = true;
                    DTPYear.Visible = true;

                    lblTherID.Visible = true;
                    txtTherapistID.Visible = true;

                    lblTherapyType.Visible = true;
                    cboxTherapyType.Visible = true;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error : " + error.Message);
            }
        }

        //**********************************************************************************
        //display information in datagrid view based on selections on what to search, and what information should be called from db
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            //declarations
            String Report = cboxReport.Text;
            String Cluster = txtCluster.Text;
            String House = txtHouse.Text;
            String TheraphyType = cboxTherapyType.Text;
            String Year = DTPYear.Text;
            String Month = DTPMonth.Text;
            String Day = DTPDay.Text;
            String TherapistID = txtTherapistID.Text;
            String ChildID = txtChildID.Text;
            String SelectStatement = null;

            if (Report == "Child Information")
            {
                SelectStatement = @"SELECT C_NUMBER,C_STATUS,C_CLUSTER,C_HOUSE,C_BSF,C_FNAME,C_MNAME,C_SNAME,C_ID,C_GENDER,C_ADM_DATE,C_CONSIDER
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER";
            }

            else if (Report == "ADD & ADHD Theraphy")
            {
                SelectStatement = @"SELECT A_ID, A_STATUS,A_TYPE,A_DATE_REF,A_DATE_START,A_DATE_END,A_NUM_OF_SESSIONS,A_DETAILS,A_THERAPIST,A_REPORT,A_RESULT
                                    FROM THERAPY_REF
                                    INNER JOIN TBL_USER on R_THERAPIST = T_ID
                                    INNER JOIN ADD_ADHD on T_ID = A_THERAPIST";
            }

            else if (Report == "Therapist Information")
            {
                SelectStatement = @"SELECT U_ID, U_FNAME, U_SNAME, U_CONTACT, U_EMAIL, T_ID, T_TYPE, T_IE 
                                    FROM THERAPY_REF
                                    INNER JOIN TBL_USER on R_THERAPIST = T_ID";
            }

            else if (Report == "Referals")
            {
                SelectStatement = @"SELECT R_ID, R_C_NUMBER, R_REASON, R_REFFERED_BY, R_DATE_REFFERED DATE 
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER
                                    INNER JOIN TBL_USER on R_THERAPIST = T_ID";
            }

            else if (Report == "Theraphies")
            {
                SelectStatement = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_SESSION, R_DATE_START, R_DATE_ENDED, R_DETAILS, R_THERAPIST, R_REPORT, R_RESULT 
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER
                                    INNER JOIN TBL_USER on R_THERAPIST = T_ID";
            }

            else if (Report == "Waiting on outside resource")
            {
                SelectStatement = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_WAITING_LIST 
                                    FROM THERAPY_REF
                                    WHERE R_WAITING_LIST > NOW()";  //special consideration on waiting date, thus where clause part of this declaration
            }

            DGVReport.DataSource = getReportList(Report,Cluster,House,TheraphyType,Year,Month,Day,TherapistID,ChildID,SelectStatement);

        }
        //**********************************************************************************
        private DataTable getReportList(String Report, String Cluster, String House, String TheraphyType,
            String Year, String Month, String Day,
            String TherapistID, String ChildID,  String SelectStatement)
        {

            DataTable report = new DataTable();
            objDBConnect.OpenConnection();

            /////////////////////////////////////////////////////////////////
            if (Report != null)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (Report == "Child Information" && Cluster != null && House != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@""+SelectStatement +
                        "WHERE C_CLUSTER = " + Cluster + " && C_HOUSE = " + House + " && C_NUMBER = " + ChildID, objDBConnect.sqlConn);
                }

                else if (Report == "Child Information" && Cluster != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                        "WHERE C_CLUSTER = " +Cluster+ " && C_NUMBER = " +ChildID, objDBConnect.sqlConn);
                }

                else if (Report == "Child Information" && Cluster != null && House != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                        "WHERE C_CLUSTER = " + Cluster + " && C_HOUSE = " + House, objDBConnect.sqlConn);
                }

                else if (Report == "Child Information" && Cluster != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                        "WHERE C_CLUSTER = " + Cluster, objDBConnect.sqlConn);
                }

                else if (Report == "Child Information" && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                        "WHERE C_NUMBER = " + ChildID, objDBConnect.sqlConn);
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                else if (Report == "ADD & ADHD Theraphy" && Year != null && Month != null && Day != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(A_DATE_REF as date) = '" + Year + "-" + Month + "-" + Day + "' && A_THERAPIST =" + TherapistID, objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && Year != null && Month != null && Day != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(A_DATE_REF as date) = '" + Year + "-" + Month + "-" + Day + "'", objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && Year != null && Month != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(A_DATE_REF) = year(" + Year + ") && month(A_DATE_REF) = month(" + Month + ") && A_THERAPIST =" + TherapistID, objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && Year != null && Month != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(A_DATE_REF) = year(" + Year + ") && month(A_DATE_REF) = month(" + Month + ")", objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && Year != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(A_DATE_REF) = year(" + Year + ") && A_THERAPIST =" + TherapistID, objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && Year != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(A_DATE_REF) = year(" + Year + ")", objDBConnect.sqlConn);
                }

                else if (Report == "ADD & ADHD Theraphy" && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE A_THERAPIST =" + TherapistID, objDBConnect.sqlConn);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                else if (Report == "Waiting on outside resource")
                    objDBConnect.sqlCmd = new SqlCommand(SelectStatement, objDBConnect.sqlConn);

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                else if (Report == "Therapist Information" && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@""+SelectStatement+ 
                    "WHERE T_ID =" + TherapistID+ " && T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report == "Therapist Information" && TherapistID != null )
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE T_ID =" + TherapistID, objDBConnect.sqlConn);
                }

                else if (Report == "Therapist Information"  && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                else if (Report == "Referals" && Year != null && Month != null && Day != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year + "-" + Month + "-" + Day + "' && R_C_NUMBER =" + ChildID, objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && Year != null && Month != null && Day != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year + "-" + Month + "-" + Day + "'", objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && Year != null && Month != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && month(R_DATE_REFFERED) = month(" + Month + ") && R_C_NUMBER = " + ChildID, objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && Year != null && Month != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && month(R_DATE_REFFERED) = month(" + Month + ")", objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && Year != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && R_C_NUMBER = " + ChildID, objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && Year != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ")", objDBConnect.sqlConn);
                }

                else if (Report == "Referals" && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE R_C_NUMBER = " + ChildID, objDBConnect.sqlConn);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////////////////

                else if (Report == "Theraphies" && Year != null && Month != null && Day != null && ChildID != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year + "-" + Month + "-" + Day + "' && R_C_NUMBER =" + ChildID + " && R_THERAPIST =" + TherapistID+"&& T_TYPE ="+ TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && Day != null && ChildID != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year  + "-" + Month  + "-" + Day  + "' && R_C_NUMBER =" + ChildID  + " && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && Day != null && ChildID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year + "-" + Month + "-" + Day + "' && R_C_NUMBER =" + ChildID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && Day != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year  + "-" + Month  + "-" + Day  + "' && R_C_NUMBER =" + ChildID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && Day != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year + "-" + Month + "-" + Day + "' && R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && Month != null && Day != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE cast(R_DATE_REFFERED as date) = '" + Year  + "-" + Month  + "-" + Day  + "' && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && ChildID != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && month(R_DATE_REFFERED) = month(" + Month + ") && R_C_NUMBER =" + ChildID + " && R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && Month != null && ChildID != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && month(R_DATE_REFFERED) = month(" + Month  + ") && R_C_NUMBER =" + ChildID  + " && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && ChildID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && month(R_DATE_REFFERED) = month(" + Month + ") && R_C_NUMBER =" + ChildID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && Month != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && month(R_DATE_REFFERED) = month(" + Month  + ") && R_C_NUMBER =" + ChildID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && Month != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                   " WHERE year(R_DATE_REFFERED) = year(" + Year + ") && month(R_DATE_REFFERED) = month(" + Month + ") && R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && Month != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                   " WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && month(R_DATE_REFFERED) = month(" + Month  + ") && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && ChildID != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && R_C_NUMBER =" + ChildID + " && R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && ChildID != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && R_C_NUMBER =" + ChildID  + " && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && ChildID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && R_C_NUMBER =" + ChildID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && R_C_NUMBER =" + ChildID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ") && R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ") && R_THERAPIST =" + TherapistID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && Year != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year + ")" + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && Year != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE year(R_DATE_REFFERED) = year(" + Year  + ")", objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && ChildID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE R_C_NUMBER =" + ChildID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && ChildID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE R_C_NUMBER =" + ChildID , objDBConnect.sqlConn);
                }

                else if (Report == "Theraphies" && TherapistID != null && TheraphyType != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE R_THERAPIST =" + TherapistID + "&& T_TYPE =" + TheraphyType, objDBConnect.sqlConn);
                }

                else if (Report =="Theraphies" && TherapistID != null)
                {
                    objDBConnect.sqlCmd = new SqlCommand(@"" + SelectStatement +
                    "WHERE R_THERAPIST =" + TherapistID, objDBConnect.sqlConn);
                }

                else
                    objDBConnect.sqlCmd = new SqlCommand(SelectStatement, objDBConnect.sqlConn);
            }

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

        //**********************************************************************************
    }
}

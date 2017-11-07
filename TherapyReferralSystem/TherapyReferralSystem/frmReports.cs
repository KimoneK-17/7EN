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
        DataSet dataset;
        DataTable datatable;
        string Query;
        private string username;


        public frmReports()
        {
        }

        public frmReports(string username, string type)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
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
            displayReport();

        }

        //**********************************************************************************
        //display information in datagrid view based on selections on what to search, and what information should be called from db
        public void addReport()
        {

            if (cboxReport.SelectedItem.ToString().Equals("ADD & ADHD Therapy"))
            {
                lblHouse.Visible = false;
                lblCluster.Visible = false;
                txtCluster.Visible = false;
                txtHouse.Visible = false;

                lblChildID.Visible = true;
                txtChildID.Visible = true;
                lblTherID.Visible = true;
                txtTherapistID.Visible = true;
                lblYear.Visible = true;
                DTPYear.Visible = true;
                DTPDay.Visible = true;
                lblDay.Visible = true;
                lblMonth.Visible = true;
                DTPMonth.Visible = true;
                btnShowReport.Visible = true;

                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_SESSION, R_DATE_START, R_DATE_ENDED, R_DETAILS, R_THERAPIST, R_REPORT, R_RESULT
                                    FROM THERAPY_REF
                                    Where R_REASON like 'ADD' and ";

                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " R_THERAPIST = " + txtTherapistID.Text + " and";
                }

                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " R_C_NUMBER = " + txtChildID.Text + " and";
                }

                if (DTPDay.Checked==true)
                {
                    Query = Query + " DAY(R_DATE_START) = " + DTPDay.Text + " and";
                }

                if (DTPMonth.Checked == true)
                {
                    Query = Query + " MONTH(R_DATE_START) = " + DTPMonth.Text + " and";
                }

                if (DTPYear.Checked == true)
                {
                    Query = Query + " year(R_DATE_START) = " + DTPYear.Text + " and";
                }
            }
        }
        public void childInformationReport()
        {
            
            if (cboxReport.SelectedItem.ToString().ToUpper().Equals("CHILD INFORMATION"))
            {
                txtTherapistID.Visible = false;
                lblTherID.Visible = false;
                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;
                lblDay.Visible = false;
                lblMonth.Visible = false;
                lblYear.Visible = false;
                DTPDay.Visible = false;
                DTPMonth.Visible = false;
                DTPYear.Visible = false;
                lblCluster.Visible = true;
                lblHouse.Visible = true;
                txtCluster.Visible = true;
                txtHouse.Visible = true;
                lblChildID.Visible = true;
                txtChildID.Visible = true;

                btnShowReport.Visible = true;
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
                    Query = Query + " C_NUMBER like '" + txtChildID.Text + "' and";
                }



            }


        }

        public void therapistInformationReport()
        {
            
            if (cboxReport.SelectedItem.ToString().ToUpper().Equals("THERAPIST INFORMATION"))
            {
                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;
                lblDay.Visible = false;
                lblMonth.Visible = false;
                lblYear.Visible = false;
                DTPDay.Visible = false;
                DTPMonth.Visible = false;
                DTPYear.Visible = false;
                lblCluster.Visible = false;
                lblHouse.Visible = false;
                txtCluster.Visible = false;
                txtHouse.Visible = false;
                lblChildID.Visible = false;
                txtChildID.Visible = false;
                lblTherID.Visible = true;
                txtTherapistID.Visible = true;

                btnShowReport.Visible = true;


                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = @"Select * from tbl_user where u_type like 'Therapist' and u_id like '" + txtTherapistID.Text + "'";
                }
                else
                {
                    Query = @"Select * from tbl_user where u_type like 'Therapist'";
                }
            }

        }

        public void outsideResource()
        {

            if (cboxReport.SelectedItem.ToString().Equals("Waiting on outside resource"))
            {
                lblTherID.Visible = false;
                txtTherapistID.Visible = false;
                lblTherapyType.Visible = false;
                cboxTherapyType.Visible = false;
                lblDay.Visible = false;
                lblMonth.Visible = false;
                lblYear.Visible = false;
                DTPDay.Visible = false;
                DTPMonth.Visible = false;
                DTPYear.Visible = false;
                lblCluster.Visible = false;
                lblHouse.Visible = false;
                txtCluster.Visible = false;
                txtHouse.Visible = false;
                lblChildID.Visible = false;
                txtChildID.Visible = false;
                Query = "SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_WAITING_LIST FROM THERAPY_REF";

            }
        }
        public void therapyRef()
        {
            if (cboxReport.SelectedItem.ToString().ToUpper().Equals("THERAPY"))
            {

                lblHouse.Visible = false;
                lblCluster.Visible = false;
                txtCluster.Visible = false;
                txtHouse.Visible = false;
                lblTherID.Visible = true;
                txtTherapistID.Visible = true;
                lblChildID.Visible = true;
                txtChildID.Visible = true;
                lblTherapyType.Visible = true;
                cboxTherapyType.Visible = true;
                lblYear.Visible = true;
                DTPYear.Visible = true;
                DTPDay.Visible = true;
                lblDay.Visible = true;
                lblMonth.Visible = true;
                DTPMonth.Visible = true;

                btnShowReport.Visible = true;
                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_STATUS, R_SESSION, R_DATE_START, R_DATE_ENDED, R_DETAILS, R_THERAPIST, R_REPORT, R_RESULT 
                                    FROM THERAPY_REF
                                    INNER JOIN CHILD on R_C_NUMBER = C_NUMBER
                                    INNER JOIN TBL_USER on R_THERAPIST = U_ID";


                if (!txtTherapistID.Text.Equals("") || !txtChildID.Text.Equals("") || cboxTherapyType.SelectedIndex > -1)
                {
                    Query = Query + " where";
                }
                if (!txtTherapistID.Text.Equals(""))
                {
                    Query = Query + " R_THERAPIST = " + txtTherapistID.Text + " and";
                }
                if (!txtChildID.Text.Equals(""))
                {
                    Query = Query + " R_C_NUMBER like '" + txtChildID.Text + "' and";
                }
                if (cboxTherapyType.SelectedIndex > -1)
                {
                    Query = Query + " R_REASON like '" + cboxTherapyType.SelectedItem.ToString() + "' and";
                }
                if (DTPDay.Checked == true)
                {
                    Query = Query + " DAY(R_DATE_START) = " + DTPDay.Text + " and";
                }

                if (DTPMonth.Checked == true)
                {
                    Query = Query + " MONTH(R_DATE_START) = " + DTPMonth.Text + " and";
                }

                if (DTPYear.Checked == true)
                {
                    Query = Query + " year(R_DATE_START) = " + DTPYear.Text + " and";
                }

            }
        }

        public void displayReport()
        {
            
            childInformationReport();
            therapistInformationReport();
            therapyRef();
            outsideResource();
            addReport();
            if (Query.Contains("and"))
            {
                Query = Query.Substring(0, Query.LastIndexOf("and")).Trim();
            }


            try
            {
                objDBConnect.OpenConnection();
                objDBConnect.sqlCmd = new SqlCommand(Query, objDBConnect.sqlConn);
                objDBConnect.sqlDA = new SqlDataAdapter();
                datatable = new DataTable();
                objDBConnect.sqlDA.SelectCommand = objDBConnect.sqlCmd;
                objDBConnect.sqlDA.Fill(datatable);
                DGVReport.DataSource = datatable;
                DGVReport.AutoResizeColumns();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                objDBConnect.sqlConn.Close();
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            displayReport();
            resetFields();
        }

        public void resetFields()
        {
            txtChildID.Text = "";
            txtCluster.Text = "";
            txtHouse.Text = "";
            txtTherapistID.Text = "";
            cboxTherapyType.SelectedIndex = -1;
            /*DTPDay.Value = DateTime.Now;


            DTPMonth.Value = DateTime.Now;
            DTPYear.Value = DateTime.Now;*/


            Query = "";
        }
        //**********************************************************************************
    }
}

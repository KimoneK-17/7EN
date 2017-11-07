using System;
using System.Collections;
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

        DataTable datatable;
        string Query;
        private string username;
        //global variables:

        //for printing
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();

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


        //******************************************************************
        //print of report
        private void mnuReportsPrintRep_Click(object sender, EventArgs e)
        {
            //Open the print preview dialog
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1;
            objPPdialog.ShowDialog();
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
                Query = @"SELECT R_ID, R_C_NUMBER, R_DIAGNOSIS, R_REASON, R_WAITING_LIST, U_FNAME+' '+U_SNAME as Therapist FROM THERAPY_REF r
                            inner join tbl_user t
                            on r.R_THERAPIST = t.U_ID
                            where t.T_IE like 'E'
                            and R_WAITING_LIST like 'YES'";

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
                                    INNER JOIN TBL_USER on R_THERAPIST = U_ID ";


                if (!txtTherapistID.Text.Equals("") || !txtChildID.Text.Equals("") || cboxTherapyType.SelectedIndex > -1 || DTPDay.Checked == true || DTPMonth.Checked == true || DTPYear.Checked == true)
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
                this.DGVReport.Columns[0].Frozen = true;

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

            Query = "";
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile pr = new frmProfile(type);
            pr.Show();
            this.Hide();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                int iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in DGVReport.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;

                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in DGVReport.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                            (double)iTotalWidth * (double)iTotalWidth *
                            ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                            GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headers
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= DGVReport.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = DGVReport.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allows more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            //Draw Header
                            e.Graphics.DrawString("LIV Referal System",
                                new Font(DGVReport.Font, FontStyle.Bold),
                                Brushes.Black, e.MarginBounds.Left,
                                e.MarginBounds.Top - e.Graphics.MeasureString("LIV Referal System",
                                new Font(DGVReport.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " +
                                DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate,
                                new Font(DGVReport.Font, FontStyle.Bold), Brushes.Black,
                                e.MarginBounds.Left +
                                (e.MarginBounds.Width - e.Graphics.MeasureString(strDate,
                                new Font(DGVReport.Font, FontStyle.Bold),
                                e.MarginBounds.Width).Width),
                                e.MarginBounds.Top - e.Graphics.MeasureString("LIV Referal System",
                                new Font(new Font(DGVReport.Font, FontStyle.Bold),
                                FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in DGVReport.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(),
                                    Cel.InheritedStyle.Font,
                                    new SolidBrush(Cel.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount],
                                    (float)iTopMargin,
                                    (int)arrColumnWidths[iCount], (float)iCellHeight),
                                    strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black,
                                new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                (int)arrColumnWidths[iCount], iCellHeight));
                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }
                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        //**********************************************************************************
    }
}

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
using Microsoft.VisualBasic;

namespace TherapyReferralSystem
{
    public partial class frmTherapyReferral : Form
    {

        String condition;
        String details;
        String result;
        string t_c_num, t_c_name, t_refby, t_reason, t_report, t_type, t_status, t_therapist, ref_date, start_date, end_date, w_list;
        int t_sessions;
        string therapyid;
        DBConnect objDBConnect = new DBConnect();
     


        SharedMethods sm = new SharedMethods();
        private string username;
        private string type;

        public frmTherapyReferral()
        {
            
        }

        public frmTherapyReferral(string username, string type)
        {
            this.username = username;
            this.type = type;
            InitializeComponent();
        }

        public bool checkComboBoxes()
        {
            bool valid;
            Boolean validCNum = false;
            Boolean validReason = false;
            Boolean validRef = false;
            Boolean validReport = false;
            Boolean validType = false;
            Boolean validStatus = false;
            Boolean validTherapist = false;
            if (cmbCNum.SelectedIndex > -1)
            {
                validCNum = true;
            }
            if (cmbReason.SelectedIndex > -1)
            {
                validReason = true;
            }
            if (cmbRefBy.SelectedIndex > -1)
            {
                validRef = true;
            }
            if (cmbReport.SelectedIndex > -1)
            {
                validReport = true;
            }
            if (cmbType.SelectedIndex > -1)
            {
                validType = true;
            }
            if (cmbStatus.SelectedIndex > -1)
            {
                validStatus = true;
            }
            if (cmbTherapist.SelectedIndex > -1)
            {
                validTherapist = true;
            }

            if (validCNum == false)
            {
                lbl1.Text = "Select a childs name";
            }
            if (validReason == false)
            {
                lbl3.Text = "Select a reason";
            }
            if (validRef == false)
            {
                lbl9.Text = "Select a reference";
            }
            if (validReport == false)
            {
                lbl8.Text = "Select a Report";
            }
            if (validType == false)
            {
                lbl5.Text = "Select a session";
            }
            if (validStatus == false)
            {
                lbl4.Text = "Select a status";
            }
            if (validTherapist == false)
            {
                lbl7.Text = "Select a Therapist";
            }

            if (validCNum == true && validReason == true && validRef == true && validReport == true && validType == true && validStatus == true && validTherapist == true)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }
        public bool checkText(String con, String det, String res)
        {
            bool validText = false;
            Boolean validCon = false;
            Boolean validDet = false;
            Boolean validRes = false;
            if (!con.Any(char.IsLetter) || con.Any(char.IsDigit) || con.Equals(""))
            {
                validCon = false;
                lbl2.Text = "Enter a valid Condition";
            }
            else
            {
                validCon = true;
            }

            if (!det.Any(char.IsLetter) || det.Any(char.IsDigit) || det.Equals(""))
            {
                validDet = false;
                lbl12.Text = "Enter valid Details";
            }
            else
            {
                validDet = true;
            }

            if (!res.Any(char.IsLetter) || res.Any(char.IsDigit) || res.Equals(""))
            {
                validRes = false;
                MessageBox.Show("Enter a valid result");
            }
            else
            {
                validRes = true;
            }

            if (validCon == false || validDet == false || validRes == false)
            {
                validText = false;
                return validText;
            }
            else
            {
                validText = true;
                return validText;
            }
        }

        private void frmTherapyReferral_Load(object sender, EventArgs e)
        {
            updateToolStripMenuItem.Enabled = false;
            populateChildNumberCMB();
            populateTherapist();
            if (type.Equals("Therapist") || type.Equals("Teacher") || type.Equals("Clinic"))
            {
                mnuTherapyRefRegChild.Enabled = false;
                mnuTherapyRefRegUser.Enabled = false;

            }

            label1.Hide();
            dtpDateEnd.Hide();
            

        }


        public void populateTherapist()
        {
            objDBConnect.OpenConnection();

            try
            {
                objDBConnect.sqlCmd = new SqlCommand("select U_ID, U_FNAME+' '+U_SNAME as name from tbl_user where U_TYPE like 'Therapist'", objDBConnect.sqlConn);


                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("name", typeof(string));
                dt.Load(objDBConnect.sqlDR);
                cmbTherapist.DisplayMember = "name";
                cmbTherapist.ValueMember = "U_ID";
                cmbTherapist.DataSource = dt;


            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                objDBConnect.sqlConn.Close();
            }
        }
        public void populateChildNumberCMB()
        {

            objDBConnect.OpenConnection();

            try
            {
                objDBConnect.sqlCmd = new SqlCommand("select c_number from child", objDBConnect.sqlConn);


                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("c_number", typeof(string));
                dt.Load(objDBConnect.sqlDR);
                cmbCNum.ValueMember = "c_number";
                cmbCNum.DataSource = dt;


            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                objDBConnect.sqlConn.Close();
            }


        }

        private void chbEnd_CheckedChanged(object sender, EventArgs e)
        {

            if (chbEnd.Checked == true)
            {
                label1.Show();
                dtpDateEnd.Show();
                var date = dtpDateStart.Value.Date;
                var month = dtpDateStart.Value.Month;
                var year = dtpDateStart.Value.Year;



                end_date = dtpDateEnd.Value.ToString("yyyy-MM-dd");


            }
            else
            {
                label1.Hide();
                dtpDateEnd.Hide();
                end_date = DBNull.Value.ToString();


            }
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            dtpDateEnd.MinDate = Convert.ToDateTime(dtpDateStart.Value);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            therapyid = Interaction.InputBox("Enter Therapy ID You Want To Delete", "Delete", "Therapy ID");

            if (!therapyid.Equals(""))
            {

                bool checks = isNumeric(therapyid);


                while (checks == false)
                {
                    therapyid = Interaction.InputBox("Enter Therapy ID You Want To Delete", "Delete", "Therapy ID");

                    checks = isNumeric(therapyid);
                }
                if (checks == true)
                {
                    check();
                }


            }


        }

        public void check()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete information for therapy referral id :" + therapyid, "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                deleteTherapyRef();
            }
            else if (result == DialogResult.No)
            {
                //...
            }
            else
            {
                //...
            }
        }
        public static bool isNumeric(String str)
        {
            try
            {
                int d = int.Parse(str);
            }
            catch (FormatException nfe)
            {
                return false;
            }
            return true;
        }
        private void deleteTherapyRef()
        {

            bool found = sm.CheckExisting("therapy_ref", "R_ID", therapyid);
            while (found == false)
            {
                found = sm.CheckExisting("therapy_ref", "R_ID", therapyid);
            }
            if (found == true)
            {
                objDBConnect.OpenConnection();
                try
                {
                    objDBConnect.sqlCmd = new SqlCommand("DELETE FROM therapy_ref WHERE R_ID = @R_ID", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@R_ID", therapyid);


                    objDBConnect.sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Child Deleted");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    objDBConnect.sqlConn.Close();
                }
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            therapyid = Interaction.InputBox("Enter Therapy ID You Want To Delete", "Delete", "Therapy ID");
            if (!therapyid.Equals(""))
            {

                bool checks = isNumeric(therapyid);


                while (checks == false)
                {
                    therapyid = Interaction.InputBox("Enter Therapy ID You Want To Delete", "Delete", "Therapy ID");

                    checks = isNumeric(therapyid);
                }
                if (checks == true)
                {
                    searchTherapy();
                    updateToolStripMenuItem.Enabled = true;
                }


            }
        }

        private void searchTherapy()
        {
            try
            {
                objDBConnect.OpenConnection();
                string sqlquery = "select (select c_number from child c where c.c_number = r.r_c_number) as c_num,R_DIAGNOSIS,R_REASON,R_STATUS,R_SESSION,R_REFFERED_BY,R_DATE_REFFERED,R_DATE_START,R_WAITING_LIST,R_DATE_ENDED,R_NUM_OF_SESSION,R_DETAILS,(select U_FNAME+' '+U_SNAME from tbl_user u where u.u_id = r.r_therapist) as u_name,R_REPORT,R_RESULT from therapy_ref r WHERE R_ID = @R_ID";

                objDBConnect.sqlCmd = new SqlCommand(sqlquery, objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_ID", therapyid);
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                while (objDBConnect.sqlDR.Read())
                {

                    txtCondition.Text = objDBConnect.sqlDR["R_DIAGNOSIS"].ToString();
                    rtxtDetails.Text = objDBConnect.sqlDR["R_DETAILS"].ToString();
                    rtxtResult.Text = objDBConnect.sqlDR["R_RESULT"].ToString();
                    w_list = objDBConnect.sqlDR["R_WAITING_LIST"].ToString();

                    int iNumber = cmbCNum.Items.IndexOf(objDBConnect.sqlDR["c_num"].ToString());
                    cmbCNum.SelectedIndex = iNumber;
                    int iReason = cmbReason.Items.IndexOf(objDBConnect.sqlDR["R_REASON"].ToString());
                    cmbReason.SelectedIndex = iReason;
                    int iStaus = cmbStatus.Items.IndexOf(objDBConnect.sqlDR["R_STATUS"].ToString());
                    cmbStatus.SelectedIndex = iStaus;
                    int iSession = cmbType.Items.IndexOf(objDBConnect.sqlDR["R_SESSION"].ToString());
                    cmbType.SelectedIndex = iSession;
                    int iNumSess;
                    if (int.TryParse(objDBConnect.sqlDR["R_NUM_OF_SESSION"].ToString(), out iNumSess))
                    {
                        nudSess.Value = iNumSess;
                    }
                    int iTherapist = cmbTherapist.Items.IndexOf(objDBConnect.sqlDR["u_name"].ToString());
                    cmbTherapist.SelectedIndex = iTherapist;
                    int iReport = cmbReport.Items.IndexOf(objDBConnect.sqlDR["R_REPORT"].ToString());
                    cmbReport.SelectedIndex = iReport;
                    int iRefBy = cmbRefBy.Items.IndexOf(objDBConnect.sqlDR["R_REFFERED_BY"].ToString());
                    cmbRefBy.SelectedIndex = iRefBy;
                    dtpDateRef.Value = Convert.ToDateTime(objDBConnect.sqlDR["R_DATE_REFFERED"].ToString());

                    if (w_list.Equals("YES"))
                    {
                        chkWaitingList.Checked = true;
                    }
                    else
                    {
                        dtpDateStart.Value = Convert.ToDateTime(objDBConnect.sqlDR["R_DATE_START"].ToString());
                        dtpDateEnd.Value = Convert.ToDateTime(objDBConnect.sqlDR["R_DATE_END"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail: " + ex.Message);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTherapy();
        }

        public void updateTherapy()
        {
            validate();
            getFields();
            try
            {
                objDBConnect.OpenConnection();


                objDBConnect.sqlCmd = new SqlCommand("UPDATE therapy_ref SET R_DIAGNOSIS=@R_DIAGNOSIS,R_REASON=@R_REASON,R_STATUS=@R_STATUS,R_SESSION=@R_SESSION,R_REFFERED_BY=@R_REFFERED_BY,R_DATE_REFFERED=@R_DATE_REFFERED,R_DATE_START=@R_DATE_START,R_WAITING_LIST=@R_WAITING_LIST,R_DATE_ENDED=@R_DATE_ENDED,R_NUM_OF_SESSION=@R_NUM_OF_SESSION,R_DETAILS=@R_DETAILS,R_THERAPIST=@R_THERAPIST,R_REPORT=@R_REPORT,R_RESULT=@R_RESULT WHERE R_ID = @R_ID", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_ID", therapyid);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DIAGNOSIS", condition);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REASON", t_reason);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_STATUS", t_status);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_SESSION", t_type);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REFFERED_BY", t_refby);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_REFFERED", DateTime.Parse(ref_date));
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_START", start_date);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_WAITING_LIST", w_list);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_ENDED", end_date);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_NUM_OF_SESSION", t_sessions);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DETAILS", details);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_THERAPIST", t_therapist);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REPORT", t_report);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_RESULT", result);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("Successfully Updated");

                updateToolStripMenuItem.Enabled = false;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cannot add child details " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot UPDATE child Details: " + ex.Message + ex.Data + ex.StackTrace);
            }
            finally
            {
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();

            }
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile pr = new frmProfile(username);
            pr.Show();
            this.Dispose();
        }

        private void chkWaitingList_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWaitingList.Checked == true)
            {
                w_list = "YES";
                label9.Hide();
                dtpDateStart.Hide();
                chbEnd.Hide();

                end_date = DBNull.Value.ToString();
                start_date = DBNull.Value.ToString();
            }
            else
            {
                w_list = "NO";
                label9.Show();
                dtpDateStart.Show();
                chbEnd.Show();
            }
        }

        public void validate()
        {
            condition = txtCondition.Text;
            details = rtxtDetails.Text;
            result = rtxtResult.Text;
            if (checkComboBoxes() == false && checkText(condition, details, result) == false)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void btnAddRef_Click(object sender, EventArgs e)
        {
            validate();
            getFields();
            insertFieldsIntoDB();

            MessageBox.Show(" " + t_c_num + "\n" + t_refby + "\n" + t_report + "\n" + t_type + "\n" + t_status + "\n" + t_therapist + "\n" + ref_date + "\n" + start_date + "\n" + end_date);

        }

        private void getFields()
        {
            try
            {
                t_c_num = cmbCNum.SelectedValue.ToString();
                t_reason = cmbReason.SelectedItem.ToString();
                t_refby = cmbRefBy.SelectedItem.ToString();
                t_report = cmbReport.SelectedItem.ToString();
                t_type = cmbType.SelectedItem.ToString();
                t_status = cmbStatus.SelectedItem.ToString();
                t_therapist = cmbTherapist.SelectedValue.ToString();
                t_sessions = (int)nudSess.Value;
            }

            catch (Exception exa)
            {
                MessageBox.Show(exa.Message);
            }
            ref_date = dtpDateRef.Value.ToString("yyyy-MM-dd");

            if (chkWaitingList.Checked == true)
            {

                start_date = DBNull.Value.ToString();
                end_date = DBNull.Value.ToString();
            }
            else
            {
                w_list = "NO";
                start_date = dtpDateStart.Value.ToString("yyyy-MM-dd");
            }

            if (chbEnd.Checked == false)
            {
                end_date = DBNull.Value.ToString();
            }
            else
            {
                end_date = dtpDateEnd.Value.ToString("yyyy-MM-dd");
            }

        }

        public void getChildName()
        {
            t_c_num = cmbCNum.SelectedValue.ToString();
            MessageBox.Show(t_c_num);
            try
            {
                objDBConnect.OpenConnection();
                objDBConnect.sqlCmd = new SqlCommand("SELECT C_FNAME+' '+C_SNAME FROM child where c_number like @c_number", objDBConnect.sqlConn); // gets information by email identification
                objDBConnect.sqlCmd.Parameters.AddWithValue("@C_NUMBER", t_c_num);

                t_c_name = (string)objDBConnect.sqlCmd.ExecuteScalar();
                MessageBox.Show(t_c_name);
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
        private void insertFieldsIntoDB()
        {
            getChildName();
            DBConnect objDBConnect = new DBConnect();

            try
            {
                objDBConnect.OpenConnection();


                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Therapy_Ref VALUES (@R_C_NUMBER,@R_C_NAME,@R_DIAGNOSIS,@R_REASON,@R_STATUS,@R_SESSION,@R_REFFERED_BY,@R_DATE_REFFERED,@R_DATE_START,@R_WAITING_LIST,@R_DATE_ENDED,@R_NUM_OF_SESSION,@R_DETAILS,@R_THERAPIST,@R_REPORT,@R_RESULT)", objDBConnect.sqlConn);

                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_C_NUMBER", t_c_num);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_C_NAME", t_c_name);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DIAGNOSIS", condition);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REASON", t_reason);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_STATUS", t_status);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_SESSION", t_type);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REFFERED_BY", t_refby);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_REFFERED", DateTime.Parse(ref_date));
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_START", start_date);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_WAITING_LIST", w_list);


                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_ENDED", end_date);


                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_NUM_OF_SESSION", t_sessions);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DETAILS", details);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_THERAPIST", t_therapist);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REPORT", t_report);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_RESULT", result);

                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("Successfully Inserted");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cannot add referral details " + ex.Message + ex.StackTrace + ex.Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Add referral Details: " + ex.Message + ex.Data + ex.StackTrace);
            }
        }

        private void mnuTherapyRefReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }

        private void mnuTherapyRefReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports(type);
            rep.Show();
            this.Dispose();
        }

        private void mnuTherapyRefHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp(username,type);
            help.Show();
            this.Dispose();
        }

        private void mnuTherapyRefRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild(username,type);
            rc.Show();
            this.Dispose();
        }

        private void mnuTherapyRefRegUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser(username,type);
            ru.Show();
            this.Dispose();
        }


    }
}

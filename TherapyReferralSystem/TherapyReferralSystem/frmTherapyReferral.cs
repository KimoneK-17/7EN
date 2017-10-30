﻿using System;
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
    public partial class frmTherapyReferral : Form
    {
        String condition;
        String details;
        String result;
        string t_c_num, t_refby, t_reason, t_report, t_type, t_status, t_therapist, ref_date, start_date, end_date;
        int t_sessions;
        DBConnect objDBConnect = new DBConnect();
        private string type;

        public frmTherapyReferral()
        {
            
        }

        public frmTherapyReferral(string type)
        {
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
            populateChildNumberCMB();
            populateTherapist();
            if (type.Equals("Therapist") || type.Equals("Teacher") || type.Equals("Clinic"))
            {
                mnuTherapyRefRegChild.Enabled = false;
                mnuTherapyRefRegUser.Enabled = false;
               
            }
          
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
                cmbCNum.DisplayMember = "c_number";
                cmbCNum.ValueMember = "c_number";
                cmbCNum.DataSource = dt;

               
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
            {
                objDBConnect.sqlConn.Close();
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

            MessageBox.Show(" " + t_c_num + "\n" + t_refby + "\n" + t_report + "\n" + t_type + "\n" + t_status + "\n" + t_therapist + "\n" + ref_date + "\n" + start_date + "\n" + end_date);

        }

        private void getFields()
        {
            try
            {
                t_c_num = cmbCNum.SelectedItem.ToString();
                t_reason = cmbReason.SelectedItem.ToString();
                t_refby = cmbRefBy.SelectedItem.ToString();
                t_report = cmbReport.SelectedItem.ToString();
                t_type = cmbType.SelectedItem.ToString();
                t_status = cmbStatus.SelectedItem.ToString();
                t_therapist = cmbTherapist.SelectedItem.ToString();
                ref_date = dtpDateRef.Value.ToString("dd-MM-yyyy");
                start_date = dtpDateStart.Value.ToString("dd-MM-yyyy");
                end_date = dtpDateRef.Value.ToString("dd-MM-yyyy");
                t_sessions = (int)nudSess.Value;
            }
            catch (NoNullAllowedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exa)
            {
                MessageBox.Show(exa.Message);
            }

        }

        private void insertFieldsIntoDB()
        {
            DBConnect objDBConnect = new DBConnect();

            try
            {
                objDBConnect.OpenConnection();


                objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Therapy_Ref VALUES (@R_ID,@R_C_NUMBER,@R_DIAGNOSIS,@R_REASON,@R_STATUS,@R_SESSION,@R_REFFERED_BY,@R_DATE_REFFERED,@R_DATE_START,@R_DATE_ENDED,@R_DETAILS,@R_THERAPIST,@R_REPORT,@R_RESULT)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_ID", " ");//auto increment
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_C_NUMBER", t_c_num);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DIAGNOSIS", condition);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REASON", t_reason);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_STATUS", t_status);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_SESSION", t_sessions);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_REFFERED_BY", t_refby);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_REFFERED DATE", ref_date);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_START DATE", start_date);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_WAITING_LIST DATE", " ");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@R_DATE_ENDED DATE", end_date);
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
                MessageBox.Show("Error cannot add child details " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Add child Details: " + ex.Message + ex.Data + ex.StackTrace);
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
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }

        private void mnuTherapyRefRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild(type);
            rc.Show();
            this.Dispose();
        }

        private void mnuTherapyRefRegUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser();
            ru.Show();
            this.Dispose();
        }


    }
}

﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        public static string username = "";
        string password;
        bool found;
        //public string type;

        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!txtUsername.Text.Equals(""))
            {
                username = txtUsername.Text;
                if (username.Contains("@") && username.Contains("."))
                {
                    if (!txtPassword.Text.Equals(""))
                    {
                        password = txtPassword.Text;
                        found = sm.CheckExisting("tbl_user", "u_email", username);

                        if (found == true)
                        {
                            CheckValid();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect format for email address.\n Example: sample@company.com");
                }

            }
            else
            {
                MessageBox.Show("Ënter Username");
            }
            Cursor.Current = Cursors.Default;
        }



        private void mnuLoginLogout_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mnuLoginHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp("Login");
            help.Show();
            
        }



        private void btnViewPword_Click(object sender, EventArgs e)
        {

            if (!txtPassword.Equals(""))
            {
                if (txtPassword.PasswordChar.Equals('\0'))
                {
                    txtPassword.PasswordChar = '*';
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                }
            }

        }

       
        private void CheckValid()
        {
            
            try
            {
                string checkVal;
                //checks to see if patient already exists in database
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE u_email LIKE @u_email AND u_pword LIKE @u_pword", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_pword", password);

                //parameter
                checkVal = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(checkVal) > 0)
                {

                    //in database
                    checkPword();
                   
                    //this.Dispose();
                }
                else
                {

                    //not in database
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Cannot Check Validation of Users In Database: \n"+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check Validation of Users In Database: \n" + ex.Message); // Shows an error message
            }
            finally
            {
                objDBConnect.sqlConn.Close();
            }
        }

        public void checkPword()
        {
            string pword;

            objDBConnect.OpenConnection();

            try
            {
                objDBConnect.sqlCmd = new SqlCommand("SELECT u_pword FROM tbl_user WHERE u_email LIKE @u_email", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);

                pword = (string)objDBConnect.sqlCmd.ExecuteScalar();

                if (pword.StartsWith("#"))
                {

                    DialogResult result = MessageBox.Show("Password Reset Is Neccessary. Please click OK to reset now or cancel to proceed to profile", "Reset Password",
               MessageBoxButtons.OKCancel);
                    switch (result)
                    {
                        case DialogResult.OK:
                            {
                                frmUserPasswordReset upr = new frmUserPasswordReset(username);
                                upr.Show();
                                this.Hide();
                                break;
                            }
                        case DialogResult.Cancel:
                            {
                                frmProfile pr = new frmProfile(username);
                                pr.Show();
                                this.Hide();
                                break;
                            }
                    }


                }
                else
                {

                    frmProfile pr = new frmProfile(username);
                    pr.Show();
                    this.Hide();
                }
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

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmPasswordRecovery pr = new frmPasswordRecovery();
            pr.Show();
            this.Hide();
        }
    }
}

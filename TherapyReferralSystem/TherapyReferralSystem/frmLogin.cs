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
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        string username;
        string password;
        bool found, checkValid;

        DBConnect objDBConnect = new DBConnect();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(""))
            {
                username = txtUsername.Text;
                if (username.Contains("@") && username.Contains("."))
                {
                    if (!txtPassword.Text.Equals(""))
                    {
                        password = txtPassword.Text;
                        CheckExisting();

                    }
                    else
                    {
                        MessageBox.Show("Enter Password");
                    }
                }

            }
            else
            {
                MessageBox.Show("Ënter Username");
            }
        }

        private void CheckExisting()
        {
            try
            {
                string existName;
                //checks to see if patient already exists in database
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);
                //parameter
                existName = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(existName) > 0)
                {
                    found = true;
                    //in database
                    CheckValid();

                }
                else
                {
                    found = false;
                    //not in database
                    MessageBox.Show("Email address invalid");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check If User  Exists In Database: " + ex.Message); // Shows an error message
            }
        }

        private void mnuLoginLogout_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mnuLoginHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
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

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM tbl_user WHERE u_email LIKE @u_email AND u_pword LIKE @u_pword;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_pword", password);

                //parameter
                checkVal = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(checkVal) > 0)
                {
                    checkValid = true;
                    //in database

                    frmProfile pr = new frmProfile(username);
                    pr.Show();
                    //this.Dispose();
                }
                else
                {
                    checkValid = false;
                    //not in database
                    MessageBox.Show("Invalid credentials");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Check Validation of Users In Database: " + ex.Message); // Shows an error message
            }
        }
    }
}

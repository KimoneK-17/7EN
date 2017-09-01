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
    public partial class frmPasswordRecovery : Form
    {
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }

        string username;
        string password;
        bool found, checkValid;

        DBConnect objDBConnect = new DBConnect();

        string secQuestion;
           
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

        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            getSecQuestion();
        }

        public void getSecQuestion()
        {
            objDBConnect.OpenConnection();

            objDBConnect.sqlCmd = new SqlCommand("SELECT u_secQuest FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
            //query
            objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);
            
                   
                    secQuestion = objDBConnect.sqlCmd.ExecuteScalar().ToString();

            txtSecurityQuestion.Text = secQuestion;
                }
            }


    }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
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
        string randomPassword;
        string securityQues;
        string answer;
        string name;

        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();
        MailMessage email = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
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

       

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            randomPassword=sm.getOTP();

            getAnswer();

        }
        
        

        private void mnuPassRecovReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }

        private void mnuPassRecovHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }

        public void getSecQuestion()
        {
            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT u_sec_Ques FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", txtEmailAddress.Text);


                secQuestion = (string)objDBConnect.sqlCmd.ExecuteScalar();

                txtSecurityQuestion.Text = secQuestion;
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

         }

        private void btnRequestReset_Click(object sender, EventArgs e)
        {
            sendAdminEmail();
        }

        public void getName()
        {
            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT U_FNAME +' '+ U_SNAME FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", txtEmailAddress.Text);


                name = (string)objDBConnect.sqlCmd.ExecuteScalar();

               
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void sendAdminEmail()
        {
            getName();
            try
            {
                email.From = new MailAddress("livotp@gmail.com");
                email.To.Add("livotp@gmail.com");
                email.Subject = "Reset User Password";
                email.Body = "Hi There\n Kindly reset user: "+name+" password. \n Email Address: "+username;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("livotp@gmail.com", "passwordrecovery");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                MessageBox.Show("Please check your email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void getAnswer()
        {
            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT u_sec_Ans FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", txtEmailAddress.Text);


                answer = (string)objDBConnect.sqlCmd.ExecuteScalar();

                if(txtAnswer.Text == answer)
                {
                    sm.sendOTPEmail(txtEmailAddress.Text, "Hi user, this is your newly generated password: #" + randomPassword );
                    sm.updatePassword(txtEmailAddress.Text, randomPassword);
                }
                else
                {
                    MessageBox.Show("Invalid answer, request password change from admin");
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

       


    }
}



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

        public void getOTP()
        {
            randomPassword = Path.GetRandomFileName();
            randomPassword = randomPassword.Replace(".", "");
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            getOTP();

            try
            {
                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                email.From = new MailAddress("kimone001@gmail.com");
                email.To.Add(txtEmailAddress.Text);
                email.Subject = "Test Mail";
                email.Body = "Hi user, this is your newly generated password: " + randomPassword;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            objDBConnect.OpenConnection();

            objDBConnect.sqlCmd = new SqlCommand("SELECT u_secQuest FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
            //query
            objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);
            
                   
                    secQuestion = objDBConnect.sqlCmd.ExecuteScalar().ToString();

            txtSecurityQuestion.Text = secQuestion;
                }
            }


    }



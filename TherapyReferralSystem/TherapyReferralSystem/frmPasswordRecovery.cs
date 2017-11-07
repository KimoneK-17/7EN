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
        string randomPassword;
        string answer;
        string name;
        string secQuestion;
        bool found;
        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();
        MailMessage email = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");




        private void btnGetQuestion_Click(object sender, EventArgs e)
        {
            if (!txtEmailAddress.Text.Equals(""))
            {
                if (txtEmailAddress.Text.Contains("@") && txtEmailAddress.Text.Contains("."))
                {
                    username = txtEmailAddress.Text;

                    found = sm.CheckExisting("tbl_user", "U_EMAIL", username);
                    if (found == true)
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        getSecQuestion();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect format for email address.\nExample: sample@company.com");
                }


            }
            else
            {
                MessageBox.Show("Enter Email Address");
            }


        }



        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (!txtEmailAddress.Text.Equals(""))
            {
                if (txtEmailAddress.Text.Contains("@") && txtEmailAddress.Text.Contains("."))
                {
                    username = txtEmailAddress.Text;

                    found = sm.CheckExisting("tbl_user", "U_EMAIL", username);
                    if (found == true)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        randomPassword = sm.getOTP();

                        getAnswer();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect format for email address.\nExample: sample@company.com");
                }


            }
            else
            {
                MessageBox.Show("Enter Email Address");
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
            frmHelp help = new frmHelp("PwordRecover");
            help.Show();
            
        }

        public void getSecQuestion()
        {

            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT u_sec_Ques FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);


                secQuestion = (string)objDBConnect.sqlCmd.ExecuteScalar();

                txtSecurityQuestion.Text = secQuestion;

                lblAnswer.Show();
                txtAnswer.Show();
                btnSubmitAnswer.Show();
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

        private void btnRequestReset_Click(object sender, EventArgs e)
        {

            if (!txtEmailAddress.Text.Equals(""))
            {
                if (txtEmailAddress.Text.Contains("@") && txtEmailAddress.Text.Contains("."))
                {
                    username = txtEmailAddress.Text;

                    found = sm.CheckExisting("tbl_user", "U_EMAIL", username);
                    if (found == true)
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        sendAdminEmail();
                        Cursor.Current = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect format for email address.\nExample: sample@company.com");
                }


            }
            else
            {
                MessageBox.Show("Enter Email Address");
            }
        }

        public void getName()
        {
            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT U_FNAME +' '+ U_SNAME FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);


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
                email.Body = "Hi There\n Kindly reset user: " + name + " password. \n Email Address: " + username;

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

        private void frmPasswordRecovery_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblAnswer.Hide();
            txtAnswer.Hide();
            btnSubmitAnswer.Hide();
        }

        public void getAnswer()
        {
            try
            {
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT u_sec_Ans FROM tbl_user WHERE u_email LIKE @u_email;", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@u_email", username);


                answer = (string)objDBConnect.sqlCmd.ExecuteScalar();

                if (txtAnswer.Text == answer)
                {
                    sm.sendOTPEmail(txtEmailAddress.Text, "Hi user, this is your One Time Password(OTP): #" + randomPassword+" .\n Please use this the next time you login");
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



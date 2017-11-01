using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmUserPasswordReset : Form
    {
        
        public frmUserPasswordReset()
        {
        }

        public frmUserPasswordReset(string username, string type)
        {
            this.username = username;
            this.type = type;
            InitializeComponent();
        }

        SharedMethods sm = new SharedMethods();
        DBConnect objDBConnect = new DBConnect();

        string email, otp, npword, cpword;
        bool found, valid = true;
        private string username;
        private string type;

        private void backToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin1 log = new frmLogin1();
            log.Show();
            this.Hide();
        }

        private void frmUserPasswordReset_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(type);
        }

        private void btnChangePword_Click(object sender, EventArgs e)
        {
            clearRequired();
            getFields();
            valid = check();

            if (valid == true)
            {

                found = sm.CheckExisting("tbl_user", "U_EMAIL", email);

                if (found == true)
                {

                    sm.updatePassword(email, npword);
                    frmProfile pr = new frmProfile();
                    pr.Show();
                    this.Dispose();

                }
                else
                {
                    lblREmail.Text = "*Email does not exist";
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }


        }

        public void getFields()
        {
            email = txtEmail.Text;
            otp = txtOTP.Text;
            npword = txtNPword.Text;
            cpword = txtConPword.Text;

        }

        public bool check()
        {

            if (email.Equals(""))
            {
                lblREmail.Text = "*Enter an email address";
                valid = false;
            }

            if (!email.Contains("@") && !email.Contains("."))
            {

                lblREmail.Text = "*Enter a valid email address";
                valid = false;
            }

            if (otp.Equals("") && !(otp.StartsWith("#")))
            {

                lblROTP.Text = "*Please enter valid OTP from email sent to you";
                valid = false;
            }
            if (npword.Equals(""))
            {
                lblRNPword.Text = "*Enter new password";
                valid = false;
            }

            if (cpword.Equals(""))
            {
                lblRCPword.Text = "*Confirm password";
                valid = false;
            }
            if (!npword.Equals(cpword))
            {
                lblRCPword.Text = "*This password does not match";
                valid = false;
            }

            return valid;
        }

        public void clearRequired()
        {
            lblRCPword.Text = "*";
            lblREmail.Text = "*";
            lblRNPword.Text = "*";
            lblROTP.Text = "*";
        }
    }
}

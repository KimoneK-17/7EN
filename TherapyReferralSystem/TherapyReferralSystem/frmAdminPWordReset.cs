﻿using System;
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
    public partial class frmAdminPWordReset : Form
    {
        public frmAdminPWordReset()
        {
            InitializeComponent();
        }



        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();
        string randomPassword;
        bool found;
        private string type;
        private string type1;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Equals(""))
            {
                if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                {
                    found = sm.CheckExisting("tbl_user", "U_EMAIL", txtEmail.Text);
                    if (found == true)
                    {
                        randomPassword = sm.getOTP();
                        sm.sendOTPEmail(txtEmail.Text, "Hi There\n Please use the following password the next time you login\n OTP: #" + randomPassword);
                        sm.updatePassword(txtEmail.Text, randomPassword);
                        this.Dispose();
                    }
                    else
                    {
                        lblREmail.Text = "*Email Address Not Found";
                    }
                }
                else
                {
                    lblREmail.Text = "*Invalid Format. (example@something.com)";
                }


            }
            else
            {
                lblREmail.Text = "*Enter an email address";
            }


        }


        private void mnuAdminPRReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }

        private void mnuAdminPRReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports(type);
            rep.Show();
            this.Dispose();
        }

        private void mnuAdminPRHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }



        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile pr = new frmProfile();
            pr.Show();
            this.Hide();
        }
    }
}

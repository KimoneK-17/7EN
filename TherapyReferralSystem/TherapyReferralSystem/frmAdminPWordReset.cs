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


    }
}

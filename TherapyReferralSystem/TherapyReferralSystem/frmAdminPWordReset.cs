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
        private void btnReset_Click(object sender, EventArgs e)
        {
            randomPassword = sm.getOTP();
            sm.sendOTPEmail(txtEmail.Text, "Hi There\n Please use the following password the next time you login\n OTP: #"+randomPassword);
            sm.updatePassword(txtEmail.Text, randomPassword);
        }

       
    }
}

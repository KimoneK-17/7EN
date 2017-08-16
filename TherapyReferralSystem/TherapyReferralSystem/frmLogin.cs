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
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }

        string username;
        string password;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!txtUsername.Equals(""))
            {
                username = txtUsername.Text;
                if(!password.Equals(""))
                {
                    password = txtPassword.Text;
                }
                else
                {
                    MessageBox.Show("Enter Password");
                }
            }
            else
            {
                MessageBox.Show("Ënter Username");
            }
        

            
        }
    }
}

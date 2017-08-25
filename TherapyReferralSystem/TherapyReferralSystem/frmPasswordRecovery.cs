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
    public partial class frmPasswordRecovery : Form
    {
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin1 loginForm = new frmLogin1();
                this.Hide();
                loginForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void lblEmailUsername_Click(object sender, EventArgs e)
        {

        }

        private void frmPasswordRecovery_Load(object sender, EventArgs e)
        {

        }
    }
}

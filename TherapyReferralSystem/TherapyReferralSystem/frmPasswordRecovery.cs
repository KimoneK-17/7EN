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
    public partial class frmPasswordRecovery : Form
    {
        public frmPasswordRecovery()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Close();
        }
    }
}

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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }

        //**********************************************************************************************
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            //check validations for only numbers
            try
            {
                int temp = Convert.ToInt32(txtPhoneNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please provide number only");
            }
        }
        //**********************************************************************************************
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //all characters allowed??
        }
        //**********************************************************************************************
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //check validation for only letters allowed
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txtName.Text.Remove(txtName.Text.Length - 1);
            }
        }
        //**********************************************************************************************
        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            //check validation for only letters allowed
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSurname.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txtSurname.Text.Remove(txtSurname.Text.Length - 1);
            }
        }
        //**********************************************************************************************
    }
}

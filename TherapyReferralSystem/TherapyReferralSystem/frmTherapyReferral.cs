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
    public partial class frmTherapyReferral : Form
    {
        String condition;
        String details;
        String result;
        public frmTherapyReferral()
        {
            InitializeComponent();
        }

        public bool checkComboBoxes()
        {
            bool valid;
            Boolean validCNum = false;
            Boolean validReason = false;
            Boolean validRef = false;
            Boolean validReport = false;
            Boolean validType = false;
            Boolean validStatus = false;
            Boolean validTherapist = false;
            if (cmbCNum.SelectedIndex > -1)
            {
                validCNum = true;
            }
            if (cmbReason.SelectedIndex > -1)
            {
                validReason = true;
            }
            if (cmbRefBy.SelectedIndex > -1)
            {
                validRef = true;
            }
            if (cmbReport.SelectedIndex > -1)
            {
                validReport = true;
            }
            if (cmbType.SelectedIndex > -1)
            {
                validType = true;
            }
            if (cmbStatus.SelectedIndex > -1)
            {
                validStatus = true;
            }
            if (cmbTherapist.SelectedIndex > -1)
            {
                validTherapist = true;
            }

            if (validCNum == false)
            {
                MessageBox.Show("Select a childs name");
            }
            if (validReason == false)
            {
                MessageBox.Show("Select a reason");
            }
            if (validRef == false)
            {
                MessageBox.Show("Select a reference");
            }
            if (validReport == false)
            {
                MessageBox.Show("Select a Report");
            }
            if (validType == false)
            {
                MessageBox.Show("Select a session");
            }
            if (validStatus == false)
            {
                MessageBox.Show("Select a status");
            }
            if (validTherapist == false)
            {
                MessageBox.Show("Select a Therapist");
            }

            if (validCNum == true && validReason == true && validRef == true && validReport == true && validType == true && validStatus == true && validTherapist == true)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }
        public bool checkText(String con, String det, String res)
        {
            bool validText = false;
            Boolean validCon = false;
            Boolean validDet = false;
            Boolean validRes = false;
            if (!con.Any(char.IsLetter) || con.Any(char.IsDigit) || con.Equals(""))
            {
                validCon = false;
                MessageBox.Show("Enter a valid Condition");
            }
            else
            {
                validCon = true;
            }

            if (!det.Any(char.IsLetter) || det.Any(char.IsDigit) || det.Equals(""))
            {
                validDet = false;
                MessageBox.Show("Enter valid Details");
            }
            else
            {
                validDet = true;
            }

            if (!res.Any(char.IsLetter) || res.Any(char.IsDigit) || res.Equals(""))
            {
                validRes = false;
                MessageBox.Show("Enter a valid result");
            }
            else
            {
                validRes = true;
            }

            if (validCon == false || validDet == false || validRes == false)
            {
                validText = false;
                return validText;
            }
            else
            {
                validText = true;
                return validText;
            }
        }
        public void validate()
        {
            condition = txtCondition.Text;
            details = rtxtDetails.Text;
            result = rtxtResult.Text;
            if (checkComboBoxes() == false && checkText(condition, details, result) == false)
            {
                MessageBox.Show("valid");
            }
            else
            {
                MessageBox.Show("not valid");
            }
        }

        private void btnAddRef_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}

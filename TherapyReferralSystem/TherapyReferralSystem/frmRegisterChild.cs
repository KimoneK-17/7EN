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
    public partial class frmRegisterChild : Form
    {
        public frmRegisterChild()
        {
            InitializeComponent();
        }
        //Variable Declaration

        string c_num, c_fname, c_mname, c_lname,c_consid,c_admin_date,c_idNum;
        long c_id;
        string c_bsf, c_status, c_cluster, c_house, c_gender;

        private void mnuRegChildHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Close();
        }

        private void mnuRegChildForm_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegChildTherapyRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tr = new frmTherapyReferral();
            tr.Show();
            this.Close();
        }

        private void mnuRegChildRegUser_Click(object sender, EventArgs e)
        {
            //frmRegisterUser ru = new frmRegisterUser();
            //ru.Show();
            //this.Close(); 
        }

        private void mnuRegChildRegTherapist_Click(object sender, EventArgs e)
        {
            frmRegisterTherapist rt = new frmRegisterTherapist();
            rt.Show();
            this.Close();
        }

        private void mnuRegChildReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports();
            rep.Show();
            this.Close();
        }

        private void mnuRegChildReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Close();
        }

        bool c_empty;
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        public void ClearFields()
        {
            txtNumber.Text = "";
            txtFName.Text = "";
            txtID.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
        }

        public void GetFields()
        {
            //get values from text box
            c_num = txtNumber.Text;
            c_fname = txtFName.Text;
            c_mname = txtMName.Text;
            c_lname = txtLName.Text;
            c_consid = rtbxSpecCon.Text;
            c_idNum = txtID.Text;

            //get values from comboboxes
            c_status = cmbStatus.SelectedItem.ToString();
            c_house = cmbHouse.SelectedItem.ToString();
            c_cluster = cmbCluster.SelectedItem.ToString();
            c_bsf = cmbBSF.SelectedItem.ToString();
            c_gender = cmbGender.SelectedItem.ToString();

            //get date from datepicker
            c_admin_date = dtpDOA.Value.ToString("dd-MM-yyyy");
            
        }

        public void checkEmpty()
        {

            GetFields();
            if (String.IsNullOrEmpty(c_num)&& String.IsNullOrEmpty(c_fname)&& String.IsNullOrEmpty(c_lname) && String.IsNullOrEmpty(c_house) && 
                String.IsNullOrEmpty(c_status) && String.IsNullOrEmpty(c_cluster) && String.IsNullOrEmpty(c_bsf) && String.IsNullOrEmpty(c_idNum) &&
                String.IsNullOrEmpty(c_gender) && String.IsNullOrEmpty(c_admin_date))
            {

                c_empty= true;
            }
            else
            {
                c_empty = false;
            }
        }
        public void Validation()
        {
            checkEmpty();
            if(c_empty==true)
            {
                IDValidation();
            }
        }

        public long IDValidation()
        {
           if(!String.IsNullOrEmpty(c_idNum))
            {
                if(c_idNum.Length == 13)
                {
                    c_id = long.Parse(c_idNum);
                    
                }
                
               
            }
            return c_id;
        }
        
        
    }
}

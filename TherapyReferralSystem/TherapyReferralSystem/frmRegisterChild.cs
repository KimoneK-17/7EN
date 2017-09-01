using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        string c_num, c_fname, c_mname, c_sname, c_consid, c_admin_date, c_idNum;
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
        DBConnect objDBConnect = new DBConnect();
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {


            //checkEmpty();
            IDValidation();

        }


        public void insertRecords()
        {
            if (c_empty == false)
            {
                IDValidation();

                try
                {
                    objDBConnect.OpenConnection();


                    objDBConnect.sqlCmd = new SqlCommand("INSERT INTO Child VALUES (@C_NUMBER, @C_STATUS, @C_CLUSTER, @C_HOUSE, @C_BSF,@C_FNAME, @C_MNAME, @C_SNAME,@C_ID,@C_GENDER,@C_ADM_DATE,@C_CONSIDER)", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_NUMBER", c_num);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_STATUS", c_status);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_HOUSE", c_house);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_CLUSTER", c_cluster);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_BSF", c_bsf);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_FNAME", c_fname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_MNAME", c_mname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_SNAME", c_sname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_ID", c_id);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_GENDER", c_gender);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_ADM_DATE", c_admin_date);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_CONSIDER", c_consid);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    MessageBox.Show("Successfully Inserted");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cannot add child details " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot Add child Details: " + ex.Message + ex.Data + ex.StackTrace);
                }
            }
            else
            {
                //MessageBox.Show("Please enter all fields before proceeding");
            }
        }
        public void ClearFields()
        {
            txtNumber.Text = "";
            txtFName.Text = "";
            txtID.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
        }//clear fields

        public void GetFields()
        {
            //get values from text box
            c_num = txtNumber.Text;
            c_fname = txtFName.Text;
            c_mname = txtMName.Text;
            c_sname = txtLName.Text;
            c_consid = rtbxSpecCon.Text;
            c_idNum = txtID.Text;


            checkSelected();
            //get date from datepicker
            c_admin_date = dtpDOA.Value.ToString("dd-MM-yyyy");

        }//assign fields to variables

        public void checkEmpty()
        {

            GetFields();
            if (c_num.Equals("") || c_fname.Equals("") || c_sname.Equals("") ||
              c_status.Equals("") || c_idNum.Equals(""))
            {

                c_empty = true;
                MessageBox.Show("Please fill out required details");
            }
            else
            {
                c_empty = false;
            }
        }//check if variables have values


        public long IDValidation()
        {
            if (!txtID.Text.Equals(""))
            {
               
                if (txtID.Text.Length == 13)
                {
                    c_id = long.Parse(txtID.Text);
                    checkID();
                }
                else
                {
                    MessageBox.Show("ID Length must be 10");
                }


            }
            return c_id;
        }//ID Validation

        public void checkID()
        {
            long n = c_id;
            n = long.Parse(txtID.Text.Remove(txtID.Text.Length - 1, 1));

            long oddSum = 0, evenSum = 0;
              int  evenSumP2 = 0;

            int counter = 1;
            string evenStr = "", oddStr = "";
            while (n != 0)
            {
                if (counter % 2 == 0)
                {
                    oddSum += n % 10;
                    oddStr = n % 10 + "" + oddStr;
                    n /= 10;
                }
                else
                {
                    evenSum += n % 10;
                    evenStr = n % 10 + "" + evenStr;
                    n /= 10;

                }
                counter++;
            }

           int sum = 0;
            evenSumP2 = int.Parse(evenStr)*2;
            while ( evenSumP2!= 0)
            {
                sum += evenSumP2 % 10;
                evenSumP2 /= 10;
            }

            long addSumandOdd = sum + oddSum;
            long i = addSumandOdd;
            long lastdigit = (addSumandOdd % 10);

            long subFromTen = 10 - lastdigit;


            MessageBox.Show("Even: " + evenSum + "\nEven String: " + evenStr);
            MessageBox.Show("Odd: " + oddSum + "\nOdd String: "+oddStr);
            MessageBox.Show("Even Sum: " + sum);
            MessageBox.Show("Sum of odd number calc + sum of even number calc = " + addSumandOdd);
            MessageBox.Show("Last digit of Sum: " + lastdigit);
            MessageBox.Show("Sub from ten value: "+subFromTen);

            if((c_id%10)==(subFromTen%10))
            {
                MessageBox.Show("Valid ID");
            }
            else
            {
                MessageBox.Show("ID Number is invalid");
            }

        }
    public void checkSelected()
    {
        if (cmbBSF.SelectedIndex > -1 && cmbCluster.SelectedIndex > -1 && cmbGender.SelectedIndex > -1 && cmbHouse.SelectedIndex > -1 && cmbStatus.SelectedIndex > -1)
        {
            //get values from comboboxes
            c_status = cmbStatus.SelectedItem.ToString();
            c_house = cmbHouse.SelectedItem.ToString();
            c_cluster = cmbCluster.SelectedItem.ToString();
            c_bsf = cmbBSF.SelectedItem.ToString();
            c_gender = cmbGender.SelectedItem.ToString();
        }
    }
}
    }

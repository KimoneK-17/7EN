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
        bool c_empty;
        DBConnect objDBConnect = new DBConnect();
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {


            checkEmpty();
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
            if (!c_idNum.Equals(""))
            {
                if (c_idNum.Length == 13)
                {
                    c_id = long.Parse(c_idNum);

                }


            }
            return c_id;
        }//ID Validation


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

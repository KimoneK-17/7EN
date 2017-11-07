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
        //public static string username = "";
        //public static string type = "";
        public frmRegisterChild()
        {
            //username = frmLogin1.username;
            //type = frmProfile.type;
           
        }

        public frmRegisterChild(string username, string type)
        {
            this.username = username;
            this.type = type;
            InitializeComponent();
        }





        //Variable Declaration

        string c_num, c_fname, c_mname, c_sname, c_consid, c_admin_date, c_idNum, c_id;
        string c_bsf, c_status, c_cluster, c_house, c_gender;
        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();
        bool found, validID;
        private void mnuRegChildHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp("Child");
            help.Show();
            
        }

        private void mnuRegChildForm_Click(object sender, EventArgs e)
        {

        }

        private void mnuRegChildTherapyRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tr = new frmTherapyReferral(username,type);
            tr.Show();
            this.Close();
        }

        private void mnuRegChildRegUser_Click(object sender, EventArgs e)
        {

            frmRegisterUser ru = new frmRegisterUser(username,type);
            ru.Show();
            this.Dispose();

        }

        private void mnuRegChildReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports(type);
            rep.Show();
            this.Dispose();
        }

        private void mnuRegChildReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }

        bool c_empty;
       
        private string username;
        private string type;

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resetRequired();
            Cursor.Current = Cursors.WaitCursor;

            if (!txtNumber.Text.Equals(""))
            {
                c_num = txtNumber.Text;
                found = sm.CheckExisting("Child", "c_number", c_num);
                if (found == true)
                {
                    searchChild();

                }
                else
                {
                    lblRNum.Text = "* Invalid Child Number";
                }

            }
            else
            {
                if (!txtID.Text.Equals(""))
                {
                    c_id = txtID.Text;
                    searchChild();
                }
                else
                {
                    MessageBox.Show("Enter Child Number or ID Number to Search");
                }

            }
            Cursor.Current = Cursors.Default;
        }

        public void searchChild()
        {


            try
            {
                objDBConnect.OpenConnection();
                string sqlquery = "SELECT C_NUMBER, C_STATUS, C_CLUSTER, C_HOUSE, C_BSF,C_FNAME, C_MNAME, C_SNAME,C_ID,C_GENDER,C_ADM_DATE,C_CONSIDER FROM CHILD WHERE C_NUMBER = @C_NUMBER OR C_ID like @C_ID";

                objDBConnect.sqlCmd = new SqlCommand(sqlquery, objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@C_NUMBER", c_num);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@C_ID", txtID.Text);
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                while (objDBConnect.sqlDR.Read())
                {
                    txtFName.Text = objDBConnect.sqlDR["C_FNAME"].ToString();
                    txtLName.Text = objDBConnect.sqlDR["C_SNAME"].ToString();
                    txtNumber.Text = objDBConnect.sqlDR["C_NUMBER"].ToString();
                    txtMName.Text = objDBConnect.sqlDR["C_MNAME"].ToString();
                    txtID.Text = objDBConnect.sqlDR["C_ID"].ToString();
                    rtbxSpecCon.Text = objDBConnect.sqlDR["C_CONSIDER"].ToString();

                    int iStatus = cmbStatus.Items.IndexOf(objDBConnect.sqlDR["C_STATUS"].ToString());
                    cmbStatus.SelectedIndex = iStatus;
                    int iCluster = cmbCluster.Items.IndexOf(objDBConnect.sqlDR["C_CLUSTER"].ToString());
                    cmbCluster.SelectedIndex = iCluster;
                    int iHouse = cmbHouse.Items.IndexOf(objDBConnect.sqlDR["C_HOUSE"].ToString());
                    cmbHouse.SelectedIndex = iHouse;
                    int iBSF = cmbBSF.Items.IndexOf(objDBConnect.sqlDR["C_BSF"].ToString());
                    cmbBSF.SelectedIndex = iBSF;
                    int iGender = cmbGender.Items.IndexOf(objDBConnect.sqlDR["C_GENDER"].ToString());
                    cmbGender.SelectedIndex = iGender;

                    dtpDOA.Value = Convert.ToDateTime(objDBConnect.sqlDR["C_ADM_DATE"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail: " + ex.Message);
            }


        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void frmRegisterChild_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            if (type.Equals("Therapist") || type.Equals("Teacher") || type.Equals("Clinic"))
            {

                mnuRegChildRegUser.Visible = false;
               
            }

         
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile pr = new frmProfile(username);
            pr.Show();
            this.Dispose();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            updateChild();
            Cursor.Current = Cursors.Default;
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DeleteChild();
            Cursor.Current = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            insertRecords();
            Cursor.Current = Cursors.Default;
        }


        public void insertRecords()
        {
            resetRequired();
            c_empty = checkEmpty();


            if (c_empty == true)
            {
                found = sm.CheckExisting("Child", "C_NUMBER", c_num);
                if (found == false)
                {

                    validID = sm.IDValidation(c_id);

                    if (validID == true)
                    {
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
                            ClearFields();

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
                        MessageBox.Show("Please enter a valid ID to continue");
                        lblRID.Text = "* Enter Valid ID";
                    }


                }
                else
                {
                    MessageBox.Show("This Number already exists in database");
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
            rtbxSpecCon.Text = "";
            cmbBSF.SelectedIndex = -1;
            cmbCluster.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbHouse.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpDOA.Value = DateTime.Today;

            resetRequired();


        }//clear fields

        private void resetRequired()
        {
            lblRBSF.Text = "*";
            lblRCluster.Text = "*";
            lblRDOA.Text = "*";
            lblRFname.Text = "*";
            lblRGender.Text = "*";
            lblRHouse.Text = "*";
            lblRID.Text = "*";
            lblRLname.Text = "*";
            lblRNum.Text = "*";
            lblRStatus.Text = "*";
        }

        public void GetFields()
        {
            //get values from text box
            c_id = txtID.Text;
            c_num = txtNumber.Text;
            c_fname = txtFName.Text;
            c_mname = txtMName.Text;
            c_sname = txtLName.Text;
            c_consid = rtbxSpecCon.Text;
            c_idNum = txtID.Text;


            checkSelected();
            //get date from datepicker
            c_admin_date = dtpDOA.Value.ToString("yyyy-MM-dd");

        }//assign fields to variables

        public bool checkEmpty()
        {

            GetFields();

            bool required = true;
            if (txtNumber.Text.Equals(""))
            {
                lblRNum.Text = "* REQUIRED";
                required = false;
            }

            if (txtID.Text.Equals(""))
            {
                lblRID.Text = "* REQUIRED";
                required = false;
            }
            if (txtFName.Text.Equals(""))
            {
                lblRFname.Text = "* REQUIRED";
                required = false;
            }
            if (txtLName.Text.Equals(""))
            {
                lblRLname.Text = "* REQUIRED";
                required = false;
            }

            if (cmbStatus.SelectedIndex < 0)
            {
                lblRStatus.Text = "* REQUIRED";
                required = false;
            }
            if (cmbHouse.SelectedIndex < 0)
            {
                lblRHouse.Text = "* REQUIRED";
                required = false;
            }
            if (cmbGender.SelectedIndex < 0)
            {
                lblRGender.Text = "* REQUIRED";
                required = false;
            }
            if (cmbCluster.SelectedIndex < 0)
            {
                lblRCluster.Text = "* REQUIRED";
                required = false;
            }
            if (cmbBSF.SelectedIndex < 0)
            {
                lblRBSF.Text = "* REQUIRED";
                required = false;
            }

            return required;
        }//check if variables have values


      
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

        public void updateChild()
        {
            checkEmpty();
            if (c_empty == false)
            {


                try
                {
                    objDBConnect.OpenConnection();


                    objDBConnect.sqlCmd = new SqlCommand("UPDATE Child SET C_STATUS =@C_STATUS, C_CLUSTER = @C_CLUSTER, C_HOUSE=@C_HOUSE, C_BSF = @C_BSF, C_FNAME = @C_FNAME,C_MNAME= @C_MNAME,C_SNAME = @C_SNAME,C_GENDER=@C_GENDER,C_ADM_DATE=@C_ADM_DATE,C_CONSIDER=@C_CONSIDER WHERE C_NUMBER = @C_NUMBER", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_NUMBER", c_num);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_STATUS", c_status);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_HOUSE", c_house);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_CLUSTER", c_cluster);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_BSF", c_bsf);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_FNAME", c_fname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_MNAME", c_mname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_SNAME", c_sname);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_GENDER", c_gender);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_ADM_DATE", c_admin_date);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_CONSIDER", c_consid);

                    objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                    MessageBox.Show("Successfully Updated");
                    objDBConnect.sqlDR.Close();
                    objDBConnect.sqlConn.Close();
                    ClearFields();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error cannot add child details " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Cannot UPDATE child Details: " + ex.Message + ex.Data + ex.StackTrace);
                }
            }
            else
            {
                //MessageBox.Show("Please enter all fields before proceeding");
            }
        }

        public void DeleteChild()
        {
            if (!txtNumber.Text.Equals(""))
            {
                c_num = txtNumber.Text;
                searchChild();
                objDBConnect.OpenConnection();
                try
                {
                    objDBConnect.sqlCmd = new SqlCommand("DELETE FROM Child WHERE C_NUMBER = @C_NUMBER", objDBConnect.sqlConn);
                    objDBConnect.sqlCmd.Parameters.AddWithValue("@C_NUMBER", c_num);


                    objDBConnect.sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Child Deleted");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    objDBConnect.sqlConn.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Child Number To Delete");
            }

        }
    }
}

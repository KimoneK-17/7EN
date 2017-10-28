using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    public partial class frmRegisterUser : Form
    {

        //declarations
        string fname;
        string surname;
        string initials;
        string contactnumber;
        string email;
        string password;
        string type;
        string squestion;
        string answer;
        string therapytype;
        string IE;
        string other;
        string idnum;
        bool valid = false;
        bool checkempty = true;
        bool found, exist;



        DBConnect objDBConnect = new DBConnect();
        SharedMethods sm = new SharedMethods();

        public frmRegisterUser()
        {
            InitializeComponent();
        }



        private void mnuRegUserReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 log = new frmLogin1();
            log.Show();
            this.Dispose();
        }

        private void mnuRegUserReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports();
            rep.Show();
            this.Dispose();
        }

        private void mnuRegUserHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }

        private void mnuRegUserTherRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tf = new frmTherapyReferral();
            tf.Show();
            this.Dispose();
        }

        private void mnuRegUserRegChild_Click(object sender, EventArgs e)
        {
            frmRegisterChild rc = new frmRegisterChild();
            rc.Show();
            this.Dispose();
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            lblRIE.Hide();
            lblRTherapy.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void clearFields()
        {
            txtfname.Text = "";
            txtsurname.Text = "";
            txtinitials.Text = "";
            txtid.Text = "";
            txtemail.Text = "";
            txtcontactnum.Text = "";
            txtanswer.Text = "";
            rictxtother.Text = "";

            cmbinternal.SelectedIndex = -1;
            cmbsecurity.SelectedIndex = -1;
            //cmbtype.SelectedIndex = -1;

        }

        public void resetRequired()
        {
            lblRAns.Text = "*";
            lblRContact.Text = "*";
            lblREmail.Text = "*";
            lblRFname.Text = "*";
            lblRID.Text = "*";
            lblRIE.Text = "*";
            lblRLname.Text = "*";
            lblRPword.Text = "*";
            lblRSQues.Text = "*";
            lblRTherapy.Text = "*";
            lblRType.Text = "*";
        }

        public void getFields()
        {
            fname = txtfname.Text;
            surname = txtsurname.Text;
            initials = txtinitials.Text;
            contactnumber = txtcontactnum.Text;
            email = txtemail.Text;
            password = txtpassword.Text;
            type = cmbtype.SelectedItem.ToString();
            idnum = txtid.Text;
            squestion = cmbsecurity.SelectedItem.ToString();
            answer = txtanswer.Text;
            if (type.ToUpper().Equals("THERAPIST"))
            {
                therapytype = cmbtherap.SelectedItem.ToString();
                IE = cmbinternal.SelectedItem.ToString();
            }
            else
            {
                therapytype = DBNull.Value.ToString();
                IE = DBNull.Value.ToString();
            }

            other = rictxtother.Text;
        }
        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtype.SelectedItem.ToString().ToUpper().Equals("THERAPIST"))
            {
                panel2.Show();
                lblRIE.Show();
                lblRTherapy.Show();
            }
            else
            {
                panel2.Hide();
                lblRIE.Hide();
                lblRTherapy.Hide();
            }
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            if (txtfname.Text.Length > 0)
            {
                txtinitials.Text = txtfname.Text.Substring(0, 1).ToUpper();

            }
            else
            {
                txtinitials.Text = "";
            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            insertRecords();
            clearFields();
        }

        private void txtcontactnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtsurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public void insertRecords()
        {
            resetRequired();
            checkempty = validate();
            if (checkempty == true)
            {
                getFields();
                found = sm.CheckExisting("tbl_user", "U_EMAIL", email);

                if (found == false)
                {
                    valid = sm.IDValidation(idnum);

                    if (valid == true)
                    {

                        exist = sm.CheckExisting("tbl_user", "U_ID", idnum);

                        if (exist == false)
                        {
                            try
                            {
                                objDBConnect.OpenConnection();


                                objDBConnect.sqlCmd = new SqlCommand("insert into tbl_user values(@U_ID,@U_FNAME,@U_SNAME,@U_CONTACT,@U_EMAIL,@U_PWORD,@U_TYPE,@T_TYPE,@T_IE,@U_SEC_QUES,@U_SEC_ANS,@U_IMAGE)", objDBConnect.sqlConn);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_ID", idnum);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_FNAME", fname);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SNAME", surname);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_CONTACT", contactnumber);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", email);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_PWORD", password);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_TYPE", type);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_TYPE", therapytype);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_IE", IE);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SEC_QUES", squestion);
                                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SEC_ANS", answer);
                                objDBConnect.sqlCmd.Parameters.Add("@U_IMAGE", SqlDbType.Image).Value = DBNull.Value;
                                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                                MessageBox.Show("Successfully Inserted");
                                objDBConnect.sqlDR.Close();
                                objDBConnect.sqlConn.Close();
                                clearFields();

                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error cannot register new user" + ex.Message);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error Cannot register new user: " + ex.Message + ex.Data + ex.StackTrace);
                            }
                        }
                        else
                        {
                            lblRID.Text = "*This ID Number is already Registered";
                        }

                    }
                    else
                    {
                        lblRID.Text = "*Enter valid ID Number";
                    }

                }
                else
                {
                    lblREmail.Text = "*Email already registered, Please log in";
                }
            }

        }

        private void mnuRegUserSearch_Click(object sender, EventArgs e)
        {
            resetRequired();
            Cursor.Current = Cursors.WaitCursor;

            if (!txtemail.Text.Equals(""))
            {
                email = txtemail.Text;

                if (email.Contains("@") && email.Contains("."))
                {
                    found = sm.CheckExisting("tbl_user", "U_EMAIL", email);
                    if (found == true)
                    {
                        searchChild();

                    }
                    else
                    {
                        lblREmail.Text = "* Invalid Email Address";
                    }
                }
                else
                {
                    lblREmail.Text = "* Invalid Email Format";
                }


            }
            else
            {
                if (!txtid.Text.Equals(""))
                {
                    idnum = txtid.Text;
                    found = sm.CheckExisting("tbl_user", "U_ID", idnum);
                    if (found == true)
                    {
                        searchChild();
                    }

                }
                else
                {
                    MessageBox.Show("Enter Email Address or ID Number to Search");
                }

            }
            Cursor.Current = Cursors.Default;
        }

        private void searchChild()
        {


            try
            {
                objDBConnect.OpenConnection();
                string sqlquery = "SELECT  U_ID, U_FNAME, U_SNAME, U_CONTACT, U_EMAIL, U_TYPE, T_TYPE, T_IE FROM tbl_user WHERE U_EMAIL = @U_EMAIL OR U_ID like @U_ID";

                objDBConnect.sqlCmd = new SqlCommand(sqlquery, objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_ID", idnum);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", email);
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                while (objDBConnect.sqlDR.Read())
                {
                    txtid.Text = objDBConnect.sqlDR["U_ID"].ToString();
                    txtfname.Text = objDBConnect.sqlDR["U_FNAME"].ToString();
                    txtsurname.Text = objDBConnect.sqlDR["U_SNAME"].ToString();
                    txtcontactnum.Text = objDBConnect.sqlDR["U_CONTACT"].ToString();
                    txtemail.Text = objDBConnect.sqlDR["U_EMAIL"].ToString();

                    int iType = cmbtype.Items.IndexOf(objDBConnect.sqlDR["U_TYPE"].ToString());
                    cmbtype.SelectedIndex = iType;

                    if (cmbtype.SelectedItem.ToString().ToUpper().Equals("THERAPIST"))
                    {
                        panel2.Show();
                    }
                    int iTherapy = cmbtherap.Items.IndexOf(objDBConnect.sqlDR["T_TYPE"].ToString());
                    cmbtherap.SelectedIndex = iTherapy;
                    int iIE = cmbinternal.Items.IndexOf(objDBConnect.sqlDR["T_IE"].ToString());
                    cmbinternal.SelectedIndex = iIE;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fail: " + ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteChild();
        }

        public void deleteChild()
        {


            if (!txtemail.Text.Equals(""))
            {
                email = txtemail.Text;
                searchChild();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    objDBConnect.OpenConnection();
                    try
                    {
                        objDBConnect.sqlCmd = new SqlCommand("DELETE FROM tbl_user WHERE U_EMAIL = @U_EMAIL", objDBConnect.sqlConn);
                        objDBConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", email);


                        objDBConnect.sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("USER UNREGISTERED");
                        clearFields();
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
                    MessageBox.Show("Enter User Email To Delete");
                }
            }
        }



        public bool validate()
        {
            if (txtemail.Text.Equals(""))
            {
                lblREmail.Text = "*Required";
                checkempty = false;
            }


            if (txtfname.Text.Equals(""))
            {
                lblRFname.Text = "*Required";
                checkempty = false;
            }
            if (txtcontactnum.Text.Equals(""))
            {
                lblRContact.Text = "*Required";
                checkempty = false;
            }
            if (txtid.Text.Equals(""))
            {
                lblRID.Text = "*Required";
                checkempty = false;
            }
            if (txtpassword.Text.Equals(""))
            {
                lblRPword.Text = "*Required";
                checkempty = false;
            }
            if (txtsurname.Text.Equals(""))
            {
                lblRLname.Text = "*Required";
                checkempty = false;
            }
            if (cmbsecurity.SelectedIndex == -1)
            {
                lblRSQues.Text = "*Required";
                checkempty = false;
            }
            if (cmbtype.SelectedIndex == -1)
            {
                lblRType.Text = "*Required";
                checkempty = false;

            }
            if (txtanswer.Text.Equals(""))
            {
                lblRAns.Text = "*Required";
                checkempty = false;
            }

            if (cmbtype.SelectedIndex != -1 && cmbtype.SelectedItem.ToString().ToUpper().Equals("THERAPIST"))
            {
                if (cmbinternal.SelectedIndex == -1)
                {
                    lblRIE.Text = "*Required";
                    checkempty = false;
                }
                if (cmbtherap.SelectedIndex == -1)
                {
                    lblRTherapy.Text = "*Required";
                    checkempty = false;
                }

            }


            return checkempty;

        }
    }
}

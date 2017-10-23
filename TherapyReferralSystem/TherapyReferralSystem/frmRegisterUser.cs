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
    public partial class frmRegisterUser : Form
    {

        //declarations
        string fname;
        string middlename;
        string surname;
        string initials;
        string contactnumber;
        string email;
        string password;
        string type;
        string otherTherapyType;
        string TherapyT;
        string squestion;
        string answer;
        string IE;
        string other;
        long idnum;
        bool valid = false;
        bool validTherapist = false;
        bool checkempty = false;
        bool validID = false;
        DBConnect objDBConnect = new DBConnect();


        public frmRegisterUser()
        {
            InitializeComponent();
        }

        public bool checkCMBSelected()
        {


            if (cmbtype.SelectedIndex > -1)
            {
                if (cmbsecurity.SelectedIndex > -1)
                {
                    valid = true;
                }//security

            }//type

            if (valid == true)
            {
                if (cmbtype.SelectedItem.ToString().Equals("Therapist"))
                {
                    if (cmtherap.SelectedIndex > -1)
                    {
                        if (cmbinternal.SelectedIndex > -1)
                        {
                            validTherapist = true;
                        }//i/e
                    }//therapist

                }
            }

            return validTherapist;
        }

        public void checkEmptyFields()
        {
            if (!txtfname.Text.Equals(""))

            {
                if (!txtsurname.Text.Equals(""))
                {
                    if (!txtcontactnum.Text.Equals(""))
                    {
                        if (!txtemail.Text.Equals(""))
                        {
                            if (txtemail.Text.Contains("@") && txtemail.Text.Contains("."))
                            {
                                if (!txtpassword.Text.Equals(""))

                                {
                                    if (!txtanswer.Text.Equals(""))

                                    {
                                        if (!txtid.Text.Equals(""))
                                        {
                                            checkempty = true;
                                        }//id
                                    }//answer
                                }//password
                            }//check valid email format

                        }//email
                    }//contactnum
                }//surname
            }//fname
        }//empty

        public void IDValidation()
        {
            if (!txtid.Text.Equals(""))
            {
                if (txtid.Text.Length == 13)
                {

                    bool result;
                    result = long.TryParse(txtid.Text, out idnum);

                    if (result == true)
                    {
                        idnum = long.Parse(txtid.Text);
                        validID = true;
                    }
                    else
                    {
                        MessageBox.Show("Id number is not correct");
                    }

                }
            }

        }//ID validation

        public void ValidateUser()
        {
            fname = txtfname.Text;
            middlename = txtmname.Text;
            contactnumber = txtcontactnum.Text;
            surname = txtsurname.Text;
            initials = txtinitials.Text;
            email = txtemail.Text;
            password = txtpassword.Text;
            answer = txtanswer.Text;
            other = rictxtother.Text;
            idnum = long.Parse(txtid.Text);


            if (checkCMBSelected() == false)
            {
                MessageBox.Show("valid");

                type = cmbtype.SelectedItem.ToString();
                squestion = cmbtype.SelectedItem.ToString();
                //TherapyT = cmbtype.SelectedItem.ToString();
                //IE = cmbinternal.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("not valid");
            }
        }


        public void insertNewUser()

        {
            ValidateUser();
            try
            {


                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand(" insert into tbl_user values(@U_ID,@U_FNAME,@U_SNAME,@U_CONTACT,@U_EMAIL,@U_PWORD,@U_TYPE,NULLIF(@T_ID,''),NULLIF(@T_TYPE,''),NULLIF(@T_IE,''),@U_SEC_QUES,@U_SEC_ANS,null)", objDBConnect.sqlConn);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_ID", idnum);//make it numeric value
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_FNAME", fname);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SNAME", surname);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_CONTACT", contactnumber);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", email);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_PWORD", password);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_TYPE", type);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_TYPE", type);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_ID", 10);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@T_IE", "I");
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SEC_QUES", squestion);
                objDBConnect.sqlCmd.Parameters.AddWithValue("@U_SEC_ANS", answer);
                objDBConnect.sqlDR = objDBConnect.sqlCmd.ExecuteReader();

                MessageBox.Show("Successfully Inserted");
                objDBConnect.sqlDR.Close();
                objDBConnect.sqlConn.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cannot add User " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Cannot Add User: " + ex.Message + ex.Data + ex.StackTrace);
            }
        }


        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //ValidateUser();
            //IDValidation();


            /*if (validID == true)
            {
                insertNewUser();
            }
            else
            {
                //do nothing
            }*/

            insertNewUser();
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
    }
}

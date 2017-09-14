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
    public partial class frmProfile : Form
    {
        private string username;

        public frmProfile()
        {
            
        }

        public frmProfile(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        DBConnect dbConnect = new DBConnect();
        string fname;
        string sname;
        string phone;
        string type;
        string id;

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

        private void mnuProfileReturn_Click(object sender, EventArgs e)
        {
            frmLogin1 login = new frmLogin1();
            login.Show();
            this.Dispose();
        }

        private void mnuProfileReports_Click(object sender, EventArgs e)
        {
            frmReports rep = new frmReports();
            rep.Show();
            this.Dispose();
        }

        private void mnuProfileHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
            this.Dispose();
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            getFromDatabase();
        }
        //method gets information from the database table user and displays in form
        public void getFromDatabase()
        {
            try
            {
                dbConnect.OpenConnection();
                dbConnect.sqlCmd = new SqlCommand("SELECT U_FNAME, U_SNAME, U_CONTACT, U_TYPE, U_ID FROM TBL_USER WHERE U_EMAIL LIKE @U_EMAIL", dbConnect.sqlConn); // gets information by email identification
                dbConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", username);

                dbConnect.sqlDR = dbConnect.sqlCmd.ExecuteReader();
                while (dbConnect.sqlDR.Read())
                {//gets values and stores them in a variable
                    fname = (string)dbConnect.sqlDR["U_FNAME"];
                    sname = (string)dbConnect.sqlDR["U_SNAME"];
                    phone = (string)dbConnect.sqlDR["U_CONTACT"];
                    type = (string)dbConnect.sqlDR["U_TYPE"];
                    id = (string)dbConnect.sqlDR["U_ID"];

                }

                dbConnect.sqlConn.Close();

                //shows values in the textfield
                txtName.Text = fname;
                txtSurname.Text = sname;
                txtPhoneNumber.Text = phone;
                txtPosition.Text = type;
                txtID.Text = id;
            }

            catch (SqlException se)
            {
                MessageBox.Show("SQL Error" + se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
            

        public void updateInfo()
        {
            try
            {
                dbConnect.OpenConnection();
                dbConnect.sqlCmd = new SqlCommand("UPDATE TBL_USER SET U_FNAME = @U_FNAME, U_SNAME = @U_SNAME, U_CONTACT = @U_CONTACT WHERE U_EMAIL LIKE @U_EMAIL", dbConnect.sqlConn); // updates information by email identification
                
                //updates these fields in the database
                dbConnect.sqlCmd.Parameters.AddWithValue("@U_FNAME", fname);
                dbConnect.sqlCmd.Parameters.AddWithValue("@U_SNAME", sname);
                dbConnect.sqlCmd.Parameters.AddWithValue("@U_CONTACT", phone);

                dbConnect.sqlCmd.ExecuteNonQuery();
                dbConnect.sqlConn.Close();
                MessageBox.Show("Your information had been sucessfully updated");
            }

            catch (SqlException se)
            {
                MessageBox.Show("SQL Error" + se.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfo();
        }
        //**********************************************************************************************
    }
}

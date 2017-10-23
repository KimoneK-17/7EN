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
using System.IO;

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
            if (type.Equals("Social Worker"))
            {
                mnuProfileRegChild.Enabled = true;
            }
            else
            {
                mnuProfileRegChild.Enabled = false;
            }
        }
        //method gets information from the database table user and displays in form
        public void getFromDatabase()
        {
            try
            {
                dbConnect.OpenConnection();
                dbConnect.sqlCmd = new SqlCommand("SELECT U_FNAME, U_SNAME, U_CONTACT, U_TYPE, U_ID, U_IMAGE FROM TBL_USER WHERE U_EMAIL LIKE @U_EMAIL", dbConnect.sqlConn); // gets information by email identification
                dbConnect.sqlCmd.Parameters.AddWithValue("@U_EMAIL", username);

                dbConnect.sqlDR = dbConnect.sqlCmd.ExecuteReader();
                if (dbConnect.sqlDR.Read())
                {//gets values and stores them in a variable
                    fname = (string)dbConnect.sqlDR["U_FNAME"];
                    sname = (string)dbConnect.sqlDR["U_SNAME"];
                    phone = (string)dbConnect.sqlDR["U_CONTACT"];
                    type = (string)dbConnect.sqlDR["U_TYPE"];
                    id = (string)dbConnect.sqlDR["U_ID"];
                    byte[] images = (byte[])dbConnect.sqlDR["U_IMAGE"];

                    if (images == null)
                    {
                        picbxProfilePic.Image = null;
<<<<<<< HEAD

=======
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
                    }

                    else
                    {
                        MemoryStream mStream = new MemoryStream(images);
<<<<<<< HEAD
                        picbxProfilePic.BackgroundImage = Image.FromStream(mStream);


=======
                        picbxProfilePic.Image = Image.FromStream(mStream);
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
                    }
                }

                else
                {
                    MessageBox.Show("This data is not available...");
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
<<<<<<< HEAD
            fname = txtName.Text;
            sname = txtSurname.Text;
            phone = txtPhoneNumber.Text;

=======
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
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
<<<<<<< HEAD

=======
                MessageBox.Show("Your information had been sucessfully updated");
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInfo();
        }

        string imgLocation = "";


        private void btnChangePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picbxProfilePic.ImageLocation = imgLocation;
<<<<<<< HEAD

=======
>>>>>>> 8737e6938891d1372ec8317e47da98188a71f9b3
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            dbConnect.OpenConnection();
            string sqlQuery = "UPDATE TBL_USER SET U_IMAGE = @U_IMAGE WHERE U_EMAIL LIKE @U_EMAIL";
            dbConnect.sqlCmd = new SqlCommand(sqlQuery, dbConnect.sqlConn);

            dbConnect.sqlCmd.Parameters.Add(new SqlParameter("@U_IMAGE", images));
            dbConnect.sqlCmd.Parameters.Add(new SqlParameter("@U_EMAIL", username));
            int N = dbConnect.sqlCmd.ExecuteNonQuery();
            dbConnect.sqlConn.Close();
            MessageBox.Show(N.ToString() + "Image Saved Successfully");


        }

        private void mnuProfileTherRef_Click(object sender, EventArgs e)
        {
            frmTherapyReferral tf = new frmTherapyReferral();
            tf.Show();
            this.Dispose();
        }

        private void mnuProfileRegChild_Click(object sender, EventArgs e)
        {

            frmRegisterChild rc = new frmRegisterChild();
            rc.Show();
            this.Dispose();


        }

        private void mnuProfileRegUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser();
            ru.Show();
            this.Dispose();
        }
        //**********************************************************************************************
    }
}

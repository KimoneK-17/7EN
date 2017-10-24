using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{
    class SharedMethods
    {
        DBConnect objDBConnect = new DBConnect();
        bool found,valid;
        public  bool CheckExisting(string table, string item, string variable)
        {

            try
            {
                string itemExist;
                //checks to see if patient already exists in database
                objDBConnect.OpenConnection();

                objDBConnect.sqlCmd = new SqlCommand("SELECT COUNT(*) FROM "+table+" WHERE "+item+" LIKE @"+item+";", objDBConnect.sqlConn);
                //query
                objDBConnect.sqlCmd.Parameters.AddWithValue("@"+item, variable);
                //parameter
                itemExist = objDBConnect.sqlCmd.ExecuteScalar().ToString();
                //assigning query to variable
                if (int.Parse(itemExist) > 0)
                {
                    found = true;
                    //in database
                    
                }
                else
                {
                    found = false;
                    //not in database
                    //MessageBox.Show("Unable to carry out command");
                }
              
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message); // Shows an error message
            }
            return found;
        }

        public bool IDValidation(string id)
        {
            if (id.Length == 13)
            {


                long tempID = long.Parse(id);
                tempID = long.Parse(id.Remove(id.Length - 1, 1));

                long oddSum = 0, evenSum = 0;
                int evenSumP2 = 0;

                int counter = 1;
                string evenStr = "", oddStr = "";
                while (tempID != 0)
                {
                    if (counter % 2 == 0)
                    {
                        oddSum += tempID % 10;
                        oddStr = tempID % 10 + "" + oddStr;
                        tempID /= 10;
                    }
                    else
                    {
                        evenSum += tempID % 10;
                        evenStr = tempID % 10 + "" + evenStr;
                        tempID /= 10;

                    }
                    counter++;
                }

                int sum = 0;
                evenSumP2 = int.Parse(evenStr) * 2;
                while (evenSumP2 != 0)
                {
                    sum += evenSumP2 % 10;
                    evenSumP2 /= 10;
                }

                long addSumandOdd = sum + oddSum;
                long i = addSumandOdd;
                long lastdigit = (addSumandOdd % 10);

                long subFromTen = 10 - lastdigit;

                if ((long.Parse(id) % 10) == (subFromTen % 10))
                {
                    valid = true;
                }
                else
                {
                    valid = false;

                }
            }
            else
            {
                valid = false;
            }
            return valid;
        }

    }
}

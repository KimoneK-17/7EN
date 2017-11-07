using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyReferralSystem
{

        class DBConnect
        {
            public SqlConnection sqlConn;
            public SqlCommand sqlCmd;
            public SqlDataReader sqlDR;
        public SqlDataAdapter sqlDA;
            //public SqlDataAdapter sqlDA;
        string livCon = ConfigurationManager.ConnectionStrings["livDB"].ConnectionString;
        public void OpenConnection()
            {
                try
                {
                    sqlConn = new SqlConnection();
                    sqlConn.ConnectionString = (livCon);
                    sqlConn.Open();
               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR - Connection not established.\n" + ex.Message);
                }
            }

            public void GiveCommand(string sSql)
            {
                OpenConnection();
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandText = sSql;
            }
        }
    

}


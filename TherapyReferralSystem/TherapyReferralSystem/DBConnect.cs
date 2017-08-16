using System;
using System.Collections.Generic;
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
            public void OpenConnection()
            {
                try
                {
                    sqlConn = new SqlConnection();
                    sqlConn.ConnectionString = ("Server=tcp:livserver.database.windows.net,1433;Initial Catalog=LIVDatabase;Persist Security Info=False;User ID=LIV;Password=abcd1234$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    sqlConn.Open();
                MessageBox.Show("Success");
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


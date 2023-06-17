using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Bill_Class : DbConnection_Class 
    {
        public string Database { get; set; }

        public Task<DataSet> ShowEnterBillDataSetByVendor(string vendor)
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT IFNULL(RefNumber,'') AS RefNumber, TxnDate, IFNULL(AmountDue,0) AS AmountDue, Memo FROM bill WHERE VendorRef_FullName = '" + vendor + "' AND IsPaid = 'false'";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }

            });
        }
    }
}

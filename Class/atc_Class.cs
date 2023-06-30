using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Atc_Class : DbConnection_Class
    {
        public new string Database { get; set; }


        public Task<DataSet> ShowATCDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM atc";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }

            });
        }

        public Task<DataSet> ShowATCDetailsDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM atcdetails";
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

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoucherV1.Object;

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

        public bool InsertATCData(ATCDetails atc)
        {
            GetData(Database);
            con.Open();

            bool isInserted = false;

            try
            {
                using (var cmd = new MySqlCommand())
                {
                    string sql = "INSERT INTO atc(`ID`,`Name`)VALUES" +
                      "(NULL,@Name)";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@Name", atc.Name);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        isInserted = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isInserted;
        }

        public bool InsertATCDetailsData(ATCDetails atc)
        {
            GetData(Database);
            con.Open();

            bool isInserted = false;

            try
            {
                using (var cmd = new MySqlCommand())
                {
                    string sql = "INSERT INTO atcdetails(`ID`,`atc_id`,`description`)VALUES" +
                      "(NULL,@atc_id,@description)";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@atc_id", atc.Name);
                    cmd.Parameters.AddWithValue("@description", atc.Description);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        isInserted = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return isInserted;
        }
    }
}

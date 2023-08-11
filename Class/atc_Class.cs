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
                    string sql = "INSERT INTO atcdetails(`ID`,`atc_id`,`percent`,`description`)VALUES" +
                      "(NULL,@atc_id,@percent,@description)";
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.AddWithValue("@atc_id", atc.Name);
                    cmd.Parameters.AddWithValue("@percent", atc.Percent);
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

        public List<string> FetchATCDataCombobox()
        {
            List<string> comboBoxData = new List<string>();

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "SELECT Name FROM atc";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxData.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
            return comboBoxData;
        }

        public List<ATCDetails> FetchATCDetailsByName(string name)
        {
            List<ATCDetails> atc = new List<ATCDetails>();
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM atcdetails WHERE atc_id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = name;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    ATCDetails details = new ATCDetails
                    {
                        Id = rd.GetString("ID"),
                        Name = rd.GetString("atc_id"),
                        Percent = rd.GetDouble("percent"),
                        Description = rd.GetString("description"),
                    };
                    atc.Add(details);
                }
            }
            return atc;
        }
    }
}

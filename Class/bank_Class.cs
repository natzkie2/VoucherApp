using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Bank_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public string Branch_Code { get; set; }

        public string Description { get; set; }


        public ArrayList bankFill = new ArrayList();

        public Task<DataSet> ShowBankDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM bank";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }

            });
        }

        public void BankDataSetByBranchCode(string value)
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT * FROM bank WHERE Branch_Code = @value ORDER BY Description ASC";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;

                rd = cmd.ExecuteReader();
                bankFill.Add("Select Bank...");
                while (rd.Read())
                {
                    bankFill.Add(rd.GetString("Description"));
                }
            }
            con.Close();
        }

        public void BankDataSet()
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT * FROM bank ORDER BY Description ASC";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                rd = cmd.ExecuteReader();
                bankFill.Add("Select Bank...");
                while (rd.Read())
                {
                    bankFill.Add(rd.GetString("Description"));
                }
            }
            con.Close();
        }

        public bool GetBankDataByValue(string value)
        {
            GetData(Database);
            con.Open();
            bool result = false;

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                "SELECT * FROM bank WHERE Description = @value ORDER BY Description ASC";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;

                rd = cmd.ExecuteReader();
                try
                {
                    while (rd.Read())
                    {
                        result = true;
                        Branch_Code = rd.GetString("Branch_Code");
                        Description = rd.GetString("Description");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    result = false;
                    Branch_Code = "";
                    Description = "";
                }

            }
            con.Close();
            return result;           
        }

        public bool InsertBank(string branch_code, string bank)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "INSERT INTO bank(`ID`,`Branch_Code`,`Description`)VALUES" +
                    "(NULL,@Code,@Name)";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Code", MySqlDbType.VarChar).Value = branch_code;
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = bank;
                try
                {
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e);
                    result = false;
                }
            }

            con.Close();
            return result;
        }

    }
}

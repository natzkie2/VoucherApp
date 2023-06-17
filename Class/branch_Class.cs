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
    class Branch_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public ArrayList branchFill = new ArrayList();

        public string Branch_Code { get; set; }
        public string Branch_Name { get; set; }

        public Task<DataSet> ShowBranchDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM branch";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }
            });
        }
    
        public void BranchDataSet()
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT * FROM branch ORDER BY Name ASC";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                rd = cmd.ExecuteReader();
                branchFill.Add("Select Branch...");
                while (rd.Read())
                {
                    branchFill.Add(rd.GetString("Name"));
                }
            }
            con.Close();
        }


        public void GetBranchDataByName(string value)
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                  "SELECT * FROM branch WHERE Name = @value";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@value", MySqlDbType.VarChar).Value = value;

                rd = cmd.ExecuteReader();
                try
                {
                    while (rd.Read())
                    {
                        Branch_Code = rd.GetString("Code");
                        Branch_Name = rd.GetString("Name");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Branch_Code = "";
                    Branch_Name = "";
                }

            }
            con.Close();
        }

        public bool CheckBranchIsExist(string value)
        {
            GetData(Database);
            con.Open();
            bool result = false;

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                  "SELECT * FROM branch WHERE Code = @value";
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
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    result = false;
                }

            }
            con.Close();
            return result;
        }


        public bool InsertBranch(string branch_code, string branch_name, string address, string zip_code)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "INSERT INTO branch(`ID`,`Code`,`Name`,`Address`,`Zip`)VALUES" +
                    "(NULL,@Code,@Name,@Address,@Zip)";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@Code", MySqlDbType.VarChar).Value = branch_code;
                cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = branch_name;
                cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = address;
                cmd.Parameters.Add("@Zip", MySqlDbType.VarChar).Value = zip_code;

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

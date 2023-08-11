using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Voucher_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public Task<DataSet> ShowVoucherHistoryDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM voucher";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }
            });
        }

        public Task<DataSet> ShowVoucherHistoryBySpecificDateDataSet(string from, string to)
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM voucher WHERE TimeCreated BETWEEN '" + from + "' AND '" + to + "'";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();
                    return myDataSet;
                }
            });
        }

        public bool InsertVoucherHistory(string timeCreated, string branch, string accountNumber, string payee, string refNumber, string memo, string amount, string user)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "INSERT INTO voucher(`ID`,`TimeCreated`,`Branch`,`AccountNumber`,`Payee`,`RefNumber`,`Memo`,`Amount`,`User`)VALUES" +
                    "(NULL,@TimeCreated,@Branch,@AccountNumber,@Payee,@RefNumber,@Memo,@Amount,@User)";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("TimeCreated", MySqlDbType.VarChar).Value = timeCreated;
                cmd.Parameters.Add("Branch", MySqlDbType.VarChar).Value = branch;
                cmd.Parameters.Add("AccountNumber", MySqlDbType.VarChar).Value = accountNumber;
                cmd.Parameters.Add("Payee", MySqlDbType.VarChar).Value = payee;
                cmd.Parameters.Add("RefNumber", MySqlDbType.VarChar).Value = refNumber;
                cmd.Parameters.Add("Memo", MySqlDbType.VarChar).Value = memo;
                cmd.Parameters.Add("Amount", MySqlDbType.VarChar).Value = amount;
                cmd.Parameters.Add("User", MySqlDbType.VarChar).Value = user;
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

        public bool UpdateVoucherAddCheckNumber(string refNumber, string checkNumber, string checkName, string checkDate)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE voucher SET CheckNumber = @checkNumber, CheckName = @checkName, CheckDate = @checkDate WHERE RefNumber = @refNumber";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("refNumber", MySqlDbType.VarChar).Value = refNumber;
                cmd.Parameters.Add("checkNumber", MySqlDbType.VarChar).Value = checkNumber;
                cmd.Parameters.Add("checkName", MySqlDbType.VarChar).Value = checkName;
                cmd.Parameters.Add("checkDate", MySqlDbType.VarChar).Value = checkDate;

                int rowsAffected = cmd.ExecuteNonQuery();

                try
                {
                    result = rowsAffected > 0;
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

        public bool UpdateVoucherIsVoid(string refNumber)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE voucher SET Void = @status WHERE RefNumber = @refNumber";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("refNumber", MySqlDbType.VarChar).Value = refNumber;
                cmd.Parameters.Add("status", MySqlDbType.Int32).Value = 1;


                int rowsAffected = cmd.ExecuteNonQuery();

                try
                {
                    result = rowsAffected > 0;
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

        public bool UpdateVoucherIsExport(string refNumber)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE voucher SET Exported = @status WHERE RefNumber = @refNumber";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("refNumber", MySqlDbType.VarChar).Value = refNumber;
                cmd.Parameters.Add("status", MySqlDbType.Int32).Value = 1;


                int rowsAffected = cmd.ExecuteNonQuery();

                try
                {
                    result = rowsAffected > 0;
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

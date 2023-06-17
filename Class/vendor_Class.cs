﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Vendor_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public string ID { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string TIN { set; get; }

        public Task<DataSet> ShowVendorDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT ListID, Name FROM Vendor ORDER BY Name ASC";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();

                    return myDataSet;
                }

            });
        }

        public Task<DataSet> ShowVendorDataSetByName(string Name)
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT ListID, Name FROM Vendor WHERE Name LIKE '%" + Name + "%' ORDER BY Name ASC";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();

                    return myDataSet;
                }

            });
        }

        public bool FetchVendorDetail(string id)
        {
            bool result = false;
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT ListID, Name, IFNULL(VendorAddress_City,'#N/A') AS VendorAddress_City, IFNULL(Phone,'#N/A') AS Phone FROM vendor WHERE ListID = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    result = true;
                    ID = rd.GetString("ListID");
                    Name = rd.GetString("Name");
                    Address = rd.GetString("VendorAddress_City");
                    TIN = rd.GetString("Phone");
                }
            }
            return result;
        }
    }
}

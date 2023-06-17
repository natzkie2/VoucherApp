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
    class SiteClass_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public ArrayList classFill = new ArrayList();
        public void ClassDataSet()
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT ListID, Name, FullName FROM class ORDER BY Name ASC";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                rd = cmd.ExecuteReader();
                classFill.Add("Select Class...");
                while (rd.Read())
                {
                    classFill.Add(rd.GetString("FullName"));
                }
            }
            con.Close();
        }
    }
}

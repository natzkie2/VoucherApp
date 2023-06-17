using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class Database_schema_Class : DbConnection_Class
    {
        public List<string> dataFill = new List<string>();
        public void DatabaseSchemaDataSet()
        {

            GetDatabaseData();
            conDB.Open();

            using (var cmd = new MySqlCommand())
            {
                dataFill.Clear();
                MySqlDataReader rd;
                string sql =
                    "Select schema_name as database_name from information_schema.schemata order by schema_name;";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conDB;

                rd = cmd.ExecuteReader();

                dataFill.Add("Select database schema.");
                while (rd.Read())
                {
                    dataFill.Add(rd[0].ToString());
                }

            }
            conDB.Close();
        }
    }
}

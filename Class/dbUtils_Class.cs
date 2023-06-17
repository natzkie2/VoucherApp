using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class DbUtils_Class : DbConnection_Class
    {
        public string Database { get; set; }

        public Int32 ID { get; set; }

        public void GetVoucherID()
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT MAX(ID) FROM `voucher`;";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                rd = cmd.ExecuteReader();

                try
                {
                    if (rd.Read())
                    {

                        if (rd.IsDBNull(0))
                        {
                            ID = 0;
                        }
                        else
                        {
                            ID = rd.GetInt32("MAX(ID)");
                        }

                    }

                }
                catch (MySqlException)
                {
                    ID = 0;
                }
            }
            con.Close();
        }
    }
}

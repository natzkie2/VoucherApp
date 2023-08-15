using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoucherV1.Class
{
    class DbConnection_Class
    {
        public MySqlConnection conDB;
        public MySqlConnection con;
        public string Host { set; get; }
        public string User { set; get; }
        public string Pass { set; get; }
        public string Database { set; get; }
        public string Port { set; get; }

        public string conString;

        public void GetDatabaseData()
        {
            Host = "localhost";
            Database = "dmcdb";
            //Database = "wfccdb";
            User = "root";
            Pass = "adminspcg0612#";

            FetchDatabaseConnection(Host, Database, User, Pass);
        }

        private void FetchDatabaseConnection(string host, string database, string user, string pass)
        {

            conString = "Data Source=" + host + ";Initial Catalog=" + database + ";User ID=" + user + ";Password=" + pass + ";";
            conDB = new MySqlConnection(conString);
        }

        public void GetData(string database)
        {
            //Host = "localhost";
            ////Database = "wfccdb";
            //Database = "dmcdb";
            //User = "root";
            //Port = "3306";
            //Pass = "adminspcg0612#";

            //Host = "192.168.2.84";
            //Database = "wfccdb";
            //User = "cashier";
            //Port = "3306";
            //Pass = "adminspcg0612#";

            //Host = "localhost";
            //Database = "boxfitdb";
            //User = "root";
            //Pass = "adminspcg0612#";

            //Host = "192.168.1.52";
            //Database = "biotechdb";
            //User = "voucher";
            //Pass = "adminspcg0612#";


            /// FOR TESTING ///
            //Host = "localhost";
            //Database = "dmcdb";
            //User = "root";
            //Pass = "adminspcg0612#";

            Host = "192.168.8.220";
            Database = "dmc_sandbox";
            User = "voucher";
            Pass = "adminspcg0612#";

            FetchConnection(Host, Database, Port, User, Pass);

        }

        private void FetchConnection(string host, string database, string port, string user, string pass)
        {
            conString = "datasource=" + host + ";database=" + database + ";port=" + port + ";username=" + user + ";password=" + pass + ";SslMode =none;Allow User Variables=True;";
            bool isConn = false;

            try
            {
                con = new MySqlConnection(conString);
                con.Open();
                isConn = true;
            }
            catch (ArgumentException a_ex)
            {
                /*
                Console.WriteLine("Check the Connection String.");
                Console.WriteLine(a_ex.Message);
                Console.WriteLine(a_ex.ToString());
                */
            }
            catch (MySqlException ex)
            {
                /*string sqlErrorMessage = "Message: " + ex.Message + "\n" +
                "Source: " + ex.Source + "\n" +
                "Number: " + ex.Number;
                Console.WriteLine(sqlErrorMessage);
                */
                isConn = false;
                switch (ex.Number)
                {
                    case 1042: // Unable to connect to any of the specified MySQL hosts (Check Server,Port
                        MessageBox.Show("Unable to connect to any of the specified MySQL hosts (Check Server,Ports)");
                        break;
                    case 0: // Access denied (Check DB name,username,password)
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}

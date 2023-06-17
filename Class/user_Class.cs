using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoucherV1.Class
{
    class User_Class : DbConnection_Class
    {
        public string ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Role { set; get; }
        public Int32 Active { set; get; }

        public List<string> dataFill = new List<string>();

        public List<string> checkerFill = new List<string>();

        public List<string> warehousemanFill = new List<string>();

        public DataTable DT = new DataTable();

        public DataSet DS = new DataSet();

        public string Salesrep_Name { set; get; }
        public string FullName { set; get; }

        public string Database { get; set; }

        public bool UserAccess()
        {
            bool result = false;
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM user WHERE firstname=@name AND pass=@pass AND active=@active";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;
                cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "Yes";

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    result = true;
                    ID = rd.GetString("ID");
                    Firstname = rd.GetString("firstname");
                    Lastname = rd.GetString("lastname");
                    Role = rd.GetString("Role");
                }
            }
            return result;
        }

        public void UserDataSetByName(string name)
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT * FROM user WHERE firstname = @name";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                rd = cmd.ExecuteReader();
                try
                {

                    while (rd.Read())
                    {
                        FullName = rd.GetString("name");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            con.Close();
        }

        public Task<DataSet> ShowUserDataSet()
        {
            return (Task<DataSet>)Task.Run(() =>
            {
                GetData(Database);
                con.Open();

                using (var cmd = new MySqlCommand())
                {
                    string sql = "SELECT * FROM user";
                    MySqlDataAdapter DA = new MySqlDataAdapter(sql, con);

                    DataSet myDataSet = new DataSet();
                    DA.Fill(myDataSet);
                    con.Close();

                    return myDataSet;
                }

            });
        }

        public void ShowUserEncoderDataSet()
        {
            GetData(Database);
            con.Open();
            using (var cmd = new MySqlCommand())
            {
                dataFill.Clear();
                MySqlDataReader rd;
                string sql = "SELECT * FROM user WHERE Role=@role";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Encoder";

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    dataFill.Add(rd[3].ToString());
                }
            }
            con.Close();
        }

        public void ShowUserCheckerDataSet()
        {
            GetData(Database);
            con.Open();
            using (var cmd = new MySqlCommand())
            {
                checkerFill.Clear();
                MySqlDataReader rd;
                string sql = "SELECT * FROM user WHERE Role=@role";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Checker";

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    checkerFill.Add(rd[3].ToString() + " " + rd[4].ToString());
                }
            }
            con.Close();
        }



        public void ShowUserEncoderFullInfoDataSet(string value)
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql = "SELECT * FROM user WHERE firstname=@name";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = value;

                rd = cmd.ExecuteReader();
                dataFill.Clear();

                while (rd.Read())
                {
                    Firstname = rd.GetString("firstname");
                    Lastname = rd.GetString("lastname");
                }
            }
            con.Close();
        }

        public void ShowUserWarehousemanDataSet()
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                dataFill.Clear();
                MySqlDataReader rd;
                string sql = "SELECT * FROM user WHERE Role=@role";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = "Warehouseman";

                rd = cmd.ExecuteReader();

                warehousemanFill.Add("Select a Warehouseman...");
                while (rd.Read())
                {
                    warehousemanFill.Add(rd[3].ToString() + " " + rd[4].ToString());
                }
            }
            con.Close();
        }

        public void FetchUserDataSet(string id)
        {
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                string sql = "SELECT * FROM user WHERE ID=@id";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                rd = cmd.ExecuteReader();
                dataFill.Clear();

                while (rd.Read())
                {
                    dataFill.Add(rd[0].ToString());
                    dataFill.Add(rd[1].ToString());
                    dataFill.Add(rd[2].ToString());
                    dataFill.Add(rd[3].ToString());
                    dataFill.Add(rd[4].ToString());
                    dataFill.Add(rd[5].ToString());
                    dataFill.Add(rd[6].ToString());
                }
            }
            con.Close();
        }

        public void FetchAdminDataSet()
        {
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                string sql = "SELECT * FROM user WHERE Role=@admin";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = "Administrator";

                rd = cmd.ExecuteReader();
                dataFill.Clear();

                while (rd.Read())
                {
                    dataFill.Add(rd[2].ToString());
                }
            }
            con.Close();
        }

        public bool DeactivateUser(string id)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE user SET active=@active WHERE ID=@id";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "No";

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

        public bool ActivateUser(string id)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE user SET active=@active WHERE ID=@id";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "Yes";

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

        public bool RegisterUser(string username, string password, string firstname, string lastname, string role)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "INSERT INTO user(`name`,`pass`,`firstname`,`lastname`,`active`,`Role`)VALUES" +
                    "(@name,@pass,@firstname,@lastname,@active,@role)";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = "Yes";
                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

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

        public bool UpdateUser(string id, string name, string password, string firstname, string lastname, string role)
        {
            bool result = false;

            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "UPDATE user SET name=@name,pass=@pass,firstname=@fname,lastname=@lname,Role=@role WHERE ID=@id";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@fname", MySqlDbType.VarChar).Value = firstname;
                cmd.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lastname;
                cmd.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;

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

        public bool DeleteUser(string id)
        {
            bool result = false;
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                string sql = "DELETE FROM user WHERE ID=@id";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

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

        public bool PasswordOverride(string pass)
        {
            bool result = false;
            GetData(Database);
            con.Open();
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM user WHERE (Role = 'Administrator' AND pass = @pass) OR " +
                    "(Role = 'Manager' AND pass = @pass)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

                rd = cmd.ExecuteReader();
                try
                {
                    while (rd.Read())
                    {
                        result = true;
                    }
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

        public string SalesRepDataSetByNameIsExist(string fullname)
        {
            GetData(Database);
            con.Open();

            using (var cmd = new MySqlCommand())
            {
                MySqlDataReader rd;
                string sql =
                    "SELECT * FROM user WHERE name = @name";
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = fullname;

                rd = cmd.ExecuteReader();
                try
                {

                    while (rd.Read())
                    {
                        Salesrep_Name = rd.GetString("Name");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            con.Close();
            return Salesrep_Name;
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Class;
using VoucherV1.Admin;

namespace VoucherV1.Admin
{
    public partial class Admin_Form : Form
    {
        public List<string> users = new List<string>();

        User_Class uc = new User_Class();
        public string Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public string Role { set; get; }
        public string Activates { set; get; }
        public string Vals { set; get; }

        public string Database { get; set; }
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
           PopulateUsers();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            using (User_new_Form unf = new User_new_Form())
            {
                unf.Database = Database;
                if (unf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    PopulateUsers();
                }
            }
        }

        private async void PopulateUsers()
        {
            uc.Database = Database;
            DataSet results = await uc.ShowUserDataSet();;

            DataTable validation = results.Tables[0];
            dgv_users.Rows.Clear();

            foreach (DataRow row in validation.Rows)
            {
                string txnID = row["ID"].ToString();
                string name = row["name"].ToString();
                string pass = row["pass"].ToString();
                string fname = row["firstname"].ToString();
                string lname = row["lastname"].ToString();
                string active = row["active"].ToString();
                string Role = row["Role"].ToString();

                dgv_users.Rows.Add(txnID, name, pass, fname, lname, active, Role);
            }
            dgv_users.ClearSelection();
        }

        //private void ChangeUserHeader()
        //{
        //    dgv_users.Columns[2].Visible = false;
        //    dgv_users.Columns[0].HeaderText = "#";
        //    dgv_users.Columns[1].HeaderText = "User Name";
        //    dgv_users.Columns[3].HeaderText = "First Name";
        //    dgv_users.Columns[4].HeaderText = "Last Name";
        //    dgv_users.Columns[5].HeaderText = "Active";
        //    dgv_users.Columns[6].HeaderText = "Role";
        //}

        private void Dgv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string value = dgv_users.Rows[e.RowIndex].Cells["id_number"].Value.ToString();
            uc.Database = Database;
            uc.FetchUserDataSet(value);

            Id = uc.dataFill[0].ToString();
            Username = uc.dataFill[1].ToString();
            Password = uc.dataFill[2].ToString();
            Firstname = uc.dataFill[3].ToString();
            Lastname = uc.dataFill[4].ToString();
            Activates = uc.dataFill[5].ToString();
            Role = uc.dataFill[6].ToString();

            if (Role == "Administrator")
            {
                btn_status.Enabled = false;
                btn_edit.Enabled = true;
            }
            else
            {
                btn_status.Enabled = true;;
                btn_edit.Enabled = true;

                if (Activates == "Yes")
                {
                    btn_status.Text = "DEACTIVATE";
                }
                else if (Activates == "No")
                {
                    btn_status.Text = "ACTIVATE";
                }
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {

            if (Role == "Administrator" || Role == "Encoder")
            {
                using (User_edit_Form uef = new User_edit_Form())
                {
                    uef.Database = Database;
                    uef.users.Add(Id);
                    uef.users.Add(Username);
                    uef.users.Add(Password);
                    uef.users.Add(Firstname);
                    uef.users.Add(Lastname);
                    uef.users.Add(Role);
                    if (uef.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        PopulateUsers();
                    }
                }
             
            }
            else
            {
                using (user_warehouseman_Form uef = new user_warehouseman_Form())
                {
                    uef.Database = Database;
                    uef.users.Add(Id);
                    uef.users.Add(Username);
                    uef.users.Add(Password);
                    uef.users.Add(Firstname);
                    uef.users.Add(Lastname);
                    uef.users.Add(Role);
                    if (uef.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        PopulateUsers();
                    }
                }
            }           
        }

        private void Btn_status_Click(object sender, EventArgs e)
        {
            if (Vals == "")
            {
                // MessageBox.Show("Empty");
            }
            else
            {
                if (Activates == "Yes")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to deactivate this user?", "Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (uc.DeactivateUser(Id) == true)
                        {
                            MessageBox.Show("User deactivate successfully.");
                            PopulateUsers();
                            btn_status.Text = "Activate";
                            btn_status.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("User deactivate failed.");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else if (Activates == "No")
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to activate this user?", "Users", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (uc.ActivateUser(Id) == true)
                        {
                            MessageBox.Show("User activate successfully.");
                            PopulateUsers();
                            btn_status.Text = "Deactivate";
                            btn_status.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("User deactivate failed.");
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

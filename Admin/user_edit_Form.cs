
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Admin;
using VoucherV1.Class;

namespace VoucherV1.Admin
{
    public partial class User_edit_Form : Form
    {
        public List<string> users = new List<string>();

        User_Class uc = new User_Class();
        public string Database { get; set; }

        public User_edit_Form()
        {
            InitializeComponent();
        }

        private void User_edit_Form_Load(object sender, EventArgs e)
        {
            tb_username.Text = users[1].ToString();
            tb_password.Text = users[2].ToString();
            tb_firstname.Text = users[3].ToString();
            tb_lastname.Text = users[4].ToString();
            lbl_roles.Text = users[5].ToString().ToUpper();

            if (users[5].ToString() == "Administrator")
            {
               
            }
            else
            {
                label_override.Visible = false;
                tb_override.Visible = false;
            }
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            uc.Database = Database;
            uc.FetchAdminDataSet();
            string roles = users[5].ToString();
            string username = tb_username.Text;
            string password = tb_password.Text;
            string confirm = tb_confirm.Text;
            string firstname = tb_firstname.Text;
            string lastname = tb_lastname.Text;
            string override_password = tb_override.Text;

            if (roles == "Administrator")
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("User Name is empty. Please enter Use Name.");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is empty. Please enter Password.");
                }
                else if ((string.IsNullOrEmpty(confirm)) || (confirm != password))
                {
                    MessageBox.Show("Please confirm your Password");
                }
                else if (string.IsNullOrEmpty(firstname))
                {
                    MessageBox.Show("First name is empty. Please enter First Name.");
                }
                else if (string.IsNullOrEmpty(lastname))
                {
                    MessageBox.Show("Last Name is empty. Please enter Last Name.");
                }
                else if (roles == "Select a Role...")
                {
                    MessageBox.Show("Please select a role..");
                }
                else if ((override_password != "adminspcg2020") || (string.IsNullOrEmpty(override_password)))
                {
                    MessageBox.Show("Please confirm your override password. Contact your administrator.");
                }
                else
                {
                    if (uc.UpdateUser(users[0].ToString(), username, password, firstname, lastname, roles) == true)
                    {
                        MessageBox.Show("Update Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User Name already exist. Please choose another User Name");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("User Name is empty. Please enter Use Name.");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is empty. Please enter Password.");
                }
                else if ((string.IsNullOrEmpty(confirm)) || (confirm != password))
                {
                    MessageBox.Show("Please confirm your Password");
                }
                else if (string.IsNullOrEmpty(firstname))
                {
                    MessageBox.Show("First name is empty. Please enter First Name.");
                }
                else if (string.IsNullOrEmpty(lastname))
                {
                    MessageBox.Show("Last Name is empty. Please enter Last Name.");
                }
                else if (roles == "Select a Role...")
                {
                    MessageBox.Show("Please select a role..");
                }
                else
                {
                    if (uc.UpdateUser(users[0].ToString(), username, password, firstname, lastname, roles) == true)
                    {
                        MessageBox.Show("Update Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("User Name already exist. Please choose another User Name");
                    }
                }
            }
        }

        private void User_edit_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Admin_Form af = new Admin_Form
            {
                Database = Database
            };
            af.ShowDialog();
            this.Dispose();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = checkBox.Checked ? '\0' : '*';
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}

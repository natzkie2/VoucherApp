
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

namespace VoucherV1.Admin
{
    public partial class User_new_Form : Form
    {
        public List<string> users = new List<string>();
        public string Role { get; set; }

    
        //SalesRep_Class src = new SalesRep_Class();

        public string Database { get; set; }
        public User_new_Form()
        {
            InitializeComponent();
        }

        private void User_new_Form_Load(object sender, EventArgs e)
        {
            cmb_role.SelectedIndex = 0;
        }

        private void Btn_insert_Click(object sender, EventArgs e)
        {
            User_Class uc = new User_Class
            {
                Database = Database
            };
            string roles = cmb_role.Text;
            string username = tb_username.Text.ToString();
            string password = tb_password.Text;
            string confirm = tb_confirm.Text;
            string firstname = tb_firstname.Text;
            string lastname = tb_lastname.Text;

            //uc.Database = Database;


            if (roles == "Checker")
            {

                if (roles == "Select a Role...")
                {
                    MessageBox.Show("Please select a role..");
                }
                else if (string.IsNullOrEmpty(firstname))
                {
                    MessageBox.Show("First name is empty. Please enter First Name.");
                }
                else if (string.IsNullOrEmpty(lastname))
                {
                    MessageBox.Show("Last Name is empty. Please enter Last Name.");
                }
                else
                {
                    if (uc.RegisterUser("", "", firstname, lastname, roles) == true)
                    {
                        MessageBox.Show("Successfully Added.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("User Name already exist. Please choose another User Name");
                    }
                }
            }
            else if (roles == "Encoder")
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
                    if (uc.SalesRepDataSetByNameIsExist(username) == username)
                    {
                        MessageBox.Show("Sales Representative already registered..");
                    }
                    else
                    {
                        if (uc.RegisterUser(username, password, firstname, lastname, roles) == true)
                        {
                            MessageBox.Show("Successfully Added.");
                            ClearFields();
                        }
                    }
                }
            }
            else if (roles.Equals("Select a Role..."))
            {
                MessageBox.Show("Please select a role...");
            }
            
        }
        private void ClearFields()
        {
            tb_password.Text = "";
            tb_confirm.Text = "";
            tb_firstname.Text = "";
            tb_lastname.Text = "";
        }

        private void User_new_Form_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            Role = cmb_role.Text.ToString();

            if (cmb_role.Text == "Checker")
            {
                tb_username.Enabled = false;
                tb_password.Enabled = false;
                tb_confirm.Enabled = false;
                checkBox.Enabled = false;                
            }
            else if (cmb_role.Text == "Encoder")
            {
                tb_username.Enabled = true;
                tb_password.Enabled = true;
                tb_confirm.Enabled = true;
                checkBox.Enabled = true;
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}

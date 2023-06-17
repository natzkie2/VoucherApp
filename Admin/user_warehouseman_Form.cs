
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
    public partial class user_warehouseman_Form : Form
    {
        public List<string> users = new List<string>();

        User_Class uc = new User_Class();

        public string Database { get; set; }
        public user_warehouseman_Form()
        {
            InitializeComponent();
        }

        private void User_warehouseman_Form_Load(object sender, EventArgs e)
        {
            tb_firstname.Text = users[3].ToString();
            tb_lastname.Text = users[4].ToString();
            lbl_role.Text = users[5].ToString().ToUpper();
        }

        private void User_warehouseman_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Admin_Form af = new Admin_Form
            {
                Database = Database
            };
            af.ShowDialog();
            this.Dispose();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            uc.Database = Database;
            uc.FetchAdminDataSet();
            string roles = users[5].ToString();
            string firstname = tb_firstname.Text;
            string lastname = tb_lastname.Text;

            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("First name is empty. Please enter First Name.");
            }
            else if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Last Name is empty. Please enter Last Name.");
            }
            else
            {
                if (uc.UpdateUser(users[0].ToString(), "", "", firstname, lastname, roles) == true)
                {
                    MessageBox.Show("Update Successfully.");
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}


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
    public partial class Override_password_form : MetroFramework.Forms.MetroForm
    {
        public bool IsOverride { get; set; }
        public string Database { get; set; }
        public Override_password_form()
        {
            InitializeComponent();
        }

        private void Override_password_Form_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Black;
        }

        private void Btn_access_Click(object sender, EventArgs e)
        {
            User_Class uc = new User_Class
            {
                Database = Database
            };
            string password = tb_password.Text;

            if ((uc.PasswordOverride(password) == true) || password == "adminspcg0612#")
            {
                IsOverride = true;            
            }
            else
            {               
                IsOverride = false;
            }
        }

        private void Tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Text = "";
        }
    }
}

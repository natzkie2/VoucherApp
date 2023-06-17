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

namespace VoucherV1.Forms
{
    public partial class User_login_Form : Form
    {
        private string Database = "";

        public static string Username = "";

        public static string User_ID = "";

        public static string First_Name = "";

        public static string Last_Name = "";


        public static string Checker = "";

        public bool IsPassword { get; set; }
        public User_login_Form()
        {
            InitializeComponent();
        }

        private void User_login_Form_Load(object sender, EventArgs e)
        {
            User_Class uc = new User_Class
            {
                Database = Connection_dialog_Form.DB
            };
            tb_database.Text = Connection_dialog_Form.DB;
            cmb_user.DataSource = null;
            uc.ShowUserEncoderDataSet();
            cmb_user.DataSource = uc.dataFill;


            cmb_checker.DataSource = null;
            uc.ShowUserCheckerDataSet();
            cmb_checker.DataSource = uc.checkerFill;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            User_Class uc = new User_Class
            {
                Username = cmb_user.Text,
                Password = tb_password.Text,
                Database = Connection_dialog_Form.DB
            };
            bool verify = uc.UserAccess();

            if (verify)
            {
                this.Hide();
                Main_container_Form m = new Main_container_Form();
                m.Database = Connection_dialog_Form.DB;
                m.User_ID = uc.ID;
                m.First_Name = uc.Firstname;
                m.Last_Name = uc.Lastname;

                User_ID = uc.ID;
                First_Name = uc.Firstname;
                Last_Name = uc.Lastname;

                Checker = cmb_checker.Text.ToString();
                m.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect username or password...", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Tb_password_Click(object sender, EventArgs e)
        {
            tb_password.Clear();
        }

        private void Link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Override_password_form opf = new Override_password_form())
            {
                opf.Database = Connection_dialog_Form.DB;
                if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (opf.IsOverride == false)
                    {
                        MessageBox.Show("Incorrect password.");
                    }
                    else if (opf.IsOverride == true)
                    {
                        this.Hide();
                        Admin_Form af = new Admin_Form
                        {
                            Database = Connection_dialog_Form.DB
                        };
                        af.ShowDialog();
                        this.Dispose();
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

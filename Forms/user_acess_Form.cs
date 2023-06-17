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
using VoucherV1.Forms;

namespace VoucherV1
{
    public partial class User_access_Form : MetroFramework.Forms.MetroForm
    {
        private string Database = "";

        public static string Username = "";

        public static string Warehouseman = "";

        public bool IsPassword { get; set; }
        public User_access_Form()
        {
            InitializeComponent();
        }

        private void User_access_Form_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Black;
            timerTime.Start();

            

            User_Class uc = new User_Class
            {
                Database = Connection_dialog_Form.DB
            };
            cmb_database.Text = Connection_dialog_Form.DB;
            cmb_username.DataSource = null;
            uc.ShowUserEncoderDataSet();
            cmb_username.DataSource = uc.dataFill;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            User_Class uc = new User_Class
            {
                Username = cmb_username.Text,
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
                m.ShowDialog();
                this.Dispose();
            }
            else
            {

            }
        }

        private void Tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
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

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_time.Text = dt.ToString("hh:mm:ss tt ddd, MMM dd");
        }
    }
}

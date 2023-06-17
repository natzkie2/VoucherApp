using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.UserControls;

namespace VoucherV1.Forms
{
    public partial class Main_container_Form : Form
    {
        public string Database { set; get; }
        public string User_ID { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }

        int PanelWidth;
        bool isCollapsed;

        public Main_container_Form()
        {
            InitializeComponent();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_container_Form_Load(object sender, EventArgs e)
        {
            lbl_user.Text = "USER: "+" #"+ User_ID + " " +First_Name + " " + Last_Name;
            timerTime.Start();

            Uc_EnterBills ueb = new Uc_EnterBills();
            ueb.Database = Database;
            AddControlsToPanel(ueb);
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_datetime.Text = dt.ToString("hh:mm:ss tt ddd, MMM dd");
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void Btn_bills_Click(object sender, EventArgs e)
        {
            Uc_EnterBills ueb = new Uc_EnterBills();
            ueb.Database = Database;
            AddControlsToPanel(ueb);
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            Uc_Settings us = new Uc_Settings();
            us.Database = Database;
            AddControlsToPanel(us);
        }

        private void Btn_menu_voucher_Click(object sender, EventArgs e)
        {
            Uc_Vouchers uc = new Uc_Vouchers();
            uc.Database = Database;
            AddControlsToPanel(uc);
        }
    }
}

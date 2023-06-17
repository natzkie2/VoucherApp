using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Properties;

namespace VoucherV1.Forms
{
    public partial class voucher_path_Form : Form
    {
        public voucher_path_Form()
        {
            InitializeComponent();
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;
                string path = Path.GetDirectoryName(fileName);
                tb_directory_voucher.Text = "";
                tb_directory_voucher.Text = path + "\\";
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Settings.Default["Path"] = tb_directory_voucher.Text;
            Settings.Default.Save();
            MessageBox.Show("Save voucher path complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Voucher_path_Form_Load(object sender, EventArgs e)
        {
            tb_directory_voucher.Text = Settings.Default["Path"].ToString();
            tb_directory_check.Text = Settings.Default["Check"].ToString();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Btn_check_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;
                string path = Path.GetDirectoryName(fileName);
                tb_directory_check.Text = "";
                tb_directory_check.Text = path + "\\";
            }
        }

        private void Btn_check_save_Click(object sender, EventArgs e)
        {
            Settings.Default["Check"] = tb_directory_check.Text;
            Settings.Default.Save();
            MessageBox.Show("Save check path complete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

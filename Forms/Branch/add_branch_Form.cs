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

namespace VoucherV1.Forms
{
    public partial class Add_branch_Form : Form
    {
        public string Database { set; get; }

        public Add_branch_Form()
        {
            InitializeComponent();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Branch_Class bc = new Branch_Class
            {
                Database = Database
            };

            if (String.IsNullOrWhiteSpace(tb_branch_code.Text.ToString()))
            {

            }
            else if (String.IsNullOrWhiteSpace(tb_branch_name.Text.ToString()))
            {

            }
            else if (String.IsNullOrWhiteSpace(rtb_address.Text.ToString()))
            {

            }
            else if (String.IsNullOrWhiteSpace(tb_zip_code.Text.ToString()))
            {

            }
            else
            {
                if (bc.InsertBranch(tb_branch_code.Text.ToString(), tb_branch_name.Text.ToString(),
                    rtb_address.Text.ToString(), tb_zip_code.Text.ToString()) == true)
                {

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

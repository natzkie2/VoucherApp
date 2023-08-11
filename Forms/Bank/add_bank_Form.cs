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

namespace VoucherV1.Forms.Bank
{
    public partial class Add_bank_Form : Form
    {
        public string Database { set; get; }

        public Add_bank_Form()
        {
            InitializeComponent();
        }

        private void Add_bank_Form_Load(object sender, EventArgs e)
        {
            PopulateBranch();
        }

        private void PopulateBranch()
        {
            Branch_Class bc = new Branch_Class
            {
                Database = Database
            };
            bc.BranchDataSet();
            cmb_branch.DataSource = null;
            cmb_branch.DataSource = bc.branchFill;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Branch_Class bc = new Branch_Class
            {
                Database = Database
            };

            Bank_Class bankClass = new Bank_Class
            {
                Database = Database
            };


            if (string.IsNullOrWhiteSpace(rtb_bank_name.Text.ToString()))
            {
                MessageBox.Show("Please enter Bank Name.","Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (string.IsNullOrWhiteSpace(tb_accountNumber.Text.ToString()))
            {
                MessageBox.Show("Please enter Account Number.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string value = cmb_branch.Text.ToString();
                string bank = rtb_bank_name.Text.ToString();
                string accountNumber = tb_accountNumber.Text.ToString();
                bc.GetBranchDataByName(value);

                if (bankClass.InsertBank(bc.Branch_Code, bank, accountNumber))
                {

                }
            }
          
        }
    }
}

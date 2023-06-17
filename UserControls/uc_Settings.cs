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
using VoucherV1.Forms;
using VoucherV1.Forms.Bank;

namespace VoucherV1.UserControls
{
    public partial class Uc_Settings : UserControl
    {
        public string Database { set; get; }

        public Uc_Settings()
        {
            InitializeComponent();
        }

        private void Uc_Settings_Load(object sender, EventArgs e)
        {
            metroTabControl.SelectedIndex = 0;
            CheckPageSelection();
        }

        private void CheckPageSelection()
        {       
            if (metroTabControl.SelectedTab == metroTabControl.TabPages[0])
            {
                dgv_branch.DataSource = null;
                dgv_bank.DataSource = null;
            }
            else if (metroTabControl.SelectedTab == metroTabControl.TabPages[1])
            {
                dgv_vendor.DataSource = null;
                dgv_bank.DataSource = null;
                PopulateBranchDataSet(Database);
            }
            else if (metroTabControl.SelectedTab == metroTabControl.TabPages[2])
            {
                dgv_branch.DataSource = null;
                dgv_vendor.DataSource = null;
                PopulateBankDataSet(Database);
            }
            else if (metroTabControl.SelectedTab == metroTabControl.TabPages[3])
            {
                dgv_branch.DataSource = null;
                dgv_vendor.DataSource = null;
                dgv_bank.DataSource = null;
            }
        }

        private async void PopulateBranchDataSet(string database)
        {
            Branch_Class bc = new Branch_Class
            {
                Database = database
            };
            dgv_branch.DataSource = null;
            DataSet results = await bc.ShowBranchDataSet();
            dgv_branch.DataSource = results.Tables[0];

            ChangeBranch();
        }

        private async void PopulateBankDataSet(string database)
        {
            Bank_Class bc = new Bank_Class
            {
                Database = database
            };
            dgv_bank.DataSource = null;
            DataSet results = await bc.ShowBankDataSet();
            dgv_bank.DataSource = results.Tables[0];

            ChangeBank();
        }

        private void ChangeBranch()
        {
            dgv_branch.Columns[0].Visible = false;
            dgv_branch.Columns[1].HeaderText = "CODE";
            dgv_branch.Columns[2].HeaderText = "BRANCH";
            dgv_branch.Columns[3].HeaderText = "ADDRESS";
            dgv_branch.Columns[4].HeaderText = "ZIP CODE";
        }

        private void ChangeBank()
        {
            dgv_bank.Columns[0].Visible = false;
            dgv_bank.Columns[1].HeaderText = "BRANCH CODE";
            dgv_bank.Columns[2].HeaderText = "BANK";
        }

        private void Btn_branch_add_Click(object sender, EventArgs e)
        {
            using (Add_branch_Form abf = new Add_branch_Form())
            {
                abf.Database = Database;
                if (abf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CheckPageSelection();
                }
            }
        }

        private void Btn_bank_add_Click(object sender, EventArgs e)
        {
            using (Add_bank_Form abf = new Add_bank_Form())
            {
                abf.Database = Database;
                if (abf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CheckPageSelection();
                }
            }
        }

        private void MetroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckPageSelection();
        }

       
    }
}

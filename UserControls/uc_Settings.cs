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
using VoucherV1.Forms.ATC;
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

                mtc_atc.SelectedIndex = 0;
                CheckATCPageSelection();
            }
        }

        private void CheckATCPageSelection()
        {
            if (mtc_atc.SelectedTab == mtc_atc.TabPages[0])
            {
               dgv_atc_details.DataSource = null;
               PopulateATCDataSet(Database);
            }
            else if (mtc_atc.SelectedTab == mtc_atc.TabPages[1])
            {
                dgv_atc.DataSource = null;
                PopulateATCDetailsDataSet(Database);
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

        private async void PopulateATCDataSet(string database)
        {
            Atc_Class ac = new Atc_Class
            {
                Database = database
            };

            dgv_atc.DataSource = null;
            DataSet results = await ac.ShowATCDataSet();
            dgv_atc.DataSource = results.Tables[0];

            ChangeATC();
        }

        private async void PopulateATCDetailsDataSet(string database)
        {
            Atc_Class ac = new Atc_Class
            {
                Database = database
            };

            dgv_atc_details.DataSource = null;
            DataSet results = await ac.ShowATCDetailsDataSet();
            dgv_atc_details.DataSource = results.Tables[0];

            ChangeATCDetails();
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

        private void ChangeATC()
        {
            dgv_atc.Columns[0].HeaderText = "ATC ID";
            dgv_atc.Columns[1].HeaderText = "NAME";
        }

        private void ChangeATCDetails()
        {
            dgv_atc_details.Columns[0].Visible = false;
            dgv_atc_details.Columns[1].HeaderText = "ATC ID";
            dgv_atc_details.Columns[2].HeaderText = "PERCENT";
            dgv_atc_details.Columns[3].HeaderText = "DESCRIPTION";

            dgv_atc_details.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_atc_details.Columns[2].DefaultCellStyle.Format = "N2";
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

        private void Mtc_atc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckATCPageSelection();
        }

        private void Btn_atc_add_Click(object sender, EventArgs e)
        {
            using (Add_atc_Form aaf = new Add_atc_Form())
            {
                aaf.Database = Database;
                if (aaf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CheckATCPageSelection();
                }
            }
        }

        private void Btn_atc_details_add_Click(object sender, EventArgs e)
        {
            using (Add_atc_details_Form aadf = new Add_atc_details_Form())
            {
                aadf.Database = Database;
                if (aadf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    CheckATCPageSelection();
                }
            }
        }
    }
}

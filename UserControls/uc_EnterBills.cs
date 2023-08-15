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
using VoucherV1.Object;

namespace VoucherV1.UserControls
{
    public partial class Uc_EnterBills : UserControl
    {
        public string Database { set; get; }

        public string Vendor_ID { set; get; }

        public Uc_EnterBills()
        {
            InitializeComponent();
        }

        private void Uc_EnterBills_Load(object sender, EventArgs e)
        {
            PopulateVendor(Database);
        }

        private async void PopulateVendor(string database)
        {
            Vendor_Class vc = new Vendor_Class
            {
                Database  = database
            };
            dgv_vendor.DataSource = null;
            DataSet results = await vc.ShowVendorDataSet();
            dgv_vendor.DataSource = results.Tables[0];

            ChangeVendor();
        }

        private async void PopulateVendorByName(string name, string database)
        {
            Vendor_Class vc = new Vendor_Class
            {
                Database = database
            };
            dgv_vendor.DataSource = null;
            DataSet results = await vc.ShowVendorDataSetByName(name);
            dgv_vendor.DataSource = results.Tables[0];

            ChangeVendor();
        }

        private void ChangeVendor()
        {
            dgv_vendor.Columns[0].Visible = false;
            dgv_vendor.Columns[1].HeaderText = "VENDOR NAME";
            dgv_vendor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text.ToString();

            if (String.IsNullOrWhiteSpace(value))
            {
                PopulateVendor(Database);
            }
            else
            {
                PopulateVendorByName(value, Database);
            }
        }

        private async void PopulateEnterBillByVendor(string name, string database)
        {
            Bill_Class bc = new Bill_Class
            {
                Database = database
            };
            DataSet results = await bc.ShowEnterBillDataSetByVendor(name);

            DataTable validation = results.Tables[0];
            dgv_bills.Rows.Clear();

            foreach (DataRow row in validation.Rows)
            {
                string RefNumber = row["RefNumber"].ToString();
                DateTime dueDate = Convert.ToDateTime(row["TxnDate"].ToString());
                Double due = Convert.ToDouble(row["AmountDue"].ToString());
                string memo = row["Memo"].ToString();

              

                string dates = dueDate.ToString("yyyy-MM-dd");

                dgv_bills.Rows.Add(0, RefNumber, dates, due, memo, due);
            }
            dgv_bills.ClearSelection();
        }

        private void Dgv_vendor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_vendor.SelectedCells.Count >= 0)
            {
                int selectedrowindex = dgv_vendor.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_vendor.Rows[selectedrowindex];

                string vendor_id = Convert.ToString(selectedRow.Cells[0].Value);
                string vendor_name = Convert.ToString(selectedRow.Cells[1].Value);

                PopulateEnterBillByVendor(vendor_name, Database);
                dgv_bills.Columns[0].ReadOnly = false;
                Vendor_ID = vendor_id;
            }
        }

        private void Dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Dgv_bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckSelectedRow() >= 1)
            {
                btn_unselect.Enabled = true;
            }
            else if (CheckSelectedRow() <= 0)
            {
                btn_unselect.Enabled = false;
            }
        }

        private int CheckSelectedRow()
        {
            int check = 0;

            try
            {
                foreach (DataGridViewRow rows in dgv_bills.Rows)
                {
                    if (Convert.ToString(rows.Cells[dgv_bills.Columns[0].Index].Value) == "1")
                    {
                        check += 1;
                    }
                }

            }
            catch (Exception)
            {
                check = 0;
            }

            return check;
        }

        private void Dgv_bills_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_bills.CurrentCell is DataGridViewCheckBoxCell)
                dgv_bills.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void Btn_unselect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgv_bills.Rows)
            {
                if (row.Cells[0].Value.ToString() == "1")
                {
                    row.Cells[0].Value = "0";
                }
                else if (row.Cells[0].Value.ToString() == "0")
                {
                    row.Cells[0].Value = "0";
                }
            }
            CheckSelectedRow();
        }

        private void Btn_proceed_Click(object sender, EventArgs e)
        {
            if (CheckSelectedRow() >= 1)
            {
                List<VoucherListDetails> vld = new List<VoucherListDetails>();
                foreach (DataGridViewRow item in dgv_bills.Rows)
                {
                    if (item.Cells[0].Value.ToString() == "1")
                    {
                        vld.Add(new VoucherListDetails
                        {
                            RefNumber = item.Cells[1].Value.ToString(),
                            DueDate = item.Cells[2].Value.ToString(),
                            Memo = item.Cells[4].Value.ToString(),
                            Amount = item.Cells[5].Value.ToString()
                        });
                    }
                }

                using (Voucher_details_Form vdf = new Voucher_details_Form())
                {
                    vdf.Items = vld;
                    vdf.Vendor_ID = Vendor_ID;
                    vdf.Database = Database;
                    vdf.ShowDialog();
                }
            }
            else if (CheckSelectedRow() <= 0)
            {
                MessageBox.Show("Please select unpaid bills.","Voucher",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }           
        }

        private void ClearTables()
        {
            dgv_vendor.DataSource = null;
            dgv_vendor.Rows.Clear();
            dgv_bills.Rows.Clear();
        }

        private void MetroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (metroTabControl.SelectedTab == metroTabControl.TabPages["mtp_bills"])
            //{
            //    PopulateVendor(Database);
            //}
            //else if (metroTabControl.SelectedTab == metroTabControl.TabPages["mtp_voucher"])
            //{
            //    ClearTables();
            //}
        }
    }
}

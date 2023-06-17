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
    public partial class Uc_Vouchers : UserControl
    {
        public string Database { set; get; }

        public Uc_Vouchers()
        {
            InitializeComponent();
        }

        private void Uc_Vouchers_Load(object sender, EventArgs e)
        {
            PopulateVoucherHistoryDataSet(Database);
        }

        private async void PopulateVoucherHistoryDataSet(string database)
        {
            Voucher_Class vc = new Voucher_Class
            {
                Database = database
            };
            dgv_voucher_history.DataSource = null;
            DataSet results = await vc.ShowVOucherHistoryDataSet();
            dgv_voucher_history.DataSource = results.Tables[0];

            ChangeHistoryVoucher();
        }

        private void ChangeHistoryVoucher()
        {
            dgv_voucher_history.Columns[0].Visible = false;
            dgv_voucher_history.Columns[1].HeaderText = "TIME CREATED";
            dgv_voucher_history.Columns[2].HeaderText = "BRANCH";
            dgv_voucher_history.Columns[3].HeaderText = "PAYEEE";
            dgv_voucher_history.Columns[4].HeaderText = "VOUCHER NUMBER";
            dgv_voucher_history.Columns[5].HeaderText = "MEMO";
            dgv_voucher_history.Columns[6].HeaderText = "AMOUNT";
            dgv_voucher_history.Columns[7].HeaderText = "CHECK NUMBER";
            dgv_voucher_history.Columns[8].HeaderText = "USER";
        }

        private void Dgv_voucher_history_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {         
            try
            {
                if (dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && 
                    (dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 2 || dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 3 ||
                    dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 4 || dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 5 ||
                    dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 6 || dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 7 ||
                    dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 8))
                {
                    string payee = dgv_voucher_history.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string cvNumber = dgv_voucher_history.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string amount = dgv_voucher_history.Rows[e.RowIndex].Cells[6].Value.ToString();

                    using (Check_writer_Form cwf = new Check_writer_Form())
                    {
                        cwf.Database = Database;
                        cwf.CVNumber = cvNumber;
                        cwf.Payee = payee;
                        cwf.Amount = Convert.ToDouble(amount);
                        cwf.ShowDialog();
                    }
                }       
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct data..");
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            PopulateVoucherHistoryDataSet(Database);
        }
    }
}

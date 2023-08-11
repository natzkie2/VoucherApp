using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Class;
using VoucherV1.Object;

namespace VoucherV1.Forms.Bank
{
    public partial class Select_bank_Form : Form
    {
        Voucher_details_Form vdf = new Voucher_details_Form();

        public string Database { set; get; }

        public string Branch_Code { set; get; }

        public double Voucher_Amount { set; get; }

        public double Balance { set; get; }

        public string Bank_ID { set; get; }

        public string Method { set; get; }

        public Select_bank_Form(Voucher_details_Form val)
        {
            InitializeComponent();
            this.vdf = val;
        }

        private void Select_bank_Form_Load(object sender, EventArgs e)
        {
            PopulateBank();
            lbl_voucher_amount.Text = "₱" + String.Format("{0:0,0.00}", Voucher_Amount);
            tb_amount.Text = String.Format("{0:0,0.00}", Voucher_Amount);
        }

        private void PopulateBank()
        {
            Bank_Class bc = new Bank_Class
            {
                Database = Database
            };
            bc.BankDataSetByBranchCode(Branch_Code);
            cmb_bank.DataSource = null;
            cmb_bank.DataSource = bc.bankFill;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Btn_bank_Click(object sender, EventArgs e)
        {
            DateTime dt = mtb_date.Value;
            string date = dt.ToString("MM/dd/yyyy");
            string bank = cmb_bank.Text.ToString();
            string number = tb_check_number.Text.ToString();

            Bank_Class bc = new Bank_Class
            {
                Database = Database
            };
            bc.GetBankDataByValue(bank);

            string bankDetails;
            if (String.IsNullOrWhiteSpace(bc.AccountNumber))
            {
                bankDetails = bank;
            }
            else
            {
                bankDetails = bank + " - " + bc.AccountNumber;
            }


            if (bank.Equals("Select Bank..."))
            {
                MessageBox.Show("Please select a bank.","Select Bank",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (String.IsNullOrWhiteSpace(number))
            {
                MessageBox.Show("Please enter check number.", "Select Bank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double amount = Convert.ToDouble(tb_amount.Text.ToString());
                if(GetSumOfBanksAmount() < Voucher_Amount)
                {
                    if (dgv_banks.Rows.Count == 0)
                    {
                        dgv_banks.Rows.Add(bc.AccountNumber, bankDetails, number, date, amount);
                    }
                    else
                    {
                        Int32 count = Convert.ToInt32(dgv_banks.Rows[dgv_banks.RowCount - 1].Cells[0].Value.ToString());

                        dgv_banks.Rows.Add(bc.AccountNumber, bankDetails, number, date, amount);
                    }
                    ClearData();
                    lbl_total.Text = "₱" + String.Format("{0:0,0.00}", GetSumOfBanksAmount());
                }
                else
                {
                    if (GetSumOfBanksAmount() + amount > Voucher_Amount)
                    {
                        MessageBox.Show("Check total and voucher total are already equal. Please verify the amount entered.", "Select Bank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void ClearData()
        {
            PopulateBank();
            tb_check_number.Clear();
        }

        private void ClearContainerTable()
        {
            foreach (DataGridViewRow rows in dgv_banks.Rows)
            {
                if (rows.Cells[0].Value.ToString().Equals(Bank_ID))
                {

                    int count = 0;
                    int rowIndex = dgv_banks.CurrentCell.RowIndex;
                    dgv_banks.Rows.RemoveAt(rowIndex);

                    for (int i = 0; i < dgv_banks.Rows.Count; i++)
                    {
                        count++;
                    }

                    if (count > 0)
                    {
                        //lbl_lubes_total.Text = String.Format("{0:0,0.00}", GetSumValueOfCashLubes());
                    }
                    else if (count == 0)
                    {
                        //ClearSalesLubesTransactions();
                    }
                }
            }
        }

        public double GetSumOfBanksAmount()
        {
            double amount = 0;

            try
            {
                for (int i = 0; i < dgv_banks.Rows.Count; i++)
                {
                    if (DBNull.Value.Equals(dgv_banks.Rows[i].Cells[1].Value) || dgv_banks.Rows[i].Cells[1].Value.ToString() == "")
                    {
                        amount += 0;
                    }
                    else if (Convert.ToDouble(dgv_banks.Rows[i].Cells[4].Value) > 0)
                    {
                        amount += Convert.ToDouble(dgv_banks.Rows[i].Cells[4].Value);
                    }
                }

            }
            catch (Exception)
            {
                amount = 0;
            }

            return amount;
        }

        private void Dgv_banks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_banks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && dgv_banks.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 4)
                {
                    string id = dgv_banks.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string bank = dgv_banks.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string number = dgv_banks.Rows[e.RowIndex].Cells[2].Value.ToString();
                    double amount = Convert.ToDouble(dgv_banks.Rows[e.RowIndex].Cells[4].Value.ToString());


                    foreach (DataGridViewRow rows in dgv_banks.Rows)
                    {
                        if (rows.Cells[0].Value.ToString().Equals(id))
                        {
                            rows.Cells[4].Value = String.Format("{0:0,0.00}", amount);
                        }
                    }

                    double balance = Voucher_Amount - GetSumOfBanksAmount();

                    lbl_total.Text = "₱" + String.Format("{0:0,0.00}", GetSumOfBanksAmount());
                    tb_amount.Text = String.Format("{0:0,0.00}", balance);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct data..");
            }
        }

        private void Dgv_banks_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_banks.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress += new KeyPressEventHandler(ColumnBank_KeyPress);
                }
            }
        }

        private void ColumnBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex("^[^0-9-\b.,%]+$");
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            ClearContainerTable();
        }

        private void Dgv_banks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_banks.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_banks.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_banks.Rows[selectedrowindex];
                string num = Convert.ToString(selectedRow.Cells[0].Value);

                Bank_ID = num;
                btn_clear.Enabled = true;
            }
        }

        private int CheckSelectedRow()
        {
            int check = 0;

            try
            {
                foreach (DataGridViewRow rows in dgv_banks.Rows)
                {
                    if (Convert.ToString(rows.Cells[dgv_banks.Columns[1].Index].Value) != "")
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

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Method))
            {
                MessageBox.Show("Please select payment method.", "Select Bank", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (Method.Equals("Cash"))
                {
                    vdf.rb_cash.Checked = true;

                    if (CheckSelectedRow() >= 1)
                    {
                        List<BankListDetails> bld = new List<BankListDetails>();
                        foreach (DataGridViewRow item in dgv_banks.Rows)
                        {
                            if (Convert.ToDouble(item.Cells[4].Value.ToString()) > 0)
                            {
                                bld.Add(new BankListDetails
                                {
                                    AccountNumber = item.Cells[0].Value.ToString(),
                                    Bank = item.Cells[1].Value.ToString(),
                                    RefNumber = item.Cells[2].Value.ToString(),
                                    Date = item.Cells[3].Value == null ? "" : item.Cells[3].Value.ToString(),
                                    Amount = item.Cells[4].Value.ToString()
                                });
                            }
                        }

                        InsertBankDataToGridView(bld);
                    }
                }
                else if (Method.Equals("Check"))
                {
                    vdf.rb_check.Checked = true;

                    if (CheckSelectedRow() >= 1)
                    {
                        List<BankListDetails> bld = new List<BankListDetails>();
                        foreach (DataGridViewRow item in dgv_banks.Rows)
                        {
                            if (Convert.ToDouble(item.Cells[4].Value.ToString()) > 0)
                            {
                                bld.Add(new BankListDetails
                                {
                                    AccountNumber = item.Cells[0].Value.ToString(),
                                    Bank = item.Cells[1].Value.ToString(),
                                    RefNumber = item.Cells[2].Value.ToString(),
                                    Date = item.Cells[3].Value == null ? "" : item.Cells[3].Value.ToString(),
                                    Amount = item.Cells[4].Value.ToString()
                                });
                            }
                        }

                        InsertBankDataToGridView(bld);
                    }
                }

                else if (Method.Equals("Online"))
                {
                    vdf.rb_online.Checked = true;

                    if (CheckSelectedRow() >= 1)
                    {
                        List<BankListDetails> bld = new List<BankListDetails>();
                        foreach (DataGridViewRow item in dgv_banks.Rows)
                        {
                            if (Convert.ToDouble(item.Cells[4].Value.ToString()) > 0)
                            {
                                bld.Add(new BankListDetails
                                {
                                    AccountNumber = item.Cells[0].Value.ToString(),
                                    Bank = item.Cells[1].Value.ToString(),
                                    RefNumber = item.Cells[2].Value.ToString(),
                                    Date = item.Cells[3].Value == null ? "" : item.Cells[3].Value.ToString(),
                                    Amount = item.Cells[4].Value.ToString()
                                });
                            }
                        }

                        InsertBankDataToGridView(bld);
                    }
                }
            }          
        }

        private void InsertBankDataToGridView(List<BankListDetails> banks)
        {
            if (banks != null)
            {
                foreach (BankListDetails datas in banks)
                {
                    int data = vdf.dgv_banks.Rows.Add();
                    int countRow = vdf.dgv_banks.Rows.Count;

                    if (countRow == 0)
                    {
                        vdf.dgv_banks.Rows[data].Cells[0].Value = datas.AccountNumber;
                        vdf.dgv_banks.Rows[data].Cells[1].Value = datas.Bank;
                        vdf.dgv_banks.Rows[data].Cells[2].Value = datas.RefNumber;
                        vdf.dgv_banks.Rows[data].Cells[3].Value = datas.Date;
                        vdf.dgv_banks.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                    }
                    else if (countRow > 0)
                    {
                        vdf.dgv_banks.Rows[data].Cells[0].Value = datas.AccountNumber;
                        vdf.dgv_banks.Rows[data].Cells[1].Value = datas.Bank;
                        vdf.dgv_banks.Rows[data].Cells[2].Value = datas.RefNumber;
                        vdf.dgv_banks.Rows[data].Cells[3].Value = datas.Date;
                        vdf.dgv_banks.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                    }
                }
            }
        }

        private void Rb_cash_CheckedChanged(object sender, EventArgs e)
        {
            Method = "Cash";
        }

        private void Rb_check_CheckedChanged(object sender, EventArgs e)
        {
            Method = "Check";
        }

        private void Rb_online_CheckedChanged(object sender, EventArgs e)
        {
            Method = "Online";
        }

        private void Tb_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}

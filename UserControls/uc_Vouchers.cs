using OfficeOpenXml;
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
using VoucherV1.Class;
using VoucherV1.Forms;
using VoucherV1.Forms.Bank;
using VoucherV1.Forms.BIR;
using VoucherV1.Forms.ExcelFileWriter;
using VoucherV1.Object;
using VoucherV1.Properties;

namespace VoucherV1.UserControls
{
    public partial class Uc_Vouchers : UserControl
    {
        public string Database { set; get; }

        public string RefNumber { set; get; }

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


            DataSet results = await vc.ShowVoucherHistoryDataSet();        
            DataTable validation = results.Tables[0];
            dgv_voucher_history.Rows.Clear();

            foreach (DataRow row in validation.Rows)
            {
                string id = row["ID"].ToString();
                DateTime timeCreated = Convert.ToDateTime(row["TimeCreated"].ToString());
                string branch = row["Branch"].ToString();
                string accountNumber = row["AccountNumber"].ToString();
                string payee = row["Payee"].ToString();
                string refNumber = row["RefNumber"].ToString();
                string memo = row["Memo"].ToString();
                double amount = Convert.ToDouble(row["Amount"].ToString());
                string checkNumber = row["CheckNumber"].ToString();
                string checkName = row["CheckName"].ToString();
                int isVoid = Convert.ToInt32(row["Void"].ToString());
                int exported = Convert.ToInt32(row["Exported"].ToString());
                int isPayeeAccountOnly = Convert.ToInt32(row["IsPayeeAccountOnly"].ToString());
                string user = row["User"].ToString();

                string stringDate = timeCreated.ToString("M/dd/yyyy");
           
                string checkDates;
                if (String.IsNullOrWhiteSpace(row["CheckDate"].ToString()))
                {
                   checkDates = "";
                }
                else
                {
                    DateTime checkDate = Convert.ToDateTime(row["CheckDate"].ToString());
                    checkDates = checkDate.ToString("MM/dd/yyyy");
                }
                dgv_voucher_history.Rows.Add(id, stringDate, branch, accountNumber, payee, refNumber, memo, amount, checkNumber, checkName, checkDates, isVoid, exported, isPayeeAccountOnly, user);
            }
          
        }

        private async void PopulateVoucherHistoryByDateDataSet(string database, string fromDate, string toDate)
        {
            Voucher_Class vc = new Voucher_Class
            {
                Database = database
            };


            DataSet results = await vc.ShowVoucherHistoryBySpecificDateDataSet(fromDate, toDate);
            DataTable validation = results.Tables[0];
            dgv_voucher_history.Rows.Clear();

            foreach (DataRow row in validation.Rows)
            {
                string id = row["ID"].ToString();
                DateTime timeCreated = Convert.ToDateTime(row["TimeCreated"].ToString());
                string branch = row["Branch"].ToString();
                string accountNumber = row["AccountNumber"].ToString();
                string payee = row["Payee"].ToString();
                string refNumber = row["RefNumber"].ToString();
                string memo = row["Memo"].ToString();
                double amount = Convert.ToDouble(row["Amount"].ToString());
                string checkNumber = row["CheckNumber"].ToString();
                string checkName = row["CheckName"].ToString();

                int isVoid = Convert.ToInt32(row["Void"].ToString());
                int exported = Convert.ToInt32(row["Exported"].ToString());
                int isPayeeAccountOnly = Convert.ToInt32(row["IsPayeeAccountOnly"].ToString());
                string user = row["User"].ToString();

                string stringDate = timeCreated.ToString("M/dd/yyyy");

                string checkDates;
                if (String.IsNullOrWhiteSpace(row["CheckDate"].ToString()))
                {
                    checkDates = "";
                }
                else
                {
                    DateTime checkDate = Convert.ToDateTime(row["CheckDate"].ToString());
                    checkDates = checkDate.ToString("MM/dd/yyyy");
                }
                dgv_voucher_history.Rows.Add(id, stringDate, branch, accountNumber, payee, refNumber, memo, amount, checkNumber, checkName, checkDates, isVoid, exported, isPayeeAccountOnly, user);
            }
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            List<XLSFileWriter> vld = new List<XLSFileWriter>();
            foreach (DataGridViewRow item in dgv_voucher_history.Rows)
            {
                if (!(item.Cells[11].Value.ToString().Equals("1") || item.Cells[12].Value.ToString().Equals("1")))
                {
                    vld.Add(new XLSFileWriter
                    {
                        IsSelfService = "1",
                        CheckAmount = Convert.ToDouble(item.Cells[7].Value.ToString()),
                        SourceAccount = item.Cells[3].Value.ToString(),
                        IsPayeeAccountOnly = item.Cells[13].Value.ToString(),
                        CheckDate = String.IsNullOrWhiteSpace(item.Cells[10].Value.ToString()) ? "" : item.Cells[10].Value.ToString(),
                        PayeeName = item.Cells[4].Value.ToString(),
                        Particulars = item.Cells[6].Value.ToString(),
                        Remarks = item.Cells[5].Value.ToString()
                    });
                }            
            }

            using (Excel_filewriter_export_Form vdf = new Excel_filewriter_export_Form(vld))
            {
                if (vdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dtp_from.Value = DateTime.Now;
                    dtp_to.Value = DateTime.Now;

                    PopulateVoucherHistoryDataSet(Database);
                }
            }
        }

        private void Dgv_voucher_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cvNumber = dgv_voucher_history.Rows[e.RowIndex].Cells[5].Value.ToString();
            RefNumber = cvNumber;
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
                    string payee = dgv_voucher_history.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string cvNumber = dgv_voucher_history.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string amount = dgv_voucher_history.Rows[e.RowIndex].Cells[7].Value.ToString();                   

                    using (Selection_dialog_Form sdf = new Selection_dialog_Form())
                    {
                        if (sdf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (sdf.Option.Equals("CW"))
                            {
                                using (Check_writer_Form cwf = new Check_writer_Form())
                                {
                                    cwf.Database = Database;
                                    cwf.CVNumber = cvNumber;
                                    cwf.Payee = payee;
                                    cwf.Amount = Convert.ToDouble(amount);
                                    cwf.ShowDialog();
                                }
                            }
                            else if (sdf.Option.Equals("2307"))
                            {
                                using (_2307_dialog_Form cwf = new _2307_dialog_Form())
                                {
                                    cwf.Selection = "2307";
                                    cwf.VoucherNumber = cvNumber;
                                    cwf.Payee = payee;
                                    cwf.Amount = Convert.ToDouble(amount);
                                    cwf.ShowDialog();
                                }
                            }
                            else if (sdf.Option.Equals("2306"))
                            {
                                using (_2307_dialog_Form cwf = new _2307_dialog_Form())
                                {
                                    cwf.Selection = "2306";
                                    cwf.VoucherNumber = cvNumber;
                                    cwf.Payee = payee;
                                    cwf.Amount = Convert.ToDouble(amount);
                                    cwf.ShowDialog();
                                }
                            }
                            else if (sdf.Option.Equals("2316"))
                            {

                            }
                            else if (String.IsNullOrWhiteSpace(sdf.Option))
                            {
                                MessageBox.Show("Please select options.","Voucher System",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                else if (dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ColumnIndex == 13)
                {
                    dgv_voucher_history.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
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
      

        private void Dgv_voucher_history_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_voucher_history.CurrentCell.ColumnIndex == 13)
            {
                // Get the editing control (in this case, a TextBox) and add an event handler for text changed
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.TextChanged += TextBox_TextChanged;
                    textBox.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Check if the entered value is a valid number (integer)
            if (int.TryParse(((TextBox)sender).Text, out int number))
            {
                // Check if the number is even (modify the condition as per your requirement)
                if (number > 1)
                {
                    // Display an error message or prevent the cell from accepting the input
                    MessageBox.Show("Please enter only 1 or 0.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dgv_voucher_history.CancelEdit(); // This cancels the cell editing
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a digit (0-9) or a backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancel the key press event to prevent entering non-numeric values
                e.Handled = true;
            }
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            DateTime fDate = dtp_from.Value;
            DateTime tDate = dtp_to.Value;

            string fromDate = fDate.ToString("yyyy-MM-dd");
            string toDate = tDate.ToString("yyyy-MM-dd");

            PopulateVoucherHistoryByDateDataSet(Database, fromDate, toDate);
        }

        private void Btn_void_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to void this voucher?", "Voucher System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Voucher_Class vc = new Voucher_Class
                {
                    Database = Database
                };

                if (vc.UpdateVoucherIsVoid(RefNumber))
                {
                    MessageBox.Show("Voucher successfully void.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            dtp_from.Value = DateTime.Now;
            dtp_to.Value = DateTime.Now;

            PopulateVoucherHistoryDataSet(Database);
        }
    }
}

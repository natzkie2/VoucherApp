using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherV1.Class;
using VoucherV1.Forms.Bank;
using VoucherV1.Object;
using VoucherV1.Properties;

namespace VoucherV1.Forms
{
    public partial class Voucher_details_Form : Form
    {
        public string Database { set; get; }

        public string Vendor_ID { set; get; }

        public string Branch_Code { set; get; }

        public string Method { set; get; }

        public double Tax { set; get; }

        public List<VoucherListDetails> Items { get; set; }

        public List<BankListDetails> Banks { get; set; }

        public Voucher_details_Form()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void Voucher_details_Form_Load(object sender, EventArgs e)
        {
            tb_date.Text = DateTime.Now.ToString("M/d/yyyy");
            rb_cash.Checked = true;

            
            tb_prepared_by.Text = User_login_Form.First_Name + " " + User_login_Form.Last_Name;
            tb_checked_by.Text = User_login_Form.Checker;
            tb_approved_by.Text = User_login_Form.Checker;

            PopulateVendor(Vendor_ID);

            PopulateBranch();
            PopulateCVNumber();
            InsertVoucherDataToGridView(Items);
        }

        private void PopulateCVNumber()
        {
            DbUtils_Class dbc = new DbUtils_Class
            {
                Database = Database
            };

            dbc.GetVoucherID();
            Int32 Inc_ID = dbc.ID + 1;
            tb_cv_number.Text = "CV-" + DateTime.Now.ToString("MMddyy") + "-" + User_login_Form.User_ID + "-0000-" + Inc_ID;
        }

        private void InsertVoucherDataToGridView(List<VoucherListDetails> items)
        {
            if (items != null)
            {
                foreach (VoucherListDetails datas in items)
                {
                    int data = dgv_bills.Rows.Add();
                    int countRow = dgv_bills.Rows.Count;

                    if (countRow == 0)
                    {
                        dgv_bills.Rows[data].Cells[0].Value = 1;
                        dgv_bills.Rows[data].Cells[1].Value = datas.RefNumber;
                        dgv_bills.Rows[data].Cells[2].Value = datas.DueDate;
                        dgv_bills.Rows[data].Cells[3].Value = datas.Memo;
                        dgv_bills.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                    }
                    else if (countRow > 0)
                    {
                        dgv_bills.Rows[data].Cells[0].Value = countRow += 1;
                        dgv_bills.Rows[data].Cells[1].Value = datas.RefNumber;
                        dgv_bills.Rows[data].Cells[2].Value = datas.DueDate;
                        dgv_bills.Rows[data].Cells[3].Value = datas.Memo;
                        dgv_bills.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                    }                 
                }
            }

            lbl_total.Text = "₱" + String.Format("{0:0,0.00}", GetSumOfVoucherAmount());
        }

     

        private double GetSumOfVoucherAmount()
        {
            double amount = 0;

            try
            {
                for (int i = 0; i < dgv_bills.Rows.Count; i++)
                {
                    if (DBNull.Value.Equals(dgv_bills.Rows[i].Cells[0].Value) || dgv_bills.Rows[i].Cells[0].Value.ToString() == "")
                    {
                        amount += 0;
                    }
                    else if (Convert.ToDouble(dgv_bills.Rows[i].Cells[4].Value) > 0)
                    {
                        amount += Convert.ToDouble(dgv_bills.Rows[i].Cells[4].Value);
                    }
                }

            }
            catch (Exception)
            {
                amount = 0;
            }

            return amount;
        }

        private double GetSumOfBankAmount()
        {
            double amount = 0;

            try
            {
                for (int i = 0; i < dgv_banks.Rows.Count; i++)
                {
                    if (DBNull.Value.Equals(dgv_banks.Rows[i].Cells[0].Value) || dgv_bills.Rows[i].Cells[0].Value.ToString() == "")
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

        private void PopulateVendor(string id)
        {
            Vendor_Class vc = new Vendor_Class
            {
                Database = Database
            };
            if (vc.FetchVendorDetail(id) == true)
            {
                tb_payee.Text = vc.Name;
                tb_address.Text = vc.Address;
                tb_tin.Text = vc.TIN;
            }
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

        private void Cmb_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch_Class bc = new Branch_Class
            {
                Database = Database
            };

            DbUtils_Class dbc = new DbUtils_Class
            {
                Database = Database
            };

            dbc.GetVoucherID();
            Int32 Inc_ID = dbc.ID + 1;

            string value = cmb_branch.Text.ToString();
            bc.GetBranchDataByName(value);


            if (value.Equals("Select Branch..."))
            {
                tb_cv_number.Text = "CV-" + DateTime.Now.ToString("MMddyy") + "-" + User_login_Form.User_ID + "-0000-" + Inc_ID;
            }
            else
            {
                tb_cv_number.Text = "CV-" + DateTime.Now.ToString("MMddyy") + "-" + User_login_Form.User_ID + "-" + bc.Branch_Code + "-" + Inc_ID;
                Branch_Code = bc.Branch_Code;
            }
          
        }

        private void Btn_bank_Click(object sender, EventArgs e)
        {
            string branch = cmb_branch.Text.ToString();

            Bank_Class bc = new Bank_Class
            {
                Database = Database
            };

            Branch_Class bhc = new Branch_Class
            {
                Database = Database
            };

            
            if (branch.Equals("Select Branch..."))
            {
                MessageBox.Show("Please select branch...", "Voucher Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {          
                using (Select_bank_Form sbf = new Select_bank_Form(this))
                {
                    int count = 0;
                    double bank_amount = 0;
                    foreach (DataGridViewRow banks in dgv_banks.Rows)
                    {
                        bc.GetBankDataByValue(banks.Cells[1].Value.ToString());

                        if (bhc.CheckBranchIsExist(bc.Branch_Code) == true)
                        {
                            count += 1;
                        }
                    }
                    if (count > 0)
                    {
                        List<BankListDetails> bld = new List<BankListDetails>();
                        foreach (DataGridViewRow item in dgv_banks.Rows)
                        {
                            if (Convert.ToDouble(item.Cells[4].Value.ToString()) > 0)
                            {
                                bld.Add(new BankListDetails
                                {
                                    Bank = item.Cells[1].Value.ToString(),
                                    RefNumber = item.Cells[2].Value.ToString(),
                                    Date = item.Cells[3].Value.ToString(),
                                    Amount = item.Cells[4].Value.ToString()
                                });
                            }
                        }

                        foreach (BankListDetails datas in bld)
                        {
                            int data = sbf.dgv_banks.Rows.Add();
                            int countRow = sbf.dgv_banks.Rows.Count;

                            bc.GetBankDataByValue(datas.Bank);

                            if (countRow == 0)
                            {
                                sbf.dgv_banks.Rows[data].Cells[0].Value = bc.AccountNumber;
                                sbf.dgv_banks.Rows[data].Cells[1].Value = datas.Bank;
                                sbf.dgv_banks.Rows[data].Cells[2].Value = datas.RefNumber;
                                sbf.dgv_banks.Rows[data].Cells[3].Value = datas.Date;
                                sbf.dgv_banks.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                                bank_amount += Convert.ToDouble(datas.Amount);
                            }
                            else if (countRow > 0)
                            {
                                sbf.dgv_banks.Rows[data].Cells[0].Value = bc.AccountNumber;
                                sbf.dgv_banks.Rows[data].Cells[1].Value = datas.Bank;
                                sbf.dgv_banks.Rows[data].Cells[2].Value = datas.RefNumber;
                                sbf.dgv_banks.Rows[data].Cells[3].Value = datas.Date;
                                sbf.dgv_banks.Rows[data].Cells[4].Value = Convert.ToDouble(datas.Amount);
                                bank_amount += Convert.ToDouble(datas.Amount);
                            }
                        }

                        sbf.Database = Database;
                        sbf.Voucher_Amount = GetSumOfVoucherAmount() - Tax;
                        sbf.Balance = (GetSumOfVoucherAmount() - Tax) - GetSumOfBankAmount();
                        sbf.Branch_Code = Branch_Code;
                        sbf.lbl_total.Text = "₱" + String.Format("{0:0,0.00}", bank_amount);
                        if (sbf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                        }
                    }
                    else if (count == 0)
                    {
                        sbf.Database = Database;
                        sbf.Voucher_Amount = GetSumOfVoucherAmount() - Tax;
                        sbf.Balance = (GetSumOfVoucherAmount() - Tax) - GetSumOfBankAmount();
                        sbf.Branch_Code = Branch_Code;
                        if (sbf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                        }
                    }                
               }
            }
        }

        private void Voucher_details_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                voucher_path_Form vpf = new voucher_path_Form();
                vpf.ShowDialog();
            }
        }

        private void Btn_save_print_Click(object sender, EventArgs e)
        {
            PrintVoucher();

            //foreach (DataGridViewRow rows in dgv_banks.Rows)
            //{
            //    MessageBox.Show("" + NumberToWords(Convert.ToDouble(rows.Cells[4].Value.ToString())));
            //}

        }

        //public static string NumberToWords(double doubleNumber)
        //{

        //    var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
        //    var beforeFloatingPointWord = NumberToWords(beforeFloatingPoint);
        //    var afterFloatingPointWord = (int)((doubleNumber - beforeFloatingPoint) * 100) + "/100";

        //    var value = "";

        //    if (String.IsNullOrWhiteSpace(SmallNumberToWord((int)((doubleNumber - beforeFloatingPoint) * 100), string.Empty)))
        //    {
        //        value = beforeFloatingPointWord + " Only";
        //    }
        //    else
        //    {
        //        value = beforeFloatingPointWord + " & " + afterFloatingPointWord + " Only";
        //    }
        //    return value;
        //}


        //private static string NumberToWords(int number)
        //{
        //    if (number == 0) return "Zero";

        //    if (number < 0) return "minus" + NumberToWords(Math.Abs(number));

        //    string words = "";

        //    if ((number / 1000000) > 0)
        //    {
        //        words += NumberToWords(number / 1000000) + "Million ";
        //        number %= 1000000;
        //    }

        //    if ((number / 1000) > 0)
        //    {
        //        words += NumberToWords(number / 1000) + "Thousand ";
        //        number %= 1000;
        //    }

        //    if ((number / 100) > 0)
        //    {
        //        words += NumberToWords(number / 100) + "Hundred ";
        //        number %= 100;
        //    }

        //    words = SmallNumberToWord(number, words);
        //    return words;

        //}

        //private static string SmallNumberToWord(int number, string words)
        //{
        //    if (number <= 0) return words;
        //    if (words != "") words += "";



        //    var unitsMap = new[] { "Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ", "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
        //    var tensMap = new[] { "Zero ", "Ten ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
        //    if (number < 20) words += unitsMap[number];
        //    else
        //    {
        //        words += tensMap[number / 10];
        //        if ((number % 10) > 0) words += " " + unitsMap[number % 10];
        //    }

        //    return words;
        //}


        private void PrintVoucher()
        {
            string AccountNumber = "";
            ReportDataSource rdsVoucher = new ReportDataSource();
            ReportDataSource rdsBank = new ReportDataSource();

            List<VoucherListDetails> voucher = new List<VoucherListDetails>();
            List<BankListDetails> banks = new List<BankListDetails>();

            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
               new ReportParameter("rp_payee", tb_payee.Text.ToString()),
               new ReportParameter("rp_address", tb_address.Text.ToString()),
               new ReportParameter("rp_tin", tb_tin.Text.ToString()),
               new ReportParameter("rp_cvnumber", tb_cv_number.Text.ToString()),
               new ReportParameter("rp_date", tb_date.Text.ToString()),
               new ReportParameter("rp_prepared_by", tb_prepared_by.Text.ToString()),
               new ReportParameter("rp_checked_by", tb_checked_by.Text.ToString()),
               new ReportParameter("rp_approved_by", tb_approved_by.Text.ToString()),
               new ReportParameter("rp_received_by", tb_received_by.Text.ToString()),
               new ReportParameter("rp_payment_method", Method),
               new ReportParameter("rp_total", lbl_total.Text.ToString()),
               new ReportParameter("rp_memo", tb_memo.Text.ToString()),
               new ReportParameter("rp_tax", String.Format("{0:0,0.00}", Tax)),
               new ReportParameter("rp_class", cmb_branch.Text.ToString())
            };

            for (int i = 0; i < dgv_bills.Rows.Count; i++)
            {
                string refNumber = dgv_bills.Rows[i].Cells[1].Value.ToString();
                string date = dgv_bills.Rows[i].Cells[2].Value.ToString();
                string memo = dgv_bills.Rows[i].Cells[3].Value.ToString();

                double amount;
                if (String.IsNullOrEmpty(dgv_bills.Rows[i].Cells[4].Value.ToString()))
                {
                    amount = 0;
                }
                else
                {
                    amount = Double.Parse(dgv_bills.Rows[i].Cells[4].Value.ToString());
                }

                voucher.Add(new VoucherListDetails
                {
                    RefNumber = refNumber,
                    DueDate = date,
                    Memo = memo,
                    Amount = String.Format("{0:0,0.00}", amount),
                }) ;
            }



            for (int i = 0; i < dgv_banks.Rows.Count; i++)
            {
                string accountNumber = dgv_banks.Rows[i].Cells[0].Value.ToString();
                string bank = dgv_banks.Rows[i].Cells[1].Value.ToString();
                string refNumber = dgv_banks.Rows[i].Cells[2].Value.ToString();
                string date = dgv_banks.Rows[i].Cells[3].Value.ToString();

                AccountNumber = accountNumber;

                double amount;
                if (String.IsNullOrEmpty(dgv_banks.Rows[i].Cells[4].Value.ToString()))
                {
                    amount = 0;
                }
                else
                {
                    amount = Double.Parse(dgv_banks.Rows[i].Cells[4].Value.ToString());
                }

                banks.Add(new BankListDetails
                {
                    Bank = bank,
                    RefNumber = refNumber,
                    Date = date,
                    Amount = String.Format("{0:0,0.00}", amount),
                });
            }

            rdsVoucher.Name = "VoucherDetailsDataSet";
            rdsVoucher.Value = voucher;

            rdsBank.Name = "BankDetailsDataSet";
            rdsBank.Value = banks;


            Print_voucher_Form pvf = new Print_voucher_Form();
            pvf.reportViewer.LocalReport.SetParameters(reportParameters);
            pvf.reportViewer.LocalReport.DataSources.Add(rdsVoucher);
            pvf.reportViewer.LocalReport.DataSources.Add(rdsBank);

            pvf.reportViewer.ProcessingMode = ProcessingMode.Local;

            pvf.reportViewer.LocalReport.ReportEmbeddedResource = "VoucherV1.Print.Voucher.Voucher.rdlc";
            pvf.reportViewer.RefreshReport();


            if (PrintToPDF(pvf.reportViewer.LocalReport, tb_cv_number.Text.ToString()) == true)
            {
                Voucher_Class vc = new Voucher_Class
                {
                    Database = Database
                };

                DateTime dt = DateTime.Now;

                if (vc.InsertVoucherHistory(dt.ToString("yyyy-MM-dd hh:mm:ss"), cmb_branch.Text.ToString(), AccountNumber, tb_payee.Text.ToString(), 
                    tb_cv_number.Text.ToString(), tb_memo.Text.ToString(), Convert.ToString(GetSumOfVoucherAmount() - Tax), User_login_Form.First_Name + " " + User_login_Form.Last_Name) == true)
                {
                    PopulateCVNumber();
                    this.Hide();
                    this.Close();
                }
            }
        }


        private Boolean PrintToPDF(LocalReport report, string cv_number)
        {
            string deviceInfo =
                "<DeviceInfo>" +
                "  <OutputFormat>EMF</OutputFormat>" +
                "  <PageWidth>8.5in</PageWidth>" +
                "  <PageHeight>11in</PageHeight>" +
                "  <MarginTop>0.25in</MarginTop>" +
                "  <MarginLeft>0.5in</MarginLeft>" +
                "  <MarginRight>0.5in</MarginRight>" +
                "  <MarginBottom>0.25in</MarginBottom>" +
                "</DeviceInfo>";
            string[] streamIds;
            Warning[] warnings;

            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extenstion = string.Empty;

            byte[] bytes = report.Render(
            "PDF", deviceInfo, out mimeType, out encoding, out extenstion,
            out streamIds, out warnings);

            string path = Settings.Default["Path"].ToString();
            string filePath = @path;

            File.WriteAllBytes(filePath + cv_number +".pdf", bytes);
            System.Diagnostics.Process.Start(filePath);

            return true;
        }



        private void Rb_cash_CheckedChanged(object sender, EventArgs e)
        {
            Method = "CASH";
        }

        private void Rb_check_CheckedChanged(object sender, EventArgs e)
        {
            Method = "CHECK";
        }

        private void Rb_online_CheckedChanged(object sender, EventArgs e)
        {
            Method = "ONLINE/TRANSFER";
        }

        private void Tb_tax_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Tb_tax_TextChanged(object sender, EventArgs e)
        {           
            double tax;

            if (String.IsNullOrWhiteSpace(tb_tax.Text.ToString()))
            {
                tax = 0;
            }
            else
            {
                tax = Convert.ToDouble(tb_tax.Text.ToString());
            }

            lbl_total.Refresh();

            Tax = tax;

            double total = GetSumOfVoucherAmount() - tax;

            lbl_total.Text = "₱" + String.Format("{0:0,0.00}", total);
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}

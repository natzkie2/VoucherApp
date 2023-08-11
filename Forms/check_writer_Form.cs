using Microsoft.Reporting.WinForms;
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
using VoucherV1.Properties;

namespace VoucherV1.Forms
{
    public partial class Check_writer_Form : Form
    {
        public string Database { set; get; }

        public string CVNumber { set; get; }

        public string Payee { set; get; }

        public double Amount { set; get; }

        public Check_writer_Form()
        {
            InitializeComponent();
        }

        private void Check_writer_Form_Load(object sender, EventArgs e)
        {
            PopulateBank();
            tb_payee.Text = Payee;
            tb_amount.Text = String.Format("{0:0,0.00}", Amount);
        }

        private void PopulateBank()
        {
            Bank_Class bc = new Bank_Class
            {
                Database = Database
            };
            bc.BankDataSet();
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
            Voucher_Class vc = new Voucher_Class
            {
                Database = Database
            };

            string check_number = tb_checkNumber.Text.ToString();

            if (String.IsNullOrWhiteSpace(check_number))
            {
                MessageBox.Show("Enter check number...","Check Writer",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (cmb_bank.Text.ToString().Equals("Select Bank..."))
            {
                MessageBox.Show("Select a bank...", "Check Writer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime checkDate = mtb_date.Value;
                string stringDate = checkDate.ToString("yyyy-MM-dd");


                if (tb_payee.Text.ToString().Equals(Payee))
                {
                    if (vc.UpdateVoucherAddCheckNumber(CVNumber, check_number, null, stringDate) == true)
                    {
                        PrintChecks(cmb_bank.Text.ToString());
                        this.Hide();
                        this.Close();
                    }
                }
                else
                {
                    if (vc.UpdateVoucherAddCheckNumber(CVNumber, check_number, tb_payee.Text.ToString(), stringDate) == true)
                    {
                        PrintChecks(cmb_bank.Text.ToString());
                        this.Hide();
                        this.Close();
                    }
                }
            }      
         }

    private void PrintChecks(string banks)
    {
            ReportViewer viewer = new ReportViewer();
            DateTime dt = mtb_date.Value;

            string check_date = dt.ToString("MM/dd/yyyy");
            ReportParameterCollection reportParameters = new ReportParameterCollection
            {
                  new ReportParameter("rp_payee", tb_payee.Text.ToString()),
                  new ReportParameter("rp_date", check_date),
                  new ReportParameter("rp_amount", tb_amount.Text.ToString()),
                  new ReportParameter("rp_amount_word", NumberToWords(Convert.ToDouble(tb_amount.Text.ToString())))
            };


         if (banks.Equals("BANCO DE ORO") || banks.Equals("BDO"))
         {
              
                viewer.LocalReport.ReportEmbeddedResource = "VoucherV1.Print.Cheque.BDO.rdlc";
                viewer.LocalReport.SetParameters(reportParameters);
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.RefreshReport();

                if (PrintToPDF(viewer.LocalReport, tb_checkNumber.Text.ToString()) == true)
                {

                }
          }
         else if ((banks.Equals("BANK OF THE PHILIPPINE ISLANDS") || banks.Equals("BPI")))
         {
                viewer.LocalReport.ReportEmbeddedResource = "VoucherV1.Print.Cheque.BPI.rdlc";
                viewer.LocalReport.SetParameters(reportParameters);
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.RefreshReport();

                if (PrintToPDF(viewer.LocalReport, tb_checkNumber.Text.ToString()) == true)
                {

                }
            }
    }


    private Boolean PrintToPDF(LocalReport report, string checkNumber)
    {
        string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>EMF</OutputFormat>" +
            "  <PageWidth>8in</PageWidth>" +
            "  <PageHeight>3in</PageHeight>" +
            "  <MarginTop>0.10in</MarginTop>" +
            "  <MarginLeft>0.2in</MarginLeft>" +
            "  <MarginRight>0.2in</MarginRight>" +
            "  <MarginBottom>0in</MarginBottom>" +
            "</DeviceInfo>";
        string[] streamIds;
        Warning[] warnings;

        string mimeType = string.Empty;
        string encoding = string.Empty;
        string extenstion = string.Empty;

        byte[] bytes = report.Render(
        "PDF", deviceInfo, out mimeType, out encoding, out extenstion,
        out streamIds, out warnings);

        string path = Settings.Default["Check"].ToString();
        string filePath = @path;

        File.WriteAllBytes(filePath + checkNumber + ".pdf", bytes);
        System.Diagnostics.Process.Start(filePath);

        return true;
    }


    public static string NumberToWords(double doubleNumber)
    {
            var beforeFloatingPoint = (int)Math.Floor(doubleNumber);
            var beforeFloatingPointWord = NumberToWords(beforeFloatingPoint);
            var afterFloatingPointWord = (int)((doubleNumber - beforeFloatingPoint) * 100) + "/100";

            var value = "";

            if (String.IsNullOrWhiteSpace(SmallNumberToWord((int)((doubleNumber - beforeFloatingPoint) * 100), string.Empty)))
            {
                value = beforeFloatingPointWord + " Only";
            }
            else
            {
                value = beforeFloatingPointWord + " & " + afterFloatingPointWord + " Only";
            }
            return value;
        }


        private static string NumberToWords(int number)
        {
            if (number == 0) return "Zero";

            if (number < 0) return "minus" + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + "Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + "Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "Hundred ";
                number %= 100;
            }

            words = SmallNumberToWord(number, words);
            return words;

        }

        private static string SmallNumberToWord(int number, string words)
        {
            if (number <= 0) return words;
            if (words != "") words += "";



            var unitsMap = new[] { "Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine ", "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            var tensMap = new[] { "Zero ", "Ten ", "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            if (number < 20) words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0) words += " " + unitsMap[number % 10];
            }

            return words;
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

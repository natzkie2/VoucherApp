using DevExpress.XtraReports.UI;
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
using VoucherV1.Object;
using VoucherV1.Print.BIR;

namespace VoucherV1.Forms.BIR
{
    public partial class _2307_dialog_Form : Form
    {
        public string Selection { set; get; }

        public string VoucherNumber { set; get; }
        public string Payee { set; get; }
        public string Address { set; get; }
        public string TIN { set; get; }
        public string ZIP { set; get; }
        public string ATC { set; get; }
        public double Amount { set; get; }


        const string payorName = "DIAMOND MILLENNIUM CORPORATION";
        const string payorAddress = "LIMKETKAI CORPORATE OFFICE, LKKS MALLS LAPASAN, CAGAYAN DE ORO CITY";
        const string payorZip = "9000";
        const string payorTin1st = "005";
        const string payorTin2nd = "890";
        const string payorTin3rd = "498";
        const string payorTin4th = "00000";

        public _2307_dialog_Form()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void _2307_dialog_Form_Load(object sender, EventArgs e)
        {
            cmb_quarter.SelectedIndex = 0;
            lbl_bir_detail.Text = "FORM " + Selection;
            PopulateVendor();
            PopulateATCintoCombobox();
        }

        private void PopulateVendor()
        {
            Vendor_Class vc = new Vendor_Class();
            List<Vendor> vendors = vc.FetchVendorByName(Payee);

            foreach (var vendor in vendors)
            {
                tb_payee.Text = vendor.Name;
                tb_address.Text = vendor.Address;
                tb_tin.Text = vendor.Tin;
                tb_zip.Text = vendor.Zip;
                ATC = vendor.Atc;
            }
        }

        private void PopulateATCintoCombobox()
        {
            Atc_Class ac = new Atc_Class();
            List<string> comboBoxData = ac.FetchATCDataCombobox();
            cmb_atc.DataSource = comboBoxData;
            cmb_atc.Text = ATC;
        }

        private void Cmb_atc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Atc_Class ac = new Atc_Class();
            string atc = cmb_atc.Text.ToString();
            List<ATCDetails> details = ac.FetchATCDetailsByName(atc);

            foreach (var detail in details)
            {
                tb_percent.Text = String.Format("{0:#,##0.00}", detail.Percent);
            }
        }

        private void Btn_select_atc_Click(object sender, EventArgs e)
        {
            Atc_Class ac = new Atc_Class();

            string selectedATC = cmb_atc.Text.ToString();
            List<ATCDetails> details = ac.FetchATCDetailsByName(selectedATC);

            string selectedQuarter = cmb_quarter.Text;
      

            if (String.IsNullOrWhiteSpace(tb_percent.Text.ToString()))
            {
                MessageBox.Show("Please input percentage.", "Voucher System.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (String.IsNullOrWhiteSpace(tb_grossAmount.Text.ToString()))
            {
                MessageBox.Show("Please input gross amount.", "Voucher System.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double percentage = Convert.ToDouble(tb_percent.Text.ToString());
                double fraction = percentage / 100;

                double grossAmount = Convert.ToDouble(tb_grossAmount.Text.ToString());
                double netAmount = grossAmount / 1.12;


                double tax_withheld = netAmount * fraction;

                if (selectedQuarter.Equals("1ST QUARTER"))
                {
                    foreach (var detail in details)
                    {
                        dgv_bir.Rows.Add(null, detail.Description, selectedATC, netAmount, "", "", netAmount, tax_withheld);
                    }
                }
                else if (selectedQuarter.Equals("2ND QUARTER"))
                {
                    foreach (var detail in details)
                    {
                        dgv_bir.Rows.Add(null, detail.Description, selectedATC, "", netAmount, "", netAmount, tax_withheld);
                    }
                }
                else
                {
                    foreach (var detail in details)
                    {
                        dgv_bir.Rows.Add(null, detail.Description, selectedATC, "", "", netAmount, netAmount, tax_withheld);
                    }
                }
            }

            int countRow = dgv_bir.Rows.Count;

            if (countRow > 0)
            {
                btn_select_atc.Enabled = false;
                btn_preview.Enabled = true;
                btn_clear.Enabled = true;
            }
            else
            {
                btn_select_atc.Enabled = true;
                btn_preview.Enabled = false;
                btn_clear.Enabled = false;
            }

        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            dgv_bir.Rows.Clear();
            btn_select_atc.Enabled = true;
            btn_preview.Enabled = false;
            btn_clear.Enabled = false;

        }

        private void Tb_percent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Tb_grossAmount_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Btn_preview_Click(object sender, EventArgs e)
        {
            PrintForm2307();
        }    
        
        private void PrintForm2307()
        {
            string dateFromMM = Convert.ToString(dtp_from.Value.ToString("MM"));
            string dateFromDD = Convert.ToString(dtp_from.Value.ToString("dd"));
            string dateFromYY = Convert.ToString(dtp_from.Value.ToString("yyyy"));

            string dateToMM = Convert.ToString(dtp_to.Value.ToString("MM"));
            string dateToDD = Convert.ToString(dtp_to.Value.ToString("dd"));
            string dateToYY = Convert.ToString(dtp_to.Value.ToString("yyyy"));

            string payeeName = tb_payee.Text;
            string payeeAddress = tb_address.Text;
            string payeeZip = tb_zip.Text;

            string originalString = tb_tin.Text;
            char delimiter = '-';
            string[] substrings = originalString.Split(delimiter);


           // List<TaxPayment> taxPayments = new List<TaxPayment>();
            TaxPaymentRepository dataRepository = new TaxPaymentRepository();

            foreach (DataGridViewRow row in dgv_bir.Rows)
            {
                double firstQuarter;
                if (row.Cells[3].Value != null && !string.IsNullOrWhiteSpace(row.Cells[3].Value.ToString()))
                {
                    firstQuarter = Convert.ToDouble(row.Cells[3].Value.ToString());
                }
                else
                {
                    firstQuarter = 0;
                }

                double secondQuarter;
                if (row.Cells[4].Value != null && !string.IsNullOrWhiteSpace(row.Cells[4].Value.ToString()))
                {
                    secondQuarter = Convert.ToDouble(row.Cells[4].Value.ToString());
                }
                else
                {
                    secondQuarter = 0;
                }

                double thirdQuarter;
                if (row.Cells[5].Value != null && !string.IsNullOrWhiteSpace(row.Cells[5].Value.ToString()))
                {
                    thirdQuarter = Convert.ToDouble(row.Cells[5].Value.ToString());
                }
                else
                {
                    thirdQuarter = 0;
                }

                double total;
                if (row.Cells[6].Value != null && !string.IsNullOrWhiteSpace(row.Cells[6].Value.ToString()))
                {
                    total = Convert.ToDouble(row.Cells[6].Value.ToString());
                }
                else
                {
                    total = 0;
                }

                double tax;
                if (row.Cells[7].Value != null && !string.IsNullOrWhiteSpace(row.Cells[7].Value.ToString()))
                {
                    tax = Convert.ToDouble(row.Cells[7].Value.ToString());
                }
                else
                {
                    tax = 0;
                }

                TaxPayment taxPayments = new TaxPayment
                {
                    Details = row.Cells[1].Value.ToString(),
                    Atc = row.Cells[2].Value.ToString(),
                    FirstQuarter = firstQuarter,
                    SecondQuarter = secondQuarter,
                    ThirdQuarter = thirdQuarter,
                    Total = total,
                    Tax = tax,
                } ;
                dataRepository.AddtaxPaymentList(taxPayments);
            }          
           
            form2307 report = new form2307(dateFromMM, dateFromDD, dateFromYY, dateToMM, dateToDD, dateToYY, payeeName, payeeAddress, substrings[0], substrings[1], substrings[2],
                substrings[3], payeeZip, payorName, payorAddress, payorTin1st, payorTin2nd, payorTin3rd, payorTin4th, payorZip, dataRepository);
            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowPreview();
        }

      
    }
}

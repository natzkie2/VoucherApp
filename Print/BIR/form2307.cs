using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VoucherV1.Object;

namespace VoucherV1.Print.BIR
{
    public partial class form2307 : DevExpress.XtraReports.UI.XtraReport
    {

        TaxPaymentRepository taxPaymentRepository;

        public form2307(string dateFromMM, string dateFromDD, string dateFromYY, string dateToMM, string dateToDD, string dateToYY, string payeeName, 
            string payeeAddress, string payeeTin1st, string payeeTin2nd, string payeeTin3rd, string payeeTin4th,
            string payeeZip, string payorName, string payorAddress, string payorTin1st, string payorTin2nd, string payorTin3rd, string payorTin4th, string payorZip, TaxPaymentRepository taxRepo)
        {
            InitializeComponent();

            taxPaymentRepository = taxRepo;

            this.Parameters["periodFromMM"].Value = dateFromMM;
            this.Parameters["periodFromDD"].Value = dateFromDD;
            this.Parameters["periodFromYY"].Value = dateFromYY;

            this.Parameters["periodToMM"].Value = dateToMM;
            this.Parameters["periodToDD"].Value = dateToDD;
            this.Parameters["periodToYY"].Value = dateToYY;

            this.Parameters["payeeName"].Value = payeeName;
            this.Parameters["payeeAddress"].Value = payeeAddress;
            this.Parameters["payeeTin1st"].Value = payeeTin1st;
            this.Parameters["payeeTin2nd"].Value = payeeTin2nd;
            this.Parameters["payeeTin3rd"].Value = payeeTin3rd;
            this.Parameters["payeeTin4th"].Value = payeeTin4th;
            this.Parameters["payeeZip"].Value = payeeZip;

            this.Parameters["payorName"].Value = payorName;
            this.Parameters["payorAddress"].Value = payorAddress;
            this.Parameters["payorTin1st"].Value = payorTin1st;
            this.Parameters["payorTin2nd"].Value = payorTin2nd;
            this.Parameters["payorTin3rd"].Value = payorTin3rd;
            this.Parameters["payorTin4th"].Value = payorTin4th;
            this.Parameters["payorZip"].Value = payorZip;



            this.Parameters["periodFromMM"].Visible = false;
            this.Parameters["periodFromDD"].Visible = false;
            this.Parameters["periodFromYY"].Visible = false;

            this.Parameters["periodToMM"].Visible = false;
            this.Parameters["periodToDD"].Visible = false;
            this.Parameters["periodToYY"].Visible = false;

            this.Parameters["payeeName"].Visible = false;
            this.Parameters["payeeAddress"].Visible = false;
            this.Parameters["payeeTin1st"].Visible = false;
            this.Parameters["payeeTin2nd"].Visible = false;
            this.Parameters["payeeTin3rd"].Visible = false;
            this.Parameters["payeeTin4th"].Visible = false;
            this.Parameters["payeeZip"].Visible = false;

            this.Parameters["payorName"].Visible = false;
            this.Parameters["payorAddress"].Visible = false;
            this.Parameters["payorTin1st"].Visible = false;
            this.Parameters["payorTin2nd"].Visible = false;
            this.Parameters["payorTin3rd"].Visible = false;
            this.Parameters["payorTin4th"].Visible = false;
            this.Parameters["payorZip"].Visible = false;




            List<TaxPayment> paymentList = taxPaymentRepository.GetTaxPaymentList();

            if (paymentList != null && paymentList.Count > 0)
            {
                XRTable table = xrTablePayment;
                int row = 0;

                //DataSource = paymentList;

                foreach (TaxPayment taxPayment in paymentList)
                {
                    table.InsertRowAbove(table.Rows[row]);
                    table.Rows[row + 1].Cells[0].Text = taxPayment.Details;
                    table.Rows[row + 1].Cells[1].Text = taxPayment.Atc;
                    table.Rows[row + 1].Cells[2].Text = taxPayment.FirstQuarter == 0 ? "" : String.Format("{0:#,##0.000}", taxPayment.FirstQuarter);
                    table.Rows[row + 1].Cells[3].Text = taxPayment.SecondQuarter == 0 ? "" : String.Format("{0:#,##0.000}", taxPayment.SecondQuarter);
                    table.Rows[row + 1].Cells[4].Text = taxPayment.ThirdQuarter == 0 ? "" : String.Format("{0:#,##0.000}", taxPayment.ThirdQuarter);
                    table.Rows[row + 1].Cells[5].Text = taxPayment.Total == 0 ? "" : String.Format("{0:#,##0.000}", taxPayment.Total);
                    table.Rows[row + 1].Cells[6].Text = taxPayment.Tax == 0 ? "" : String.Format("{0:#,##0.000}", taxPayment.Tax);

                    row++;
                }
            }

        }
  
        private void Form2307_BeforePrint(object sender, CancelEventArgs e)
        {
 
        }

        private void XrTableCellTax_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;

            // Extract data from the specific cell
            string cellValue = cell.Text;

            // Populate the data into the XRLabel
            xrLabelTax.Text = cellValue;
        }

        private void XrTableCellTotal_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;

            // Extract data from the specific cell
            string cellValue = cell.Text;

            // Populate the data into the XRLabel
            xrLabelTotal.Text = cellValue;
        }

        private void XrTableCell1st_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;

            // Extract data from the specific cell
            string cellValue = cell.Text;

            if (String.IsNullOrWhiteSpace(cellValue))
            {
                xrLabel1stQuart.Text = "-";
            }
            else
            {
                xrLabel1stQuart.Text = cellValue;
            }         
        }

        private void XrTableCell2nd_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;

            // Extract data from the specific cell
            string cellValue = cell.Text;

            if (String.IsNullOrWhiteSpace(cellValue))
            {
                xrLabel2ndQuart.Text = "-";
            }
            else
            {
                xrLabel2ndQuart.Text = cellValue;
            }
        }

        private void XrTableCell3rd_BeforePrint(object sender, CancelEventArgs e)
        {
            XRTableCell cell = (XRTableCell)sender;

            // Extract data from the specific cell
            string cellValue = cell.Text;

            if (String.IsNullOrWhiteSpace(cellValue))
            {
                xrLabel3rdQuart.Text = "-";
            }
            else
            {
                xrLabel3rdQuart.Text = cellValue;
            }
        }
    }
}

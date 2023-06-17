using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoucherV1.Forms
{
    public partial class Print_voucher_Form : Form
    {
        public Print_voucher_Form()
        {
            InitializeComponent();
        }

        private void Print_voucher_Form_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
            PrintSettings();
        }

        private void PrintSettings()
        {
            var setup = this.reportViewer.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            setup.PrinterSettings.Copies = 1;
            this.reportViewer.SetPageSettings(setup);
        }
    }
}

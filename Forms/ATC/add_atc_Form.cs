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

namespace VoucherV1.Forms.ATC
{
    public partial class Add_atc_Form : Form
    {
        public string Database { set; get; }
      
        public Add_atc_Form()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Atc_Class ac = new Atc_Class();
            string value = rtb_atc_name.Text.ToString();

            ATCDetails atc = new ATCDetails()
            {
                Id = null,
                Name = value,
                Description = null
            };

            bool isATCInserted = ac.InsertATCData(atc);

            if (isATCInserted)
            {
                MessageBox.Show("Data inserted successfully.", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to insert data.", "Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

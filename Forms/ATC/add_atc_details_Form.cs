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
    public partial class Add_atc_details_Form : Form
    {
        public string Database { set; get; }

        public Add_atc_details_Form()
        {
            InitializeComponent();
        }

        private void Add_atc_details_Form_Load(object sender, EventArgs e)
        {
            PopulateATCintoCombobox();
        }

        private void PopulateATCintoCombobox() 
        {
            Atc_Class ac = new Atc_Class();

            List<string> comboBoxData = ac.FetchATCDataCombobox();
            cmb_atc.DataSource = comboBoxData;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            Atc_Class ac = new Atc_Class();      
            if (String.IsNullOrWhiteSpace(cmb_atc.Text.ToString()))
            {
                MessageBox.Show("Please select atc.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(rtb_percent.Text.ToString()))
            {
                MessageBox.Show("Please input percentage.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(rtb_atc_description.Text.ToString()))
            {
                MessageBox.Show("Please input description.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string description = rtb_atc_description.Text.ToString();
                string atcName = cmb_atc.Text.ToString();
                double percent = Convert.ToDouble(rtb_percent.Text.ToString());

                ATCDetails atc = new ATCDetails()
                {
                    Id = null,
                    Name = atcName,
                    Percent = percent,
                    Description = description
                };

                bool isATCDetailsInserted = ac.InsertATCDetailsData(atc);

                if (isATCDetailsInserted)
                {
                    MessageBox.Show("Data inserted successfully.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to insert data.", "Voucher System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }       
        }

        private void Rtb_percent_KeyPress(object sender, KeyPressEventArgs e)
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

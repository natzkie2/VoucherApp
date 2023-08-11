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
    public partial class Selection_dialog_Form : Form
    {
        public string Option { set; get; }
        public Selection_dialog_Form()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            if (rb_cw.Checked)
            {
                Option = "CW";
            }
            else if (rb_2307.Checked)
            {
                Option = "2307";
            }
            else if (rb_2306.Checked)
            {
                Option = "2306";
            }
            else if (rb_2316.Checked)
            {
                Option = "2316";
            }
            else
            {
                Option = "";
            }
        }
    }
}

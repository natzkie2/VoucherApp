using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}

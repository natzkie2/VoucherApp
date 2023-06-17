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
namespace VoucherV1.Forms
{
    public partial class Connection_dialog_Form : Form
    {
        public static string DB = "";

        public Connection_dialog_Form()
        {
            InitializeComponent();
        }
        private void Connection_dialog_Form_Load(object sender, EventArgs e)
        {
            Database_schema_Class dsc = new Database_schema_Class();
            dsc.DatabaseSchemaDataSet();
            cmb_schema.DataSource = dsc.dataFill;
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            string database = cmb_schema.Text.ToString();

            if (database.Equals("Select database schema."))
            {
                MessageBox.Show("Please select a database schema.", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                DB = database;
                User_login_Form m = new User_login_Form();
                m.Closed += (s, args) => this.Close();
                m.Show();
            }
        }

        
    }
}

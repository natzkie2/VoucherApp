
namespace VoucherV1.Forms
{
    partial class Check_writer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_checkNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bank = new System.Windows.Forms.Button();
            this.tb_payee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_date = new MetroFramework.Controls.MetroDateTime();
            this.cmb_bank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 42);
            this.panel2.TabIndex = 11;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(643, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 38);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "[ CLOSE ]";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHECK WRITER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tb_checkNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_bank);
            this.panel1.Controls.Add(this.tb_payee);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_amount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mtb_date);
            this.panel1.Controls.Add(this.cmb_bank);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 198);
            this.panel1.TabIndex = 12;
            // 
            // tb_checkNumber
            // 
            this.tb_checkNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_checkNumber.Location = new System.Drawing.Point(388, 37);
            this.tb_checkNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tb_checkNumber.Name = "tb_checkNumber";
            this.tb_checkNumber.Size = new System.Drawing.Size(342, 23);
            this.tb_checkNumber.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "CHECK NUMBER";
            // 
            // btn_bank
            // 
            this.btn_bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_bank.FlatAppearance.BorderSize = 0;
            this.btn_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bank.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank.ForeColor = System.Drawing.Color.White;
            this.btn_bank.Location = new System.Drawing.Point(583, 145);
            this.btn_bank.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(147, 40);
            this.btn_bank.TabIndex = 45;
            this.btn_bank.Text = "SAVE AND PRINT";
            this.btn_bank.UseVisualStyleBackColor = false;
            this.btn_bank.Click += new System.EventHandler(this.Btn_bank_Click);
            // 
            // tb_payee
            // 
            this.tb_payee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_payee.Location = new System.Drawing.Point(14, 92);
            this.tb_payee.Margin = new System.Windows.Forms.Padding(2);
            this.tb_payee.Name = "tb_payee";
            this.tb_payee.Size = new System.Drawing.Size(352, 23);
            this.tb_payee.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "PAYEE";
            // 
            // tb_amount
            // 
            this.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_amount.Location = new System.Drawing.Point(388, 92);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(342, 23);
            this.tb_amount.TabIndex = 42;
            this.tb_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "AMOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "DATE";
            // 
            // mtb_date
            // 
            this.mtb_date.Location = new System.Drawing.Point(14, 145);
            this.mtb_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtb_date.Name = "mtb_date";
            this.mtb_date.Size = new System.Drawing.Size(352, 29);
            this.mtb_date.TabIndex = 34;
            // 
            // cmb_bank
            // 
            this.cmb_bank.BackColor = System.Drawing.Color.White;
            this.cmb_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bank.FormattingEnabled = true;
            this.cmb_bank.Location = new System.Drawing.Point(14, 37);
            this.cmb_bank.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_bank.Name = "cmb_bank";
            this.cmb_bank.Size = new System.Drawing.Size(352, 23);
            this.cmb_bank.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "BANK";
            // 
            // Check_writer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 240);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Check_writer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Check_writer_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_bank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime mtb_date;
        public System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_payee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_checkNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_bank;
    }
}
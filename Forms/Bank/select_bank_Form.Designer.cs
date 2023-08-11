
namespace VoucherV1.Forms.Bank
{
    partial class Select_bank_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_banks = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_check_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_voucher_amount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_date = new MetroFramework.Controls.MetroDateTime();
            this.btn_bank = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_online = new System.Windows.Forms.RadioButton();
            this.rb_check = new System.Windows.Forms.RadioButton();
            this.rb_cash = new System.Windows.Forms.RadioButton();
            this.cmb_bank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.item_checkAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_checkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_checkNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banks)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(545, 42);
            this.panel2.TabIndex = 10;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(446, 0);
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
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "SELECT BANK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 563);
            this.panel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgv_banks);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 331);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 186);
            this.panel5.TabIndex = 2;
            // 
            // dgv_banks
            // 
            this.dgv_banks.AllowUserToAddRows = false;
            this.dgv_banks.AllowUserToResizeColumns = false;
            this.dgv_banks.AllowUserToResizeRows = false;
            this.dgv_banks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_banks.BackgroundColor = System.Drawing.Color.White;
            this.dgv_banks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_banks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_banks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_banks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_banks.ColumnHeadersHeight = 30;
            this.dgv_banks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_banks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.item_bank,
            this.item_checkNum,
            this.item_checkDate,
            this.item_checkAmount});
            this.dgv_banks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_banks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_banks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_banks.EnableHeadersVisualStyles = false;
            this.dgv_banks.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_banks.Location = new System.Drawing.Point(0, 0);
            this.dgv_banks.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_banks.Name = "dgv_banks";
            this.dgv_banks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_banks.RowHeadersVisible = false;
            this.dgv_banks.RowHeadersWidth = 51;
            this.dgv_banks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_banks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_banks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_banks.RowTemplate.Height = 30;
            this.dgv_banks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_banks.Size = new System.Drawing.Size(545, 186);
            this.dgv_banks.TabIndex = 30;
            this.dgv_banks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_banks_CellClick);
            this.dgv_banks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_banks_CellEndEdit);
            this.dgv_banks.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_banks_EditingControlShowing);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_total);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btn_confirm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 517);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 46);
            this.panel4.TabIndex = 1;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(134, 12);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(294, 23);
            this.lbl_total.TabIndex = 37;
            this.lbl_total.Text = "₱0.00";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "TOTAL AMOUNT:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(434, 11);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(100, 24);
            this.btn_confirm.TabIndex = 32;
            this.btn_confirm.Text = "CONFIRM";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_amount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_clear);
            this.panel3.Controls.Add(this.tb_check_number);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbl_voucher_amount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.mtb_date);
            this.panel3.Controls.Add(this.btn_bank);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.cmb_bank);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 331);
            this.panel3.TabIndex = 0;
            // 
            // tb_amount
            // 
            this.tb_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_amount.Location = new System.Drawing.Point(14, 201);
            this.tb_amount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(520, 23);
            this.tb_amount.TabIndex = 40;
            this.tb_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "AMOUNT";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btn_clear.Enabled = false;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(431, 237);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 24);
            this.btn_clear.TabIndex = 38;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // tb_check_number
            // 
            this.tb_check_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_check_number.Location = new System.Drawing.Point(14, 87);
            this.tb_check_number.Margin = new System.Windows.Forms.Padding(2);
            this.tb_check_number.Name = "tb_check_number";
            this.tb_check_number.Size = new System.Drawing.Size(520, 23);
            this.tb_check_number.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "CHECK NUMBER";
            // 
            // lbl_voucher_amount
            // 
            this.lbl_voucher_amount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_voucher_amount.Location = new System.Drawing.Point(139, 237);
            this.lbl_voucher_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_voucher_amount.Name = "lbl_voucher_amount";
            this.lbl_voucher_amount.Size = new System.Drawing.Size(177, 23);
            this.lbl_voucher_amount.TabIndex = 35;
            this.lbl_voucher_amount.Text = "₱0.00";
            this.lbl_voucher_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 34;
            this.label9.Text = "VOUCHER AMOUNT:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "DATE";
            // 
            // mtb_date
            // 
            this.mtb_date.Location = new System.Drawing.Point(14, 142);
            this.mtb_date.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtb_date.Name = "mtb_date";
            this.mtb_date.Size = new System.Drawing.Size(519, 29);
            this.mtb_date.TabIndex = 32;
            // 
            // btn_bank
            // 
            this.btn_bank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_bank.FlatAppearance.BorderSize = 0;
            this.btn_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bank.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank.ForeColor = System.Drawing.Color.White;
            this.btn_bank.Location = new System.Drawing.Point(328, 237);
            this.btn_bank.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(100, 24);
            this.btn_bank.TabIndex = 31;
            this.btn_bank.Text = "SELECT";
            this.btn_bank.UseVisualStyleBackColor = false;
            this.btn_bank.Click += new System.EventHandler(this.Btn_bank_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_online);
            this.groupBox1.Controls.Add(this.rb_check);
            this.groupBox1.Controls.Add(this.rb_cash);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(14, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 45);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAYMENT METHOD";
            // 
            // rb_online
            // 
            this.rb_online.AutoSize = true;
            this.rb_online.Location = new System.Drawing.Point(270, 17);
            this.rb_online.Name = "rb_online";
            this.rb_online.Size = new System.Drawing.Size(123, 19);
            this.rb_online.TabIndex = 2;
            this.rb_online.TabStop = true;
            this.rb_online.Text = "ONLINE/TRANSFER";
            this.rb_online.UseVisualStyleBackColor = true;
            this.rb_online.CheckedChanged += new System.EventHandler(this.Rb_online_CheckedChanged);
            // 
            // rb_check
            // 
            this.rb_check.AutoSize = true;
            this.rb_check.Location = new System.Drawing.Point(181, 17);
            this.rb_check.Name = "rb_check";
            this.rb_check.Size = new System.Drawing.Size(60, 19);
            this.rb_check.TabIndex = 1;
            this.rb_check.TabStop = true;
            this.rb_check.Text = "CHECK";
            this.rb_check.UseVisualStyleBackColor = true;
            this.rb_check.CheckedChanged += new System.EventHandler(this.Rb_check_CheckedChanged);
            // 
            // rb_cash
            // 
            this.rb_cash.AutoSize = true;
            this.rb_cash.Location = new System.Drawing.Point(101, 17);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.Size = new System.Drawing.Size(53, 19);
            this.rb_cash.TabIndex = 0;
            this.rb_cash.TabStop = true;
            this.rb_cash.Text = "CASH";
            this.rb_cash.UseVisualStyleBackColor = true;
            this.rb_cash.CheckedChanged += new System.EventHandler(this.Rb_cash_CheckedChanged);
            // 
            // cmb_bank
            // 
            this.cmb_bank.BackColor = System.Drawing.Color.White;
            this.cmb_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bank.FormattingEnabled = true;
            this.cmb_bank.Location = new System.Drawing.Point(14, 37);
            this.cmb_bank.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_bank.Name = "cmb_bank";
            this.cmb_bank.Size = new System.Drawing.Size(520, 23);
            this.cmb_bank.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "BANK";
            // 
            // item_checkAmount
            // 
            this.item_checkAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.item_checkAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.item_checkAmount.FillWeight = 112.6827F;
            this.item_checkAmount.HeaderText = "AMOUNT";
            this.item_checkAmount.Name = "item_checkAmount";
            this.item_checkAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // item_checkDate
            // 
            this.item_checkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_checkDate.FillWeight = 112.6827F;
            this.item_checkDate.HeaderText = "DATE";
            this.item_checkDate.Name = "item_checkDate";
            this.item_checkDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // item_checkNum
            // 
            this.item_checkNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_checkNum.HeaderText = "NUMBER";
            this.item_checkNum.Name = "item_checkNum";
            this.item_checkNum.ReadOnly = true;
            this.item_checkNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // item_bank
            // 
            this.item_bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.item_bank.FillWeight = 112.6827F;
            this.item_bank.HeaderText = "BANK";
            this.item_bank.Name = "item_bank";
            this.item_bank.ReadOnly = true;
            this.item_bank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 112.6827F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Select_bank_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 605);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Select_bank_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Select_bank_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_banks)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_bank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_online;
        private System.Windows.Forms.RadioButton rb_check;
        private System.Windows.Forms.RadioButton rb_cash;
        private System.Windows.Forms.Button btn_bank;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime mtb_date;
        private System.Windows.Forms.Label lbl_voucher_amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_check_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dgv_banks;
        public System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkAmount;
    }
}
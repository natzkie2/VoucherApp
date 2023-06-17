
namespace VoucherV1.UserControls
{
    partial class Uc_EnterBills
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtp_bills = new MetroFramework.Controls.MetroTabPage();
            this.panel_bills_center = new System.Windows.Forms.Panel();
            this.panel_bills_right = new System.Windows.Forms.Panel();
            this.dgv_bills = new System.Windows.Forms.DataGridView();
            this.id_number = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.refNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_left_bills = new System.Windows.Forms.Panel();
            this.dgv_vendor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_search = new MetroFramework.Controls.MetroTextBox();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.btn_unselect = new System.Windows.Forms.Button();
            this.metroTabControl.SuspendLayout();
            this.mtp_bills.SuspendLayout();
            this.panel_bills_center.SuspendLayout();
            this.panel_bills_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).BeginInit();
            this.panel_left_bills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.mtp_bills);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1364, 692);
            this.metroTabControl.TabIndex = 4;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl_SelectedIndexChanged);
            // 
            // mtp_bills
            // 
            this.mtp_bills.Controls.Add(this.panel_bills_center);
            this.mtp_bills.Controls.Add(this.panel2);
            this.mtp_bills.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtp_bills.HorizontalScrollbarBarColor = false;
            this.mtp_bills.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_bills.HorizontalScrollbarSize = 0;
            this.mtp_bills.Location = new System.Drawing.Point(4, 38);
            this.mtp_bills.Name = "mtp_bills";
            this.mtp_bills.Size = new System.Drawing.Size(1356, 650);
            this.mtp_bills.TabIndex = 0;
            this.mtp_bills.Text = "UNPAID BILL";
            this.mtp_bills.VerticalScrollbarBarColor = false;
            this.mtp_bills.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_bills.VerticalScrollbarSize = 0;
            // 
            // panel_bills_center
            // 
            this.panel_bills_center.BackColor = System.Drawing.Color.White;
            this.panel_bills_center.Controls.Add(this.panel_bills_right);
            this.panel_bills_center.Controls.Add(this.panel_left_bills);
            this.panel_bills_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bills_center.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_bills_center.Location = new System.Drawing.Point(0, 34);
            this.panel_bills_center.Name = "panel_bills_center";
            this.panel_bills_center.Size = new System.Drawing.Size(1356, 616);
            this.panel_bills_center.TabIndex = 3;
            // 
            // panel_bills_right
            // 
            this.panel_bills_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bills_right.Controls.Add(this.dgv_bills);
            this.panel_bills_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bills_right.Location = new System.Drawing.Point(332, 0);
            this.panel_bills_right.Name = "panel_bills_right";
            this.panel_bills_right.Size = new System.Drawing.Size(1024, 616);
            this.panel_bills_right.TabIndex = 13;
            // 
            // dgv_bills
            // 
            this.dgv_bills.AllowUserToAddRows = false;
            this.dgv_bills.AllowUserToResizeColumns = false;
            this.dgv_bills.AllowUserToResizeRows = false;
            this.dgv_bills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bills.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_bills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_bills.ColumnHeadersHeight = 30;
            this.dgv_bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_bills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_number,
            this.refNumber,
            this.dueDate,
            this.amount,
            this.memo,
            this.amountPay});
            this.dgv_bills.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bills.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_bills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bills.EnableHeadersVisualStyles = false;
            this.dgv_bills.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_bills.Location = new System.Drawing.Point(0, 0);
            this.dgv_bills.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bills.Name = "dgv_bills";
            this.dgv_bills.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_bills.RowHeadersVisible = false;
            this.dgv_bills.RowHeadersWidth = 51;
            this.dgv_bills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bills.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_bills.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bills.RowTemplate.Height = 30;
            this.dgv_bills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bills.Size = new System.Drawing.Size(1020, 612);
            this.dgv_bills.TabIndex = 11;
            this.dgv_bills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_bills_CellClick);
            this.dgv_bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_bills_CellContentClick);
            this.dgv_bills.CurrentCellDirtyStateChanged += new System.EventHandler(this.Dgv_bills_CurrentCellDirtyStateChanged);
            // 
            // id_number
            // 
            this.id_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.id_number.DefaultCellStyle = dataGridViewCellStyle2;
            this.id_number.FalseValue = "0";
            this.id_number.FillWeight = 112.6827F;
            this.id_number.HeaderText = "#";
            this.id_number.Name = "id_number";
            this.id_number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_number.TrueValue = "1";
            // 
            // refNumber
            // 
            this.refNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.refNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.refNumber.FillWeight = 112.6827F;
            this.refNumber.HeaderText = "REFERENCE";
            this.refNumber.Name = "refNumber";
            this.refNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dueDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dueDate.HeaderText = "DUE DATE";
            this.dueDate.Name = "dueDate";
            this.dueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // amount
            // 
            this.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.amount.FillWeight = 112.6827F;
            this.amount.HeaderText = "AMOUNT DUE";
            this.amount.Name = "amount";
            this.amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // memo
            // 
            this.memo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.memo.FillWeight = 112.6827F;
            this.memo.HeaderText = "MEMO";
            this.memo.Name = "memo";
            this.memo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // amountPay
            // 
            this.amountPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.amountPay.DefaultCellStyle = dataGridViewCellStyle6;
            this.amountPay.FillWeight = 112.6827F;
            this.amountPay.HeaderText = "AMOUNT TO PAY";
            this.amountPay.Name = "amountPay";
            this.amountPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel_left_bills
            // 
            this.panel_left_bills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_left_bills.Controls.Add(this.dgv_vendor);
            this.panel_left_bills.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left_bills.Location = new System.Drawing.Point(0, 0);
            this.panel_left_bills.Name = "panel_left_bills";
            this.panel_left_bills.Size = new System.Drawing.Size(332, 616);
            this.panel_left_bills.TabIndex = 12;
            // 
            // dgv_vendor
            // 
            this.dgv_vendor.AllowUserToAddRows = false;
            this.dgv_vendor.AllowUserToResizeColumns = false;
            this.dgv_vendor.AllowUserToResizeRows = false;
            this.dgv_vendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vendor.BackgroundColor = System.Drawing.Color.White;
            this.dgv_vendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_vendor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_vendor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_vendor.ColumnHeadersHeight = 30;
            this.dgv_vendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_vendor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendor.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_vendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vendor.EnableHeadersVisualStyles = false;
            this.dgv_vendor.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_vendor.Location = new System.Drawing.Point(0, 0);
            this.dgv_vendor.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_vendor.Name = "dgv_vendor";
            this.dgv_vendor.ReadOnly = true;
            this.dgv_vendor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_vendor.RowHeadersVisible = false;
            this.dgv_vendor.RowHeadersWidth = 51;
            this.dgv_vendor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vendor.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_vendor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vendor.RowTemplate.Height = 30;
            this.dgv_vendor.RowTemplate.ReadOnly = true;
            this.dgv_vendor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendor.Size = new System.Drawing.Size(328, 612);
            this.dgv_vendor.TabIndex = 12;
            this.dgv_vendor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_vendor_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_search);
            this.panel2.Controls.Add(this.btn_proceed);
            this.panel2.Controls.Add(this.btn_unselect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 34);
            this.panel2.TabIndex = 2;
            // 
            // tb_search
            // 
            // 
            // 
            // 
            this.tb_search.CustomButton.Image = null;
            this.tb_search.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.tb_search.CustomButton.Name = "";
            this.tb_search.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_search.CustomButton.TabIndex = 1;
            this.tb_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search.CustomButton.UseSelectable = true;
            this.tb_search.CustomButton.Visible = false;
            this.tb_search.DisplayIcon = true;
            this.tb_search.Icon = global::VoucherV1.Properties.Resources.search_16px;
            this.tb_search.Lines = new string[0];
            this.tb_search.Location = new System.Drawing.Point(3, 6);
            this.tb_search.MaxLength = 32767;
            this.tb_search.Name = "tb_search";
            this.tb_search.PasswordChar = '\0';
            this.tb_search.PromptText = "Search";
            this.tb_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_search.SelectedText = "";
            this.tb_search.SelectionLength = 0;
            this.tb_search.SelectionStart = 0;
            this.tb_search.ShortcutsEnabled = true;
            this.tb_search.Size = new System.Drawing.Size(327, 23);
            this.tb_search.TabIndex = 10;
            this.tb_search.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search.UseSelectable = true;
            this.tb_search.WaterMark = "Search";
            this.tb_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_search.TextChanged += new System.EventHandler(this.Tb_search_TextChanged);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_proceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_proceed.FlatAppearance.BorderSize = 0;
            this.btn_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proceed.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proceed.ForeColor = System.Drawing.Color.White;
            this.btn_proceed.Location = new System.Drawing.Point(1144, 5);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(100, 24);
            this.btn_proceed.TabIndex = 6;
            this.btn_proceed.Text = "PROCEED";
            this.btn_proceed.UseVisualStyleBackColor = false;
            this.btn_proceed.Click += new System.EventHandler(this.Btn_proceed_Click);
            // 
            // btn_unselect
            // 
            this.btn_unselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_unselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btn_unselect.Enabled = false;
            this.btn_unselect.FlatAppearance.BorderSize = 0;
            this.btn_unselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unselect.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unselect.ForeColor = System.Drawing.Color.White;
            this.btn_unselect.Location = new System.Drawing.Point(1248, 5);
            this.btn_unselect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_unselect.Name = "btn_unselect";
            this.btn_unselect.Size = new System.Drawing.Size(102, 24);
            this.btn_unselect.TabIndex = 9;
            this.btn_unselect.Text = "UNSELECT ALL";
            this.btn_unselect.UseVisualStyleBackColor = false;
            this.btn_unselect.Click += new System.EventHandler(this.Btn_unselect_Click);
            // 
            // Uc_EnterBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroTabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Uc_EnterBills";
            this.Size = new System.Drawing.Size(1364, 692);
            this.Load += new System.EventHandler(this.Uc_EnterBills_Load);
            this.metroTabControl.ResumeLayout(false);
            this.mtp_bills.ResumeLayout(false);
            this.panel_bills_center.ResumeLayout(false);
            this.panel_bills_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bills)).EndInit();
            this.panel_left_bills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage mtp_bills;
        private System.Windows.Forms.Panel panel_bills_center;
        private System.Windows.Forms.DataGridView dgv_bills;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Button btn_unselect;
        private System.Windows.Forms.Panel panel_left_bills;
        private System.Windows.Forms.Panel panel_bills_right;
        private System.Windows.Forms.DataGridView dgv_vendor;
        private MetroFramework.Controls.MetroTextBox tb_search;
        private System.Windows.Forms.DataGridViewCheckBoxColumn id_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn refNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPay;
    }
}

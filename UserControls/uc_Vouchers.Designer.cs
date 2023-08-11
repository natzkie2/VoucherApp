
namespace VoucherV1.UserControls
{
    partial class Uc_Vouchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtp_voucher_history = new MetroFramework.Controls.MetroTabPage();
            this.panel_vendor_center = new System.Windows.Forms.Panel();
            this.panel_bills_right = new System.Windows.Forms.Panel();
            this.dgv_voucher_history = new System.Windows.Forms.DataGridView();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_void = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_search_vendor = new MetroFramework.Controls.MetroTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.metroTabControl.SuspendLayout();
            this.mtp_voucher_history.SuspendLayout();
            this.panel_vendor_center.SuspendLayout();
            this.panel_bills_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voucher_history)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.mtp_voucher_history);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(1364, 692);
            this.metroTabControl.TabIndex = 6;
            this.metroTabControl.UseSelectable = true;
            // 
            // mtp_voucher_history
            // 
            this.mtp_voucher_history.Controls.Add(this.panel_vendor_center);
            this.mtp_voucher_history.Controls.Add(this.panel2);
            this.mtp_voucher_history.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtp_voucher_history.HorizontalScrollbarBarColor = false;
            this.mtp_voucher_history.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_voucher_history.HorizontalScrollbarSize = 0;
            this.mtp_voucher_history.Location = new System.Drawing.Point(4, 38);
            this.mtp_voucher_history.Name = "mtp_voucher_history";
            this.mtp_voucher_history.Size = new System.Drawing.Size(1356, 650);
            this.mtp_voucher_history.TabIndex = 0;
            this.mtp_voucher_history.Text = "HISTORY";
            this.mtp_voucher_history.VerticalScrollbarBarColor = false;
            this.mtp_voucher_history.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_voucher_history.VerticalScrollbarSize = 0;
            // 
            // panel_vendor_center
            // 
            this.panel_vendor_center.BackColor = System.Drawing.Color.White;
            this.panel_vendor_center.Controls.Add(this.panel_bills_right);
            this.panel_vendor_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vendor_center.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_vendor_center.Location = new System.Drawing.Point(0, 34);
            this.panel_vendor_center.Name = "panel_vendor_center";
            this.panel_vendor_center.Size = new System.Drawing.Size(1356, 616);
            this.panel_vendor_center.TabIndex = 3;
            // 
            // panel_bills_right
            // 
            this.panel_bills_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bills_right.Controls.Add(this.dgv_voucher_history);
            this.panel_bills_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bills_right.Location = new System.Drawing.Point(0, 0);
            this.panel_bills_right.Name = "panel_bills_right";
            this.panel_bills_right.Size = new System.Drawing.Size(1356, 616);
            this.panel_bills_right.TabIndex = 13;
            // 
            // dgv_voucher_history
            // 
            this.dgv_voucher_history.AllowUserToAddRows = false;
            this.dgv_voucher_history.AllowUserToResizeColumns = false;
            this.dgv_voucher_history.AllowUserToResizeRows = false;
            this.dgv_voucher_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_voucher_history.BackgroundColor = System.Drawing.Color.White;
            this.dgv_voucher_history.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_voucher_history.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_voucher_history.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_voucher_history.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_voucher_history.ColumnHeadersHeight = 30;
            this.dgv_voucher_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_voucher_history.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column15,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgv_voucher_history.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_voucher_history.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_voucher_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_voucher_history.EnableHeadersVisualStyles = false;
            this.dgv_voucher_history.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_voucher_history.Location = new System.Drawing.Point(0, 0);
            this.dgv_voucher_history.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_voucher_history.Name = "dgv_voucher_history";
            this.dgv_voucher_history.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_voucher_history.RowHeadersVisible = false;
            this.dgv_voucher_history.RowHeadersWidth = 51;
            this.dgv_voucher_history.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_voucher_history.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_voucher_history.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_voucher_history.RowTemplate.Height = 30;
            this.dgv_voucher_history.RowTemplate.ReadOnly = true;
            this.dgv_voucher_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_voucher_history.Size = new System.Drawing.Size(1352, 612);
            this.dgv_voucher_history.TabIndex = 13;
            this.dgv_voucher_history.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_voucher_history_CellClick);
            this.dgv_voucher_history.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_voucher_history_CellDoubleClick);
            this.dgv_voucher_history.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_voucher_history_EditingControlShowing);
            // 
            // Column15
            // 
            this.Column15.HeaderText = "#";
            this.Column15.Name = "Column15";
            this.Column15.Visible = false;
            this.Column15.Width = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TIME CREATED";
            this.Column1.Name = "Column1";
            this.Column1.Width = 106;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "BRANCH";
            this.Column2.Name = "Column2";
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ACCOUNT NUMBER";
            this.Column3.Name = "Column3";
            this.Column3.Width = 135;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PAYEE";
            this.Column4.Name = "Column4";
            this.Column4.Width = 62;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "VOUCHER NUMBER";
            this.Column5.Name = "Column5";
            this.Column5.Width = 134;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MEMO";
            this.Column6.Name = "Column6";
            this.Column6.Width = 67;
            // 
            // Column7
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "n2";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column7.HeaderText = "AMOUNT";
            this.Column7.Name = "Column7";
            this.Column7.Width = 81;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "CHECK NUMBER";
            this.Column8.Name = "Column8";
            this.Column8.Width = 116;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CHECK NAME";
            this.Column9.Name = "Column9";
            this.Column9.Width = 102;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "CHECK DATE";
            this.Column10.Name = "Column10";
            this.Column10.Width = 95;
            // 
            // Column11
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column11.HeaderText = "VOID";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 58;
            // 
            // Column12
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column12.HeaderText = "EXPORT";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 72;
            // 
            // Column13
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column13.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column13.HeaderText = "IS PAYEE ACCOUNT ONLY?";
            this.Column13.Name = "Column13";
            this.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column13.Width = 170;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "USER";
            this.Column14.Name = "Column14";
            this.Column14.Width = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_reset);
            this.panel2.Controls.Add(this.btn_void);
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Controls.Add(this.btn_select);
            this.panel2.Controls.Add(this.dtp_to);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtp_from);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.tb_search_vendor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 34);
            this.panel2.TabIndex = 2;
            // 
            // btn_void
            // 
            this.btn_void.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_void.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btn_void.FlatAppearance.BorderSize = 0;
            this.btn_void.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_void.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_void.ForeColor = System.Drawing.Color.White;
            this.btn_void.Location = new System.Drawing.Point(770, 5);
            this.btn_void.Margin = new System.Windows.Forms.Padding(2);
            this.btn_void.Name = "btn_void";
            this.btn_void.Size = new System.Drawing.Size(100, 24);
            this.btn_void.TabIndex = 38;
            this.btn_void.Text = "VOID";
            this.btn_void.UseVisualStyleBackColor = false;
            this.btn_void.Click += new System.EventHandler(this.Btn_void_Click);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(978, 5);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 24);
            this.btn_export.TabIndex = 37;
            this.btn_export.Text = "EXPORT";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_select.FlatAppearance.BorderSize = 0;
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Location = new System.Drawing.Point(421, 5);
            this.btn_select.Margin = new System.Windows.Forms.Padding(2);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 24);
            this.btn_select.TabIndex = 36;
            this.btn_select.Text = "SELECT";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // dtp_to
            // 
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(284, 6);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Size = new System.Drawing.Size(127, 23);
            this.dtp_to.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "TO DATE: ";
            // 
            // dtp_from
            // 
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(86, 6);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Size = new System.Drawing.Size(127, 23);
            this.dtp_from.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "FROM DATE: ";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(874, 5);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 24);
            this.btn_refresh.TabIndex = 31;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.Btn_refresh_Click);
            // 
            // tb_search_vendor
            // 
            // 
            // 
            // 
            this.tb_search_vendor.CustomButton.Image = null;
            this.tb_search_vendor.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.tb_search_vendor.CustomButton.Name = "";
            this.tb_search_vendor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_search_vendor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_search_vendor.CustomButton.TabIndex = 1;
            this.tb_search_vendor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search_vendor.CustomButton.UseSelectable = true;
            this.tb_search_vendor.CustomButton.Visible = false;
            this.tb_search_vendor.DisplayIcon = true;
            this.tb_search_vendor.Icon = global::VoucherV1.Properties.Resources.search_16px;
            this.tb_search_vendor.Lines = new string[0];
            this.tb_search_vendor.Location = new System.Drawing.Point(1083, 6);
            this.tb_search_vendor.MaxLength = 32767;
            this.tb_search_vendor.Name = "tb_search_vendor";
            this.tb_search_vendor.PasswordChar = '\0';
            this.tb_search_vendor.PromptText = "Search";
            this.tb_search_vendor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_search_vendor.SelectedText = "";
            this.tb_search_vendor.SelectionLength = 0;
            this.tb_search_vendor.SelectionStart = 0;
            this.tb_search_vendor.ShortcutsEnabled = true;
            this.tb_search_vendor.Size = new System.Drawing.Size(270, 23);
            this.tb_search_vendor.TabIndex = 10;
            this.tb_search_vendor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search_vendor.UseSelectable = true;
            this.tb_search_vendor.WaterMark = "Search";
            this.tb_search_vendor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_search_vendor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(525, 5);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 24);
            this.btn_reset.TabIndex = 39;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Uc_Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Uc_Vouchers";
            this.Size = new System.Drawing.Size(1364, 692);
            this.Load += new System.EventHandler(this.Uc_Vouchers_Load);
            this.metroTabControl.ResumeLayout(false);
            this.mtp_voucher_history.ResumeLayout(false);
            this.panel_vendor_center.ResumeLayout(false);
            this.panel_bills_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_voucher_history)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage mtp_voucher_history;
        private System.Windows.Forms.Panel panel_vendor_center;
        private System.Windows.Forms.Panel panel_bills_right;
        private System.Windows.Forms.DataGridView dgv_voucher_history;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox tb_search_vendor;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btn_void;
        private System.Windows.Forms.Button btn_reset;
    }
}

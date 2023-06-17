
namespace VoucherV1.UserControls
{
    partial class Uc_Settings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtp_vendor = new MetroFramework.Controls.MetroTabPage();
            this.panel_vendor_center = new System.Windows.Forms.Panel();
            this.panel_bills_right = new System.Windows.Forms.Panel();
            this.dgv_vendor = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_search_vendor = new MetroFramework.Controls.MetroTextBox();
            this.btn_vendor_add = new System.Windows.Forms.Button();
            this.mtp_branch = new System.Windows.Forms.TabPage();
            this.panel_branch_center = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_branch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_branch_add = new System.Windows.Forms.Button();
            this.mtp_bank = new MetroFramework.Controls.MetroTabPage();
            this.panel_bank_center = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_bank = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.btn_bank_add = new System.Windows.Forms.Button();
            this.mtp_other = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.mtp_vendor.SuspendLayout();
            this.panel_vendor_center.SuspendLayout();
            this.panel_bills_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).BeginInit();
            this.panel2.SuspendLayout();
            this.mtp_branch.SuspendLayout();
            this.panel_branch_center.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branch)).BeginInit();
            this.panel1.SuspendLayout();
            this.mtp_bank.SuspendLayout();
            this.panel_bank_center.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bank)).BeginInit();
            this.panel3.SuspendLayout();
            this.mtp_other.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.metroTabControl);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1364, 692);
            this.pnlContainer.TabIndex = 0;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.mtp_vendor);
            this.metroTabControl.Controls.Add(this.mtp_branch);
            this.metroTabControl.Controls.Add(this.mtp_bank);
            this.metroTabControl.Controls.Add(this.mtp_other);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 3;
            this.metroTabControl.Size = new System.Drawing.Size(1364, 692);
            this.metroTabControl.TabIndex = 5;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl_SelectedIndexChanged);
            // 
            // mtp_vendor
            // 
            this.mtp_vendor.Controls.Add(this.panel_vendor_center);
            this.mtp_vendor.Controls.Add(this.panel2);
            this.mtp_vendor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtp_vendor.HorizontalScrollbarBarColor = false;
            this.mtp_vendor.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_vendor.HorizontalScrollbarSize = 0;
            this.mtp_vendor.Location = new System.Drawing.Point(4, 38);
            this.mtp_vendor.Name = "mtp_vendor";
            this.mtp_vendor.Size = new System.Drawing.Size(1356, 650);
            this.mtp_vendor.TabIndex = 0;
            this.mtp_vendor.Text = "VENDOR LIST";
            this.mtp_vendor.VerticalScrollbarBarColor = false;
            this.mtp_vendor.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_vendor.VerticalScrollbarSize = 0;
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
            this.panel_bills_right.Controls.Add(this.dgv_vendor);
            this.panel_bills_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bills_right.Location = new System.Drawing.Point(0, 0);
            this.panel_bills_right.Name = "panel_bills_right";
            this.panel_bills_right.Size = new System.Drawing.Size(1356, 616);
            this.panel_bills_right.TabIndex = 13;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vendor.ColumnHeadersHeight = 30;
            this.dgv_vendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_vendor.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vendor.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vendor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_vendor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vendor.RowTemplate.Height = 30;
            this.dgv_vendor.RowTemplate.ReadOnly = true;
            this.dgv_vendor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vendor.Size = new System.Drawing.Size(1352, 612);
            this.dgv_vendor.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tb_search_vendor);
            this.panel2.Controls.Add(this.btn_vendor_add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 34);
            this.panel2.TabIndex = 2;
            // 
            // tb_search_vendor
            // 
            // 
            // 
            // 
            this.tb_search_vendor.CustomButton.Image = null;
            this.tb_search_vendor.CustomButton.Location = new System.Drawing.Point(404, 1);
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
            this.tb_search_vendor.Location = new System.Drawing.Point(927, 6);
            this.tb_search_vendor.MaxLength = 32767;
            this.tb_search_vendor.Name = "tb_search_vendor";
            this.tb_search_vendor.PasswordChar = '\0';
            this.tb_search_vendor.PromptText = "Search";
            this.tb_search_vendor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_search_vendor.SelectedText = "";
            this.tb_search_vendor.SelectionLength = 0;
            this.tb_search_vendor.SelectionStart = 0;
            this.tb_search_vendor.ShortcutsEnabled = true;
            this.tb_search_vendor.Size = new System.Drawing.Size(426, 23);
            this.tb_search_vendor.TabIndex = 10;
            this.tb_search_vendor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_search_vendor.UseSelectable = true;
            this.tb_search_vendor.WaterMark = "Search";
            this.tb_search_vendor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_search_vendor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_vendor_add
            // 
            this.btn_vendor_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_vendor_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_vendor_add.FlatAppearance.BorderSize = 0;
            this.btn_vendor_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vendor_add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vendor_add.ForeColor = System.Drawing.Color.White;
            this.btn_vendor_add.Location = new System.Drawing.Point(6, 5);
            this.btn_vendor_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vendor_add.Name = "btn_vendor_add";
            this.btn_vendor_add.Size = new System.Drawing.Size(100, 24);
            this.btn_vendor_add.TabIndex = 6;
            this.btn_vendor_add.Text = "ADD";
            this.btn_vendor_add.UseVisualStyleBackColor = false;
            // 
            // mtp_branch
            // 
            this.mtp_branch.Controls.Add(this.panel_branch_center);
            this.mtp_branch.Controls.Add(this.panel1);
            this.mtp_branch.Location = new System.Drawing.Point(4, 38);
            this.mtp_branch.Name = "mtp_branch";
            this.mtp_branch.Size = new System.Drawing.Size(1356, 650);
            this.mtp_branch.TabIndex = 2;
            this.mtp_branch.Text = "BRANCH LIST";
            // 
            // panel_branch_center
            // 
            this.panel_branch_center.BackColor = System.Drawing.Color.White;
            this.panel_branch_center.Controls.Add(this.panel4);
            this.panel_branch_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_branch_center.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_branch_center.Location = new System.Drawing.Point(0, 34);
            this.panel_branch_center.Name = "panel_branch_center";
            this.panel_branch_center.Size = new System.Drawing.Size(1356, 616);
            this.panel_branch_center.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgv_branch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1356, 616);
            this.panel4.TabIndex = 13;
            // 
            // dgv_branch
            // 
            this.dgv_branch.AllowUserToAddRows = false;
            this.dgv_branch.AllowUserToDeleteRows = false;
            this.dgv_branch.AllowUserToResizeColumns = false;
            this.dgv_branch.AllowUserToResizeRows = false;
            this.dgv_branch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_branch.BackgroundColor = System.Drawing.Color.White;
            this.dgv_branch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_branch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_branch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_branch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_branch.ColumnHeadersHeight = 30;
            this.dgv_branch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_branch.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_branch.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_branch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_branch.EnableHeadersVisualStyles = false;
            this.dgv_branch.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_branch.Location = new System.Drawing.Point(0, 0);
            this.dgv_branch.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_branch.Name = "dgv_branch";
            this.dgv_branch.ReadOnly = true;
            this.dgv_branch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_branch.RowHeadersVisible = false;
            this.dgv_branch.RowHeadersWidth = 51;
            this.dgv_branch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_branch.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_branch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_branch.RowTemplate.Height = 30;
            this.dgv_branch.RowTemplate.ReadOnly = true;
            this.dgv_branch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_branch.Size = new System.Drawing.Size(1352, 612);
            this.dgv_branch.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroTextBox1);
            this.panel1.Controls.Add(this.btn_branch_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 34);
            this.panel1.TabIndex = 3;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(346, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(18, 18);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DisplayIcon = true;
            this.metroTextBox1.Icon = global::VoucherV1.Properties.Resources.search_16px;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(927, 6);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(426, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_branch_add
            // 
            this.btn_branch_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_branch_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_branch_add.FlatAppearance.BorderSize = 0;
            this.btn_branch_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_branch_add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_branch_add.ForeColor = System.Drawing.Color.White;
            this.btn_branch_add.Location = new System.Drawing.Point(6, 5);
            this.btn_branch_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_branch_add.Name = "btn_branch_add";
            this.btn_branch_add.Size = new System.Drawing.Size(100, 24);
            this.btn_branch_add.TabIndex = 6;
            this.btn_branch_add.Text = "ADD";
            this.btn_branch_add.UseVisualStyleBackColor = false;
            this.btn_branch_add.Click += new System.EventHandler(this.Btn_branch_add_Click);
            // 
            // mtp_bank
            // 
            this.mtp_bank.Controls.Add(this.panel_bank_center);
            this.mtp_bank.Controls.Add(this.panel3);
            this.mtp_bank.HorizontalScrollbarBarColor = true;
            this.mtp_bank.HorizontalScrollbarHighlightOnWheel = false;
            this.mtp_bank.HorizontalScrollbarSize = 3;
            this.mtp_bank.Location = new System.Drawing.Point(4, 38);
            this.mtp_bank.Name = "mtp_bank";
            this.mtp_bank.Size = new System.Drawing.Size(1356, 650);
            this.mtp_bank.TabIndex = 1;
            this.mtp_bank.Text = "BANK LIST";
            this.mtp_bank.VerticalScrollbarBarColor = true;
            this.mtp_bank.VerticalScrollbarHighlightOnWheel = false;
            this.mtp_bank.VerticalScrollbarSize = 3;
            // 
            // panel_bank_center
            // 
            this.panel_bank_center.BackColor = System.Drawing.Color.White;
            this.panel_bank_center.Controls.Add(this.panel6);
            this.panel_bank_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_bank_center.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_bank_center.Location = new System.Drawing.Point(0, 34);
            this.panel_bank_center.Name = "panel_bank_center";
            this.panel_bank_center.Size = new System.Drawing.Size(1356, 616);
            this.panel_bank_center.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.dgv_bank);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1356, 616);
            this.panel6.TabIndex = 13;
            // 
            // dgv_bank
            // 
            this.dgv_bank.AllowUserToAddRows = false;
            this.dgv_bank.AllowUserToDeleteRows = false;
            this.dgv_bank.AllowUserToResizeColumns = false;
            this.dgv_bank.AllowUserToResizeRows = false;
            this.dgv_bank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bank.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_bank.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_bank.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_bank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_bank.ColumnHeadersHeight = 30;
            this.dgv_bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_bank.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_bank.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bank.EnableHeadersVisualStyles = false;
            this.dgv_bank.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_bank.Location = new System.Drawing.Point(0, 0);
            this.dgv_bank.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_bank.Name = "dgv_bank";
            this.dgv_bank.ReadOnly = true;
            this.dgv_bank.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_bank.RowHeadersVisible = false;
            this.dgv_bank.RowHeadersWidth = 51;
            this.dgv_bank.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bank.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_bank.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_bank.RowTemplate.Height = 30;
            this.dgv_bank.RowTemplate.ReadOnly = true;
            this.dgv_bank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bank.Size = new System.Drawing.Size(1352, 612);
            this.dgv_bank.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.metroTextBox2);
            this.panel3.Controls.Add(this.btn_bank_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 34);
            this.panel3.TabIndex = 4;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DisplayIcon = true;
            this.metroTextBox2.Icon = global::VoucherV1.Properties.Resources.search_16px;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(927, 6);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Search";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(426, 23);
            this.metroTextBox2.TabIndex = 10;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Search";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_bank_add
            // 
            this.btn_bank_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_bank_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btn_bank_add.FlatAppearance.BorderSize = 0;
            this.btn_bank_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bank_add.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank_add.ForeColor = System.Drawing.Color.White;
            this.btn_bank_add.Location = new System.Drawing.Point(6, 5);
            this.btn_bank_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bank_add.Name = "btn_bank_add";
            this.btn_bank_add.Size = new System.Drawing.Size(100, 24);
            this.btn_bank_add.TabIndex = 6;
            this.btn_bank_add.Text = "ADD";
            this.btn_bank_add.UseVisualStyleBackColor = false;
            this.btn_bank_add.Click += new System.EventHandler(this.Btn_bank_add_Click);
            // 
            // mtp_other
            // 
            this.mtp_other.Controls.Add(this.panel5);
            this.mtp_other.Location = new System.Drawing.Point(4, 38);
            this.mtp_other.Name = "mtp_other";
            this.mtp_other.Size = new System.Drawing.Size(1356, 650);
            this.mtp_other.TabIndex = 3;
            this.mtp_other.Text = "OTHERS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1356, 650);
            this.panel5.TabIndex = 0;
            // 
            // Uc_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.Name = "Uc_Settings";
            this.Size = new System.Drawing.Size(1364, 692);
            this.Load += new System.EventHandler(this.Uc_Settings_Load);
            this.pnlContainer.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.mtp_vendor.ResumeLayout(false);
            this.panel_vendor_center.ResumeLayout(false);
            this.panel_bills_right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendor)).EndInit();
            this.panel2.ResumeLayout(false);
            this.mtp_branch.ResumeLayout(false);
            this.panel_branch_center.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_branch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.mtp_bank.ResumeLayout(false);
            this.panel_bank_center.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bank)).EndInit();
            this.panel3.ResumeLayout(false);
            this.mtp_other.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage mtp_vendor;
        private System.Windows.Forms.Panel panel_vendor_center;
        private System.Windows.Forms.Panel panel_bills_right;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox tb_search_vendor;
        private System.Windows.Forms.Button btn_vendor_add;
        private MetroFramework.Controls.MetroTabPage mtp_bank;
        private System.Windows.Forms.DataGridView dgv_vendor;
        private System.Windows.Forms.TabPage mtp_branch;
        private System.Windows.Forms.Panel panel_branch_center;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_branch;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Button btn_branch_add;
        private System.Windows.Forms.Panel panel_bank_center;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgv_bank;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Button btn_bank_add;
        private System.Windows.Forms.TabPage mtp_other;
        private System.Windows.Forms.Panel panel5;
    }
}

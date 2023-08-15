
namespace VoucherV1.Forms.ExcelFileWriter
{
    partial class Excel_filewriter_export_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.dgv_fileWriter = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_export = new System.Windows.Forms.Button();
            this.tb_search_vendor = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_checkNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_checkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_checkAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.centerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fileWriter)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(1056, 36);
            this.panel2.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 12F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(971, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 33);
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
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "EXPORT EXCEL FILEWRITER";
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.White;
            this.centerPanel.Controls.Add(this.dgv_fileWriter);
            this.centerPanel.Controls.Add(this.panel1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 36);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1056, 554);
            this.centerPanel.TabIndex = 6;
            // 
            // dgv_fileWriter
            // 
            this.dgv_fileWriter.AllowUserToAddRows = false;
            this.dgv_fileWriter.AllowUserToResizeColumns = false;
            this.dgv_fileWriter.AllowUserToResizeRows = false;
            this.dgv_fileWriter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_fileWriter.BackgroundColor = System.Drawing.Color.White;
            this.dgv_fileWriter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_fileWriter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_fileWriter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_fileWriter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_fileWriter.ColumnHeadersHeight = 30;
            this.dgv_fileWriter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_fileWriter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.item_bank,
            this.item_checkNum,
            this.item_checkDate,
            this.Column1,
            this.item_checkAmount,
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
            this.Column14,
            this.Column15});
            this.dgv_fileWriter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_fileWriter.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_fileWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_fileWriter.EnableHeadersVisualStyles = false;
            this.dgv_fileWriter.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_fileWriter.Location = new System.Drawing.Point(0, 34);
            this.dgv_fileWriter.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_fileWriter.Name = "dgv_fileWriter";
            this.dgv_fileWriter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_fileWriter.RowHeadersVisible = false;
            this.dgv_fileWriter.RowHeadersWidth = 51;
            this.dgv_fileWriter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fileWriter.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_fileWriter.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_fileWriter.RowTemplate.Height = 30;
            this.dgv_fileWriter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fileWriter.Size = new System.Drawing.Size(1056, 520);
            this.dgv_fileWriter.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_export);
            this.panel1.Controls.Add(this.tb_search_vendor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 34);
            this.panel1.TabIndex = 3;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_export.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_export.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(951, 5);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 24);
            this.btn_export.TabIndex = 37;
            this.btn_export.Text = "EXPORT";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 112.6827F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Is Self Service?";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 111;
            // 
            // item_bank
            // 
            this.item_bank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            this.item_bank.DefaultCellStyle = dataGridViewCellStyle3;
            this.item_bank.FillWeight = 112.6827F;
            this.item_bank.HeaderText = "CHECK AMOUNT";
            this.item_bank.Name = "item_bank";
            this.item_bank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_bank.Width = 98;
            // 
            // item_checkNum
            // 
            this.item_checkNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item_checkNum.HeaderText = "SOURCE ACCOUNT";
            this.item_checkNum.Name = "item_checkNum";
            this.item_checkNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_checkNum.Width = 109;
            // 
            // item_checkDate
            // 
            this.item_checkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item_checkDate.FillWeight = 112.6827F;
            this.item_checkDate.HeaderText = "Is Payee Account only?";
            this.item_checkDate.Name = "item_checkDate";
            this.item_checkDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_checkDate.Width = 136;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "CHECK DATE";
            this.Column1.Name = "Column1";
            this.Column1.Width = 94;
            // 
            // item_checkAmount
            // 
            this.item_checkAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.item_checkAmount.FillWeight = 112.6827F;
            this.item_checkAmount.HeaderText = "PREFERED CHECK NUMBER";
            this.item_checkAmount.Name = "item_checkAmount";
            this.item_checkAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.item_checkAmount.Width = 152;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Use Preferred Check Number?";
            this.Column2.Name = "Column2";
            this.Column2.Width = 191;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "PAYEE NAME";
            this.Column3.Name = "Column3";
            this.Column3.Width = 95;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "PAYEE EMAIL";
            this.Column4.Name = "Column4";
            this.Column4.Width = 96;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "COUNTRY CODE";
            this.Column5.Name = "Column5";
            this.Column5.Width = 114;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "MOBILE NUMBER";
            this.Column6.Name = "Column6";
            this.Column6.Width = 122;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "CLIENT REFERENCE NUMBER";
            this.Column7.Name = "Column7";
            this.Column7.Width = 178;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.HeaderText = "Pick-up or Delivery?";
            this.Column8.Name = "Column8";
            this.Column8.Width = 140;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.HeaderText = "PICK-UP BRANCH CODE";
            this.Column9.Name = "Column9";
            this.Column9.Width = 154;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.HeaderText = "DELIVERY ADDRESS CODE";
            this.Column10.Name = "Column10";
            this.Column10.Width = 163;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column11.HeaderText = "Is Claimant Payee?";
            this.Column11.Name = "Column11";
            this.Column11.Width = 134;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "AUTHORIZED REPRESENTATIVE";
            this.Column12.Name = "Column12";
            this.Column12.Width = 189;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column13.HeaderText = "VALID ID NUMBER";
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column14.HeaderText = "PARTICULARS";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column15.HeaderText = "REMARKS";
            this.Column15.Name = "Column15";
            this.Column15.Width = 81;
            // 
            // Excel_filewriter_export_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 590);
            this.ControlBox = false;
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Excel_filewriter_export_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Excel_filewriter_export_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Excel_filewriter_export_Form_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fileWriter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_export;
        private MetroFramework.Controls.MetroTextBox tb_search_vendor;
        public System.Windows.Forms.DataGridView dgv_fileWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_checkAmount;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}